namespace TabberCapture.UI.Controls
{
    partial class CamSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CamSettings));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.b저장 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GridControl1 = new MvUtils.CustomGrid();
            this.Bind카메라설정 = new System.Windows.Forms.BindingSource(this.components);
            this.GridView1 = new MvUtils.CustomView();
            this.col구분 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col코드 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col설명 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col주소 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col지연시간 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col시간 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col노출 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col밝기 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col대비 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col상태 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.GridControl2 = new MvUtils.CustomGrid();
            this.Bind조명설정 = new System.Windows.Forms.BindingSource(this.components);
            this.GridView2 = new MvUtils.CustomView();
            this.col포트 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col채널 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col밝기1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col설명1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col켜짐 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BindLocalization = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.repositoryItemToggleSwitch2 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bind카메라설정)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bind조명설정)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindLocalization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.b저장);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 798);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(943, 54);
            this.panelControl1.TabIndex = 9;
            // 
            // b저장
            // 
            this.b저장.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b저장.Appearance.Options.UseFont = true;
            this.b저장.Dock = System.Windows.Forms.DockStyle.Right;
            this.b저장.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("b저장.ImageOptions.SvgImage")));
            this.b저장.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.b저장.Location = new System.Drawing.Point(790, 2);
            this.b저장.Name = "b저장";
            this.b저장.Size = new System.Drawing.Size(151, 50);
            this.b저장.TabIndex = 7;
            this.b저장.Text = "설정저장";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.GridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(943, 440);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Cameras";
            // 
            // GridControl1
            // 
            this.GridControl1.DataSource = this.Bind카메라설정;
            this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl1.Location = new System.Drawing.Point(2, 27);
            this.GridControl1.MainView = this.GridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch2});
            this.GridControl1.Size = new System.Drawing.Size(939, 411);
            this.GridControl1.TabIndex = 0;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // Bind카메라설정
            // 
            this.Bind카메라설정.DataSource = typeof(TabberCapture.Schemas.카메라장치);
            // 
            // GridView1
            // 
            this.GridView1.AllowColumnMenu = true;
            this.GridView1.AllowCustomMenu = true;
            this.GridView1.AllowExport = true;
            this.GridView1.AllowPrint = true;
            this.GridView1.AllowSettingsMenu = false;
            this.GridView1.AllowSummaryMenu = true;
            this.GridView1.ApplyFocusedRow = true;
            this.GridView1.Caption = "";
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col구분,
            this.col코드,
            this.col설명,
            this.col주소,
            this.col지연시간,
            this.col시간,
            this.col노출,
            this.col밝기,
            this.col대비,
            this.col상태});
            this.GridView1.FooterPanelHeight = 21;
            this.GridView1.GridControl = this.GridControl1;
            this.GridView1.GroupRowHeight = 21;
            this.GridView1.IndicatorWidth = 44;
            this.GridView1.MinColumnRowHeight = 24;
            this.GridView1.MinRowHeight = 18;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsBehavior.Editable = false;
            this.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.GridView1.OptionsCustomization.AllowColumnMoving = false;
            this.GridView1.OptionsCustomization.AllowFilter = false;
            this.GridView1.OptionsCustomization.AllowGroup = false;
            this.GridView1.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
            this.GridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.GridView1.OptionsCustomization.AllowSort = false;
            this.GridView1.OptionsFilter.AllowFilterEditor = false;
            this.GridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.GridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.GridView1.OptionsPrint.AutoWidth = false;
            this.GridView1.OptionsPrint.UsePrintStyles = false;
            this.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.RowHeight = 20;
            // 
            // col구분
            // 
            this.col구분.AppearanceHeader.Options.UseTextOptions = true;
            this.col구분.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col구분.FieldName = "구분";
            this.col구분.Name = "col구분";
            this.col구분.Visible = true;
            this.col구분.VisibleIndex = 0;
            // 
            // col코드
            // 
            this.col코드.AppearanceHeader.Options.UseTextOptions = true;
            this.col코드.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col코드.FieldName = "코드";
            this.col코드.Name = "col코드";
            this.col코드.Visible = true;
            this.col코드.VisibleIndex = 1;
            // 
            // col설명
            // 
            this.col설명.AppearanceHeader.Options.UseTextOptions = true;
            this.col설명.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col설명.FieldName = "설명";
            this.col설명.Name = "col설명";
            this.col설명.Visible = true;
            this.col설명.VisibleIndex = 2;
            // 
            // col주소
            // 
            this.col주소.AppearanceHeader.Options.UseTextOptions = true;
            this.col주소.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col주소.FieldName = "주소";
            this.col주소.Name = "col주소";
            this.col주소.Visible = true;
            this.col주소.VisibleIndex = 3;
            // 
            // col지연시간
            // 
            this.col지연시간.AppearanceHeader.Options.UseTextOptions = true;
            this.col지연시간.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col지연시간.FieldName = "지연시간";
            this.col지연시간.Name = "col지연시간";
            this.col지연시간.Visible = true;
            this.col지연시간.VisibleIndex = 5;
            // 
            // col시간
            // 
            this.col시간.AppearanceHeader.Options.UseTextOptions = true;
            this.col시간.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col시간.FieldName = "시간";
            this.col시간.Name = "col시간";
            this.col시간.Visible = true;
            this.col시간.VisibleIndex = 6;
            // 
            // col노출
            // 
            this.col노출.AppearanceHeader.Options.UseTextOptions = true;
            this.col노출.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col노출.FieldName = "노출";
            this.col노출.Name = "col노출";
            this.col노출.Visible = true;
            this.col노출.VisibleIndex = 7;
            // 
            // col밝기
            // 
            this.col밝기.AppearanceHeader.Options.UseTextOptions = true;
            this.col밝기.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col밝기.FieldName = "밝기";
            this.col밝기.Name = "col밝기";
            this.col밝기.Visible = true;
            this.col밝기.VisibleIndex = 8;
            // 
            // col대비
            // 
            this.col대비.AppearanceHeader.Options.UseTextOptions = true;
            this.col대비.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col대비.FieldName = "대비";
            this.col대비.Name = "col대비";
            this.col대비.Visible = true;
            this.col대비.VisibleIndex = 9;
            // 
            // col상태
            // 
            this.col상태.AppearanceHeader.Options.UseTextOptions = true;
            this.col상태.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col상태.ColumnEdit = this.repositoryItemToggleSwitch2;
            this.col상태.FieldName = "상태";
            this.col상태.Name = "col상태";
            this.col상태.OptionsColumn.ReadOnly = true;
            this.col상태.Visible = true;
            this.col상태.VisibleIndex = 4;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.Controls.Add(this.GridControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 440);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(943, 358);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Lights";
            // 
            // GridControl2
            // 
            this.GridControl2.DataSource = this.Bind조명설정;
            this.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl2.Location = new System.Drawing.Point(2, 27);
            this.GridControl2.MainView = this.GridView2;
            this.GridControl2.Name = "GridControl2";
            this.GridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1});
            this.GridControl2.Size = new System.Drawing.Size(939, 329);
            this.GridControl2.TabIndex = 1;
            this.GridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView2});
            // 
            // Bind조명설정
            // 
            this.Bind조명설정.DataSource = typeof(TabberCapture.Schemas.조명제어);
            // 
            // GridView2
            // 
            this.GridView2.AllowColumnMenu = true;
            this.GridView2.AllowCustomMenu = true;
            this.GridView2.AllowExport = true;
            this.GridView2.AllowPrint = true;
            this.GridView2.AllowSettingsMenu = false;
            this.GridView2.AllowSummaryMenu = true;
            this.GridView2.ApplyFocusedRow = true;
            this.GridView2.Caption = "";
            this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col포트,
            this.col채널,
            this.col밝기1,
            this.col설명1,
            this.col켜짐});
            this.GridView2.FooterPanelHeight = 21;
            this.GridView2.GridControl = this.GridControl2;
            this.GridView2.GroupRowHeight = 21;
            this.GridView2.IndicatorWidth = 44;
            this.GridView2.MinColumnRowHeight = 24;
            this.GridView2.MinRowHeight = 18;
            this.GridView2.Name = "GridView2";
            this.GridView2.OptionsBehavior.Editable = false;
            this.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.GridView2.OptionsFilter.UseNewCustomFilterDialog = true;
            this.GridView2.OptionsNavigation.EnterMoveNextColumn = true;
            this.GridView2.OptionsPrint.AutoWidth = false;
            this.GridView2.OptionsPrint.UsePrintStyles = false;
            this.GridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.GridView2.OptionsView.ShowGroupPanel = false;
            this.GridView2.RowHeight = 20;
            // 
            // col포트
            // 
            this.col포트.AppearanceHeader.Options.UseTextOptions = true;
            this.col포트.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col포트.FieldName = "포트";
            this.col포트.Name = "col포트";
            this.col포트.Visible = true;
            this.col포트.VisibleIndex = 0;
            // 
            // col채널
            // 
            this.col채널.AppearanceHeader.Options.UseTextOptions = true;
            this.col채널.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col채널.FieldName = "채널";
            this.col채널.Name = "col채널";
            this.col채널.Visible = true;
            this.col채널.VisibleIndex = 1;
            // 
            // col밝기1
            // 
            this.col밝기1.AppearanceHeader.Options.UseTextOptions = true;
            this.col밝기1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col밝기1.FieldName = "밝기";
            this.col밝기1.Name = "col밝기1";
            this.col밝기1.Visible = true;
            this.col밝기1.VisibleIndex = 2;
            // 
            // col설명1
            // 
            this.col설명1.AppearanceHeader.Options.UseTextOptions = true;
            this.col설명1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col설명1.FieldName = "설명";
            this.col설명1.Name = "col설명1";
            this.col설명1.Visible = true;
            this.col설명1.VisibleIndex = 3;
            // 
            // col켜짐
            // 
            this.col켜짐.AppearanceHeader.Options.UseTextOptions = true;
            this.col켜짐.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col켜짐.ColumnEdit = this.repositoryItemToggleSwitch1;
            this.col켜짐.FieldName = "켜짐";
            this.col켜짐.Name = "col켜짐";
            this.col켜짐.Visible = true;
            this.col켜짐.VisibleIndex = 4;
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Off";
            this.repositoryItemToggleSwitch1.OnText = "On";
            // 
            // repositoryItemToggleSwitch2
            // 
            this.repositoryItemToggleSwitch2.AutoHeight = false;
            this.repositoryItemToggleSwitch2.Name = "repositoryItemToggleSwitch2";
            this.repositoryItemToggleSwitch2.OffText = "Off";
            this.repositoryItemToggleSwitch2.OnText = "On";
            // 
            // CamSettings
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "CamSettings";
            this.Size = new System.Drawing.Size(943, 852);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bind카메라설정)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bind조명설정)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindLocalization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton b저장;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private MvUtils.CustomGrid GridControl2;
        private MvUtils.CustomView GridView2;
        private System.Windows.Forms.BindingSource Bind카메라설정;
        private System.Windows.Forms.BindingSource Bind조명설정;
        private MvUtils.CustomGrid GridControl1;
        private MvUtils.CustomView GridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col구분;
        private DevExpress.XtraGrid.Columns.GridColumn col코드;
        private DevExpress.XtraGrid.Columns.GridColumn col설명;
        private DevExpress.XtraGrid.Columns.GridColumn col주소;
        private DevExpress.XtraGrid.Columns.GridColumn col지연시간;
        private DevExpress.XtraGrid.Columns.GridColumn col시간;
        private DevExpress.XtraGrid.Columns.GridColumn col노출;
        private DevExpress.XtraGrid.Columns.GridColumn col밝기;
        private DevExpress.XtraGrid.Columns.GridColumn col대비;
        private DevExpress.XtraGrid.Columns.GridColumn col상태;
        private DevExpress.XtraGrid.Columns.GridColumn col포트;
        private DevExpress.XtraGrid.Columns.GridColumn col채널;
        private DevExpress.XtraGrid.Columns.GridColumn col밝기1;
        private DevExpress.XtraGrid.Columns.GridColumn col설명1;
        private DevExpress.XtraGrid.Columns.GridColumn col켜짐;
        private System.Windows.Forms.BindingSource BindLocalization;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch2;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
    }
}
