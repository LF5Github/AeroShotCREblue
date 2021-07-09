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
    along with this program.  If not, see <http://www.gnu.org/licenses/>. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AeroShot
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            // set up icon
            Icon SysIcon = new Icon(typeof(About), "icon.ico");

            Icon = new Icon(SysIcon, 16, 16); 

        }

        private void AeroShotCREOKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
