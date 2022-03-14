
namespace Mondongo_Browser
{
    partial class DCUnavegador
    {
   
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.imgSpinner = new System.Windows.Forms.PictureBox();
            this.imgRefresh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).BeginInit();
            this.SuspendLayout();
           
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 41);
            this.panel1.TabIndex = 0;
          
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.SystemColors.Control;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(1280, 10);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(30, 22);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDownload.TabIndex = 1;
            this.btnDownload.TabStop = false;
           
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(63, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 24);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 6;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
           
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(1331, 5);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(31, 29);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfig.TabIndex = 5;
            this.btnConfig.TabStop = false;
            
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(200, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1600, 26);
            this.panel4.TabIndex = 4;
          
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1590, 18);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Enter URL";
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
           
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(155, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 24);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
          
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(109, 10);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(25, 21);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnForward.TabIndex = 2;
            this.btnForward.TabStop = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
           
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(19, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 21);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
           
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1386, 682);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
           
            this.imgSpinner.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgSpinner.Image = ((System.Drawing.Image)(resources.GetObject("imgSpinner.Image")));
            this.imgSpinner.Location = new System.Drawing.Point(126, 625);
            this.imgSpinner.Name = "imgSpinner";
            this.imgSpinner.Size = new System.Drawing.Size(39, 36);
            this.imgSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSpinner.TabIndex = 4;
            this.imgSpinner.TabStop = false;
            this.imgSpinner.Visible = false;
           
            this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));
            this.imgRefresh.Location = new System.Drawing.Point(90, 637);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Size = new System.Drawing.Size(30, 24);
            this.imgRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRefresh.TabIndex = 5;
            this.imgRefresh.TabStop = false;
            this.imgRefresh.Visible = false;
          
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 723);
            this.Controls.Add(this.imgRefresh);
            this.Controls.Add(this.imgSpinner);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DCUnavegador";
            this.Text = "DCUnavegador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnConfig;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnDownload;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox imgSpinner;
        private System.Windows.Forms.PictureBox imgRefresh;
    }
}