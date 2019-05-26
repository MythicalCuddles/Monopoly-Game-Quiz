namespace AS_Project
{
    partial class frmQuestion
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.pnlAnswerHolder = new System.Windows.Forms.Panel();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tmrViewAnswer = new System.Windows.Forms.Timer(this.components);
            this.pnlAnswerHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblQuestion.Location = new System.Drawing.Point(168, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(468, 97);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Vint Cerf is regarded as the father of the Internet but who is the person that ac" +
    "tually invented the World Wide Web?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnswer1.Location = new System.Drawing.Point(4, 3);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(461, 52);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "David Filo";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // pnlAnswerHolder
            // 
            this.pnlAnswerHolder.Controls.Add(this.btnAnswer4);
            this.pnlAnswerHolder.Controls.Add(this.btnAnswer3);
            this.pnlAnswerHolder.Controls.Add(this.btnAnswer2);
            this.pnlAnswerHolder.Controls.Add(this.btnAnswer1);
            this.pnlAnswerHolder.Location = new System.Drawing.Point(168, 109);
            this.pnlAnswerHolder.Name = "pnlAnswerHolder";
            this.pnlAnswerHolder.Size = new System.Drawing.Size(468, 235);
            this.pnlAnswerHolder.TabIndex = 8;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnswer4.Location = new System.Drawing.Point(4, 177);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(461, 52);
            this.btnAnswer4.TabIndex = 4;
            this.btnAnswer4.Text = "Grace Hopper";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnswer3.Location = new System.Drawing.Point(4, 119);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(461, 52);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "Marc Andreessen";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnswer2.Location = new System.Drawing.Point(4, 61);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(461, 52);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "Tim Berners-Lee";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(12, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(150, 150);
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 165);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 57);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrViewAnswer
            // 
            this.tmrViewAnswer.Interval = 2000;
            this.tmrViewAnswer.Tick += new System.EventHandler(this.tmrViewAnswer_Tick);
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 353);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pnlAnswerHolder);
            this.Name = "frmQuestion";
            this.Load += new System.EventHandler(this.frmQuestion_Load);
            this.pnlAnswerHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Panel pnlAnswerHolder;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Timer tmrViewAnswer;
    }
}