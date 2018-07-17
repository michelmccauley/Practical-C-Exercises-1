namespace MultiForms
{
    partial class frmIntro
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
            this.btnWelcome = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWelcome
            // 
            this.btnWelcome.Location = new System.Drawing.Point(309, 195);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(196, 23);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.Text = "Click to Start";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Location = new System.Drawing.Point(362, 317);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(75, 23);
            this.btnExitGame.TabIndex = 1;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnWelcome);
            this.Name = "frmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Forms example Intro Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Button btnExitGame;
    }
}

