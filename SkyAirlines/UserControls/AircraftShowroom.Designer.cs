namespace SkyAirlines.UserControls
{
    partial class AircraftShowroom
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

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiLBiTPanel1 = new WiLBiT.WiLBiTPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAircraftImage = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBuyLicence = new WiLBiT.WiLBiTButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.wiLBiTPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAircraftImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView.Location = new System.Drawing.Point(441, 84);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(173, 35);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // wiLBiTPanel1
            // 
            this.wiLBiTPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.wiLBiTPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel1.BorderRadius = 20;
            this.wiLBiTPanel1.BorderSize = 0;
            this.wiLBiTPanel1.Controls.Add(this.label2);
            this.wiLBiTPanel1.Controls.Add(this.label1);
            this.wiLBiTPanel1.Controls.Add(this.lblPrice);
            this.wiLBiTPanel1.Controls.Add(this.lblName);
            this.wiLBiTPanel1.Controls.Add(this.lblPassengers);
            this.wiLBiTPanel1.Controls.Add(this.pictureBox3);
            this.wiLBiTPanel1.Controls.Add(this.lblAltitude);
            this.wiLBiTPanel1.Controls.Add(this.pictureBox2);
            this.wiLBiTPanel1.Controls.Add(this.lblSpeed);
            this.wiLBiTPanel1.Controls.Add(this.pictureBox1);
            this.wiLBiTPanel1.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.Location = new System.Drawing.Point(100, 12);
            this.wiLBiTPanel1.Name = "wiLBiTPanel1";
            this.wiLBiTPanel1.Size = new System.Drawing.Size(862, 175);
            this.wiLBiTPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label2.Location = new System.Drawing.Point(528, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label1.Location = new System.Drawing.Point(355, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lblPrice.Location = new System.Drawing.Point(455, 127);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(78, 32);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "5000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(374, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 32);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Boeing 787";
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassengers.Location = new System.Drawing.Point(711, 67);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(48, 25);
            this.lblPassengers.TabIndex = 5;
            this.lblPassengers.Text = "100";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SkyAirlines.Properties.Resources.Passenger;
            this.pictureBox3.Location = new System.Drawing.Point(655, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAltitude.Location = new System.Drawing.Point(436, 67);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(96, 25);
            this.lblAltitude.TabIndex = 3;
            this.lblAltitude.Text = "40 000 ft";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkyAirlines.Properties.Resources.Altitude;
            this.pictureBox2.Location = new System.Drawing.Point(380, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSpeed.Location = new System.Drawing.Point(154, 67);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(77, 25);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "0 km/h";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkyAirlines.Properties.Resources.SpeedIcon;
            this.pictureBox1.Location = new System.Drawing.Point(98, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbAircraftImage
            // 
            this.pbAircraftImage.BackColor = System.Drawing.Color.Transparent;
            this.pbAircraftImage.Image = global::SkyAirlines.Properties.Resources.A380;
            this.pbAircraftImage.Location = new System.Drawing.Point(259, 204);
            this.pbAircraftImage.Name = "pbAircraftImage";
            this.pbAircraftImage.Size = new System.Drawing.Size(551, 293);
            this.pbAircraftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAircraftImage.TabIndex = 2;
            this.pbAircraftImage.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::SkyAirlines.Properties.Resources.ArrowLeft;
            this.btnBack.Location = new System.Drawing.Point(150, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 96);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::SkyAirlines.Properties.Resources.ArrowRight;
            this.btnNext.Location = new System.Drawing.Point(836, 320);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 96);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBuyLicence
            // 
            this.btnBuyLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnBuyLicence.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBuyLicence.BorderRadius = 20;
            this.btnBuyLicence.BorderSize = 2;
            this.btnBuyLicence.FlatAppearance.BorderSize = 0;
            this.btnBuyLicence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBuyLicence.ForeColor = System.Drawing.Color.White;
            this.btnBuyLicence.Location = new System.Drawing.Point(438, 562);
            this.btnBuyLicence.Name = "btnBuyLicence";
            this.btnBuyLicence.Size = new System.Drawing.Size(205, 60);
            this.btnBuyLicence.TabIndex = 8;
            this.btnBuyLicence.Text = "Buy";
            this.btnBuyLicence.UseVisualStyleBackColor = false;
            this.btnBuyLicence.Click += new System.EventHandler(this.btnBuyLicence_Click);
            // 
            // AircraftShowroom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SkyAirlines.Properties.Resources.Clouds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnBuyLicence);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbAircraftImage);
            this.Controls.Add(this.wiLBiTPanel1);
            this.Controls.Add(this.dataGridView);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1050, 655);
            this.MinimumSize = new System.Drawing.Size(1050, 655);
            this.Name = "AircraftShowroom";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.AircraftShowroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.wiLBiTPanel1.ResumeLayout(false);
            this.wiLBiTPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAircraftImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private WiLBiT.WiLBiTPanel wiLBiTPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbAircraftImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private WiLBiT.WiLBiTButton btnBuyLicence;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
