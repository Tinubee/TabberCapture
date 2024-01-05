using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabberCapture.Schemas;
using static TabberCapture.Schemas.BaslerGigE;

namespace TabberCapture.UI.Controls
{
    public partial class CamViewers : XtraUserControl
    {
        private delegate void 이미지그랩완료보고대리자(카메라구분 카메라, AcquisitionData Data);
        public CamViewers()
        {
            InitializeComponent();
        }
        public void Init()
        {
            if (Global.그랩제어.카메라1 != null)
                Global.그랩제어.카메라1.AcquisitionFinishedEvent += Paint_camImage;
            if (Global.그랩제어.카메라2 != null)
                Global.그랩제어.카메라2.AcquisitionFinishedEvent += Paint_camImage;
            if (Global.그랩제어.카메라3 != null)
                Global.그랩제어.카메라3.AcquisitionFinishedEvent += Paint_camImage;
            if (Global.그랩제어.카메라4 != null)
                Global.그랩제어.카메라4.AcquisitionFinishedEvent += Paint_camImage;
            if (Global.그랩제어.카메라5 != null)
                Global.그랩제어.카메라5.AcquisitionFinishedEvent += Paint_camImage;

            b카메라1번수동촬영.Click += B카메라1번수동촬영_Click;
            b카메라2번수동촬영.Click += B카메라2번수동촬영_Click;
            b카메라3번수동촬영.Click += B카메라3번수동촬영_Click;
            b카메라4번수동촬영.Click += B카메라4번수동촬영_Click;
            b카메라5번수동촬영.Click += B카메라5번수동촬영_Click;

            e입력신호.Init();
        }

       
        private void B카메라1번수동촬영_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("1번카메라 수동촬영");
            //Global.그랩제어.GetItem(카메라구분.Cam01).
            Global.그랩제어.GetItem(카메라구분.Cam01).수동촬영();
        }
        private void B카메라2번수동촬영_Click(object sender, EventArgs e)
        {
            Global.그랩제어.GetItem(카메라구분.Cam02).수동촬영();
        }
        private void B카메라3번수동촬영_Click(object sender, EventArgs e)
        {
            Global.그랩제어.GetItem(카메라구분.Cam03).수동촬영();
        }
        private void B카메라4번수동촬영_Click(object sender, EventArgs e)
        {
            Global.그랩제어.GetItem(카메라구분.Cam04).수동촬영();
        }
        private void B카메라5번수동촬영_Click(object sender, EventArgs e)
        {
            Global.그랩제어.GetItem(카메라구분.Cam05).수동촬영();
        }

        private void Paint_camImage(카메라구분 구분, AcquisitionData Data)
        {
            if (구분 == 카메라구분.Cam01) cam1View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam02) cam2View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam03) cam3View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam04) cam4View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam05) cam5View.Image = Data.BmpImage;

            Global.그랩제어.ImageSave(Data.MatImage, 구분, (Int32)구분);
        }
    }
}
