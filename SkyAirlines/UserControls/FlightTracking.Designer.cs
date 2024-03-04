namespace SkyAirlines
{
    partial class FlightTracking
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new WiLBiT.WiLBiTPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAirplane = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.panelFlightplan = new WiLBiT.WiLBiTPanel();
            this.btnSubmitFlight = new WiLBiT.WiLBiTButton();
            this.btnSimbriefOFP = new WiLBiT.WiLBiTButton();
            this.btnSimbriefDispatch = new WiLBiT.WiLBiTButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInformation = new WiLBiT.WiLBiTPanel();
            this.lblAltitudeMetres = new System.Windows.Forms.Label();
            this.lblIAS = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelFlightplan.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelTop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelTop.BorderRadius = 20;
            this.panelTop.BorderSize = 0;
            this.panelTop.Controls.Add(this.tableLayoutPanel1);
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(9, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1038, 75);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblAirplane, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDistance, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblArrival, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDeparture, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAirplane
            // 
            this.lblAirplane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAirplane.AutoSize = true;
            this.lblAirplane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAirplane.Location = new System.Drawing.Point(747, 36);
            this.lblAirplane.Name = "lblAirplane";
            this.lblAirplane.Size = new System.Drawing.Size(245, 36);
            this.lblAirplane.TabIndex = 7;
            this.lblAirplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDistance.Location = new System.Drawing.Point(499, 36);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(242, 36);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArrival
            // 
            this.lblArrival.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArrival.Location = new System.Drawing.Point(251, 36);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(242, 36);
            this.lblArrival.TabIndex = 5;
            this.lblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departure airport";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival airport";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(499, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(747, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Airplane";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeparture
            // 
            this.lblDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeparture.Location = new System.Drawing.Point(3, 36);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(242, 36);
            this.lblDeparture.TabIndex = 4;
            this.lblDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFlightplan
            // 
            this.panelFlightplan.BackColor = System.Drawing.Color.White;
            this.panelFlightplan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelFlightplan.BorderRadius = 20;
            this.panelFlightplan.BorderSize = 0;
            this.panelFlightplan.Controls.Add(this.btnSubmitFlight);
            this.panelFlightplan.Controls.Add(this.btnSimbriefOFP);
            this.panelFlightplan.Controls.Add(this.btnSimbriefDispatch);
            this.panelFlightplan.Controls.Add(this.label6);
            this.panelFlightplan.Controls.Add(this.label5);
            this.panelFlightplan.ForeColor = System.Drawing.Color.White;
            this.panelFlightplan.Location = new System.Drawing.Point(9, 503);
            this.panelFlightplan.Name = "panelFlightplan";
            this.panelFlightplan.Size = new System.Drawing.Size(1038, 73);
            this.panelFlightplan.TabIndex = 2;
            // 
            // btnSubmitFlight
            // 
            this.btnSubmitFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnSubmitFlight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnSubmitFlight.BorderRadius = 10;
            this.btnSubmitFlight.BorderSize = 0;
            this.btnSubmitFlight.Enabled = false;
            this.btnSubmitFlight.FlatAppearance.BorderSize = 0;
            this.btnSubmitFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubmitFlight.ForeColor = System.Drawing.Color.White;
            this.btnSubmitFlight.Location = new System.Drawing.Point(723, 6);
            this.btnSubmitFlight.Name = "btnSubmitFlight";
            this.btnSubmitFlight.Size = new System.Drawing.Size(182, 60);
            this.btnSubmitFlight.TabIndex = 5;
            this.btnSubmitFlight.Text = "Submit flight";
            this.btnSubmitFlight.UseVisualStyleBackColor = false;
            this.btnSubmitFlight.Click += new System.EventHandler(this.btnSubmitFlight_Click);
            this.btnSubmitFlight.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSubmitFlight.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnSimbriefOFP
            // 
            this.btnSimbriefOFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnSimbriefOFP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnSimbriefOFP.BorderRadius = 10;
            this.btnSimbriefOFP.BorderSize = 0;
            this.btnSimbriefOFP.FlatAppearance.BorderSize = 0;
            this.btnSimbriefOFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimbriefOFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSimbriefOFP.ForeColor = System.Drawing.Color.White;
            this.btnSimbriefOFP.Location = new System.Drawing.Point(535, 6);
            this.btnSimbriefOFP.Name = "btnSimbriefOFP";
            this.btnSimbriefOFP.Size = new System.Drawing.Size(182, 60);
            this.btnSimbriefOFP.TabIndex = 3;
            this.btnSimbriefOFP.Text = "Simbrief OFP";
            this.btnSimbriefOFP.UseVisualStyleBackColor = false;
            this.btnSimbriefOFP.Click += new System.EventHandler(this.btnSimbriefOFP_Click);
            this.btnSimbriefOFP.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSimbriefOFP.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnSimbriefDispatch
            // 
            this.btnSimbriefDispatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnSimbriefDispatch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnSimbriefDispatch.BorderRadius = 10;
            this.btnSimbriefDispatch.BorderSize = 0;
            this.btnSimbriefDispatch.FlatAppearance.BorderSize = 0;
            this.btnSimbriefDispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimbriefDispatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSimbriefDispatch.ForeColor = System.Drawing.Color.White;
            this.btnSimbriefDispatch.Location = new System.Drawing.Point(347, 6);
            this.btnSimbriefDispatch.Name = "btnSimbriefDispatch";
            this.btnSimbriefDispatch.Size = new System.Drawing.Size(182, 60);
            this.btnSimbriefDispatch.TabIndex = 2;
            this.btnSimbriefDispatch.Text = "Simbrief dispatch";
            this.btnSimbriefDispatch.UseVisualStyleBackColor = false;
            this.btnSimbriefDispatch.Click += new System.EventHandler(this.btnSimbriefDispatch_Click);
            this.btnSimbriefDispatch.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSimbriefDispatch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select an action to perform";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Action";
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.White;
            this.panelInformation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelInformation.BorderRadius = 20;
            this.panelInformation.BorderSize = 0;
            this.panelInformation.Controls.Add(this.lblAltitudeMetres);
            this.panelInformation.Controls.Add(this.lblIAS);
            this.panelInformation.Controls.Add(this.label19);
            this.panelInformation.Controls.Add(this.lblAltitude);
            this.panelInformation.Controls.Add(this.label15);
            this.panelInformation.Controls.Add(this.lblLongitude);
            this.panelInformation.Controls.Add(this.label12);
            this.panelInformation.Controls.Add(this.lblLatitude);
            this.panelInformation.Controls.Add(this.label11);
            this.panelInformation.Controls.Add(this.lblSpeed);
            this.panelInformation.Controls.Add(this.label9);
            this.panelInformation.Controls.Add(this.lblStatus);
            this.panelInformation.Controls.Add(this.label7);
            this.panelInformation.ForeColor = System.Drawing.Color.White;
            this.panelInformation.Location = new System.Drawing.Point(9, 582);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(1038, 70);
            this.panelInformation.TabIndex = 3;
            // 
            // lblAltitudeMetres
            // 
            this.lblAltitudeMetres.AutoSize = true;
            this.lblAltitudeMetres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAltitudeMetres.ForeColor = System.Drawing.Color.Black;
            this.lblAltitudeMetres.Location = new System.Drawing.Point(705, 35);
            this.lblAltitudeMetres.Name = "lblAltitudeMetres";
            this.lblAltitudeMetres.Size = new System.Drawing.Size(31, 17);
            this.lblAltitudeMetres.TabIndex = 15;
            this.lblAltitudeMetres.Text = "0 m";
            // 
            // lblIAS
            // 
            this.lblIAS.AutoSize = true;
            this.lblIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIAS.ForeColor = System.Drawing.Color.Black;
            this.lblIAS.Location = new System.Drawing.Point(940, 35);
            this.lblIAS.Name = "lblIAS";
            this.lblIAS.Size = new System.Drawing.Size(38, 17);
            this.lblIAS.TabIndex = 13;
            this.lblIAS.Text = "0 kts";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(896, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 17);
            this.label19.TabIndex = 14;
            this.label19.Text = "TAS";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAltitude.ForeColor = System.Drawing.Color.Black;
            this.lblAltitude.Location = new System.Drawing.Point(705, 10);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(28, 17);
            this.lblAltitude.TabIndex = 11;
            this.lblAltitude.Text = "0 ft";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(626, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Altitude";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLongitude.ForeColor = System.Drawing.Color.Black;
            this.lblLongitude.Location = new System.Drawing.Point(415, 35);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(22, 17);
            this.lblLongitude.TabIndex = 10;
            this.lblLongitude.Text = "0°";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(318, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Longitude";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLatitude.ForeColor = System.Drawing.Color.Black;
            this.lblLatitude.Location = new System.Drawing.Point(415, 10);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(22, 17);
            this.lblLatitude.TabIndex = 7;
            this.lblLatitude.Text = "0°";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(318, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Latitude";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpeed.ForeColor = System.Drawing.Color.Black;
            this.lblSpeed.Location = new System.Drawing.Point(940, 10);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 17);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "0 kts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(817, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ground speed";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(20, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(230, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Offline - you need to start simulator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Flight status";
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(33, 84);
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
            this.gMapControl.Size = new System.Drawing.Size(994, 413);
            this.gMapControl.TabIndex = 4;
            this.gMapControl.Zoom = 0D;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FlightTracking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.panelFlightplan);
            this.Controls.Add(this.panelTop);
            this.MaximumSize = new System.Drawing.Size(1050, 655);
            this.MinimumSize = new System.Drawing.Size(1050, 655);
            this.Name = "FlightTracking";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.FlightTracking_Load);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelFlightplan.ResumeLayout(false);
            this.panelFlightplan.PerformLayout();
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private WiLBiT.WiLBiTPanel panelFlightplan;
        private WiLBiT.WiLBiTPanel panelInformation;
        private WiLBiT.WiLBiTButton btnSimbriefOFP;
        private WiLBiT.WiLBiTButton btnSimbriefDispatch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblIAS;
        private System.Windows.Forms.Label label19;
        private WiLBiT.WiLBiTButton btnSubmitFlight;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Label lblAltitudeMetres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblAirplane;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Timer timer1;
    }
}
