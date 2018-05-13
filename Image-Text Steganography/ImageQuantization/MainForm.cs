using Image_Viewer_Main_Idea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageQuantization
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnImageViewer_Click(object sender, EventArgs e)
        {
            Form1 ImageViewerForm = new Form1();
            ImageViewerForm.Show();
        }

        private void btntexthiding_Click(object sender, EventArgs e)
        {
            TextHiding TextHidingForm = new TextHiding();
            TextHidingForm.Show();
        }
    }
}