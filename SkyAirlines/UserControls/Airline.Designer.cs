namespace SkyAirlines
{
    partial class Airline
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
            this.btnCreateOwnAirline = new WiLBiT.WiLBiTButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Headquater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Join = new System.Windows.Forms.DataGridViewButtonColumn();
            this.wiLBiTPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // wiLBiTPanel1
            // 
            this.wiLBiTPanel1.BackColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wiLBiTPanel1.BorderRadius = 20;
            this.wiLBiTPanel1.BorderSize = 0;
            this.wiLBiTPanel1.Controls.Add(this.btnCreateOwnAirline);
            this.wiLBiTPanel1.Controls.Add(this.label2);
            this.wiLBiTPanel1.Controls.Add(this.label1);
            this.wiLBiTPanel1.ForeColor = System.Drawing.Color.White;
            this.wiLBiTPanel1.Location = new System.Drawing.Point(15, 532);
            this.wiLBiTPanel1.Name = "wiLBiTPanel1";
            this.wiLBiTPanel1.Size = new System.Drawing.Size(1019, 104);
            this.wiLBiTPanel1.TabIndex = 0;
            // 
            // btnCreateOwnAirline
            // 
            this.btnCreateOwnAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCreateOwnAirline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(82)))));
            this.btnCreateOwnAirline.BorderRadius = 10;
            this.btnCreateOwnAirline.BorderSize = 0;
            this.btnCreateOwnAirline.FlatAppearance.BorderSize = 0;
            this.btnCreateOwnAirline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOwnAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateOwnAirline.ForeColor = System.Drawing.Color.White;
            this.btnCreateOwnAirline.Location = new System.Drawing.Point(774, 10);
            this.btnCreateOwnAirline.Name = "btnCreateOwnAirline";
            this.btnCreateOwnAirline.Size = new System.Drawing.Size(198, 84);
            this.btnCreateOwnAirline.TabIndex = 3;
            this.btnCreateOwnAirline.Text = "Create your own airline";
            this.btnCreateOwnAirline.UseVisualStyleBackColor = false;
            this.btnCreateOwnAirline.MouseEnter += new System.EventHandler(this.btnCreateOwnAirline_MouseEnter);
            this.btnCreateOwnAirline.MouseLeave += new System.EventHandler(this.btnCreateOwnAirline_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "and manage it?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to create your own airline";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Logo,
            this.Name,
            this.Headquater,
            this.Members,
            this.MoreInformation,
            this.Join});
            this.dataGridView.Location = new System.Drawing.Point(15, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1019, 509);
            this.dataGridView.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.HeaderText = "Logo";
            this.Logo.MinimumWidth = 6;
            this.Logo.Name = "Logo";
            this.Logo.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Headquater
            // 
            this.Headquater.HeaderText = "Headquater";
            this.Headquater.MinimumWidth = 6;
            this.Headquater.Name = "Headquater";
            this.Headquater.Width = 125;
            // 
            // Members
            // 
            this.Members.HeaderText = "Members";
            this.Members.MinimumWidth = 6;
            this.Members.Name = "Members";
            this.Members.Width = 125;
            // 
            // MoreInformation
            // 
            this.MoreInformation.HeaderText = "More information";
            this.MoreInformation.MinimumWidth = 6;
            this.MoreInformation.Name = "MoreInformation";
            this.MoreInformation.Width = 125;
            // 
            // Join
            // 
            this.Join.HeaderText = "Join";
            this.Join.MinimumWidth = 6;
            this.Join.Name = "Join";
            this.Join.Width = 125;
            // 
            // Airline
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.wiLBiTPanel1);
            this.MaximumSize = new System.Drawing.Size(1050, 655);
            this.MinimumSize = new System.Drawing.Size(1050, 655);
            this.Name = "Airline";
            this.Size = new System.Drawing.Size(1050, 655);
            this.wiLBiTPanel1.ResumeLayout(false);
            this.wiLBiTPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel wiLBiTPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WiLBiT.WiLBiTButton btnCreateOwnAirline;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Headquater;
        private System.Windows.Forms.DataGridViewTextBoxColumn Members;
        private System.Windows.Forms.DataGridViewButtonColumn MoreInformation;
        private System.Windows.Forms.DataGridViewButtonColumn Join;
    }
}
