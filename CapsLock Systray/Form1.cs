using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapsLock_Systray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                if (Control.ModifierKeys == Keys.Shift)
                {
                    systrayIcon.Text = "CapsLock Status: OFF";
                    systrayIcon.Icon = CapsLock_Systray.Properties.Resources.capslock_off;
                }
                else
                {
                    systrayIcon.Text = "CapsLock Status: ON";
                    systrayIcon.Icon = CapsLock_Systray.Properties.Resources.capslock_on;
                }
            else
                if (Control.ModifierKeys != Keys.Shift)
                {
                    systrayIcon.Text = "CapsLock Status: OFF";
                    systrayIcon.Icon = CapsLock_Systray.Properties.Resources.capslock_off;
                }
                else
                {
                    systrayIcon.Text = "CapsLock Status: ON";
                    systrayIcon.Icon = CapsLock_Systray.Properties.Resources.capslock_on;
                }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
