using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageQuantization
{
    public partial class TextHiding : Form
    {
        public TextHiding()
        {
            InitializeComponent();
        }

        private void btnTextEncryption_Click(object sender, EventArgs e)
        {
            Text_Encryption obj = new Text_Encryption();
            obj.Show();
        }

        private void btntextDecryption_Click(object sender, EventArgs e)
        {
            TextDecryption obj = new TextDecryption();
            obj.Show();
        }
    }
}
