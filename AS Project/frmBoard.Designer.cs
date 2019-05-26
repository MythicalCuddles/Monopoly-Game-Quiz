namespace AS_Project
{
    partial class frmBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyALLPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splashFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.player2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPlayerNearJailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayersToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblP1Username = new System.Windows.Forms.Label();
            this.lblP2Username = new System.Windows.Forms.Label();
            this.lblP1Money = new System.Windows.Forms.Label();
            this.lblP2Money = new System.Windows.Forms.Label();
            this.lblP1QuestionScore = new System.Windows.Forms.Label();
            this.lblP2QuestionScore = new System.Windows.Forms.Label();
            this.lblP2AmountofProperties = new System.Windows.Forms.Label();
            this.lblP2isInJail = new System.Windows.Forms.Label();
            this.lblP1isInJail = new System.Windows.Forms.Label();
            this.lblP1AmountofProperties = new System.Windows.Forms.Label();
            this.picP2Avatar = new System.Windows.Forms.PictureBox();
            this.picP1Avatar = new System.Windows.Forms.PictureBox();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.picP1Token = new System.Windows.Forms.PictureBox();
            this.lblP1IsTurn = new System.Windows.Forms.Label();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.picP2Token = new System.Windows.Forms.PictureBox();
            this.lblP2IsTurn = new System.Windows.Forms.Label();
            this.tmrTokenCheck = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Avatar)).BeginInit();
            this.pnlPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Token)).BeginInit();
            this.pnlPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Token)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu_MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.highscoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // highscoreToolStripMenuItem
            // 
            this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
            this.highscoreToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.highscoreToolStripMenuItem.Text = "Highscore";
            this.highscoreToolStripMenuItem.Click += new System.EventHandler(this.highscoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpGuideToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpGuideToolStripMenuItem
            // 
            this.helpGuideToolStripMenuItem.Name = "helpGuideToolStripMenuItem";
            this.helpGuideToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.helpGuideToolStripMenuItem.Text = "Help Guide";
            this.helpGuideToolStripMenuItem.Click += new System.EventHandler(this.helpGuideToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.addPlayersToDatabaseToolStripMenuItem,
            this.closeDebugToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyALLPropertiesToolStripMenuItem,
            this.loadFormToolStripMenuItem,
            this.turnToolStripMenuItem,
            this.placeToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // buyALLPropertiesToolStripMenuItem
            // 
            this.buyALLPropertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1ToolStripMenuItem,
            this.player2ToolStripMenuItem});
            this.buyALLPropertiesToolStripMenuItem.Name = "buyALLPropertiesToolStripMenuItem";
            this.buyALLPropertiesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.buyALLPropertiesToolStripMenuItem.Text = "Buy ALL Properties";
            // 
            // player1ToolStripMenuItem
            // 
            this.player1ToolStripMenuItem.Name = "player1ToolStripMenuItem";
            this.player1ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.player1ToolStripMenuItem.Text = "Player 1";
            this.player1ToolStripMenuItem.Click += new System.EventHandler(this.player1ToolStripMenuItem_Click);
            // 
            // player2ToolStripMenuItem
            // 
            this.player2ToolStripMenuItem.Name = "player2ToolStripMenuItem";
            this.player2ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.player2ToolStripMenuItem.Text = "Player 2";
            this.player2ToolStripMenuItem.Click += new System.EventHandler(this.player2ToolStripMenuItem_Click);
            // 
            // loadFormToolStripMenuItem
            // 
            this.loadFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyFormToolStripMenuItem,
            this.questionFormToolStripMenuItem,
            this.splashFormToolStripMenuItem});
            this.loadFormToolStripMenuItem.Name = "loadFormToolStripMenuItem";
            this.loadFormToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadFormToolStripMenuItem.Text = "Load Form";
            // 
            // propertyFormToolStripMenuItem
            // 
            this.propertyFormToolStripMenuItem.Name = "propertyFormToolStripMenuItem";
            this.propertyFormToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.propertyFormToolStripMenuItem.Text = "Property Form";
            this.propertyFormToolStripMenuItem.Click += new System.EventHandler(this.propertyFormToolStripMenuItem_Click);
            // 
            // questionFormToolStripMenuItem
            // 
            this.questionFormToolStripMenuItem.Name = "questionFormToolStripMenuItem";
            this.questionFormToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.questionFormToolStripMenuItem.Text = "Question Form";
            this.questionFormToolStripMenuItem.Click += new System.EventHandler(this.questionFormToolStripMenuItem_Click);
            // 
            // splashFormToolStripMenuItem
            // 
            this.splashFormToolStripMenuItem.Name = "splashFormToolStripMenuItem";
            this.splashFormToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.splashFormToolStripMenuItem.Text = "Splash Form";
            // 
            // turnToolStripMenuItem
            // 
            this.turnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1ToolStripMenuItem1,
            this.player2ToolStripMenuItem1});
            this.turnToolStripMenuItem.Name = "turnToolStripMenuItem";
            this.turnToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.turnToolStripMenuItem.Text = "Turn";
            // 
            // player1ToolStripMenuItem1
            // 
            this.player1ToolStripMenuItem1.Name = "player1ToolStripMenuItem1";
            this.player1ToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.player1ToolStripMenuItem1.Text = "Player 1";
            this.player1ToolStripMenuItem1.Click += new System.EventHandler(this.player1ToolStripMenuItem1_Click);
            // 
            // player2ToolStripMenuItem1
            // 
            this.player2ToolStripMenuItem1.Name = "player2ToolStripMenuItem1";
            this.player2ToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.player2ToolStripMenuItem1.Text = "Player 2";
            this.player2ToolStripMenuItem1.Click += new System.EventHandler(this.player2ToolStripMenuItem1_Click);
            // 
            // placeToolStripMenuItem
            // 
            this.placeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPlayerNearJailToolStripMenuItem});
            this.placeToolStripMenuItem.Name = "placeToolStripMenuItem";
            this.placeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.placeToolStripMenuItem.Text = "Place";
            // 
            // currentPlayerNearJailToolStripMenuItem
            // 
            this.currentPlayerNearJailToolStripMenuItem.Name = "currentPlayerNearJailToolStripMenuItem";
            this.currentPlayerNearJailToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.currentPlayerNearJailToolStripMenuItem.Text = "Current Player Near Jail";
            this.currentPlayerNearJailToolStripMenuItem.Click += new System.EventHandler(this.currentPlayerNearJailToolStripMenuItem_Click);
            // 
            // addPlayersToDatabaseToolStripMenuItem
            // 
            this.addPlayersToDatabaseToolStripMenuItem.Name = "addPlayersToDatabaseToolStripMenuItem";
            this.addPlayersToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addPlayersToDatabaseToolStripMenuItem.Text = "Add Players To Database";
            // 
            // closeDebugToolStripMenuItem
            // 
            this.closeDebugToolStripMenuItem.Name = "closeDebugToolStripMenuItem";
            this.closeDebugToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.closeDebugToolStripMenuItem.Text = "Close Debug";
            this.closeDebugToolStripMenuItem.Click += new System.EventHandler(this.closeDebugToolStripMenuItem_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRoll.Location = new System.Drawing.Point(9, 469);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(417, 72);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblP1Username
            // 
            this.lblP1Username.AutoSize = true;
            this.lblP1Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Username.Location = new System.Drawing.Point(159, 3);
            this.lblP1Username.Name = "lblP1Username";
            this.lblP1Username.Size = new System.Drawing.Size(139, 25);
            this.lblP1Username.TabIndex = 3;
            this.lblP1Username.Text = "lblP1Username";
            // 
            // lblP2Username
            // 
            this.lblP2Username.AutoSize = true;
            this.lblP2Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Username.Location = new System.Drawing.Point(159, 3);
            this.lblP2Username.Name = "lblP2Username";
            this.lblP2Username.Size = new System.Drawing.Size(139, 25);
            this.lblP2Username.TabIndex = 6;
            this.lblP2Username.Text = "lblP2Username";
            // 
            // lblP1Money
            // 
            this.lblP1Money.AutoSize = true;
            this.lblP1Money.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Money.Location = new System.Drawing.Point(159, 128);
            this.lblP1Money.Name = "lblP1Money";
            this.lblP1Money.Size = new System.Drawing.Size(112, 25);
            this.lblP1Money.TabIndex = 9;
            this.lblP1Money.Text = "lblP1Money";
            // 
            // lblP2Money
            // 
            this.lblP2Money.AutoSize = true;
            this.lblP2Money.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Money.Location = new System.Drawing.Point(159, 128);
            this.lblP2Money.Name = "lblP2Money";
            this.lblP2Money.Size = new System.Drawing.Size(112, 25);
            this.lblP2Money.TabIndex = 10;
            this.lblP2Money.Text = "lblP2Money";
            // 
            // lblP1QuestionScore
            // 
            this.lblP1QuestionScore.AutoSize = true;
            this.lblP1QuestionScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1QuestionScore.Location = new System.Drawing.Point(159, 153);
            this.lblP1QuestionScore.Name = "lblP1QuestionScore";
            this.lblP1QuestionScore.Size = new System.Drawing.Size(177, 25);
            this.lblP1QuestionScore.TabIndex = 11;
            this.lblP1QuestionScore.Text = "lblP1QuestionScore";
            // 
            // lblP2QuestionScore
            // 
            this.lblP2QuestionScore.AutoSize = true;
            this.lblP2QuestionScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2QuestionScore.Location = new System.Drawing.Point(159, 153);
            this.lblP2QuestionScore.Name = "lblP2QuestionScore";
            this.lblP2QuestionScore.Size = new System.Drawing.Size(177, 25);
            this.lblP2QuestionScore.TabIndex = 12;
            this.lblP2QuestionScore.Text = "lblP2QuestionScore";
            // 
            // lblP2AmountofProperties
            // 
            this.lblP2AmountofProperties.AutoSize = true;
            this.lblP2AmountofProperties.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2AmountofProperties.Location = new System.Drawing.Point(159, 178);
            this.lblP2AmountofProperties.Name = "lblP2AmountofProperties";
            this.lblP2AmountofProperties.Size = new System.Drawing.Size(224, 25);
            this.lblP2AmountofProperties.TabIndex = 14;
            this.lblP2AmountofProperties.Text = "lblP2AmountofProperties";
            // 
            // lblP2isInJail
            // 
            this.lblP2isInJail.AutoSize = true;
            this.lblP2isInJail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2isInJail.ForeColor = System.Drawing.Color.Red;
            this.lblP2isInJail.Location = new System.Drawing.Point(159, 66);
            this.lblP2isInJail.Name = "lblP2isInJail";
            this.lblP2isInJail.Size = new System.Drawing.Size(110, 25);
            this.lblP2isInJail.TabIndex = 15;
            this.lblP2isInJail.Text = "lblP2isInJail";
            // 
            // lblP1isInJail
            // 
            this.lblP1isInJail.AutoSize = true;
            this.lblP1isInJail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1isInJail.ForeColor = System.Drawing.Color.Red;
            this.lblP1isInJail.Location = new System.Drawing.Point(159, 59);
            this.lblP1isInJail.Name = "lblP1isInJail";
            this.lblP1isInJail.Size = new System.Drawing.Size(110, 25);
            this.lblP1isInJail.TabIndex = 16;
            this.lblP1isInJail.Text = "lblP1isInJail";
            // 
            // lblP1AmountofProperties
            // 
            this.lblP1AmountofProperties.AutoSize = true;
            this.lblP1AmountofProperties.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1AmountofProperties.Location = new System.Drawing.Point(159, 178);
            this.lblP1AmountofProperties.Name = "lblP1AmountofProperties";
            this.lblP1AmountofProperties.Size = new System.Drawing.Size(224, 25);
            this.lblP1AmountofProperties.TabIndex = 17;
            this.lblP1AmountofProperties.Text = "lblP1AmountofProperties";
            // 
            // picP2Avatar
            // 
            this.picP2Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picP2Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picP2Avatar.Location = new System.Drawing.Point(3, 3);
            this.picP2Avatar.Name = "picP2Avatar";
            this.picP2Avatar.Size = new System.Drawing.Size(150, 150);
            this.picP2Avatar.TabIndex = 8;
            this.picP2Avatar.TabStop = false;
            // 
            // picP1Avatar
            // 
            this.picP1Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picP1Avatar.Location = new System.Drawing.Point(3, 3);
            this.picP1Avatar.Name = "picP1Avatar";
            this.picP1Avatar.Size = new System.Drawing.Size(150, 150);
            this.picP1Avatar.TabIndex = 7;
            this.picP1Avatar.TabStop = false;
            // 
            // btnEndGame
            // 
            this.btnEndGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.Location = new System.Drawing.Point(9, 547);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(417, 45);
            this.btnEndGame.TabIndex = 19;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Controls.Add(this.picP1Token);
            this.pnlPlayer1.Controls.Add(this.lblP1IsTurn);
            this.pnlPlayer1.Controls.Add(this.picP1Avatar);
            this.pnlPlayer1.Controls.Add(this.lblP1Username);
            this.pnlPlayer1.Controls.Add(this.lblP1Money);
            this.pnlPlayer1.Controls.Add(this.lblP1AmountofProperties);
            this.pnlPlayer1.Controls.Add(this.lblP1QuestionScore);
            this.pnlPlayer1.Controls.Add(this.lblP1isInJail);
            this.pnlPlayer1.Location = new System.Drawing.Point(12, 27);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(414, 212);
            this.pnlPlayer1.TabIndex = 20;
            // 
            // picP1Token
            // 
            this.picP1Token.Location = new System.Drawing.Point(53, 159);
            this.picP1Token.Name = "picP1Token";
            this.picP1Token.Size = new System.Drawing.Size(50, 50);
            this.picP1Token.TabIndex = 19;
            this.picP1Token.TabStop = false;
            // 
            // lblP1IsTurn
            // 
            this.lblP1IsTurn.AutoSize = true;
            this.lblP1IsTurn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1IsTurn.Location = new System.Drawing.Point(159, 84);
            this.lblP1IsTurn.Name = "lblP1IsTurn";
            this.lblP1IsTurn.Size = new System.Drawing.Size(128, 25);
            this.lblP1IsTurn.TabIndex = 18;
            this.lblP1IsTurn.Text = "It is your turn.";
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Controls.Add(this.picP2Token);
            this.pnlPlayer2.Controls.Add(this.lblP2IsTurn);
            this.pnlPlayer2.Controls.Add(this.picP2Avatar);
            this.pnlPlayer2.Controls.Add(this.lblP2Username);
            this.pnlPlayer2.Controls.Add(this.lblP2Money);
            this.pnlPlayer2.Controls.Add(this.lblP2isInJail);
            this.pnlPlayer2.Controls.Add(this.lblP2QuestionScore);
            this.pnlPlayer2.Controls.Add(this.lblP2AmountofProperties);
            this.pnlPlayer2.Location = new System.Drawing.Point(12, 245);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(414, 212);
            this.pnlPlayer2.TabIndex = 21;
            // 
            // picP2Token
            // 
            this.picP2Token.Location = new System.Drawing.Point(53, 159);
            this.picP2Token.Name = "picP2Token";
            this.picP2Token.Size = new System.Drawing.Size(50, 50);
            this.picP2Token.TabIndex = 20;
            this.picP2Token.TabStop = false;
            // 
            // lblP2IsTurn
            // 
            this.lblP2IsTurn.AutoSize = true;
            this.lblP2IsTurn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2IsTurn.Location = new System.Drawing.Point(159, 91);
            this.lblP2IsTurn.Name = "lblP2IsTurn";
            this.lblP2IsTurn.Size = new System.Drawing.Size(128, 25);
            this.lblP2IsTurn.TabIndex = 19;
            this.lblP2IsTurn.Text = "It is your turn.";
            // 
            // tmrTokenCheck
            // 
            this.tmrTokenCheck.Enabled = true;
            this.tmrTokenCheck.Tick += new System.EventHandler(this.tmrTokenCheck_Tick);
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AS_Project.Properties.Resources.boardBackground;
            this.ClientSize = new System.Drawing.Size(1000, 604);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBoard";
            this.Text = "Monopoly | Main Board";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Avatar)).EndInit();
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Token)).EndInit();
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Token)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyALLPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splashFormToolStripMenuItem;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ToolStripMenuItem turnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem player2ToolStripMenuItem1;
        private System.Windows.Forms.Label lblP1Username;
        private System.Windows.Forms.Label lblP2Username;
        private System.Windows.Forms.ToolStripMenuItem placeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentPlayerNearJailToolStripMenuItem;
        private System.Windows.Forms.PictureBox picP1Avatar;
        private System.Windows.Forms.PictureBox picP2Avatar;
        private System.Windows.Forms.Label lblP1Money;
        private System.Windows.Forms.Label lblP2Money;
        private System.Windows.Forms.Label lblP1QuestionScore;
        private System.Windows.Forms.Label lblP2QuestionScore;
        private System.Windows.Forms.Label lblP2AmountofProperties;
        private System.Windows.Forms.Label lblP2isInJail;
        private System.Windows.Forms.Label lblP1isInJail;
        private System.Windows.Forms.Label lblP1AmountofProperties;
        private System.Windows.Forms.ToolStripMenuItem addPlayersToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDebugToolStripMenuItem;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Label lblP1IsTurn;
        private System.Windows.Forms.Label lblP2IsTurn;
        private System.Windows.Forms.PictureBox picP1Token;
        private System.Windows.Forms.PictureBox picP2Token;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpGuideToolStripMenuItem;
        private System.Windows.Forms.Timer tmrTokenCheck;
    }
}

