using System;
using System.Windows.Forms;

namespace CapsLock_Systray
{
	public partial class Frm_CapsLockSystray : Form
	{
		public Frm_CapsLockSystray()
		{
			InitializeComponent();
		}

		private void Timer_Tick( Object sender, EventArgs e )
		{
			if( IsKeyLocked( Keys.CapsLock ) )
			{
				if( ModifierKeys == Keys.Shift )
				{
					Ico_Systray.Text = "CapsLock Status: OFF";
					Ico_Systray.Icon = Properties.Resources.capslock_off;
				}
				else
				{
					Ico_Systray.Text = "CapsLock Status: ON";
					Ico_Systray.Icon = Properties.Resources.capslock_on;
				}
			}
			else
			{
				if( ModifierKeys != Keys.Shift )
				{
					Ico_Systray.Text = "CapsLock Status: OFF";
					Ico_Systray.Icon = Properties.Resources.capslock_off;
				}
				else
				{
					Ico_Systray.Text = "CapsLock Status: ON";
					Ico_Systray.Icon = Properties.Resources.capslock_on;
				}
			}
		}

		private void TSMI_Exit_Click( Object sender, EventArgs e )
		{
			Close();
		}

		private void Frm_CapsLockSystray_VisibleChanged( Object sender, EventArgs e )
		{
			Hide();
		}
	}
}
