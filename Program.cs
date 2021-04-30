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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[assembly: AssemblyTitle("AeroShotCRE")]
[assembly: AssemblyProduct("AeroShotCRE")]
[assembly: AssemblyDescription("Screenshot capture utility for Windows Aero")]
[assembly: AssemblyCopyright("\u00a9 2021 Cvolton")]
[assembly: AssemblyVersion("1.8.1.0")]
[assembly: AssemblyFileVersion("1.8.1.0")]
[assembly: ComVisible(false)]

namespace AeroShot
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            /*if (Environment.OSVersion.Version.Major < 6)
            {
                MessageBox.Show("Windows Vista or newer is required.", Application.ProductName);
                return;
            }*/

			bool isFirstInstance;

            // set if truly first instance:
            var mutex = new System.Threading.Mutex(true, "AeroShot", out isFirstInstance);

            if (!isFirstInstance)
            {
                return;
			}
			//temporary workaround - we need to lose focus for inactive screenshot captures to work
			MessageBox.Show("Press OK to start the application", Application.ProductName);

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SysTray());
            GC.KeepAlive(mutex);
        }
    }
}