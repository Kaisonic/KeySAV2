using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeySAV2
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        
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
