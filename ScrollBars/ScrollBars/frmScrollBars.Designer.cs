namespace ScrollBars
{
    partial class frmScrollBars
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
            this.hscBar = new System.Windows.Forms.HScrollBar();
            this.lblScroll = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // hscBar
            // 
            this.hscBar.Location = new System.Drawing.Point(193, 26);
            this.hscBar.Name = "hscBar";
            this.hscBar.Size = new System.Drawing.Size(441, 52);
            this.hscBar.TabIndex = 0;
            this.hscBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscBar_Scroll);
            // 
            // lblScroll
            // 
            this.lblScroll.AutoSize = true;
            this.lblScroll.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScroll.ForeColor = System.Drawing.Color.Black;
            this.lblScroll.Location = new System.Drawing.Point(325, 105);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(177, 110);
            this.lblScroll.TabIndex = 1;
            this.lblScroll.Text = "-----";
            this.lblScroll.Click += new System.EventHandler(this.lblScroll_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(344, 264);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 118);
            this.numericUpDown1.TabIndex = 2;
            // 
            // frmScrollBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblScroll);
            this.Controls.Add(this.hscBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.LightGray;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmScrollBars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scroll Bars Demo";
            this.Load += new System.EventHandler(this.frmScrollBars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hscBar;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

