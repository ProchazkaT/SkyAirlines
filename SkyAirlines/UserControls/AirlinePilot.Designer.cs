﻿namespace SkyAirlines
{
    partial class AirlinePilot
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
            this.label5 = new System.Windows.Forms.Label();
            this.wiLBiTPanel5 = new WiLBiT.WiLBiTPanel();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblFleet = new System.Windows.Forms.Label();
            this.lblHeadquarter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.wiLBiTPanel1 = new WiLBiT.WiLBiTPanel();
            this.panelMembers = new WiLBiT.WiLBiTPanel();
            this.FlowRow = new System.Windows.Forms.FlowLayoutPanel();
            this.wiLBiTPanel4 = new WiLBiT.WiLBiTPanel();
            this.cbFleet = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbFlightUsername = new WiLBiT.WiLBiTTextBox();
            this.btnCopyFlight = new WiLBiT.WiLBiTButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerateFlight = new WiLBiT.WiLBiTButton();
            this.lblGenerateFlight = new System.Windows.Forms.Label();
            this.wiLBiTPanel2 = new WiLBiT.WiLBiTPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAirlineName = new System.Windows.Forms.Label();
            this.wiLBiTPanel5.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.wiLBiTPanel1.SuspendLayout();
            this.panelMembers.SuspendLayout();
            this.wiLBiTPanel4.SuspendLayout();
            this.wiLBiTPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(90, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Members";
            // 
            // wiLBiTPanel5
            // 
            this.wiLBiTPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.wiLBiTPanel5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel5.BorderRadius = 10;
            this.wiLBiTPanel5.BorderSize = 0;
            this.wiLBiTPanel5.Controls.Add(this.label5);
            this.wiLBiTPanel5.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel5.Location = new System.Drawing.Point(15, 3);
            this.wiLBiTPanel5.Name = "wiLBiTPanel5";
            this.wiLBiTPanel5.Size = new System.Drawing.Size(295, 33);
            this.wiLBiTPanel5.TabIndex = 3;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(337, 116);
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
            this.gMapControl.Size = new System.Drawing.Size(695, 383);
            this.gMapControl.TabIndex = 7;
            this.gMapControl.Zoom = 0D;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMembers.ForeColor = System.Drawing.Color.Black;
            this.lblMembers.Location = new System.Drawing.Point(3, 28);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(137, 28);
            this.lblMembers.TabIndex = 7;
            this.lblMembers.Text = "1 / 20";
            this.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney.ForeColor = System.Drawing.Color.Black;
            this.lblMoney.Location = new System.Drawing.Point(146, 28);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(225, 28);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "3000 $";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFleet
            // 
            this.lblFleet.AutoSize = true;
            this.lblFleet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFleet.ForeColor = System.Drawing.Color.Black;
            this.lblFleet.Location = new System.Drawing.Point(377, 28);
            this.lblFleet.Name = "lblFleet";
            this.lblFleet.Size = new System.Drawing.Size(446, 28);
            this.lblFleet.TabIndex = 5;
            this.lblFleet.Text = "B737";
            this.lblFleet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeadquarter
            // 
            this.lblHeadquarter.AutoSize = true;
            this.lblHeadquarter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeadquarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeadquarter.ForeColor = System.Drawing.Color.Black;
            this.lblHeadquarter.Location = new System.Drawing.Point(829, 28);
            this.lblHeadquarter.Name = "lblHeadquarter";
            this.lblHeadquarter.Size = new System.Drawing.Size(176, 28);
            this.lblHeadquarter.TabIndex = 4;
            this.lblHeadquarter.Text = "LKPR";
            this.lblHeadquarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(829, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Headquarter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(377, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fleet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(146, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Money";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18651F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.91667F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.84127F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.95635F));
            this.tableLayoutPanel.Controls.Add(this.lblMembers, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblMoney, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblFleet, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblHeadquarter, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(22, 42);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1008, 56);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // wiLBiTPanel1
            // 
            this.wiLBiTPanel1.BackColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel1.BorderRadius = 20;
            this.wiLBiTPanel1.BorderSize = 0;
            this.wiLBiTPanel1.Controls.Add(this.wiLBiTPanel2);
            this.wiLBiTPanel1.Controls.Add(this.tableLayoutPanel);
            this.wiLBiTPanel1.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.Location = new System.Drawing.Point(2, 3);
            this.wiLBiTPanel1.Name = "wiLBiTPanel1";
            this.wiLBiTPanel1.Size = new System.Drawing.Size(1047, 101);
            this.wiLBiTPanel1.TabIndex = 4;
            // 
            // panelMembers
            // 
            this.panelMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMembers.BackColor = System.Drawing.Color.White;
            this.panelMembers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelMembers.BorderRadius = 20;
            this.panelMembers.BorderSize = 0;
            this.panelMembers.Controls.Add(this.FlowRow);
            this.panelMembers.Controls.Add(this.wiLBiTPanel5);
            this.panelMembers.ForeColor = System.Drawing.Color.Black;
            this.panelMembers.Location = new System.Drawing.Point(3, 110);
            this.panelMembers.Name = "panelMembers";
            this.panelMembers.Size = new System.Drawing.Size(328, 542);
            this.panelMembers.TabIndex = 5;
            // 
            // FlowRow
            // 
            this.FlowRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowRow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowRow.Location = new System.Drawing.Point(15, 39);
            this.FlowRow.Name = "FlowRow";
            this.FlowRow.Size = new System.Drawing.Size(295, 495);
            this.FlowRow.TabIndex = 4;
            // 
            // wiLBiTPanel4
            // 
            this.wiLBiTPanel4.BackColor = System.Drawing.Color.White;
            this.wiLBiTPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel4.BorderRadius = 20;
            this.wiLBiTPanel4.BorderSize = 0;
            this.wiLBiTPanel4.Controls.Add(this.cbFleet);
            this.wiLBiTPanel4.Controls.Add(this.lblDestination);
            this.wiLBiTPanel4.Controls.Add(this.tbFlightUsername);
            this.wiLBiTPanel4.Controls.Add(this.btnCopyFlight);
            this.wiLBiTPanel4.Controls.Add(this.label7);
            this.wiLBiTPanel4.Controls.Add(this.btnGenerateFlight);
            this.wiLBiTPanel4.Controls.Add(this.lblGenerateFlight);
            this.wiLBiTPanel4.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel4.Location = new System.Drawing.Point(337, 505);
            this.wiLBiTPanel4.Name = "wiLBiTPanel4";
            this.wiLBiTPanel4.Size = new System.Drawing.Size(709, 147);
            this.wiLBiTPanel4.TabIndex = 6;
            // 
            // cbFleet
            // 
            this.cbFleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFleet.FormattingEnabled = true;
            this.cbFleet.Location = new System.Drawing.Point(313, 25);
            this.cbFleet.Name = "cbFleet";
            this.cbFleet.Size = new System.Drawing.Size(169, 28);
            this.cbFleet.TabIndex = 15;
            this.cbFleet.Text = "--Select airplane--";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDestination.ForeColor = System.Drawing.Color.Black;
            this.lblDestination.Location = new System.Drawing.Point(228, 24);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(0, 29);
            this.lblDestination.TabIndex = 14;
            // 
            // tbFlightUsername
            // 
            this.tbFlightUsername.BackColor = System.Drawing.SystemColors.Window;
            this.tbFlightUsername.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbFlightUsername.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.tbFlightUsername.BorderRadius = 4;
            this.tbFlightUsername.BorderSize = 2;
            this.tbFlightUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFlightUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFlightUsername.Location = new System.Drawing.Point(309, 87);
            this.tbFlightUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbFlightUsername.Multiline = false;
            this.tbFlightUsername.Name = "tbFlightUsername";
            this.tbFlightUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbFlightUsername.PasswordChar = false;
            this.tbFlightUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbFlightUsername.PlaceholderText = "Username";
            this.tbFlightUsername.Size = new System.Drawing.Size(173, 44);
            this.tbFlightUsername.TabIndex = 13;
            this.tbFlightUsername.Texts = "";
            this.tbFlightUsername.UnderlinedStyle = false;
            // 
            // btnCopyFlight
            // 
            this.btnCopyFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCopyFlight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCopyFlight.BorderRadius = 10;
            this.btnCopyFlight.BorderSize = 0;
            this.btnCopyFlight.FlatAppearance.BorderSize = 0;
            this.btnCopyFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCopyFlight.ForeColor = System.Drawing.Color.White;
            this.btnCopyFlight.Location = new System.Drawing.Point(531, 81);
            this.btnCopyFlight.Name = "btnCopyFlight";
            this.btnCopyFlight.Size = new System.Drawing.Size(164, 50);
            this.btnCopyFlight.TabIndex = 12;
            this.btnCopyFlight.Text = "Copy flight";
            this.btnCopyFlight.UseVisualStyleBackColor = false;
            this.btnCopyFlight.Click += new System.EventHandler(this.btnCopyFlight_Click);
            this.btnCopyFlight.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCopyFlight.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fly with your colleague:";
            // 
            // btnGenerateFlight
            // 
            this.btnGenerateFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnGenerateFlight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnGenerateFlight.BorderRadius = 10;
            this.btnGenerateFlight.BorderSize = 0;
            this.btnGenerateFlight.FlatAppearance.BorderSize = 0;
            this.btnGenerateFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerateFlight.ForeColor = System.Drawing.Color.White;
            this.btnGenerateFlight.Location = new System.Drawing.Point(531, 16);
            this.btnGenerateFlight.Name = "btnGenerateFlight";
            this.btnGenerateFlight.Size = new System.Drawing.Size(164, 50);
            this.btnGenerateFlight.TabIndex = 10;
            this.btnGenerateFlight.Text = "Generate flight";
            this.btnGenerateFlight.UseVisualStyleBackColor = false;
            this.btnGenerateFlight.Click += new System.EventHandler(this.btnGenerateFlight_Click);
            this.btnGenerateFlight.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnGenerateFlight.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // lblGenerateFlight
            // 
            this.lblGenerateFlight.AutoSize = true;
            this.lblGenerateFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGenerateFlight.ForeColor = System.Drawing.Color.Black;
            this.lblGenerateFlight.Location = new System.Drawing.Point(14, 24);
            this.lblGenerateFlight.Name = "lblGenerateFlight";
            this.lblGenerateFlight.Size = new System.Drawing.Size(228, 29);
            this.lblGenerateFlight.TabIndex = 9;
            this.lblGenerateFlight.Text = "Generate flight to: ";
            // 
            // wiLBiTPanel2
            // 
            this.wiLBiTPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.wiLBiTPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel2.BorderRadius = 10;
            this.wiLBiTPanel2.BorderSize = 0;
            this.wiLBiTPanel2.Controls.Add(this.tableLayoutPanel1);
            this.wiLBiTPanel2.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel2.Location = new System.Drawing.Point(197, 3);
            this.wiLBiTPanel2.Name = "wiLBiTPanel2";
            this.wiLBiTPanel2.Size = new System.Drawing.Size(656, 39);
            this.wiLBiTPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblAirlineName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 33);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblAirlineName
            // 
            this.lblAirlineName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAirlineName.AutoSize = true;
            this.lblAirlineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAirlineName.Location = new System.Drawing.Point(3, 0);
            this.lblAirlineName.Name = "lblAirlineName";
            this.lblAirlineName.Size = new System.Drawing.Size(625, 33);
            this.lblAirlineName.TabIndex = 0;
            this.lblAirlineName.Text = "Airline name";
            this.lblAirlineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirlinePilot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.wiLBiTPanel4);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.wiLBiTPanel1);
            this.Controls.Add(this.panelMembers);
            this.MaximumSize = new System.Drawing.Size(1050, 655);
            this.MinimumSize = new System.Drawing.Size(1050, 655);
            this.Name = "AirlinePilot";
            this.Size = new System.Drawing.Size(1050, 655);
            this.Load += new System.EventHandler(this.AirlinePilot_Load);
            this.wiLBiTPanel5.ResumeLayout(false);
            this.wiLBiTPanel5.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.wiLBiTPanel1.ResumeLayout(false);
            this.panelMembers.ResumeLayout(false);
            this.wiLBiTPanel4.ResumeLayout(false);
            this.wiLBiTPanel4.PerformLayout();
            this.wiLBiTPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private WiLBiT.WiLBiTPanel wiLBiTPanel5;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblFleet;
        private System.Windows.Forms.Label lblHeadquarter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private WiLBiT.WiLBiTPanel wiLBiTPanel1;
        private WiLBiT.WiLBiTPanel panelMembers;
        private System.Windows.Forms.FlowLayoutPanel FlowRow;
        private WiLBiT.WiLBiTPanel wiLBiTPanel4;
        private System.Windows.Forms.ComboBox cbFleet;
        private System.Windows.Forms.Label lblDestination;
        private WiLBiT.WiLBiTTextBox tbFlightUsername;
        private WiLBiT.WiLBiTButton btnCopyFlight;
        private System.Windows.Forms.Label label7;
        private WiLBiT.WiLBiTButton btnGenerateFlight;
        private System.Windows.Forms.Label lblGenerateFlight;
        private WiLBiT.WiLBiTPanel wiLBiTPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAirlineName;
    }
}
