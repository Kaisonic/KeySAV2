using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeySAV3
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
