namespace SkyAirlines
{
    partial class CreateOwnAirline
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.wiLBiTPanel2 = new WiLBiT.WiLBiTPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateOwnAirline = new WiLBiT.WiLBiTButton();
            this.label5 = new System.Windows.Forms.Label();
            this.wiLBiTPanel1 = new WiLBiT.WiLBiTPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbName = new WiLBiT.WiLBiTTextBox();
            this.cbFleet = new System.Windows.Forms.ComboBox();
            this.wiLBiTPanel2.SuspendLayout();
            this.wiLBiTPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(21, 146);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(1006, 363);
            this.gMapControl.TabIndex = 1;
            this.gMapControl.Zoom = 0D;
            // 
            // wiLBiTPanel2
            // 
            this.wiLBiTPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.wiLBiTPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel2.BorderRadius = 20;
            this.wiLBiTPanel2.BorderSize = 0;
            this.wiLBiTPanel2.Controls.Add(this.btnCreateOwnAirline);
            this.wiLBiTPanel2.Controls.Add(this.label5);
            this.wiLBiTPanel2.Controls.Add(this.label1);
            this.wiLBiTPanel2.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel2.Location = new System.Drawing.Point(4, 515);
            this.wiLBiTPanel2.Name = "wiLBiTPanel2";
            this.wiLBiTPanel2.Size = new System.Drawing.Size(1043, 136);
            this.wiLBiTPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(700, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost 5000$";
            // 
            // btnCreateOwnAirline
            // 
            this.btnCreateOwnAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCreateOwnAirline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCreateOwnAirline.BorderRadius = 10;
            this.btnCreateOwnAirline.BorderSize = 0;
            this.btnCreateOwnAirline.FlatAppearance.BorderSize = 0;
            this.btnCreateOwnAirline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOwnAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateOwnAirline.ForeColor = System.Drawing.Color.White;
            this.btnCreateOwnAirline.Location = new System.Drawing.Point(672, 18);
            this.btnCreateOwnAirline.Name = "btnCreateOwnAirline";
            this.btnCreateOwnAirline.Size = new System.Drawing.Size(198, 68);
            this.btnCreateOwnAirline.TabIndex = 4;
            this.btnCreateOwnAirline.Text = "Create your own airline";
            this.btnCreateOwnAirline.UseVisualStyleBackColor = false;
            this.btnCreateOwnAirline.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCreateOwnAirline.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select headquater on a map";
            // 
            // wiLBiTPanel1
            // 
            this.wiLBiTPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.wiLBiTPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel1.BorderRadius = 20;
            this.wiLBiTPanel1.BorderSize = 0;
            this.wiLBiTPanel1.Controls.Add(this.cbFleet);
            this.wiLBiTPanel1.Controls.Add(this.tbName);
            this.wiLBiTPanel1.Controls.Add(this.pbLogo);
            this.wiLBiTPanel1.Controls.Add(this.label4);
            this.wiLBiTPanel1.Controls.Add(this.label3);
            this.wiLBiTPanel1.Controls.Add(this.label2);
            this.wiLBiTPanel1.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.Location = new System.Drawing.Point(4, 7);
            this.wiLBiTPanel1.Name = "wiLBiTPanel1";
            this.wiLBiTPanel1.Size = new System.Drawing.Size(1043, 136);
            this.wiLBiTPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(431, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(796, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fleet";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SkyAirlines.Properties.Resources.SkyAirlines2;
            this.pbLogo.Location = new System.Drawing.Point(174, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(125, 110);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.BorderColor = System.Drawing.Color.DarkGray;
            this.tbName.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.tbName.BorderRadius = 4;
            this.tbName.BorderSize = 2;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(437, 61);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(250, 37);
            this.tbName.TabIndex = 4;
            this.tbName.Texts = "";
            this.tbName.UnderlinedStyle = false;
            // 
            // cbFleet
            // 
            this.cbFleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFleet.FormattingEnabled = true;
            this.cbFleet.Location = new System.Drawing.Point(802, 61);
            this.cbFleet.Name = "cbFleet";
            this.cbFleet.Size = new System.Drawing.Size(206, 33);
            this.cbFleet.TabIndex = 5;
            // 
            // CreateOwnAirline
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.wiLBiTPanel1);
            this.Controls.Add(this.wiLBiTPanel2);
            this.Controls.Add(this.gMapControl);
            this.MaximumSize = new System.Drawing.Size(1050, 655);
            this.MinimumSize = new System.Drawing.Size(1050, 655);
            this.Name = "CreateOwnAirline";
            this.Size = new System.Drawing.Size(1050, 655);
            this.wiLBiTPanel2.ResumeLayout(false);
            this.wiLBiTPanel2.PerformLayout();
            this.wiLBiTPanel1.ResumeLayout(false);
            this.wiLBiTPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private WiLBiT.WiLBiTPanel wiLBiTPanel2;
        private System.Windows.Forms.Label label1;
        private WiLBiT.WiLBiTButton btnCreateOwnAirline;
        private System.Windows.Forms.Label label5;
        private WiLBiT.WiLBiTPanel wiLBiTPanel1;
        private System.Windows.Forms.ComboBox cbFleet;
        private WiLBiT.WiLBiTTextBox tbName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
