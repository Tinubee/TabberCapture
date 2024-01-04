using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace TabberCapture.UI.Controls
{
    public partial class CamSettings : XtraUserControl
    {
        private LocalizationConfig 번역 = new LocalizationConfig();
        public CamSettings()
        {
            InitializeComponent();
            this.BindLocalization.DataSource = this.번역;
        }

        public void Init()
        {
            this.GridView1.Init();
            this.GridView1.OptionsBehavior.Editable = true;
            this.GridView1.OptionsView.ShowAutoFilterRow = false;
            this.GridView1.OptionsView.ShowFooter = false;
            this.GridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            this.GridControl1.DataSource = Global.그랩제어.Values;

            this.GridView2.Init();
            this.GridView2.OptionsBehavior.Editable = true;
            this.GridView2.OptionsView.ShowAutoFilterRow = false;
            this.GridView2.OptionsView.ShowFooter = false;
            this.GridControl2.DataSource = Global.조명제어;

            Localization.SetColumnCaption(this.GridView1, typeof(카메라장치));
            Localization.SetColumnCaption(this.GridView2, typeof(조명정보));
            this.b저장.Text = Localization.저장.GetString();
            this.b저장.Click += b저장_Click;

            this.GridView1.CellValueChanged += GridView1_CellValueChanged;
            this.GridView2.CellValueChanged += GridView2_CellValueChanged;
            //this.e조명켜짐.Toggled += E켜짐_Toggled;
        }

        private void b저장_Click(object sender, EventArgs e)
        {
            if (!MvUtils.Utils.Confirm(번역.저장확인, Localization.확인.GetString())) return;
            this.GridControl1.EmbeddedNavigator.Buttons.DoClick(this.GridControl1.EmbeddedNavigator.Buttons.EndEdit);
            this.GridControl2.EmbeddedNavigator.Buttons.DoClick(this.GridControl2.EmbeddedNavigator.Buttons.EndEdit);
            Global.그랩제어?.Save();
            Global.조명제어?.Save();
            //Global.정보로그("카메라 설정", "설정저장", "저장되었습니다.", this.FindForm());
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            BaslerGigE 장치 = view.GetRow(e.RowHandle) as BaslerGigE;
            if (장치 == null) return;
            GridControl1.EmbeddedNavigator.Buttons.DoClick(GridControl1.EmbeddedNavigator.Buttons.EndEdit);
            if (e.Column.FieldName == this.col노출.FieldName) 장치.노출적용();
            //if (e.Column.FieldName == this.col밝기.FieldName) 장치.밝기적용();
            //else if (e.Column.FieldName == this.col대비.FieldName) 장치.대비적용();
            //else if (e.Column.FieldName == this.col노출.FieldName) 장치.노출적용();
        }

        private void GridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName != this.col광량.FieldName) return;
            //GridView view = sender as GridView;
            //조명정보 정보 = view.GetRow(e.RowHandle) as 조명정보;
            //정보?.Set();
            //view.RefreshRow(e.RowHandle);
        }

        private void E켜짐_Toggled(object sender, EventArgs e)
        {
            조명정보 정보 = this.GridView2.GetRow(this.GridView2.FocusedRowHandle) as 조명정보;
            if (정보 == null) return;
            정보.OnOff();
        }

        private class LocalizationConfig
        {
            private enum Items
            {
                [Translation("Save", "설정저장")]
                설정저장,
                [Translation("It's saved.", "저장되었습니다.")]
                저장완료,
                [Translation("Save your device setting?", "장치설정을 저장하시겠습니까?")]
                저장확인,
            }

            public String 기본경로 { get { return Localization.GetString(typeof(환경설정).GetProperty(nameof(환경설정.기본경로))); } }
            public String 문서저장 { get { return Localization.GetString(typeof(환경설정).GetProperty(nameof(환경설정.문서저장))); } }
            public String 사진저장 { get { return Localization.GetString(typeof(환경설정).GetProperty(nameof(환경설정.사진저장))); } }
            public String 설정저장 { get { return Localization.GetString(Items.설정저장); } }
            public String 저장완료 { get { return Localization.GetString(Items.저장완료); } }
            public String 저장확인 { get { return Localization.GetString(Items.저장확인); } }
        }
    }
}
