using SkyAirlines.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace SkyAirlines.Forms
{
    public partial class RegisterForm : Form
    {
        private Register register = new Register();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            register.RegisterPilot(tbUsername.Text, tbPassword.Text, tbEmail.Text);
            this.Hide();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            WiLBiTButton btn;
            btn = (WiLBiTButton)sender;
            btn.BorderSize = 3;
            btn.BackColor = Color.FromArgb(16, 47, 82);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            WiLBiTButton btn;
            btn = (WiLBiTButton)sender;
            btn.BorderSize = 1;
            btn.BackColor = Color.FromArgb(16, 47, 82);
        }

        private void linkLblHaveAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm form = new LogInForm();
            form.Show();
            this.Hide();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
