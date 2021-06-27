/*  AeroShot - Transparent screenshot utility for Windows
    Copyright (C) 2021 Cvolton
    Copyright (C) 2015 toe_head2001
    Copyright (C) 2012 Caleb Joseph

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
using System.Diagnostics;
using System.Text;
using Microsoft.Win32;

namespace AeroShot
{
    public class Settings
    {
        public bool firstRun;
        public string folderTextBox;
        public bool aeroColorCheckbox;
        public string aeroColorHexBox;
        public bool resizeCheckbox;
        public bool canvasSizeCheckbox;
        public int windowHeight = 480;
        public int windowWidth = 640;
        public int canvasHeight = 720;
        public int canvasWidth = 1280;
        public bool diskButton;
        public bool clipboardButton;
        public bool mouseCheckbox;
        public bool delayCheckbox;
        public byte delaySeconds = 3;
        public bool clearTypeCheckbox;
        public bool shadowCheckbox;
        public bool saveActiveDarkCheckbox;
        public bool saveActiveLightCheckbox;
        public bool saveInactiveDarkCheckbox;
        public bool saveInactiveLightCheckbox;
        public bool saveMaskCheckbox;
        public bool saveActiveTransparentCheckbox;
        public bool saveInactiveTransparentCheckbox;
        public bool optimizeVistaCheckbox;
        private readonly RegistryKey _registryKey;

        bool AeroGlassForWin8IsRunning()
        {
            return Process.GetProcessesByName("aerohost").Length > 0;
        }

        bool HasAeroAfterglow()
        {
            return (Environment.OSVersion.Version.Build >= 6730 && Environment.OSVersion.Version.Build < 8432) || AeroGlassForWin8IsRunning();
        }

        bool HasAeroTransparency()
        {
            return (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Build < 8432) || AeroGlassForWin8IsRunning();
        }

        public Settings()
        {
            object value;
            _registryKey = Registry.CurrentUser.CreateSubKey(@"Software\AeroShot");

            if ((value = _registryKey.GetValue("FirstRun")) == null)
            {
                firstRun = true;
            }


            if ((value = _registryKey.GetValue("LastPath")) != null && value.GetType() == (typeof(string)))
            {
                if (((string)value).Substring(0, 1) == "*")
                {
                    folderTextBox = ((string)value).Substring(1);
                    clipboardButton = true;
                }
                else
                {
                    folderTextBox = (string)value;
                    diskButton = true;
                }
            }
            else
            {
                folderTextBox =
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            if ((value = _registryKey.GetValue("WindowSize")) != null && value.GetType() == (typeof(long)))
            {
                var b = new byte[8];
                for (int i = 0; i < 8; i++)
                    b[i] = (byte)(((long)value >> (i * 8)) & 0xff);
                resizeCheckbox = (b[0] & 1) == 1;
                windowWidth = b[1] << 16 | b[2] << 8 | b[3];
                windowHeight = b[4] << 16 | b[5] << 8 | b[6];
            }

            if ((value = _registryKey.GetValue("CanvasSize")) != null && value.GetType() == (typeof(long)))
            {
                var b = new byte[8];
                for (int i = 0; i < 8; i++)
                    b[i] = (byte)(((long)value >> (i * 8)) & 0xff);
                canvasSizeCheckbox = (b[0] & 1) == 1;
                canvasWidth = b[1] << 16 | b[2] << 8 | b[3];
                canvasHeight = b[4] << 16 | b[5] << 8 | b[6];
            }

            if ((value = _registryKey.GetValue("AeroColor")) != null && value.GetType() == (typeof(long)))
            {
                var b = new byte[8];
                for (int i = 0; i < 8; i++)
                    b[i] = (byte)(((long)value >> (i * 8)) & 0xff);
                aeroColorCheckbox = (b[0] & 1) == 1;

                var hex = new StringBuilder(6);
                hex.AppendFormat("{0:X2}", b[1]);
                hex.AppendFormat("{0:X2}", b[2]);
                hex.AppendFormat("{0:X2}", b[3]);
                aeroColorHexBox = hex.ToString();
            }
            /*else
                opaqueType = 0;*/

            if ((value = _registryKey.GetValue("CapturePointer")) != null && value.GetType() == (typeof(int)))
                mouseCheckbox = ((int)value & 1) == 1;

            if ((value = _registryKey.GetValue("ClearType")) != null && value.GetType() == (typeof(int)))
                clearTypeCheckbox = ((int)value & 1) == 1;

            if ((value = _registryKey.GetValue("Shadow")) != null && value.GetType() == (typeof(int)))
                shadowCheckbox = ((int)value & 1) == 1;

            if ((value = _registryKey.GetValue("SaveActiveDark")) != null && value.GetType() == (typeof(int)))
                saveActiveDarkCheckbox = ((int)value & 1) == 1;
            else
                saveActiveDarkCheckbox = true;

            if ((value = _registryKey.GetValue("SaveActiveLight")) != null && value.GetType() == (typeof(int)))
                saveActiveLightCheckbox = ((int)value & 1) == 1;
            else
                saveActiveLightCheckbox = HasAeroAfterglow();

            if ((value = _registryKey.GetValue("SaveInactiveDark")) != null && value.GetType() == (typeof(int)))
                saveInactiveDarkCheckbox = ((int)value & 1) == 1;
            else
                saveInactiveDarkCheckbox = true;

            if ((value = _registryKey.GetValue("SaveInactiveLight")) != null && value.GetType() == (typeof(int)))
                saveInactiveLightCheckbox = ((int)value & 1) == 1;
            else
                saveInactiveLightCheckbox = HasAeroAfterglow();

            if ((value = _registryKey.GetValue("SaveMask")) != null && value.GetType() == (typeof(int)))
                saveMaskCheckbox = ((int)value & 1) == 1;
            else
                saveMaskCheckbox = HasAeroTransparency();

            if ((value = _registryKey.GetValue("SaveActiveTransparent")) != null && value.GetType() == (typeof(int)))
                saveActiveTransparentCheckbox = ((int)value & 1) == 1;
            else
                saveActiveTransparentCheckbox = HasAeroAfterglow();

            if ((value = _registryKey.GetValue("SaveInactiveTransparent")) != null && value.GetType() == (typeof(int)))
                saveInactiveTransparentCheckbox = ((int)value & 1) == 1;
            else
                saveInactiveTransparentCheckbox = HasAeroAfterglow();

            if ((value = _registryKey.GetValue("OptimizeVista")) != null && value.GetType() == (typeof(int)))
                optimizeVistaCheckbox = ((int)value & 1) == 1;
            else
                optimizeVistaCheckbox = (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 0) ? true : false;

            if ((value = _registryKey.GetValue("Delay")) != null && value.GetType() == (typeof(long)))
            {
                var b = new byte[8];
                for (int i = 0; i < 8; i++)
                    b[i] = (byte)(((long)value >> (i * 8)) & 0xff);
                delayCheckbox = (b[0] & 1) == 1;
                delaySeconds = b[1];
            }
        }
    }
}