namespace AS_Project
{
    partial class frmMenu
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
            this.picMaleAvatarP1 = new System.Windows.Forms.PictureBox();
            this.picFemaleAvatarP1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dropPlayer1Colour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dropPlayer2Colour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.picMaleAvatarP2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picFemaleAvatarP2 = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMaleAvatarP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemaleAvatarP1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaleAvatarP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemaleAvatarP2)).BeginInit();
            this.SuspendLayout();
            // 
            // picMaleAvatarP1
            // 
            this.picMaleAvatarP1.Image = global::AS_Project.Properties.Resources.avatar_boy;
            this.picMaleAvatarP1.Location = new System.Drawing.Point(155, 77);
            this.picMaleAvatarP1.Margin = new System.Windows.Forms.Padding(2);
            this.picMaleAvatarP1.Name = "picMaleAvatarP1";
            this.picMaleAvatarP1.Size = new System.Drawing.Size(150, 150);
            this.picMaleAvatarP1.TabIndex = 4;
            this.picMaleAvatarP1.TabStop = false;
            this.picMaleAvatarP1.Click += new System.EventHandler(this.picMaleAvatarP1_Click);
            // 
            // picFemaleAvatarP1
            // 
            this.picFemaleAvatarP1.Image = global::AS_Project.Properties.Resources.avatarGirl;
            this.picFemaleAvatarP1.Location = new System.Drawing.Point(2, 77);
            this.picFemaleAvatarP1.Margin = new System.Windows.Forms.Padding(2);
            this.picFemaleAvatarP1.Name = "picFemaleAvatarP1";
            this.picFemaleAvatarP1.Size = new System.Drawing.Size(150, 150);
            this.picFemaleAvatarP1.TabIndex = 3;
            this.picFemaleAvatarP1.TabStop = false;
            this.picFemaleAvatarP1.Click += new System.EventHandler(this.picFemaleAvatarP1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dropPlayer1Colour);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPlayer1Name);
            this.panel1.Controls.Add(this.picMaleAvatarP1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picFemaleAvatarP1);
            this.panel1.Location = new System.Drawing.Point(18, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 277);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Player Colour";
            // 
            // dropPlayer1Colour
            // 
            this.dropPlayer1Colour.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropPlayer1Colour.FormattingEnabled = true;
            this.dropPlayer1Colour.Items.AddRange(new object[] {
            "Blue",
            "Pink",
            "Yellow",
            "Green",
            "Brown"});
            this.dropPlayer1Colour.Location = new System.Drawing.Point(113, 245);
            this.dropPlayer1Colour.Name = "dropPlayer1Colour";
            this.dropPlayer1Colour.Size = new System.Drawing.Size(191, 21);
            this.dropPlayer1Colour.TabIndex = 12;
            this.dropPlayer1Colour.SelectedIndexChanged += new System.EventHandler(this.dropPlayer1Colour_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.Location = new System.Drawing.Point(90, 38);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer1Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player 1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dropPlayer2Colour);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPlayer2Name);
            this.panel2.Controls.Add(this.picMaleAvatarP2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.picFemaleAvatarP2);
            this.panel2.Location = new System.Drawing.Point(345, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 277);
            this.panel2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Player Colour";
            // 
            // dropPlayer2Colour
            // 
            this.dropPlayer2Colour.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dropPlayer2Colour.FormattingEnabled = true;
            this.dropPlayer2Colour.Items.AddRange(new object[] {
            "Blue",
            "Pink",
            "Yellow",
            "Green",
            "Brown"});
            this.dropPlayer2Colour.Location = new System.Drawing.Point(113, 245);
            this.dropPlayer2Colour.Name = "dropPlayer2Colour";
            this.dropPlayer2Colour.Size = new System.Drawing.Size(191, 21);
            this.dropPlayer2Colour.TabIndex = 10;
            this.dropPlayer2Colour.SelectedIndexChanged += new System.EventHandler(this.dropPlayer2Colour_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtPlayer2Name.Location = new System.Drawing.Point(90, 36);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer2Name.TabIndex = 5;
            // 
            // picMaleAvatarP2
            // 
            this.picMaleAvatarP2.Image = global::AS_Project.Properties.Resources.avatar_boy;
            this.picMaleAvatarP2.Location = new System.Drawing.Point(155, 77);
            this.picMaleAvatarP2.Margin = new System.Windows.Forms.Padding(2);
            this.picMaleAvatarP2.Name = "picMaleAvatarP2";
            this.picMaleAvatarP2.Size = new System.Drawing.Size(150, 150);
            this.picMaleAvatarP2.TabIndex = 4;
            this.picMaleAvatarP2.TabStop = false;
            this.picMaleAvatarP2.Click += new System.EventHandler(this.picMaleAvatarP2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player 2";
            // 
            // picFemaleAvatarP2
            // 
            this.picFemaleAvatarP2.Image = global::AS_Project.Properties.Resources.avatarGirl;
            this.picFemaleAvatarP2.Location = new System.Drawing.Point(2, 77);
            this.picFemaleAvatarP2.Margin = new System.Windows.Forms.Padding(2);
            this.picFemaleAvatarP2.Name = "picFemaleAvatarP2";
            this.picFemaleAvatarP2.Size = new System.Drawing.Size(150, 150);
            this.picFemaleAvatarP2.TabIndex = 3;
            this.picFemaleAvatarP2.TabStop = false;
            this.picFemaleAvatarP2.Click += new System.EventHandler(this.picFemaleAvatarP2_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(240, 361);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(190, 55);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "Let Play Monopoly!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AS_Project.Properties.Resources.menuBackground;
            this.ClientSize = new System.Drawing.Size(676, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monopoly | Lets Get Started!";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMaleAvatarP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemaleAvatarP1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaleAvatarP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemaleAvatarP2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMaleAvatarP1;
        private System.Windows.Forms.PictureBox picFemaleAvatarP1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picMaleAvatarP2;
        private System.Windows.Forms.PictureBox picFemaleAvatarP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dropPlayer1Colour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dropPlayer2Colour;
    }
}