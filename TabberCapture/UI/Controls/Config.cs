﻿using DevExpress.XtraEditors;
using MvUtils;
using System;
using System.Windows.Forms;
using TabberCapture.Schemas;

namespace TabberCapture.UI.Controls
{
    public partial class Config : XtraUserControl
    {
        private LocalizationConfig 번역 = new LocalizationConfig();
        public Config()
        {
            InitializeComponent();
            this.BindLocalization.DataSource = this.번역;
            //this.g환경설정.Text = 환경설정.로그영역.GetString();
        }

        public void Init()
        {
            this.Bind환경설정.DataSource = Global.환경설정;
            this.d기본경로.SelectedPath = Global.환경설정.기본경로;
            this.d문서저장.SelectedPath = Global.환경설정.문서저장;
            this.d사진저장.SelectedPath = Global.환경설정.사진저장;
            this.e기본경로.Text = this.d기본경로.SelectedPath;
            this.e문서저장.Text = this.d문서저장.SelectedPath;
            this.e사진저장.Text = this.d사진저장.SelectedPath;
            this.e기본경로.ButtonClick += E기본경로_ButtonClick;
            this.e문서저장.ButtonClick += E문서저장_ButtonClick;
            this.e사진저장.ButtonClick += E사진저장_ButtonClick;
            this.b설정저장.Click += b설정저장_Click;
        }

        public void Close()
        {

        }

        private void E사진저장_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.d사진저장.ShowDialog() == DialogResult.OK)
                this.e사진저장.Text = this.d사진저장.SelectedPath;
        }

        private void E문서저장_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.d문서저장.ShowDialog() == DialogResult.OK)
                this.e문서저장.Text = this.d문서저장.SelectedPath;
        }

        private void E기본경로_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.d기본경로.ShowDialog() == DialogResult.OK)
                this.e기본경로.Text = this.d기본경로.SelectedPath;
        }

        private void b설정저장_Click(object sender, EventArgs e)
        {
            this.Bind환경설정.EndEdit();
            if (!Utils.Confirm(번역.저장확인, Localization.확인.GetString())) return;
            Global.환경설정.Save();
            Utils.SaveOK();
        }

        private class LocalizationConfig
        {
            private enum Items
            {
                [Translation("Save", "설정저장")]
                설정저장,
                [Translation("It's saved.", "저장되었습니다.")]
                저장완료,
                [Translation("Save your preferences?", "환경설정을 저장하시겠습니까?")]
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
