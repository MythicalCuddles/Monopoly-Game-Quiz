namespace AS_Project
{
    partial class frmMinigame
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
            this.lblMoneyCount = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoneyCount
            // 
            this.lblMoneyCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyCount.Location = new System.Drawing.Point(12, 218);
            this.lblMoneyCount.Name = "lblMoneyCount";
            this.lblMoneyCount.Size = new System.Drawing.Size(150, 37);
            this.lblMoneyCount.TabIndex = 22;
            this.lblMoneyCount.Text = "Money Count";
            this.lblMoneyCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 165);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 53);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Location = new System.Drawing.Point(12, 12);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(150, 150);
            this.picUserAvatar.TabIndex = 20;
            this.picUserAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(335, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 23;
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(12, 442);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(150, 57);
            this.btnEndGame.TabIndex = 24;
            this.btnEndGame.Text = "End Game Early";
            this.btnEndGame.UseVisualStyleBackColor = true;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(12, 393);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(150, 37);
            this.lblTimeLeft.TabIndex = 25;
            this.lblTimeLeft.Text = "Time Left";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // frmMinigame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 511);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMoneyCount);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picUserAvatar);
            this.Name = "frmMinigame";
            this.Text = "frmMinigame";
            this.Load += new System.EventHandler(this.frmMinigame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMoneyCount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer tmrGameTimer;
    }
}