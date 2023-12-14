using DevExpress.XtraEditors;
using MvUtils;
using System;
using TabberCapture.Schemas;

namespace TabberCapture.UI.Controls
{
    public partial class State : XtraUserControl
    {
        private LocalizationState 번역 = new LocalizationState();
        public State()
        {
            InitializeComponent();
            //this.BindLocalization.DataSource = this.번역;
            //this.BindLocalization.ResetBindings(false);
        }

        public void Init()
        {
            this.Bind모델자료.DataSource = Global.모델자료.선택모델;
            //this.BindLocalization.ResetBindings(false);
            Localization.SetColumnCaption(this.e모델선택, typeof(모델정보));
            this.e모델선택.Properties.DataSource = Global.모델자료;
            this.e모델선택.EditValue = Global.환경설정.선택모델;
            this.e모델선택.CustomDisplayText += 선택모델표현;
            this.e모델선택.EditValueChanging += 모델변경;

            //else this.e모델선택.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.e모델선택.CustomDisplayText += 선택모델표현;

            Global.환경설정.모델변경알림 += 모델변경알림;
            //Global.장치통신.동작상태알림 += 동작상태알림;
           
            this.e모델선택.Refresh();
            this.e장치상태.Init();
            this.e저장용량.EditValue = Global.환경설정.저장비율;
        }

        public void Close() { }

        private void 선택모델표현(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            try
            {
                모델구분 모델 = (모델구분)e.Value;
                e.DisplayText = $"{((Int32)모델).ToString("d2")}. {Utils.GetDescription(모델)}";
            }
            catch { e.DisplayText = String.Empty; }
        }

        private void 모델변경알림(모델구분 모델코드)
        {
            if (Global.모델자료.선택모델 == null) return;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => 모델변경알림(모델코드)));
                return;
            }
            this.e모델선택.EditValue = 모델코드;
            this.Bind모델자료.DataSource = Global.모델자료.선택모델;
            this.Bind모델자료.ResetBindings(false);
        }

        private void 모델변경(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            모델구분 모델 = (모델구분)e.NewValue;
            if (Global.환경설정.선택모델 == 모델) return;
            if (!Utils.Confirm(번역.모델변경))
            {
                e.Cancel = true;
                return;
            }
            Global.환경설정.모델변경요청(모델);
        }
      
        private class LocalizationState
        {
            private enum Items
            {
                [Translation("Change the model name?", "모델이름을 변경하시겠습니까?")]
                모델변경,
            }

            private String GetString(Items item) { return Localization.GetString(item); }
            public String 모델변경 { get { return GetString(Items.모델변경); } }
        }
    }
}
