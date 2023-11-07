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
            this.wiLBiTPanel1 = new WiLBiT.WiLBiTPanel();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.wiLBiTPanel2 = new WiLBiT.WiLBiTPanel();
            this.btnCreateAirline = new WiLBiT.WiLBiTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new WiLBiT.WiLBiTTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wiLBiTPanel1.SuspendLayout();
            this.wiLBiTPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // wiLBiTPanel1
            // 
            this.wiLBiTPanel1.BackColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel1.BorderRadius = 20;
            this.wiLBiTPanel1.BorderSize = 0;
            this.wiLBiTPanel1.Controls.Add(this.comboBox1);
            this.wiLBiTPanel1.Controls.Add(this.label5);
            this.wiLBiTPanel1.Controls.Add(this.tbName);
            this.wiLBiTPanel1.Controls.Add(this.pbLogo);
            this.wiLBiTPanel1.Controls.Add(this.label4);
            this.wiLBiTPanel1.Controls.Add(this.label3);
            this.wiLBiTPanel1.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.Location = new System.Drawing.Point(15, 17);
            this.wiLBiTPanel1.Name = "wiLBiTPanel1";
            this.wiLBiTPanel1.Size = new System.Drawing.Size(1018, 145);
            this.wiLBiTPanel1.TabIndex = 0;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(15, 168);
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
            this.gMapControl.Size = new System.Drawing.Size(1018, 347);
            this.gMapControl.TabIndex = 1;
            this.gMapControl.Zoom = 0D;
            // 
            // wiLBiTPanel2
            // 
            this.wiLBiTPanel2.BackColor = System.Drawing.Color.White;
            this.wiLBiTPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel2.BorderRadius = 20;
            this.wiLBiTPanel2.BorderSize = 0;
            this.wiLBiTPanel2.Controls.Add(this.label1);
            this.wiLBiTPanel2.Controls.Add(this.btnCreateAirline);
            this.wiLBiTPanel2.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel2.Location = new System.Drawing.Point(15, 524);
            this.wiLBiTPanel2.Name = "wiLBiTPanel2";
            this.wiLBiTPanel2.Size = new System.Drawing.Size(1018, 115);
            this.wiLBiTPanel2.TabIndex = 1;
            // 
            // btnCreateAirline
            // 
            this.btnCreateAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCreateAirline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCreateAirline.BorderRadius = 10;
            this.btnCreateAirline.BorderSize = 0;
            this.btnCreateAirline.FlatAppearance.BorderSize = 0;
            this.btnCreateAirline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateAirline.ForeColor = System.Drawing.Color.White;
            this.btnCreateAirline.Location = new System.Drawing.Point(744, 15);
            this.btnCreateAirline.Name = "btnCreateAirline";
            this.btnCreateAirline.Size = new System.Drawing.Size(228, 80);
            this.btnCreateAirline.TabIndex = 6;
            this.btnCreateAirline.Text = "Create airline";
            this.btnCreateAirline.UseVisualStyleBackColor = false;
            this.btnCreateAirline.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCreateAirline.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create your own airline will cost you 5000$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select airport as a headquater";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(388, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(177, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(120, 120);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Logo";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.BorderColor = System.Drawing.Color.Black;
            this.tbName.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.tbName.BorderRadius = 10;
            this.tbName.BorderSize = 1;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Location = new System.Drawing.Point(393, 53);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(273, 37);
            this.tbName.TabIndex = 3;
            this.tbName.Texts = "";
            this.tbName.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(767, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Starter fleet";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(772, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // CreateOwnAirline
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wiLBiTPanel2);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.wiLBiTPanel1);
            this.MaximumSize = new System.Drawing.Size(1050, 655);
            this.MinimumSize = new System.Drawing.Size(1050, 655);
            this.Name = "CreateOwnAirline";
            this.Size = new System.Drawing.Size(1050, 655);
            this.wiLBiTPanel1.ResumeLayout(false);
            this.wiLBiTPanel1.PerformLayout();
            this.wiLBiTPanel2.ResumeLayout(false);
            this.wiLBiTPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WiLBiT.WiLBiTPanel wiLBiTPanel1;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private WiLBiT.WiLBiTPanel wiLBiTPanel2;
        private WiLBiT.WiLBiTButton btnCreateAirline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbLogo;
        private WiLBiT.WiLBiTTextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}
