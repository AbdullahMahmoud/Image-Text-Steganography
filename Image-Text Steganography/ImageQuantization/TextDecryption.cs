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
    public partial class TextDecryption : Form
    {
        private bool fileSelected;
        private string FileName;
        public TextDecryption()
        {
            InitializeComponent();
            fileSelected = false;
        }

        private void btnTextEncryption_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileSelected = true;
                FileName = openFileDialog1.FileName.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileSelected)
            {
                char [] SecretMessage =new char[200];
                SecretMessage[0] = 'A';

                MessageBox.Show(FileName + "  " + FileName.Length.ToString());
                SecretMessage = Assembly.Decrypts(FileName, FileName.Length, SecretMessage);
                richTextBox1.Text = SecretMessage.ToString();
                
                for(int i=0  ;i<200  ; i++)
                {
                    MessageBox.Show(SecretMessage[i].ToString());
                }
            }
            else
                MessageBox.Show("Please Enter Image Text File");

        }
    }
}
