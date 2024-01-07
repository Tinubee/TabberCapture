using DevExpress.XtraEditors;

namespace TabberCapture.UI.Controls
{
    public partial class DeviceSettings : XtraUserControl
    {
        public DeviceSettings()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.config1.Init();
            this.camSettings1.Init();
        }
    }
}
