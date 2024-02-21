﻿namespace SkyAirlines
{
    partial class Dashboard
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
            this.panelRank = new WiLBiT.WiLBiTPanel();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblNextRank = new System.Windows.Forms.Label();
            this.lblCurrentRank = new System.Windows.Forms.Label();
            this.pbNextRank = new System.Windows.Forms.PictureBox();
            this.pbCurrentRank = new System.Windows.Forms.PictureBox();
            this.progressBar = new WiLBiT.WiLBiTProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFlights = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblLandingRate = new System.Windows.Forms.Label();
            this.panelTop = new WiLBiT.WiLBiTPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panelRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentRank)).BeginInit();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRank
            // 
            this.panelRank.BackColor = System.Drawing.Color.White;
            this.panelRank.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelRank.BorderRadius = 20;
            this.panelRank.BorderSize = 0;
            this.panelRank.Controls.Add(this.lblXP);
            this.panelRank.Controls.Add(this.lblNextRank);
            this.panelRank.Controls.Add(this.lblCurrentRank);
            this.panelRank.Controls.Add(this.pbNextRank);
            this.panelRank.Controls.Add(this.pbCurrentRank);
            this.panelRank.Controls.Add(this.progressBar);
            this.panelRank.ForeColor = System.Drawing.Color.White;
            this.panelRank.Location = new System.Drawing.Point(5, 548);
            this.panelRank.Name = "panelRank";
            this.panelRank.Size = new System.Drawing.Size(1038, 92);
            this.panelRank.TabIndex = 0;
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.BackColor = System.Drawing.Color.Transparent;
            this.lblXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXP.ForeColor = System.Drawing.Color.Black;
            this.lblXP.Location = new System.Drawing.Point(448, 53);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(147, 29);
            this.lblXP.TabIndex = 5;
            this.lblXP.Text = "XP 0 / 1000";
            // 
            // lblNextRank
            // 
            this.lblNextRank.AutoSize = true;
            this.lblNextRank.BackColor = System.Drawing.Color.Transparent;
            this.lblNextRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNextRank.ForeColor = System.Drawing.Color.Black;
            this.lblNextRank.Location = new System.Drawing.Point(878, 49);
            this.lblNextRank.Name = "lblNextRank";
            this.lblNextRank.Size = new System.Drawing.Size(102, 29);
            this.lblNextRank.TabIndex = 4;
            this.lblNextRank.Text = "Captain";
            // 
            // lblCurrentRank
            // 
            this.lblCurrentRank.AutoSize = true;
            this.lblCurrentRank.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrentRank.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentRank.Location = new System.Drawing.Point(34, 49);
            this.lblCurrentRank.Name = "lblCurrentRank";
            this.lblCurrentRank.Size = new System.Drawing.Size(150, 29);
            this.lblCurrentRank.TabIndex = 3;
            this.lblCurrentRank.Text = "First Officer";
            // 
            // pbNextRank
            // 
            this.pbNextRank.Image = global::SkyAirlines.Properties.Resources.FirstOfficer;
            this.pbNextRank.Location = new System.Drawing.Point(828, 16);
            this.pbNextRank.Name = "pbNextRank";
            this.pbNextRank.Size = new System.Drawing.Size(192, 30);
            this.pbNextRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNextRank.TabIndex = 2;
            this.pbNextRank.TabStop = false;
            // 
            // pbCurrentRank
            // 
            this.pbCurrentRank.Image = global::SkyAirlines.Properties.Resources.FirstOfficer;
            this.pbCurrentRank.Location = new System.Drawing.Point(19, 16);
            this.pbCurrentRank.Name = "pbCurrentRank";
            this.pbCurrentRank.Size = new System.Drawing.Size(192, 30);
            this.pbCurrentRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentRank.TabIndex = 1;
            this.pbCurrentRank.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar.BarBackColor = System.Drawing.Color.RoyalBlue;
            this.progressBar.BarColor = System.Drawing.Color.Gray;
            this.progressBar.BarWidth = 50;
            this.progressBar.BorderColor = System.Drawing.Color.Silver;
            this.progressBar.BorderRadius = 15;
            this.progressBar.BorderSize = 0;
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(240, 16);
            this.progressBar.Maximum = 300;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(568, 34);
            this.progressBar.TabIndex = 0;
            this.progressBar.ValueBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.progressBar.ValueBarWidth = 50;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Flights";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(647, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rating";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(325, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Average landing rate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlights
            // 
            this.lblFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlights.AutoSize = true;
            this.lblFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFlights.Location = new System.Drawing.Point(3, 38);
            this.lblFlights.Name = "lblFlights";
            this.lblFlights.Size = new System.Drawing.Size(316, 38);
            this.lblFlights.TabIndex = 2;
            this.lblFlights.Text = "0";
            this.lblFlights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRating
            // 
            this.lblRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRating.Location = new System.Drawing.Point(647, 38);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(317, 38);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "100";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLandingRate
            // 
            this.lblLandingRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLandingRate.AutoSize = true;
            this.lblLandingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLandingRate.Location = new System.Drawing.Point(325, 38);
            this.lblLandingRate.Name = "lblLandingRate";
            this.lblLandingRate.Size = new System.Drawing.Size(316, 38);
            this.lblLandingRate.TabIndex = 5;
            this.lblLandingRate.Text = "0 FPM";
            this.lblLandingRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelTop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelTop.BorderRadius = 20;
            this.panelTop.BorderSize = 0;
            this.panelTop.Controls.Add(this.tableLayoutPanel1);
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(5, 17);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1038, 82);
            this.panelTop.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblLandingRate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRating, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFlights, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(23, 105);
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
            this.gMapControl.Size = new System.Drawing.Size(1001, 437);
            this.gMapControl.TabIndex = 3;
            this.gMapControl.Zoom = 0D;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelRank);
            this.MaximumSize = new System.Drawing.Size(1050, 655);
            this.MinimumSize = new System.Drawing.Size(1050, 655);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelRank.ResumeLayout(false);
            this.panelRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentRank)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel panelRank;
        private WiLBiT.WiLBiTProgressBar progressBar;
        private System.Windows.Forms.Label lblCurrentRank;
        private System.Windows.Forms.PictureBox pbNextRank;
        private System.Windows.Forms.PictureBox pbCurrentRank;
        private System.Windows.Forms.Label lblNextRank;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblLandingRate;
        private WiLBiT.WiLBiTPanel panelTop;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
