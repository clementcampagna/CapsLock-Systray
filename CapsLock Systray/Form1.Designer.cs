namespace CapsLock_Systray
{
    partial class Frm_CapsLockSystray
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CapsLockSystray));
			this.Ico_Systray = new System.Windows.Forms.NotifyIcon(this.components);
			this.CMS_Systray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.CMS_Systray.SuspendLayout();
			this.SuspendLayout();
			// 
			// Ico_Systray
			// 
			this.Ico_Systray.ContextMenuStrip = this.CMS_Systray;
			this.Ico_Systray.Icon = ((System.Drawing.Icon)(resources.GetObject("Ico_Systray.Icon")));
			this.Ico_Systray.Text = "Please wait...";
			this.Ico_Systray.Visible = true;
			// 
			// CMS_Systray
			// 
			this.CMS_Systray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Exit});
			this.CMS_Systray.Name = "contextMenu";
			this.CMS_Systray.Size = new System.Drawing.Size(94, 26);
			// 
			// TSMI_Exit
			// 
			this.TSMI_Exit.Name = "TSMI_Exit";
			this.TSMI_Exit.Size = new System.Drawing.Size(93, 22);
			this.TSMI_Exit.Text = "Exit";
			this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click );
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// Frm_CapsLockSystray
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Frm_CapsLockSystray";
			this.Text = "CapsLock Systray";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.VisibleChanged += new System.EventHandler(this.Frm_CapsLockSystray_VisibleChanged );
			this.CMS_Systray.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Ico_Systray;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ContextMenuStrip CMS_Systray;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
    }
}

