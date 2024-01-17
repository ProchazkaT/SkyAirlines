namespace SkyAirlines.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panelUdaje = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.linkLblHaveAcc = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new WiLBiT.WiLBiTButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.DragControl = new WiLBiT.WiLBiTDragControl();
            this.panelUdaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUdaje
            // 
            this.panelUdaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelUdaje.Controls.Add(this.tbPassword);
            this.panelUdaje.Controls.Add(this.tbEmail);
            this.panelUdaje.Controls.Add(this.tbUsername);
            this.panelUdaje.Controls.Add(this.Email);
            this.panelUdaje.Controls.Add(this.linkLblHaveAcc);
            this.panelUdaje.Controls.Add(this.btnRegister);
            this.panelUdaje.Controls.Add(this.label2);
            this.panelUdaje.Controls.Add(this.label1);
            this.panelUdaje.Controls.Add(this.pictureBox1);
            this.panelUdaje.Controls.Add(this.panel1);
            this.panelUdaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUdaje.Location = new System.Drawing.Point(0, 0);
            this.panelUdaje.Name = "panelUdaje";
            this.panelUdaje.Size = new System.Drawing.Size(605, 614);
            this.panelUdaje.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(123, 429);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(357, 32);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTextBox);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(123, 342);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(357, 32);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTextBox);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUsername.Location = new System.Drawing.Point(125, 257);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(357, 32);
            this.tbUsername.TabIndex = 10;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTextBox);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(121, 316);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(62, 23);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email";
            // 
            // linkLblHaveAcc
            // 
            this.linkLblHaveAcc.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLblHaveAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLblHaveAcc.AutoSize = true;
            this.linkLblHaveAcc.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.linkLblHaveAcc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLblHaveAcc.ForeColor = System.Drawing.Color.DimGray;
            this.linkLblHaveAcc.LinkColor = System.Drawing.Color.Silver;
            this.linkLblHaveAcc.Location = new System.Drawing.Point(223, 555);
            this.linkLblHaveAcc.Name = "linkLblHaveAcc";
            this.linkLblHaveAcc.Size = new System.Drawing.Size(209, 22);
            this.linkLblHaveAcc.TabIndex = 8;
            this.linkLblHaveAcc.TabStop = true;
            this.linkLblHaveAcc.Text = "Already have account";
            this.linkLblHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLblHaveAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHaveAcc_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnRegister.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.BorderRadius = 20;
            this.btnRegister.BorderSize = 1;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(227, 501);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkyAirlines.Properties.Resources.SkyAirlines3;
            this.pictureBox1.Location = new System.Drawing.Point(123, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimaze);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Image = global::SkyAirlines.Properties.Resources.minimaze;
            this.btnMinimaze.Location = new System.Drawing.Point(505, 0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(50, 50);
            this.btnMinimaze.TabIndex = 6;
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::SkyAirlines.Properties.Resources.Close;
            this.btnExit.Location = new System.Drawing.Point(555, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.panel1;
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(605, 614);
            this.Controls.Add(this.panelUdaje);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Leave += new System.EventHandler(this.RegisterForm_Leave);
            this.panelUdaje.ResumeLayout(false);
            this.panelUdaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelUdaje;
        private System.Windows.Forms.LinkLabel linkLblHaveAcc;
        private WiLBiT.WiLBiTButton btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnExit;
        private WiLBiT.WiLBiTDragControl DragControl;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUsername;
    }
}