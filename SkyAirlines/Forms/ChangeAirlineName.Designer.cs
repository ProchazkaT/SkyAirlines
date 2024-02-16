namespace SkyAirlines
{
    partial class ChangeAirlineName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAirlineName));
            this.panelUdaje = new System.Windows.Forms.Panel();
            this.tbAirlineName = new System.Windows.Forms.TextBox();
            this.btnChangeAirlineName = new WiLBiT.WiLBiTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.DragControl = new WiLBiT.WiLBiTDragControl();
            this.panelUdaje.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUdaje
            // 
            this.panelUdaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.panelUdaje.Controls.Add(this.tbAirlineName);
            this.panelUdaje.Controls.Add(this.btnChangeAirlineName);
            this.panelUdaje.Controls.Add(this.label1);
            this.panelUdaje.Controls.Add(this.panel1);
            this.panelUdaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUdaje.Location = new System.Drawing.Point(0, 0);
            this.panelUdaje.Name = "panelUdaje";
            this.panelUdaje.Size = new System.Drawing.Size(605, 312);
            this.panelUdaje.TabIndex = 1;
            // 
            // tbAirlineName
            // 
            this.tbAirlineName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAirlineName.Location = new System.Drawing.Point(124, 114);
            this.tbAirlineName.Name = "tbAirlineName";
            this.tbAirlineName.Size = new System.Drawing.Size(357, 32);
            this.tbAirlineName.TabIndex = 11;
            // 
            // btnChangeAirlineName
            // 
            this.btnChangeAirlineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnChangeAirlineName.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnChangeAirlineName.BorderRadius = 20;
            this.btnChangeAirlineName.BorderSize = 1;
            this.btnChangeAirlineName.FlatAppearance.BorderSize = 0;
            this.btnChangeAirlineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAirlineName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeAirlineName.ForeColor = System.Drawing.Color.White;
            this.btnChangeAirlineName.Location = new System.Drawing.Point(170, 186);
            this.btnChangeAirlineName.Name = "btnChangeAirlineName";
            this.btnChangeAirlineName.Size = new System.Drawing.Size(264, 75);
            this.btnChangeAirlineName.TabIndex = 6;
            this.btnChangeAirlineName.Text = "Change name\r\n5000$\r\n";
            this.btnChangeAirlineName.UseVisualStyleBackColor = false;
            this.btnChangeAirlineName.Click += new System.EventHandler(this.btnChangeAirlineName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "New airline name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 50);
            this.panel1.TabIndex = 0;
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
            // ChangeAirlineName
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(605, 312);
            this.Controls.Add(this.panelUdaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeAirlineName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeAirlineName";
            this.panelUdaje.ResumeLayout(false);
            this.panelUdaje.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUdaje;
        private System.Windows.Forms.TextBox tbAirlineName;
        private WiLBiT.WiLBiTButton btnChangeAirlineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private WiLBiT.WiLBiTDragControl DragControl;
    }
}