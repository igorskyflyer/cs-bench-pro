namespace BenchPro {
    partial class Author {
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
            this.ImageAuthor = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelNick = new System.Windows.Forms.Label();
            this.Web = new System.Diagnostics.Process();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.WndClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WndClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageAuthor
            // 
            this.ImageAuthor.Image = global::BenchPro.Properties.Resources.Igor;
            this.ImageAuthor.Location = new System.Drawing.Point(133, 30);
            this.ImageAuthor.Name = "ImageAuthor";
            this.ImageAuthor.Size = new System.Drawing.Size(117, 117);
            this.ImageAuthor.TabIndex = 0;
            this.ImageAuthor.TabStop = false;
            this.ImageAuthor.Click += new System.EventHandler(this.ImageAuthor_Click);
            this.ImageAuthor.MouseEnter += new System.EventHandler(this.MouseOver);
            this.ImageAuthor.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(136, 150);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(116, 19);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Igor Dimitrijević ";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNick
            // 
            this.LabelNick.AutoSize = true;
            this.LabelNick.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNick.Location = new System.Drawing.Point(159, 169);
            this.LabelNick.Name = "LabelNick";
            this.LabelNick.Size = new System.Drawing.Size(66, 19);
            this.LabelNick.TabIndex = 2;
            this.LabelNick.Text = "SkyFlyer";
            this.LabelNick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Web
            // 
            this.Web.StartInfo.Domain = "";
            this.Web.StartInfo.LoadUserProfile = false;
            this.Web.StartInfo.Password = null;
            this.Web.StartInfo.StandardErrorEncoding = null;
            this.Web.StartInfo.StandardOutputEncoding = null;
            this.Web.StartInfo.UserName = "";
            this.Web.SynchronizingObject = this;
            // 
            // Link
            // 
            this.Link.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.Link.AutoSize = true;
            this.Link.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Link.LinkColor = System.Drawing.Color.DodgerBlue;
            this.Link.Location = new System.Drawing.Point(308, 193);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(64, 13);
            this.Link.TabIndex = 3;
            this.Link.TabStop = true;
            this.Link.Text = "neovisio.org";
            this.Link.VisitedLinkColor = System.Drawing.Color.Red;
            this.Link.Click += new System.EventHandler(this.Link_Click);
            // 
            // WndClose
            // 
            this.WndClose.Image = global::BenchPro.Properties.Resources.CloseDialog;
            this.WndClose.Location = new System.Drawing.Point(351, 8);
            this.WndClose.Name = "WndClose";
            this.WndClose.Size = new System.Drawing.Size(24, 24);
            this.WndClose.TabIndex = 4;
            this.WndClose.TabStop = false;
            this.WndClose.Click += new System.EventHandler(this.WndClose_Click);
            this.WndClose.MouseEnter += new System.EventHandler(this.WndClose_MouseEnter);
            this.WndClose.MouseLeave += new System.EventHandler(this.WndClose_MouseLeave);
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 215);
            this.Controls.Add(this.WndClose);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.LabelNick);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ImageAuthor);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BenchoPro - Autor";
            this.TopMost = true;
            this.LocationChanged += new System.EventHandler(this.Author_LocationChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Author_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Author_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ImageAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WndClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageAuthor;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelNick;
        private System.Diagnostics.Process Web;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.PictureBox WndClose;
    }
}