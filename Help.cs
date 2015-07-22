/*
    Copyright 2015 Thomas DeBell (Kaisonic)

    This file is part of KeySAV2 - Kaisonic Edition.

    KeySAV2 - Kaisonic Edition is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    KeySAV2 - Kaisonic Edition is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keysav2kai
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            CB_HelpSelector.SelectedIndex = 0;
            loadHelp(null, null);
        }

        private static string[] topics = {
            "formatting",
            "howto",
            "howto_getsave",
            "howto_breaksave",
            "howto_getvideo",
            "howto_breakvideo",
            "howto_encrypted",
            "howto_decrypted",
            "howto_videos",
            "options",
            "about",
            "changelog"
        };
        
        private static Help inst;
        
        public static Help GetHelp
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Help();
                return inst;
            }
        }

        private void loadHelp(object sender, EventArgs e)
        {
            RTB_Help.Text = (string)Properties.Resources.ResourceManager.GetObject(topics[CB_HelpSelector.SelectedIndex]);
            return;
        }
        
        private void Link_Clicked (object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
           System.Diagnostics.Process.Start(e.LinkText);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
