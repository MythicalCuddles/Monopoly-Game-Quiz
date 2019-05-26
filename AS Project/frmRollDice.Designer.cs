namespace AS_Project
{
    partial class frmRollDice
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
            this.pic_Die = new System.Windows.Forms.PictureBox();
            this.tmrRoll = new System.Windows.Forms.Timer(this.components);
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Die)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Die
            // 
            this.pic_Die.Image = global::AS_Project.Properties.Resources.dieValue1;
            this.pic_Die.Location = new System.Drawing.Point(12, 12);
            this.pic_Die.Name = "pic_Die";
            this.pic_Die.Size = new System.Drawing.Size(150, 150);
            this.pic_Die.TabIndex = 1;
            this.pic_Die.TabStop = false;
            // 
            // tmrRoll
            // 
            this.tmrRoll.Interval = 200;
            this.tmrRoll.Tick += new System.EventHandler(this.tmrRoll_Tick);
            // 
            // tmrClose
            // 
            this.tmrClose.Interval = 2000;
            this.tmrClose.Tick += new System.EventHandler(this.tmrClose_Tick);
            // 
            // frmRollDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(174, 174);
            this.Controls.Add(this.pic_Die);
            this.Name = "frmRollDice";
            this.Text = "frmRollDice";
            this.Load += new System.EventHandler(this.frmRollDice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Die)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Die;
        private System.Windows.Forms.Timer tmrRoll;
        private System.Windows.Forms.Timer tmrClose;

    }
}