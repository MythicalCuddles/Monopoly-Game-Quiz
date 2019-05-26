namespace AS_Project
{
    partial class frmSplash
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
            this.tmrCountdownToLogin = new System.Windows.Forms.Timer(this.components);
            this.tmrChangeMessage = new System.Windows.Forms.Timer(this.components);
            this.lblLoadingMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrCountdownToLogin
            // 
            this.tmrCountdownToLogin.Interval = 7000;
            this.tmrCountdownToLogin.Tick += new System.EventHandler(this.tmrCountdownToLogin_Tick);
            // 
            // tmrChangeMessage
            // 
            this.tmrChangeMessage.Interval = 3000;
            this.tmrChangeMessage.Tick += new System.EventHandler(this.tmrChangeMessage_Tick);
            // 
            // lblLoadingMessage
            // 
            this.lblLoadingMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingMessage.Location = new System.Drawing.Point(12, 171);
            this.lblLoadingMessage.Name = "lblLoadingMessage";
            this.lblLoadingMessage.Size = new System.Drawing.Size(401, 72);
            this.lblLoadingMessage.TabIndex = 1;
            this.lblLoadingMessage.Text = "Getting things ready for you.";
            this.lblLoadingMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::AS_Project.Properties.Resources.Monopoly_pack_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLoadingMessage);
            this.Name = "frmSplash";
            this.Text = "Monopoly | Loading...";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCountdownToLogin;
        private System.Windows.Forms.Timer tmrChangeMessage;
        private System.Windows.Forms.Label lblLoadingMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}