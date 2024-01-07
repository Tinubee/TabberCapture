using MvUtils;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TabberCapture.Schemas
{
    public class 환경설정
    {
        public delegate void 모델변경(모델구분 모델코드);
        public event 모델변경 모델변경알림;

        [JsonIgnore]
        public const String 프로젝트번호 = "23-1213-005";
        [Description("프로그램 동작구분"), JsonProperty("RunType")]
        public 동작구분 동작구분 { get; set; } = 동작구분.Live;
        [Description("Config Path"), JsonProperty("ConfigSavePath")]
        public String 기본경로 { get; set; } = @"C:\Tabber\Config";
        [Description("Document Save Path"), JsonProperty("DocumentSavePath")]
        public String 문서저장 { get; set; } = @"C:\Tabber\SaveData";
        [Description("Image Save Path"), JsonProperty("ImageSavePath")]
        public String 사진저장 { get; set; } = @"C:\Tabber\SaveImage";
        [JsonIgnore]
        private String 저장파일 { get { return Path.Combine(this.기본경로, "Config.json"); } }
        [JsonProperty("CurrentModel")]
        public 모델구분 선택모델 { get; set; } = 모델구분.TabberLine1;
        [JsonIgnore, Description("이미지 저장 디스크 사용율")]
        public Int32 저장비율 { get { return 100 - this.SaveImageDriveFreeSpace(); } }

        public Boolean Init()
        {
            return this.Load();
        }

        public void Close()
        {
            this.Save();
        }

        public Boolean Load()
        {
            Common.DirectoryExists(Path.Combine(Application.StartupPath, @"Views"), true);
            if (!Common.DirectoryExists(기본경로, true))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", "기본설정 폴더를 생성할 수 없습니다.", true);
                return false;
            }
            if (!Common.DirectoryExists(사진저장, true))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", "사진저장 폴더를 생성할 수 없습니다.", true);
            }
            if (!Common.DirectoryExists(문서저장, true))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", "문서저장 폴더를 생성할 수 없습니다.", true);
            }

            if (File.Exists(저장파일))
            {
                try
                {
                    환경설정 설정 = JsonConvert.DeserializeObject<환경설정>(File.ReadAllText(저장파일, Encoding.UTF8));
                    foreach (PropertyInfo p in 설정.GetType().GetProperties())
                    {
                        if (!p.CanWrite) continue;
                        Object v = p.GetValue(설정);
                        if (v == null) continue;
                        p.SetValue(this, v);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", ex.Message, true);
                }
            }
            else
            {
                this.Save();
                //Global.정보로그(로그영역.GetString(), "환경설정 로드", "저장된 설정파일이 없습니다.", false);
            }

            Debug.WriteLine(this.동작구분, "동작구분");
            return true;
        }

        public void Save()
        {
            if (!Utils.WriteAllText(저장파일, JsonConvert.SerializeObject(this, Utils.JsonSetting())))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 저장", "환경설정 저장에 실패하였습니다.", true);
            }
        }
        public void 모델변경요청(Int32 모델번호)
        {
            this.모델변경요청((모델구분)모델번호);
        }

        public void 모델변경요청(모델구분 모델구분)
        {
            if (this.선택모델 == 모델구분) return;
            this.선택모델 = 모델구분;
            this.모델변경알림?.Invoke(this.선택모델);
        }


        #region 드라이브 용량계산
        private DriveInfo ImageSaveDrive = null;
        private DriveInfo GetSaveImageDrive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (this.사진저장.StartsWith(drive.Name))
                {
                    //Debug.WriteLine(drive.Name, drive.VolumeLabel);
                    this.ImageSaveDrive = drive;
                    return this.ImageSaveDrive;
                }
            }
            if (drives.Length > 0)
                this.ImageSaveDrive = drives[0];

            return this.ImageSaveDrive;
        }

        public Int32 SaveImageDriveFreeSpace()
        {
            DriveInfo drive = this.GetSaveImageDrive();
            double FreeSpace = drive.AvailableFreeSpace / (double)drive.TotalSize * 100;
            return Convert.ToInt32(FreeSpace);
        }
        #endregion
    }
}
