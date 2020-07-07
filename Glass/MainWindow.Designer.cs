namespace Glass
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ubtSplitContainer1 = new UBTStandardLibrary.UBTSplitContainer();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.peMain = new DevExpress.XtraEditors.PictureEdit();
            this.pnlAllPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ubtSplitContainer1)).BeginInit();
            this.ubtSplitContainer1.Panel1.SuspendLayout();
            this.ubtSplitContainer1.Panel2.SuspendLayout();
            this.ubtSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peMain.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ubtSplitContainer1
            // 
            this.ubtSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubtSplitContainer1.IsSplitterFixed = true;
            this.ubtSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.ubtSplitContainer1.Name = "ubtSplitContainer1";
            // 
            // ubtSplitContainer1.Panel1
            // 
            this.ubtSplitContainer1.Panel1.Controls.Add(this.p2);
            this.ubtSplitContainer1.Panel1.Controls.Add(this.p1);
            this.ubtSplitContainer1.Panel1.Controls.Add(this.peMain);
            this.ubtSplitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // ubtSplitContainer1.Panel2
            // 
            this.ubtSplitContainer1.Panel2.Controls.Add(this.pnlAllPictures);
            this.ubtSplitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.ubtSplitContainer1.Size = new System.Drawing.Size(841, 557);
            this.ubtSplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ubtSplitContainer1.SplitterDistance = 544;
            this.ubtSplitContainer1.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(376, 224);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(156, 168);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p2.TabIndex = 4;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(8, 224);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(361, 168);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p1.TabIndex = 4;
            this.p1.TabStop = false;
            // 
            // peMain
            // 
            this.peMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peMain.EditValue = ((object)(resources.GetObject("peMain.EditValue")));
            this.peMain.Location = new System.Drawing.Point(5, 5);
            this.peMain.Name = "peMain";
            this.peMain.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.peMain.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peMain.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peMain.Size = new System.Drawing.Size(534, 547);
            this.peMain.TabIndex = 0;
            // 
            // pnlAllPictures
            // 
            this.pnlAllPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAllPictures.AutoScroll = true;
            this.pnlAllPictures.Location = new System.Drawing.Point(5, 5);
            this.pnlAllPictures.Name = "pnlAllPictures";
            this.pnlAllPictures.Size = new System.Drawing.Size(283, 547);
            this.pnlAllPictures.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioGroup1);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ubtSplitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 557);
            this.panel2.TabIndex = 2;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioGroup1.Location = new System.Drawing.Point(618, 0);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Right"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Both"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Left")});
            this.radioGroup1.Size = new System.Drawing.Size(221, 35);
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(851, 626);
            this.MinimumSize = new System.Drawing.Size(851, 626);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glass Demo";
            this.ubtSplitContainer1.Panel1.ResumeLayout(false);
            this.ubtSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ubtSplitContainer1)).EndInit();
            this.ubtSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peMain.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UBTStandardLibrary.UBTSplitContainer ubtSplitContainer1;
        private System.Windows.Forms.FlowLayoutPanel pnlAllPictures;
        private DevExpress.XtraEditors.PictureEdit peMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}