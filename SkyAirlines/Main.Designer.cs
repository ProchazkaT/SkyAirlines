namespace SkyAirlines
{
    partial class Main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wiLBiTRoundedPictureBox1 = new WiLBiT.WiLBiTRoundedPictureBox();
            this.panelMenu = new WiLBiT.WiLBiTPanel();
            this.btnLeaveAirline = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnAirline = new System.Windows.Forms.Button();
            this.btnFlight = new System.Windows.Forms.Button();
            this.btnLicences = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelUser = new WiLBiT.WiLBiTPanel();
            this.pbRank = new System.Windows.Forms.PictureBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbPicture = new WiLBiT.WiLBiTRoundedPictureBox();
            this.panel = new WiLBiT.WiLBiTPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.DragControl = new WiLBiT.WiLBiTDragControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiLBiTRoundedPictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnMinimaze);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.wiLBiTRoundedPictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.MaximumSize = new System.Drawing.Size(1375, 50);
            this.panelTop.MinimumSize = new System.Drawing.Size(1375, 50);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1375, 50);
            this.panelTop.TabIndex = 0;
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Image = global::SkyAirlines.Properties.Resources.minimaze;
            this.btnMinimaze.Location = new System.Drawing.Point(1275, 0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(50, 50);
            this.btnMinimaze.TabIndex = 4;
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::SkyAirlines.Properties.Resources.Close;
            this.btnExit.Location = new System.Drawing.Point(1325, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage airline and hire pilots!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "SkyAirlines";
            // 
            // wiLBiTRoundedPictureBox1
            // 
            this.wiLBiTRoundedPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.wiLBiTRoundedPictureBox1.BorderColor = System.Drawing.Color.White;
            this.wiLBiTRoundedPictureBox1.BorderColor2 = System.Drawing.Color.White;
            this.wiLBiTRoundedPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.wiLBiTRoundedPictureBox1.BorderSize = 2;
            this.wiLBiTRoundedPictureBox1.GradientAngle = 50F;
            this.wiLBiTRoundedPictureBox1.Image = global::SkyAirlines.Properties.Resources.SkyAirlines2;
            this.wiLBiTRoundedPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.wiLBiTRoundedPictureBox1.Name = "wiLBiTRoundedPictureBox1";
            this.wiLBiTRoundedPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.wiLBiTRoundedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wiLBiTRoundedPictureBox1.TabIndex = 0;
            this.wiLBiTRoundedPictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelMenu.BorderRadius = 20;
            this.panelMenu.BorderSize = 0;
            this.panelMenu.Controls.Add(this.btnLeaveAirline);
            this.panelMenu.Controls.Add(this.btnChat);
            this.panelMenu.Controls.Add(this.btnAirline);
            this.panelMenu.Controls.Add(this.btnFlight);
            this.panelMenu.Controls.Add(this.btnLicences);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(13, 56);
            this.panelMenu.MaximumSize = new System.Drawing.Size(255, 682);
            this.panelMenu.MinimumSize = new System.Drawing.Size(255, 682);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(255, 682);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLeaveAirline
            // 
            this.btnLeaveAirline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnLeaveAirline.FlatAppearance.BorderSize = 0;
            this.btnLeaveAirline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLeaveAirline.Image = global::SkyAirlines.Properties.Resources.leave;
            this.btnLeaveAirline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveAirline.Location = new System.Drawing.Point(5, 454);
            this.btnLeaveAirline.Name = "btnLeaveAirline";
            this.btnLeaveAirline.Size = new System.Drawing.Size(247, 46);
            this.btnLeaveAirline.TabIndex = 19;
            this.btnLeaveAirline.Text = "   Leave airline";
            this.btnLeaveAirline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeaveAirline.UseVisualStyleBackColor = true;
            this.btnLeaveAirline.Visible = false;
            this.btnLeaveAirline.Click += new System.EventHandler(this.btnLeaveAirline_Click);
            this.btnLeaveAirline.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnLeaveAirline.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnChat
            // 
            this.btnChat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChat.Image = global::SkyAirlines.Properties.Resources.chat;
            this.btnChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.Location = new System.Drawing.Point(5, 402);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(247, 46);
            this.btnChat.TabIndex = 18;
            this.btnChat.Text = "  Airline discord";
            this.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Visible = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            this.btnChat.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnChat.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnAirline
            // 
            this.btnAirline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnAirline.FlatAppearance.BorderSize = 0;
            this.btnAirline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAirline.Image = global::SkyAirlines.Properties.Resources.Airline;
            this.btnAirline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAirline.Location = new System.Drawing.Point(5, 350);
            this.btnAirline.Name = "btnAirline";
            this.btnAirline.Size = new System.Drawing.Size(247, 46);
            this.btnAirline.TabIndex = 17;
            this.btnAirline.Text = "   Airline";
            this.btnAirline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAirline.UseVisualStyleBackColor = true;
            this.btnAirline.Click += new System.EventHandler(this.btnAirline_Click);
            this.btnAirline.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnAirline.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnFlight
            // 
            this.btnFlight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnFlight.FlatAppearance.BorderSize = 0;
            this.btnFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFlight.Image = global::SkyAirlines.Properties.Resources.Flight;
            this.btnFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlight.Location = new System.Drawing.Point(5, 298);
            this.btnFlight.Name = "btnFlight";
            this.btnFlight.Size = new System.Drawing.Size(247, 46);
            this.btnFlight.TabIndex = 16;
            this.btnFlight.Text = "   Flight";
            this.btnFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFlight.UseVisualStyleBackColor = true;
            this.btnFlight.Click += new System.EventHandler(this.btnFlight_Click);
            this.btnFlight.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnFlight.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnLicences
            // 
            this.btnLicences.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnLicences.FlatAppearance.BorderSize = 0;
            this.btnLicences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLicences.Image = global::SkyAirlines.Properties.Resources.Licence;
            this.btnLicences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicences.Location = new System.Drawing.Point(5, 246);
            this.btnLicences.Name = "btnLicences";
            this.btnLicences.Size = new System.Drawing.Size(247, 46);
            this.btnLicences.TabIndex = 15;
            this.btnLicences.Text = "   Licences shop";
            this.btnLicences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLicences.UseVisualStyleBackColor = true;
            this.btnLicences.Click += new System.EventHandler(this.btnLicences_Click);
            this.btnLicences.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnLicences.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDashboard.Image = global::SkyAirlines.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(5, 194);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(247, 46);
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.Image = global::SkyAirlines.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(5, 569);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(247, 46);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogOut.Image = global::SkyAirlines.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(5, 616);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(247, 46);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "   Log out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelUser.BorderRadius = 20;
            this.panelUser.BorderSize = 0;
            this.panelUser.Controls.Add(this.pbRank);
            this.panelUser.Controls.Add(this.lblRank);
            this.panelUser.Controls.Add(this.lblMoney);
            this.panelUser.Controls.Add(this.lblUsername);
            this.panelUser.Controls.Add(this.pbPicture);
            this.panelUser.ForeColor = System.Drawing.Color.White;
            this.panelUser.Location = new System.Drawing.Point(3, 3);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(249, 174);
            this.panelUser.TabIndex = 0;
            // 
            // pbRank
            // 
            this.pbRank.Image = global::SkyAirlines.Properties.Resources.FirstOfficer;
            this.pbRank.Location = new System.Drawing.Point(16, 128);
            this.pbRank.Name = "pbRank";
            this.pbRank.Size = new System.Drawing.Size(219, 30);
            this.pbRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRank.TabIndex = 4;
            this.pbRank.TabStop = false;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRank.Location = new System.Drawing.Point(12, 102);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(124, 25);
            this.lblRank.TabIndex = 3;
            this.lblRank.Text = "First Officer";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney.Location = new System.Drawing.Point(84, 40);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(34, 25);
            this.lblMoney.TabIndex = 2;
            this.lblMoney.Text = "0$";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(84, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 29);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // pbPicture
            // 
            this.pbPicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.pbPicture.BorderColor2 = System.Drawing.Color.White;
            this.pbPicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPicture.BorderSize = 2;
            this.pbPicture.GradientAngle = 50F;
            this.pbPicture.Location = new System.Drawing.Point(3, 3);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(82, 82);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.Color.Silver;
            this.panel.BorderColor = System.Drawing.Color.Empty;
            this.panel.BorderRadius = 20;
            this.panel.BorderSize = 2;
            this.panel.Controls.Add(this.panelMain);
            this.panel.ForeColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(281, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1075, 682);
            this.panel.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(13, 14);
            this.panelMain.MaximumSize = new System.Drawing.Size(1050, 655);
            this.panelMain.MinimumSize = new System.Drawing.Size(1050, 655);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1050, 655);
            this.panelMain.TabIndex = 0;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.panelTop;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1375, 750);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1375, 750);
            this.MinimumSize = new System.Drawing.Size(1375, 750);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                            ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiLBiTRoundedPictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private WiLBiT.WiLBiTRoundedPictureBox wiLBiTRoundedPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimaze;
        private WiLBiT.WiLBiTPanel panelMenu;
        private WiLBiT.WiLBiTPanel panel;
        private WiLBiT.WiLBiTPanel panelUser;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblUsername;
        private WiLBiT.WiLBiTRoundedPictureBox pbPicture;
        private System.Windows.Forms.PictureBox pbRank;
        private System.Windows.Forms.Label lblRank;
        private WiLBiT.WiLBiTDragControl DragControl;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLeaveAirline;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnAirline;
        private System.Windows.Forms.Button btnFlight;
        private System.Windows.Forms.Button btnLicences;
        private System.Windows.Forms.Button btnDashboard;
    }
}

