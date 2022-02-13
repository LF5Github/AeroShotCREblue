/*  AeroShot - Transparent screenshot utility for Windows
    Copyright (C) 2021 Cvolton, starfrost
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

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[assembly: AssemblyTitle("AeroShotCRE blue")]
[assembly: AssemblyProduct("AeroShotCRE blue")]
[assembly: AssemblyDescription("Screenshot capture utility for Windows Aero")]
[assembly: AssemblyCopyright("\u00a9 2022 Cvolton and LF5")]
[assembly: AssemblyVersion("1.9.5.0")]
[assembly: AssemblyFileVersion("1.9.5.0")]
[assembly: ComVisible(false)]

namespace AeroShot
{
    class Program : WindowsFormsApplicationBase
    {
        public Program()
        {
            EnableVisualStyles = true;
            MainForm = new SysTray();
            IsSingleInstance = true;
        }

        [STAThreadAttribute]
        public static void Main(string[] args)
        {
            Instance = new Program();
            Instance.Run(args);
        }

        public static void Restart()
        {
            Instance.IsSingleInstance = false;
            Application.Restart();
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            MessageBox.Show("An instance of AeroShot or AeroShotCRE is already running.\r\nPress Alt+PrtSc to take a screenshot.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static Program Instance;
    }
}