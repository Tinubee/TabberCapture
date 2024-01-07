using DevExpress.XtraEditors;
using MvUtils;
using System;
using System.Collections.Generic;
using System.Drawing;
using TabberCapture.Schemas;

namespace TabberCapture.UI.Controls
{
    public partial class IOControl : XtraUserControl
    {
        public IOControl()
        {
            InitializeComponent();
        }
        public void Init()
        {
            //MyGridView.SetFocusedRow(this.gridView1);
            this.customGrid1.DataSource = new 입력신호자료();
            this.입출변경알림();
            Global.신호제어.입출변경알림 += 입출변경알림;
        }

        private void 입출변경알림()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(입출변경알림));
                return;
            }
            this.customView1.RefreshData();
        }
        private Color 동작색상 = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
        private Color 정지색상 = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
        private void 버튼체크(SimpleButton 버튼, Boolean 상태)
        {
            if (상태 && 버튼.Appearance.ForeColor == 동작색상) return;
            if (!상태 && 버튼.Appearance.ForeColor == 정지색상) return;
            if (버튼.InvokeRequired) 버튼.BeginInvoke(new Action(() => { 버튼상태(버튼, 상태); }));
            else 버튼상태(버튼, 상태);
        }
        private void 버튼상태(SimpleButton 버튼, Boolean 상태)
        {
            버튼.Appearance.Options.UseForeColor = true;
            if (상태) 버튼.Appearance.ForeColor = 동작색상;
            else 버튼.Appearance.ForeColor = 정지색상;
        }
        private class 입력신호자료 : List<입력신호정보>
        {
            public 입력신호자료()
            {
                foreach (신호제어.입력번호 번호 in typeof(신호제어.입력번호).GetEnumValues())
                {
                    if (Utils.GetAttribute<TranslationAttribute>(번호) == null) continue;
                    this.Add(new 입력신호정보() { 구분 = 번호 });
                }
            }
        }

        private class 입력신호정보
        {
            public 신호제어.입력번호 구분 { get; set; }
            public Int32 번호 { get { return (Int32)구분; } }
            public String 명칭 { get { return Localization.GetString(this.구분); } }
            public Boolean 여부 { get { return Global.신호제어.입력상태(구분); } }
        }
    }
}
