namespace SkyAirlines
{
    partial class ChangeDiscordLink
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
            this.panelUdaje = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiscordLink = new System.Windows.Forms.TextBox();
            this.btnChangeDiscordLink = new WiLBiT.WiLBiTButton();
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
            this.panelUdaje.Controls.Add(this.label2);
            this.panelUdaje.Controls.Add(this.tbDiscordLink);
            this.panelUdaje.Controls.Add(this.btnChangeDiscordLink);
            this.panelUdaje.Controls.Add(this.label1);
            this.panelUdaje.Controls.Add(this.panel1);
            this.panelUdaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUdaje.Location = new System.Drawing.Point(0, 0);
            this.panelUdaje.Name = "panelUdaje";
            this.panelUdaje.Size = new System.Drawing.Size(605, 312);
            this.panelUdaje.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Set it to be unlimited. \r\nIf you want to remove the link, leave the box empty.";
            // 
            // tbDiscordLink
            // 
            this.tbDiscordLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDiscordLink.Location = new System.Drawing.Point(124, 145);
            this.tbDiscordLink.Name = "tbDiscordLink";
            this.tbDiscordLink.Size = new System.Drawing.Size(357, 32);
            this.tbDiscordLink.TabIndex = 11;
            // 
            // btnChangeDiscordLink
            // 
            this.btnChangeDiscordLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnChangeDiscordLink.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnChangeDiscordLink.BorderRadius = 20;
            this.btnChangeDiscordLink.BorderSize = 1;
            this.btnChangeDiscordLink.FlatAppearance.BorderSize = 0;
            this.btnChangeDiscordLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDiscordLink.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeDiscordLink.ForeColor = System.Drawing.Color.White;
            this.btnChangeDiscordLink.Location = new System.Drawing.Point(170, 206);
            this.btnChangeDiscordLink.Name = "btnChangeDiscordLink";
            this.btnChangeDiscordLink.Size = new System.Drawing.Size(264, 75);
            this.btnChangeDiscordLink.TabIndex = 6;
            this.btnChangeDiscordLink.Text = "Change discord link \r\n5000$\r\n";
            this.btnChangeDiscordLink.UseVisualStyleBackColor = false;
            this.btnChangeDiscordLink.Click += new System.EventHandler(this.btnChangeDiscordLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "New discord link";
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
            // ChangeDiscordLink
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(605, 312);
            this.Controls.Add(this.panelUdaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(605, 312);
            this.MinimumSize = new System.Drawing.Size(605, 312);
            this.Name = "ChangeDiscordLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeDiscordLink";
            this.panelUdaje.ResumeLayout(false);
            this.panelUdaje.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUdaje;
        private System.Windows.Forms.TextBox tbDiscordLink;
        private WiLBiT.WiLBiTButton btnChangeDiscordLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private WiLBiT.WiLBiTDragControl DragControl;
        private System.Windows.Forms.Label label2;
    }
}