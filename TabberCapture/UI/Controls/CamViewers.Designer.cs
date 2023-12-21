namespace TabberCapture.UI.Controls
{
    partial class CamViewers
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.cam5View = new System.Windows.Forms.PictureBox();
            this.cam4View = new System.Windows.Forms.PictureBox();
            this.cam3View = new System.Windows.Forms.PictureBox();
            this.cam2View = new System.Windows.Forms.PictureBox();
            this.cam1View = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cam5View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1View)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.cam5View);
            this.tablePanel1.Controls.Add(this.cam4View);
            this.tablePanel1.Controls.Add(this.cam3View);
            this.tablePanel1.Controls.Add(this.cam2View);
            this.tablePanel1.Controls.Add(this.cam1View);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1884, 1035);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // cam5View
            // 
            this.cam5View.BackColor = System.Drawing.Color.Black;
            this.tablePanel1.SetColumn(this.cam5View, 1);
            this.cam5View.Location = new System.Drawing.Point(634, 519);
            this.cam5View.Name = "cam5View";
            this.tablePanel1.SetRow(this.cam5View, 1);
            this.cam5View.Size = new System.Drawing.Size(617, 503);
            this.cam5View.TabIndex = 4;
            this.cam5View.TabStop = false;
            // 
            // cam4View
            // 
            this.cam4View.BackColor = System.Drawing.Color.Black;
            this.tablePanel1.SetColumn(this.cam4View, 0);
            this.cam4View.Location = new System.Drawing.Point(13, 519);
            this.cam4View.Name = "cam4View";
            this.tablePanel1.SetRow(this.cam4View, 1);
            this.cam4View.Size = new System.Drawing.Size(617, 503);
            this.cam4View.TabIndex = 3;
            this.cam4View.TabStop = false;
            // 
            // cam3View
            // 
            this.cam3View.BackColor = System.Drawing.Color.Black;
            this.tablePanel1.SetColumn(this.cam3View, 2);
            this.cam3View.Location = new System.Drawing.Point(1254, 12);
            this.cam3View.Name = "cam3View";
            this.tablePanel1.SetRow(this.cam3View, 0);
            this.cam3View.Size = new System.Drawing.Size(617, 503);
            this.cam3View.TabIndex = 2;
            this.cam3View.TabStop = false;
            // 
            // cam2View
            // 
            this.cam2View.BackColor = System.Drawing.Color.Black;
            this.tablePanel1.SetColumn(this.cam2View, 1);
            this.cam2View.Location = new System.Drawing.Point(634, 12);
            this.cam2View.Name = "cam2View";
            this.tablePanel1.SetRow(this.cam2View, 0);
            this.cam2View.Size = new System.Drawing.Size(617, 503);
            this.cam2View.TabIndex = 1;
            this.cam2View.TabStop = false;
            // 
            // cam1View
            // 
            this.cam1View.BackColor = System.Drawing.Color.Black;
            this.tablePanel1.SetColumn(this.cam1View, 0);
            this.cam1View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam1View.Location = new System.Drawing.Point(13, 12);
            this.cam1View.Name = "cam1View";
            this.tablePanel1.SetRow(this.cam1View, 0);
            this.cam1View.Size = new System.Drawing.Size(617, 503);
            this.cam1View.TabIndex = 0;
            this.cam1View.TabStop = false;
            // 
            // CamViewers
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "CamViewers";
            this.Size = new System.Drawing.Size(1884, 1035);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cam5View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.PictureBox cam5View;
        private System.Windows.Forms.PictureBox cam4View;
        private System.Windows.Forms.PictureBox cam3View;
        private System.Windows.Forms.PictureBox cam2View;
        private System.Windows.Forms.PictureBox cam1View;
    }
}
