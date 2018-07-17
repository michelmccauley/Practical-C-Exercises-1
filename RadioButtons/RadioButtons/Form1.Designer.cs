namespace RadioButtons
{
    partial class frmButtons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmButtons));
            this.grpMood = new System.Windows.Forms.GroupBox();
            this.rdoHappy = new System.Windows.Forms.RadioButton();
            this.rdoSad = new System.Windows.Forms.RadioButton();
            this.picHappy = new System.Windows.Forms.PictureBox();
            this.picSad = new System.Windows.Forms.PictureBox();
            this.grpMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMood
            // 
            this.grpMood.Controls.Add(this.picSad);
            this.grpMood.Controls.Add(this.picHappy);
            this.grpMood.Controls.Add(this.rdoSad);
            this.grpMood.Controls.Add(this.rdoHappy);
            this.grpMood.Location = new System.Drawing.Point(35, 38);
            this.grpMood.Name = "grpMood";
            this.grpMood.Size = new System.Drawing.Size(179, 120);
            this.grpMood.TabIndex = 0;
            this.grpMood.TabStop = false;
            this.grpMood.Text = "Moods";
            this.grpMood.Enter += new System.EventHandler(this.grpMood_Enter);
            // 
            // rdoHappy
            // 
            this.rdoHappy.AutoSize = true;
            this.rdoHappy.Location = new System.Drawing.Point(17, 32);
            this.rdoHappy.Name = "rdoHappy";
            this.rdoHappy.Size = new System.Drawing.Size(56, 17);
            this.rdoHappy.TabIndex = 0;
            this.rdoHappy.TabStop = true;
            this.rdoHappy.Text = "Happy";
            this.rdoHappy.UseVisualStyleBackColor = true;
            this.rdoHappy.CheckedChanged += new System.EventHandler(this.rdoHappy_CheckedChanged);
            // 
            // rdoSad
            // 
            this.rdoSad.AutoSize = true;
            this.rdoSad.Location = new System.Drawing.Point(17, 75);
            this.rdoSad.Name = "rdoSad";
            this.rdoSad.Size = new System.Drawing.Size(44, 17);
            this.rdoSad.TabIndex = 1;
            this.rdoSad.TabStop = true;
            this.rdoSad.Text = "Sad";
            this.rdoSad.UseVisualStyleBackColor = true;
            this.rdoSad.CheckedChanged += new System.EventHandler(this.rdoSad_CheckedChanged);
            // 
            // picHappy
            // 
            this.picHappy.Image = ((System.Drawing.Image)(resources.GetObject("picHappy.Image")));
            this.picHappy.Location = new System.Drawing.Point(114, 42);
            this.picHappy.Name = "picHappy";
            this.picHappy.Size = new System.Drawing.Size(51, 39);
            this.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHappy.TabIndex = 2;
            this.picHappy.TabStop = false;
            this.picHappy.Visible = false;
            this.picHappy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picSad
            // 
            this.picSad.Image = ((System.Drawing.Image)(resources.GetObject("picSad.Image")));
            this.picSad.Location = new System.Drawing.Point(114, 42);
            this.picSad.Name = "picSad";
            this.picSad.Size = new System.Drawing.Size(51, 40);
            this.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSad.TabIndex = 3;
            this.picSad.TabStop = false;
            this.picSad.Visible = false;
            this.picSad.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 221);
            this.Controls.Add(this.grpMood);
            this.Name = "frmButtons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMood.ResumeLayout(false);
            this.grpMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMood;
        private System.Windows.Forms.PictureBox picSad;
        private System.Windows.Forms.PictureBox picHappy;
        private System.Windows.Forms.RadioButton rdoSad;
        private System.Windows.Forms.RadioButton rdoHappy;
    }
}

