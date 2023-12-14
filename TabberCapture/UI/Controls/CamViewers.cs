using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private delegate void 이미지그랩완료보고대리자(카메라구분 카메라 ,AcquisitionData Data);
        public CamViewers()
        {
            InitializeComponent();
        }
        public void Init()
        {
            Global.그랩제어.카메라1.AcquisitionFinishedEvent += Paint_camImage;
            Global.그랩제어.카메라2.AcquisitionFinishedEvent += Paint_camImage;
            Global.그랩제어.카메라3.AcquisitionFinishedEvent += Paint_camImage;
            Global.그랩제어.카메라4.AcquisitionFinishedEvent += Paint_camImage;
            Global.그랩제어.카메라5.AcquisitionFinishedEvent += Paint_camImage;
        }

        private void Paint_camImage(카메라구분 구분, AcquisitionData Data)
        {
            if(구분 == 카메라구분.Cam01) cam1View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam02) cam2View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam03) cam3View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam04) cam4View.Image = Data.BmpImage;
            else if (구분 == 카메라구분.Cam05) cam5View.Image = Data.BmpImage;

            Global.그랩제어.ImageSave(Data.MatImage, 구분, (Int32)구분);
        }
    }
}
