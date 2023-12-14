namespace TabberCapture.UI.Controls
{
    partial class Config
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.g환경설정 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.d기본경로 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.d문서저장 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.d사진저장 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.BindLocalization = new System.Windows.Forms.BindingSource(this.components);
            this.b설정저장 = new DevExpress.XtraEditors.SimpleButton();
            this.e기본경로 = new DevExpress.XtraEditors.ButtonEdit();
            this.e사진저장 = new DevExpress.XtraEditors.ButtonEdit();
            this.e문서저장 = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Bind환경설정 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.g환경설정)).BeginInit();
            this.g환경설정.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindLocalization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e기본경로.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e사진저장.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e문서저장.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bind환경설정)).BeginInit();
            this.SuspendLayout();
            // 
            // g환경설정
            // 
            this.g환경설정.Controls.Add(this.layoutControl1);
            this.g환경설정.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g환경설정.Location = new System.Drawing.Point(0, 0);
            this.g환경설정.Name = "g환경설정";
            this.g환경설정.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.g환경설정.Size = new System.Drawing.Size(599, 751);
            this.g환경설정.TabIndex = 8;
            this.g환경설정.Text = "환경설정";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.e기본경로);
            this.layoutControl1.Controls.Add(this.e문서저장);
            this.layoutControl1.Controls.Add(this.e사진저장);
            this.layoutControl1.Controls.Add(this.b설정저장);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(12, 34);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(575, 701);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(575, 701);
            this.Root.TextVisible = false;
            // 
            // b설정저장
            // 
            this.b설정저장.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b설정저장.Appearance.Options.UseFont = true;
            this.b설정저장.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("b설정저장.ImageOptions.SvgImage")));
            this.b설정저장.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.b설정저장.Location = new System.Drawing.Point(9, 126);
            this.b설정저장.Name = "b설정저장";
            this.b설정저장.Size = new System.Drawing.Size(557, 30);
            this.b설정저장.StyleController = this.layoutControl1;
            this.b설정저장.TabIndex = 1;
            this.b설정저장.Text = "저  장";
            // 
            // e기본경로
            // 
            this.e기본경로.EnterMoveNextControl = true;
            this.e기본경로.Location = new System.Drawing.Point(109, 30);
            this.e기본경로.Name = "e기본경로";
            this.e기본경로.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.e기본경로.Properties.Appearance.Options.UseFont = true;
            this.e기본경로.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.e기본경로.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.e기본경로.Size = new System.Drawing.Size(457, 28);
            this.e기본경로.StyleController = this.layoutControl1;
            this.e기본경로.TabIndex = 4;
            // 
            // e사진저장
            // 
            this.e사진저장.EnterMoveNextControl = true;
            this.e사진저장.Location = new System.Drawing.Point(109, 94);
            this.e사진저장.Name = "e사진저장";
            this.e사진저장.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.e사진저장.Properties.Appearance.Options.UseFont = true;
            this.e사진저장.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.e사진저장.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.e사진저장.Size = new System.Drawing.Size(457, 28);
            this.e사진저장.StyleController = this.layoutControl1;
            this.e사진저장.TabIndex = 6;
            // 
            // e문서저장
            // 
            this.e문서저장.EnterMoveNextControl = true;
            this.e문서저장.Location = new System.Drawing.Point(109, 62);
            this.e문서저장.Name = "e문서저장";
            this.e문서저장.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.e문서저장.Properties.Appearance.Options.UseFont = true;
            this.e문서저장.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.e문서저장.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.e문서저장.Size = new System.Drawing.Size(457, 28);
            this.e문서저장.StyleController = this.layoutControl1;
            this.e문서저장.TabIndex = 11;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Basic";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup2.Size = new System.Drawing.Size(575, 701);
            this.layoutControlGroup2.Text = "Basic";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.e기본경로;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "설정 저장 경로";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(561, 32);
            this.layoutControlItem1.Text = "설정 저장 경로";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 17);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.e문서저장;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "문서 저장 경로";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(561, 32);
            this.layoutControlItem8.Text = "문서 저장 경로";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(88, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.e사진저장;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "사진 저장 경로";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(561, 32);
            this.layoutControlItem4.Text = "사진 저장 경로";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.b설정저장;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(561, 570);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Bind환경설정
            // 
            this.Bind환경설정.DataSource = typeof(TabberCapture.Schemas.환경설정);
            // 
            // Config
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.g환경설정);
            this.Name = "Config";
            this.Size = new System.Drawing.Size(599, 751);
            ((System.ComponentModel.ISupportInitialize)(this.g환경설정)).EndInit();
            this.g환경설정.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindLocalization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e기본경로.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e사진저장.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e문서저장.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bind환경설정)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl g환경설정;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog d기본경로;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog d문서저장;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog d사진저장;
        private System.Windows.Forms.BindingSource Bind환경설정;
        private System.Windows.Forms.BindingSource BindLocalization;
        private DevExpress.XtraEditors.ButtonEdit e기본경로;
        private DevExpress.XtraEditors.ButtonEdit e문서저장;
        private DevExpress.XtraEditors.ButtonEdit e사진저장;
        private DevExpress.XtraEditors.SimpleButton b설정저장;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
