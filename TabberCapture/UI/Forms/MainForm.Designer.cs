namespace TabberCapture
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            bool isDesignMode = DesignMode;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (!isDesignMode)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.타이틀 = new DevExpress.XtraBars.BarStaticItem();
            this.e프로젝트 = new DevExpress.XtraBars.BarStaticItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.p메인화면 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.e결과뷰어 = new TabberCapture.UI.Controls.CamViewers();
            this.e상태뷰어 = new TabberCapture.UI.Controls.State();
            this.p환경설정 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.e환경설정 = new TabberCapture.UI.Controls.DeviceSettings();
            this.p입출자료 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer3 = new DevExpress.XtraBars.TabFormContentContainer();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.e입력신호 = new TabberCapture.UI.Controls.IOControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            this.tabFormContentContainer2.SuspendLayout();
            this.tabFormContentContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.AllowMoveTabs = false;
            this.tabFormControl1.AllowMoveTabsToOuterForm = false;
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.타이틀,
            this.e프로젝트,
            this.skinPaletteDropDownButtonItem1});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.p메인화면);
            this.tabFormControl1.Pages.Add(this.p환경설정);
            this.tabFormControl1.Pages.Add(this.p입출자료);
            this.tabFormControl1.SelectedPage = this.p메인화면;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabCloseButtons = false;
            this.tabFormControl1.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.True;
            this.tabFormControl1.Size = new System.Drawing.Size(1920, 30);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabLeftItemLinks.Add(this.타이틀);
            this.tabFormControl1.TabRightItemLinks.Add(this.e프로젝트);
            this.tabFormControl1.TabRightItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.tabFormControl1.TabStop = false;
            // 
            // 타이틀
            // 
            this.타이틀.Caption = "Tabber Capture Program";
            this.타이틀.Id = 0;
            this.타이틀.Name = "타이틀";
            // 
            // e프로젝트
            // 
            this.e프로젝트.Caption = "23-1213-005";
            this.e프로젝트.Id = 1;
            this.e프로젝트.Name = "e프로젝트";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 2;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // p메인화면
            // 
            this.p메인화면.ContentContainer = this.tabFormContentContainer1;
            this.p메인화면.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("p메인화면.ImageOptions.SvgImage")));
            this.p메인화면.Name = "p메인화면";
            this.p메인화면.Text = "Main";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.e결과뷰어);
            this.tabFormContentContainer1.Controls.Add(this.e상태뷰어);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 30);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1920, 1070);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // e결과뷰어
            // 
            this.e결과뷰어.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e결과뷰어.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.e결과뷰어.Appearance.Options.UseBackColor = true;
            this.e결과뷰어.Appearance.Options.UseForeColor = true;
            this.e결과뷰어.Dock = System.Windows.Forms.DockStyle.Fill;
            this.e결과뷰어.Location = new System.Drawing.Point(0, 105);
            this.e결과뷰어.Margin = new System.Windows.Forms.Padding(0);
            this.e결과뷰어.Name = "e결과뷰어";
            this.e결과뷰어.Size = new System.Drawing.Size(1920, 965);
            this.e결과뷰어.TabIndex = 1;
            // 
            // e상태뷰어
            // 
            this.e상태뷰어.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e상태뷰어.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.e상태뷰어.Appearance.Options.UseBackColor = true;
            this.e상태뷰어.Appearance.Options.UseForeColor = true;
            this.e상태뷰어.Dock = System.Windows.Forms.DockStyle.Top;
            this.e상태뷰어.Location = new System.Drawing.Point(0, 0);
            this.e상태뷰어.Name = "e상태뷰어";
            this.e상태뷰어.Size = new System.Drawing.Size(1920, 105);
            this.e상태뷰어.TabIndex = 0;
            // 
            // p환경설정
            // 
            this.p환경설정.ContentContainer = this.tabFormContentContainer2;
            this.p환경설정.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("p환경설정.ImageOptions.SvgImage")));
            this.p환경설정.Name = "p환경설정";
            this.p환경설정.Text = "Setting";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.e환경설정);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 30);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(1920, 1070);
            this.tabFormContentContainer2.TabIndex = 2;
            // 
            // e환경설정
            // 
            this.e환경설정.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e환경설정.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e환경설정.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.e환경설정.Appearance.Options.UseBackColor = true;
            this.e환경설정.Appearance.Options.UseFont = true;
            this.e환경설정.Appearance.Options.UseForeColor = true;
            this.e환경설정.Dock = System.Windows.Forms.DockStyle.Fill;
            this.e환경설정.Location = new System.Drawing.Point(0, 0);
            this.e환경설정.Name = "e환경설정";
            this.e환경설정.Size = new System.Drawing.Size(1920, 1070);
            this.e환경설정.TabIndex = 0;
            // 
            // p입출자료
            // 
            this.p입출자료.ContentContainer = this.tabFormContentContainer3;
            this.p입출자료.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("p입출자료.ImageOptions.SvgImage")));
            this.p입출자료.Name = "p입출자료";
            this.p입출자료.Text = "I/O";
            // 
            // tabFormContentContainer3
            // 
            this.tabFormContentContainer3.Controls.Add(this.splitContainerControl1);
            this.tabFormContentContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer3.Location = new System.Drawing.Point(0, 30);
            this.tabFormContentContainer3.Name = "tabFormContentContainer3";
            this.tabFormContentContainer3.Size = new System.Drawing.Size(1920, 1070);
            this.tabFormContentContainer3.TabIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.e입력신호);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1920, 1070);
            this.splitContainerControl1.SplitterPosition = 930;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // e입력신호
            // 
            this.e입력신호.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e입력신호.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.e입력신호.Appearance.Options.UseBackColor = true;
            this.e입력신호.Appearance.Options.UseForeColor = true;
            this.e입력신호.Dock = System.Windows.Forms.DockStyle.Fill;
            this.e입력신호.Location = new System.Drawing.Point(0, 0);
            this.e입력신호.Name = "e입력신호";
            this.e입력신호.Size = new System.Drawing.Size(930, 1070);
            this.e입력신호.TabIndex = 0;
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1100);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            this.tabFormContentContainer2.ResumeLayout(false);
            this.tabFormContentContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormPage p메인화면;
        private DevExpress.XtraBars.BarStaticItem 타이틀;
        private DevExpress.XtraBars.BarStaticItem e프로젝트;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.TabFormPage p환경설정;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private UI.Controls.DeviceSettings e환경설정;
        private UI.Controls.State e상태뷰어;
        private UI.Controls.CamViewers e결과뷰어;
        private DevExpress.XtraBars.TabFormPage p입출자료;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private UI.Controls.IOControl e입력신호;
    }
}

