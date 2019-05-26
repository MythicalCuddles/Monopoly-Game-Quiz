namespace AS_Project
{
    partial class frmProperty
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.btnBuyProperty = new System.Windows.Forms.Button();
            this.btnPayRent = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.pnlPropertyHolder = new System.Windows.Forms.Panel();
            this.lblPropertyInfo = new System.Windows.Forms.Label();
            this.lblPropertyName = new System.Windows.Forms.Label();
            this.lblPropertyOwner = new System.Windows.Forms.Label();
            this.lblMoneyStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.pnlPropertyHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 165);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 53);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Location = new System.Drawing.Point(12, 12);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(150, 150);
            this.picUserAvatar.TabIndex = 10;
            this.picUserAvatar.TabStop = false;
            // 
            // btnBuyProperty
            // 
            this.btnBuyProperty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyProperty.Location = new System.Drawing.Point(168, 218);
            this.btnBuyProperty.Name = "btnBuyProperty";
            this.btnBuyProperty.Size = new System.Drawing.Size(261, 37);
            this.btnBuyProperty.TabIndex = 12;
            this.btnBuyProperty.Text = "Buy Property";
            this.btnBuyProperty.UseVisualStyleBackColor = true;
            this.btnBuyProperty.Click += new System.EventHandler(this.btnBuyProperty_Click);
            // 
            // btnPayRent
            // 
            this.btnPayRent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPayRent.Location = new System.Drawing.Point(168, 261);
            this.btnPayRent.Name = "btnPayRent";
            this.btnPayRent.Size = new System.Drawing.Size(261, 37);
            this.btnPayRent.TabIndex = 13;
            this.btnPayRent.Text = "Pay Rent";
            this.btnPayRent.UseVisualStyleBackColor = true;
            this.btnPayRent.Click += new System.EventHandler(this.btnPayRent_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEndTurn.Location = new System.Drawing.Point(168, 304);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(261, 37);
            this.btnEndTurn.TabIndex = 14;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // pnlPropertyHolder
            // 
            this.pnlPropertyHolder.BackColor = System.Drawing.Color.White;
            this.pnlPropertyHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPropertyHolder.Controls.Add(this.lblPropertyInfo);
            this.pnlPropertyHolder.Controls.Add(this.lblPropertyName);
            this.pnlPropertyHolder.Controls.Add(this.lblPropertyOwner);
            this.pnlPropertyHolder.Location = new System.Drawing.Point(435, 12);
            this.pnlPropertyHolder.Name = "pnlPropertyHolder";
            this.pnlPropertyHolder.Size = new System.Drawing.Size(200, 329);
            this.pnlPropertyHolder.TabIndex = 16;
            // 
            // lblPropertyInfo
            // 
            this.lblPropertyInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyInfo.Location = new System.Drawing.Point(3, 72);
            this.lblPropertyInfo.Name = "lblPropertyInfo";
            this.lblPropertyInfo.Size = new System.Drawing.Size(192, 133);
            this.lblPropertyInfo.TabIndex = 20;
            this.lblPropertyInfo.Text = "Property Information";
            this.lblPropertyInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyName.Location = new System.Drawing.Point(2, 2);
            this.lblPropertyName.Name = "lblPropertyName";
            this.lblPropertyName.Size = new System.Drawing.Size(194, 70);
            this.lblPropertyName.TabIndex = 16;
            this.lblPropertyName.Text = "Property Name";
            this.lblPropertyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPropertyOwner
            // 
            this.lblPropertyOwner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyOwner.Location = new System.Drawing.Point(3, 205);
            this.lblPropertyOwner.Name = "lblPropertyOwner";
            this.lblPropertyOwner.Size = new System.Drawing.Size(192, 118);
            this.lblPropertyOwner.TabIndex = 17;
            this.lblPropertyOwner.Text = "Property Owner";
            this.lblPropertyOwner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMoneyStats
            // 
            this.lblMoneyStats.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblMoneyStats.Location = new System.Drawing.Point(168, 9);
            this.lblMoneyStats.Name = "lblMoneyStats";
            this.lblMoneyStats.Size = new System.Drawing.Size(261, 206);
            this.lblMoneyStats.TabIndex = 20;
            this.lblMoneyStats.Text = "Working with the players money and the property costs for the current player";
            this.lblMoneyStats.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 353);
            this.Controls.Add(this.lblMoneyStats);
            this.Controls.Add(this.pnlPropertyHolder);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnPayRent);
            this.Controls.Add(this.btnBuyProperty);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picUserAvatar);
            this.Name = "frmProperty";
            this.Text = "Spaceopoly Game | Property";
            this.Load += new System.EventHandler(this.frmProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.pnlPropertyHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Button btnBuyProperty;
        private System.Windows.Forms.Button btnPayRent;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Panel pnlPropertyHolder;
        private System.Windows.Forms.Label lblPropertyName;
        private System.Windows.Forms.Label lblPropertyOwner;
        private System.Windows.Forms.Label lblPropertyInfo;
        private System.Windows.Forms.Label lblMoneyStats;
    }
}