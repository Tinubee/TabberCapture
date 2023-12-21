namespace TabberCapture.UI.Controls
{
    partial class IOControl
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
            this.customGrid1 = new MvUtils.CustomGrid();
            this.customView1 = new MvUtils.CustomView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bind입력신호 = new System.Windows.Forms.BindingSource(this.components);
            this.col구분 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col번호 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col명칭 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col여부 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind입력신호)).BeginInit();
            this.SuspendLayout();
            // 
            // customGrid1
            // 
            this.customGrid1.DataSource = this.bind입력신호;
            this.customGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGrid1.Location = new System.Drawing.Point(2, 23);
            this.customGrid1.MainView = this.customView1;
            this.customGrid1.Name = "customGrid1";
            this.customGrid1.Size = new System.Drawing.Size(568, 632);
            this.customGrid1.TabIndex = 0;
            this.customGrid1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customView1});
            // 
            // customView1
            // 
            this.customView1.AllowColumnMenu = true;
            this.customView1.AllowCustomMenu = true;
            this.customView1.AllowExport = true;
            this.customView1.AllowPrint = true;
            this.customView1.AllowSettingsMenu = false;
            this.customView1.AllowSummaryMenu = true;
            this.customView1.ApplyFocusedRow = true;
            this.customView1.Caption = "";
            this.customView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col구분,
            this.col번호,
            this.col명칭,
            this.col여부});
            this.customView1.FooterPanelHeight = 21;
            this.customView1.GridControl = this.customGrid1;
            this.customView1.GroupRowHeight = 21;
            this.customView1.IndicatorWidth = 44;
            this.customView1.MinColumnRowHeight = 24;
            this.customView1.MinRowHeight = 18;
            this.customView1.Name = "customView1";
            this.customView1.OptionsBehavior.Editable = false;
            this.customView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.customView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.customView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.customView1.OptionsPrint.AutoWidth = false;
            this.customView1.OptionsPrint.UsePrintStyles = false;
            this.customView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.customView1.OptionsView.ShowGroupPanel = false;
            this.customView1.RowHeight = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.customGrid1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(572, 657);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Input";
            // 
            // bind입력신호
            // 
            this.bind입력신호.DataSource = typeof(TabberCapture.UI.Controls.IOControl.입력신호자료);
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
            // col번호
            // 
            this.col번호.AppearanceHeader.Options.UseTextOptions = true;
            this.col번호.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col번호.FieldName = "번호";
            this.col번호.Name = "col번호";
            this.col번호.OptionsColumn.ReadOnly = true;
            this.col번호.Visible = true;
            this.col번호.VisibleIndex = 1;
            // 
            // col명칭
            // 
            this.col명칭.AppearanceHeader.Options.UseTextOptions = true;
            this.col명칭.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col명칭.FieldName = "명칭";
            this.col명칭.Name = "col명칭";
            this.col명칭.OptionsColumn.ReadOnly = true;
            this.col명칭.Visible = true;
            this.col명칭.VisibleIndex = 2;
            // 
            // col여부
            // 
            this.col여부.AppearanceHeader.Options.UseTextOptions = true;
            this.col여부.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col여부.FieldName = "여부";
            this.col여부.Name = "col여부";
            this.col여부.OptionsColumn.ReadOnly = true;
            this.col여부.Visible = true;
            this.col여부.VisibleIndex = 3;
            // 
            // IOControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "IOControl";
            this.Size = new System.Drawing.Size(572, 657);
            ((System.ComponentModel.ISupportInitialize)(this.customGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bind입력신호)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MvUtils.CustomGrid customGrid1;
        private MvUtils.CustomView customView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource bind입력신호;
        private DevExpress.XtraGrid.Columns.GridColumn col구분;
        private DevExpress.XtraGrid.Columns.GridColumn col번호;
        private DevExpress.XtraGrid.Columns.GridColumn col명칭;
        private DevExpress.XtraGrid.Columns.GridColumn col여부;
    }
}
