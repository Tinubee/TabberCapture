using DevExpress.XtraBars;
using DevExpress.XtraWaitForm;
using MvUtils;
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

namespace TabberCapture
{
    public partial class MainForm : TabForm
    {
        private LocalizationMain 번역 = new LocalizationMain();
        private WaitForm WaitForm;
        public MainForm()
        {
            InitializeComponent();
            this.ShowWaitForm();
            this.타이틀.Caption = $"IVM: {환경설정.프로젝트번호}";
            this.Shown += MainFormShown;
            this.FormClosing += MainFormClosing;
        }
        private void ShowWaitForm()
        {
            WaitForm = new WaitForm() { ShowOnTopMode = ShowFormOnTopMode.AboveAll };
            WaitForm.Show(this);
        }
        private void HideWaitForm()
        {
            WaitForm.Close();
        }
        private void MainFormShown(object sender, EventArgs e)
        {
            Global.Initialized += GlobalInitialized;
            Task.Run(() => { Global.Init(); });
        }

        private void GlobalInitialized(object sender, Boolean e)
        {
            this.BeginInvoke(new Action(() => GlobalInitialized(e)));
        }

        private void GlobalInitialized(Boolean e)
        {
            Global.Initialized -= GlobalInitialized;
            if (!e) { this.Close(); return; }
            this.HideWaitForm();
            Common.SetForegroundWindow(this.Handle.ToInt32());
            Global.DxLocalization();
            this.Init();
        }

        private void Init()
        {
            this.SetLocalization();
            //this.e변수설정.Init();
            //this.e장치설정.Init();
            this.e환경설정.Init();
            this.e결과뷰어.Init();
            this.e상태뷰어.Init();
            this.e입력신호.Init();

            this.TabFormControl.AllowMoveTabs = false;
            this.TabFormControl.AllowMoveTabsToOuterForm = false;

            if (Global.환경설정.동작구분 == 동작구분.Live)
                this.WindowState = FormWindowState.Maximized;
            //this.ShowHideControl();

            if (Global.환경설정.동작구분 != 동작구분.Live) return;

            //Global.Start();
        }

        private void CloseForm()
        {
            //this.e장치설정.Close();
            //this.e로그내역.Close();
            //this.e상태뷰어.Close();
            Global.Close();
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Utils.Confirm(this, 번역.종료확인, Localization.확인.GetString());
            if (!e.Cancel) this.CloseForm();
        }
        private void SetLocalization()
        {
            this.Text = this.번역.타이틀;
            this.타이틀.Caption = this.번역.타이틀;
            this.p메인화면.Text = this.번역.메인화면;
            this.p환경설정.Text = this.번역.환경설정;
        }
        private class LocalizationMain
        {
            private enum Items
            {
                [Translation("Main", "메인")]
                메인화면,
                [Translation("Setting", "환경설정")]
                환경설정,
                [Translation("Are you want to exit the program?", "프로그램을 종료하시겠습나까?")]
                종료확인,
            }
            private String GetString(Items item) { return Localization.GetString(item); }

            public String 타이틀 { get { return Localization.제목.GetString(); } }
            public String 메인화면 { get { return GetString(Items.메인화면); } }
            public String 환경설정 { get { return GetString(Items.환경설정); } }
            public String 종료확인 { get { return GetString(Items.종료확인); } }
        }
    }
}
