namespace BenchPro {
    partial class Dialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
            this.ImageOk = new System.Windows.Forms.PictureBox();
            this.ImageCancel = new System.Windows.Forms.PictureBox();
            this.LabelIterations = new System.Windows.Forms.Label();
            this.TextIterations = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageOk
            // 
            this.ImageOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImageOk.Enabled = false;
            this.ImageOk.Image = global::BenchPro.Properties.Resources.ApplyDisabled;
            this.ImageOk.Location = new System.Drawing.Point(25, 71);
            this.ImageOk.Name = "ImageOk";
            this.ImageOk.Size = new System.Drawing.Size(48, 48);
            this.ImageOk.TabIndex = 0;
            this.ImageOk.TabStop = false;
            this.ImageOk.Click += new System.EventHandler(this.ImageOk_Click);
            this.ImageOk.MouseEnter += new System.EventHandler(this.MouseOver);
            this.ImageOk.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // ImageCancel
            // 
            this.ImageCancel.Image = ((System.Drawing.Image)(resources.GetObject("ImageCancel.Image")));
            this.ImageCancel.Location = new System.Drawing.Point(335, 71);
            this.ImageCancel.Name = "ImageCancel";
            this.ImageCancel.Size = new System.Drawing.Size(48, 48);
            this.ImageCancel.TabIndex = 1;
            this.ImageCancel.TabStop = false;
            this.ImageCancel.Click += new System.EventHandler(this.ImageCancel_Click);
            this.ImageCancel.MouseEnter += new System.EventHandler(this.MouseOver);
            this.ImageCancel.MouseLeave += new System.EventHandler(this.MouseOut);
            // 
            // LabelIterations
            // 
            this.LabelIterations.AutoSize = true;
            this.LabelIterations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIterations.ForeColor = System.Drawing.Color.White;
            this.LabelIterations.Location = new System.Drawing.Point(22, 24);
            this.LabelIterations.Name = "LabelIterations";
            this.LabelIterations.Size = new System.Drawing.Size(142, 15);
            this.LabelIterations.TabIndex = 2;
            this.LabelIterations.Text = "Broj iteracija (min. 100):";
            // 
            // TextIterations
            // 
            this.TextIterations.AcceptsReturn = true;
            this.TextIterations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIterations.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TextIterations.Location = new System.Drawing.Point(25, 42);
            this.TextIterations.MaxLength = 6;
            this.TextIterations.Name = "TextIterations";
            this.TextIterations.Size = new System.Drawing.Size(358, 23);
            this.TextIterations.TabIndex = 3;
            this.TextIterations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextIterations_KeyDown);
            this.TextIterations.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextIterations_KeyUp);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(409, 136);
            this.Controls.Add(this.TextIterations);
            this.Controls.Add(this.LabelIterations);
            this.Controls.Add(this.ImageCancel);
            this.Controls.Add(this.ImageOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proizvoljan broj iteracija";
            this.Shown += new System.EventHandler(this.Dialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ImageOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageOk;
        private System.Windows.Forms.PictureBox ImageCancel;
        private System.Windows.Forms.Label LabelIterations;
        private System.Windows.Forms.TextBox TextIterations;
    }
}