using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageQuantization
{
    public partial class Text_Encryption : Form
    {
        private bool fileSelected;
        private string FileName;
        public Text_Encryption()
        {
            InitializeComponent();
            fileSelected = false;
        }

        private void btnTextEncryption_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileSelected = true;
                FileName = openFileDialog1.FileName.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileSelected)
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter The Secret Message");
                }
                else
                {
                    saveFileDialog1 = new SaveFileDialog();
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Assembly.Encrypts(FileName, FileName.Length, saveFileDialog1.FileName.ToString(), saveFileDialog1.FileName.ToString().Length, richTextBox1.Text.ToString(), richTextBox1.Text.ToString().Length);
                    }
                }
            }
            else
                MessageBox.Show("Please Enter Image Text File");
        }
    }
}
