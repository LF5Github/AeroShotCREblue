/*  AeroShot - Transparent screenshot utility for Windows
    Copyright (C) 2021 Cvolton, starfrost
    Copyright (C) 2015 toe_head2001

    AeroShot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    AeroShot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace AeroShot
{
    public class SysTray : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        MainForm _window = new MainForm();
        Hotkeys _hotkeys = new Hotkeys();
        Settings _settings = new Settings();
        About _about = new About(); 

        public SysTray()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Text = "AeroShot CRE";

            Icon _trayIcon = new Icon(typeof(SysTray), "icon.ico");
            trayIcon.Icon = new Icon(_trayIcon, 16, 16);

            // Create a tray menu
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Settings...", ShowWindow);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("About", LoadAboutWindow);
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            // Handle the DoubleClick event to open the Settings window.
            trayIcon.DoubleClick += ShowWindow;
        }


        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);

            string saveLocation;
            if (_settings.diskButton)
            {
                saveLocation = "\"" + _settings.folderTextBox + "\"";
            }
            else
            {
                saveLocation = "the Clipboard";
            }
            trayIcon.ShowBalloonTip(10000, "Press Alt+PrtSrn to Capture Screenshots", "Screenshot will be saved to " + saveLocation + ".", ToolTipIcon.Info);
        }

        private void OnExit(object sender, EventArgs e)
        {
            _hotkeys.Close(); //unregisters the hotkeys on program exit
            Application.Exit();
        }

        private void ShowWindow(object sender, EventArgs e)
        {
            if (_window.IsDisposed)
            {
                _window = new MainForm();
                _window.Show();
            }
            else 
            {
                if (!_window.Visible)
                {
                    _window.Show();
                }
            }
            _window.Activate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }

            base.Dispose(disposing);
        }

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// SysTray
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Name = "SysTray";
			this.ResumeLayout(false);

		}

        /// <summary>
        /// Launches the About Window. Parameters disregarded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadAboutWindow(object sender, EventArgs e)
        {
            // check if we got killed or it's been previously closed
            if (_about.IsDisposed)
            {
                _about = new About();
            }

            if (!_about.Visible) _about.Show();

            _about.Activate(); 
        }
        
	}
}