using Newtonsoft.Json;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Basler.Pylon;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MvUtils;

namespace TabberCapture.Schemas
{
    public enum 카메라구분
    {
        [Bindable(false)]
        None,
        [Description("Cam1")]
        Cam01 = 1,
        [Description("Cam2")]
        Cam02 = 2,
        [Description("Cam3")]
        Cam03 = 3,
        [Description("Cam4")]
        Cam04 = 4,
        [Description("Cam5")]
        Cam05 = 5,
    }

    public class 그랩제어 : Dictionary<카메라구분, 카메라장치>
    {
        public delegate void 그랩완료대리자(카메라구분 구분, Mat 이미지);
        public event 그랩완료대리자 그랩완료보고;

        [JsonIgnore]
        private const string 로그영역 = "카메라";
        [JsonIgnore]
        private string 저장파일 { get { return Path.Combine(Global.환경설정.기본경로, "Cameras.json"); } }

        public BaslerGigE 카메라1 = null;
        public BaslerGigE 카메라2 = null;
        public BaslerGigE 카메라3 = null;
        public BaslerGigE 카메라4 = null;
        public BaslerGigE 카메라5 = null;

        public Boolean Init()
        {
            this.카메라1 = new BaslerGigE() { 구분 = 카메라구분.Cam01, 코드 = "40216985" };
            this.카메라2 = new BaslerGigE() { 구분 = 카메라구분.Cam02, 코드 = "40216979" };
            this.카메라3 = new BaslerGigE() { 구분 = 카메라구분.Cam03, 코드 = "40216983" };
            this.카메라4 = new BaslerGigE() { 구분 = 카메라구분.Cam04, 코드 = "40229766" };
            this.카메라5 = new BaslerGigE() { 구분 = 카메라구분.Cam05, 코드 = "40229770" };

            this.Add(카메라구분.Cam01, this.카메라1);
            this.Add(카메라구분.Cam02, this.카메라2);
            this.Add(카메라구분.Cam03, this.카메라3);
            this.Add(카메라구분.Cam04, this.카메라4);
            this.Add(카메라구분.Cam05, this.카메라5);

            // 카메라 설정 저장정보 로드
            카메라장치 정보;
            List<카메라장치> 자료 = Load();
            if (자료 != null)
            {
                foreach (카메라장치 설정 in 자료)
                {
                    정보 = this.GetItem(설정.구분);
                    if (정보 == null) continue;
                    정보.Set(설정);
                }
            }

            List<ICameraInfo> 카메라들 = CameraFinder.Enumerate();
            Debug.WriteLine($"PC와 연결되어있는 카메라 : ${카메라들.Count} 개");
            for (int lop = 0; lop < 카메라들.Count; lop++)
            {
                ICameraInfo gigeInfo = 카메라들[lop];
                BaslerGigE gige = this.GetItem(gigeInfo[CameraInfoKey.SerialNumber]) as BaslerGigE;
                if (gige == null) continue;
                gige.Init(gigeInfo);
                Debug.WriteLine($"{gigeInfo[CameraInfoKey.SerialNumber]} 연결완료.");
            }
            GC.Collect();
            return true;
        }

        private List<카메라장치> Load()
        {
            if (!File.Exists(this.저장파일)) return null;
            return JsonConvert.DeserializeObject<List<카메라장치>>(File.ReadAllText(this.저장파일), Utils.JsonSetting());
        }

        public void Save()
        {
            if (!Utils.WriteAllText(저장파일, JsonConvert.SerializeObject(this.Values, Utils.JsonSetting())))
            {
                //Global.오류로그(로그영역, "카메라 설정 저장", "카메라 설정 저장에 실패하였습니다.", true);
            }
        }

        public void Close()
        {
            this.Save();
            foreach (카메라장치 장치 in this.Values)
                장치?.Close();
        }

        public void Ready(카메라구분 카메라) => this.GetItem(카메라)?.Ready();

        public void 그랩완료(카메라구분 카메라, Mat 이미지)
        {
            this.그랩완료보고?.Invoke(카메라, 이미지);
        }
       
        public void ImageSave(Mat 이미지, 카메라구분 카메라, Int32 검사번호)
        {
            //if (!Global.환경설정.사진저장OK && !Global.환경설정.사진저장NG) return;
            List<String> paths = new List<String> { Global.환경설정.사진저장, Utils.FormatDate(DateTime.Now, "{0:yyyy-MM-dd}"), 카메라.ToString() };
            String name = $"{검사번호.ToString("d4")}_{Utils.FormatDate(DateTime.Now, "{0:HHmmss}")}.png";//_{결과.ToString()}
            String path = Common.CreateDirectory(paths);
            if (String.IsNullOrEmpty(path))
            {
                //Global.오류로그(로그영역, "이미지 저장", $"[{Path.Combine(paths.ToArray())}] 디렉토리를 만들 수 없습니다.", true);
                return;
            }
            String file = Path.Combine(path, name);
            Debug.WriteLine($"{이미지.Size()}: {file}", $"{카메라} 그랩완료");
            Task.Run(() =>
            {
                Int32 level = 3; // 0에서 9까지의 값 중 선택
                Int32[] @params = new[] { (Int32)ImwriteFlags.PngCompression, level };
                Cv2.ImWrite(file, 이미지, @params);
                이미지.Dispose();
            });
        }

        public 카메라장치 GetItem(카메라구분 구분)
        {
            if (this.ContainsKey(구분)) return this[구분];
            return null;
        }

        private 카메라장치 GetItem(String serial) => this.Values.Where(e => e.코드 == serial).FirstOrDefault();
    }

    public class 카메라장치
    {
        [JsonProperty("Camera"), Description("Camera")]
        public virtual 카메라구분 구분 { get; set; } = 카메라구분.None;
        [JsonIgnore, Description("Index")]
        public virtual Int32 번호 { get; set; } = 0;
        [JsonProperty("Serial"), Description("Serial")]
        public virtual String 코드 { get; set; } = String.Empty;
        [JsonIgnore, Description("Name")]
        public virtual String 명칭 { get; set; } = String.Empty;
        [JsonProperty("Description"), Description("Description")]
        public virtual String 설명 { get; set; } = String.Empty;
        [JsonProperty("IpAddress"), Description("IP")]
        public virtual String 주소 { get; set; } = String.Empty;
        [JsonProperty("Delaytime"), Description("Delaytime")]
        public virtual Double 지연시간 { get; set; } = 0;
        [JsonProperty("Timeout"), Description("Timeout")]
        public virtual Double 시간 { get; set; } = 1000;
        [JsonProperty("Exposure"), Description("Exposure")]
        public virtual Single 노출 { get; set; } = 5000;
        [JsonProperty("BlackLevel"), Description("Black Level")]
        public virtual UInt32 밝기 { get; set; } = 0;
        [JsonProperty("Contrast"), Description("Contrast")]
        public virtual Single 대비 { get; set; } = 10;
        [JsonProperty("Width"), Description("Width")]
        public virtual Int32 가로 { get; set; } = 0;
        [JsonProperty("Height"), Description("Height")]
        public virtual Int32 세로 { get; set; } = 0;
        [JsonProperty("OffsetX"), Description("OffsetX")]
        public virtual Int32 OffsetX { get; set; } = 0;
        [JsonIgnore, Description("카메라 초기화 상태")]
        public virtual Boolean 상태 { get; set; } = false;
        [JsonIgnore]
        public const String 로그영역 = "카메라장치";

        public virtual void Set(카메라장치 장치)
        {
            if (장치 == null) return;
            this.코드 = 장치.코드;
            this.설명 = 장치.설명;
            this.시간 = 장치.시간;
            this.지연시간 = 장치.지연시간;
            this.노출 = 장치.노출;
            this.대비 = 장치.대비;
            this.밝기 = 장치.밝기;
            this.가로 = 장치.가로;
            this.세로 = 장치.세로;
            this.OffsetX = 장치.OffsetX;
        }

        public virtual Boolean Init() => false;
        public virtual Boolean Ready() => false;
        public virtual Boolean Start() => false;
        public virtual Boolean Stop() => false;
        public virtual Boolean Close() => false;
        public virtual void 수동촬영() => 수동촬영();
        //public virtual void TurnOn() => Global.조명제어.TurnOn(this.구분);
        //public virtual void TurnOff() => Global.조명제어.TurnOff(this.구분);
    }

    public class BaslerGigE : 카메라장치
    {
        [Description("이미지 그랩 이벤트")]
        public delegate void AcquisitionFinished(카메라구분 구분, AcquisitionData Data);

        public event AcquisitionFinished AcquisitionFinishedEvent;
        [JsonIgnore]
        private Camera Camera = null;
        [JsonIgnore]
        private ICameraInfo Device;
        //[JsonIgnore]
        //private EventHandler<ImageGrabbedEventArgs> ImageGrabbedEvent;
        public Boolean Init(ICameraInfo info)
        {
            try
            {
                this.Camera = new Camera(info);
                this.Device = info;
                this.Camera.StreamGrabber.ImageGrabbed += onImageGrabbed;
                //this.ImageGrabbedEvent += onImageGrabbed;
                Debug.WriteLine($"{this.Camera.CameraInfo["Address"].Split(':')[0]}");
                this.주소 = $"{this.Camera.CameraInfo["Address"].Split(':')[0]}";
                this.상태 = this.Init();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                this.상태 = false;
            }
            return this.상태;
        }

        public override async void 수동촬영()
        {
            //Debug.WriteLine("수동촬영 신호들어옴");
            if(this.지연시간 != 0)
            {
                Debug.WriteLine($"DelayTime : {this.지연시간}");
                //int delayMilliseconds = (int)(this.지연시간 * 1000);
                await Task.Delay((int)this.지연시간);
            }
            
            this.Camera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            this.Camera.ExecuteSoftwareTrigger();
        }

        public void 노출적용()
        {
            if (this.Camera == null) return;

            this.Camera.Parameters[PLCamera.ExposureTime].SetValue(this.노출);
        }

        public void 대비적용()
        {
            if (this.Camera == null) return;

            this.Camera.Parameters[PLCamera.GainAbs].SetValue(this.대비);
        }

        public override Boolean Close()
        {
            this.Camera?.Close();
            this.Camera?.Dispose();
            return true;
        }

        public override Boolean Init()
        {
            this.Camera.Open(); //카메라오픈
            this.Camera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
            this.Camera.Parameters[PLCamera.GevSCPSPacketSize].SetValue(8192); //카메라 프레임 올려주기위한 설정
            return true;
        }
        public void TrigForce() => this.Camera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);

        private void onImageGrabbed(object sender, ImageGrabbedEventArgs e)
        {
            Debug.WriteLine("onImageGrabbed Event 들어옴");
            AcquisitionData acq = new AcquisitionData(this.구분);
            try
            {
                if (!e.GrabResult.IsValid) return;
                Debug.WriteLine($"{this.구분} Grab완료.");
                PixelDataConverter ImageConverter = new PixelDataConverter();
                IGrabResult ImageResult = e.GrabResult;

                Bitmap Image = new Bitmap(ImageResult.Width, ImageResult.Height, PixelFormat.Format32bppRgb);
                BitmapData Imagedata = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, Image.PixelFormat);
                //IntPtr ptrbmp = Imagedata.Scan0;
                //Mat image = new Mat(Image.Height, Image.Width, MatType.CV_8U, ptrbmp);
                //Image.UnlockBits(Imagedata);

                ImageConverter.OutputPixelFormat = PixelType.BGRA8packed;
                IntPtr ptrbmp = Imagedata.Scan0;
                ImageConverter.Convert(ptrbmp, Imagedata.Stride * Image.Height, ImageResult);
                Image.UnlockBits(Imagedata);

                acq.SetImage(Image);
                //Global.그랩제어.그랩완료(this.구분, image);
                this.Camera.StreamGrabber.Stop();
                GC.Collect();
                //this.Stop();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "System Exception");
                acq.Dispose();
                return;
            }
            this.AcquisitionFinishedEvent?.Invoke(this.구분, acq);
        }

        public class AcquisitionData : IDisposable
        {
            public 카메라구분 카메라 { get; set; } = 카메라구분.None;
            public Bitmap BmpImage { get; set; } = null;
            public Mat MatImage { get; set; } = null;

            public AcquisitionData(카메라구분 Cam)
            {
                this.카메라 = Cam;
            }
            public AcquisitionData(카메라구분 Cam, Mat Image)
            {
                this.카메라 = Cam;
                this.MatImage = Image;
            }

            public void SetImage(Mat image)
            {
                this.MatImage?.Dispose();
                this.MatImage = image;
                this.BmpImage?.Dispose();
                this.BmpImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(this.MatImage);
            }

            public void SetImage(Bitmap image)
            {
                this.BmpImage?.Dispose();
                this.BmpImage = image;
            }

            public void Dispose()
            {
                this.MatImage?.Dispose();
                this.MatImage = null;
            }
        }
    }
}