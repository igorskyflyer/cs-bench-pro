namespace BenchPro {
    partial class Loading {
        /// <summary>
        /// Required designer variable.
        /// </summary>
    private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
        if(disposing && (components != null)) {
        components.Dispose();
        }
        base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.LabelLoading = new System.Windows.Forms.Label();
            this.FetchHW = new System.ComponentModel.BackgroundWorker();
            this.LoadingProgress = new System.Windows.Forms.ProgressBar();
            this.ImageIcon = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLoading
            // 
            this.LabelLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLoading.AutoSize = true;
            this.LabelLoading.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoading.Font = new System.Drawing.Font("Calibri", 12F);
            this.LabelLoading.ForeColor = System.Drawing.Color.White;
            this.LabelLoading.Location = new System.Drawing.Point(12, 222);
            this.LabelLoading.Name = "LabelLoading";
            this.LabelLoading.Size = new System.Drawing.Size(90, 19);
            this.LabelLoading.TabIndex = 1;
            this.LabelLoading.Text = "Učitavanje...";
            this.LabelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FetchHW
            // 
            this.FetchHW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FetchHW_DoWork);
            this.FetchHW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FetchHW_RunWorkerCompleted);
            // 
            // LoadingProgress
            // 
            this.LoadingProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingProgress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoadingProgress.Location = new System.Drawing.Point(108, 225);
            this.LoadingProgress.Name = "LoadingProgress";
            this.LoadingProgress.Size = new System.Drawing.Size(356, 16);
            this.LoadingProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LoadingProgress.TabIndex = 2;
            // 
            // ImageIcon
            // 
            this.ImageIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageIcon.BackColor = System.Drawing.Color.Transparent;
            this.ImageIcon.Image = ((System.Drawing.Image)(resources.GetObject("ImageIcon.Image")));
            this.ImageIcon.Location = new System.Drawing.Point(174, 12);
            this.ImageIcon.Name = "ImageIcon";
            this.ImageIcon.Size = new System.Drawing.Size(128, 128);
            this.ImageIcon.TabIndex = 3;
            this.ImageIcon.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Black;
            this.LabelTitle.Location = new System.Drawing.Point(184, 169);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(109, 29);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "BenchPro";
            this.LabelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelTitle_Paint);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BenchPro.Properties.Resources.Design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 253);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ImageIcon);
            this.Controls.Add(this.LoadingProgress);
            this.Controls.Add(this.LabelLoading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dim";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Loading_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Loading_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ImageIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelLoading;
        private System.ComponentModel.BackgroundWorker FetchHW;
        private System.Windows.Forms.ProgressBar LoadingProgress;
        private System.Windows.Forms.PictureBox ImageIcon;
        private System.Windows.Forms.Label LabelTitle;
    }
}