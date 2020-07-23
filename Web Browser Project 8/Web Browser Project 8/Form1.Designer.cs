namespace Web_Browser_Project_8
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnBack = new System.Windows.Forms.ToolStripButton();
            this.BtnFwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cboLocation = new System.Windows.Forms.ToolStripComboBox();
            this.BtnGo = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBack,
            this.BtnFwd,
            this.toolStripSeparator1,
            this.cboLocation,
            this.BtnGo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // BtnBack
            // 
            this.BtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(36, 22);
            this.BtnBack.Text = "Back";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnFwd
            // 
            this.BtnFwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnFwd.Image = ((System.Drawing.Image)(resources.GetObject("BtnFwd.Image")));
            this.BtnFwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFwd.Name = "BtnFwd";
            this.BtnFwd.Size = new System.Drawing.Size(50, 22);
            this.BtnFwd.Text = "Foward";
            this.BtnFwd.Click += new System.EventHandler(this.BtnFwd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cboLocation
            // 
            this.cboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 25);
            this.cboLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLocation_KeyDown);
            // 
            // BtnGo
            // 
            this.BtnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnGo.Image = ((System.Drawing.Image)(resources.GetObject("BtnGo.Image")));
            this.BtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(26, 22);
            this.BtnGo.Text = "Go";
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "bluelime";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnBack;
        private System.Windows.Forms.ToolStripButton BtnFwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cboLocation;
        private System.Windows.Forms.ToolStripButton BtnGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

