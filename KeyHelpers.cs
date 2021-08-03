using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AeroShot
{
	static class KeyHelpers
	{
        //TODO: localized key names
		public static string[] modifiers = { "", "Alt", "Ctrl", "Ctrl + Alt", "Shift", "Alt + Shift", "Ctrl + Shift", "Ctrl + Alt + Shift" };
        //TODO: is there no better way to implement this?
        public static Dictionary<Keys, int> modifierCodes = new Dictionary<Keys, int> {
                { Keys.Alt, 1 },
                { Keys.Control, 2 },
                { Keys.Alt ^ Keys.Control, 3 },
                { Keys.Shift, 4 },
                { Keys.Alt ^ Keys.Shift, 5 },
                { Keys.Shift ^ Keys.Control, 6 },
                { Keys.Alt ^ Keys.Shift ^ Keys.Control, 7}
            };
    }
}
