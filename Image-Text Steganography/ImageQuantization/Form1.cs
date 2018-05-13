using ImageQuantization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer_Main_Idea
{
    public partial class Form1 : Form
    {
        private RGBPixel[,] ImageMatrix;
        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openBitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);
            }
        }

        private void loadFromTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                int Width = Convert.ToInt32(sr.ReadLine());
                int Height = Convert.ToInt32(sr.ReadLine());
                ImageMatrix = new RGBPixel[Height, Width];
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        ImageMatrix[i, j].red = Convert.ToByte(sr.ReadLine());
                        ImageMatrix[i, j].green = Convert.ToByte(sr.ReadLine());
                        ImageMatrix[i, j].blue = Convert.ToByte(sr.ReadLine());
                    }
                }
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);
            }
        }

        private void asTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                int Width = ImageOperations.GetWidth(ImageMatrix);
                int Height = ImageOperations.GetHeight(ImageMatrix);
                sw.WriteLine(Width.ToString());
                sw.WriteLine(Height.ToString());
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        sw.WriteLine(ImageMatrix[i, j].red.ToString());
                        sw.WriteLine(ImageMatrix[i, j].green.ToString());
                        sw.WriteLine(ImageMatrix[i, j].blue.ToString());
                    }
                }
                sw.Close();
            }
        }

        private void asBitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int Width = ImageOperations.GetWidth(ImageMatrix);
                int Height = ImageOperations.GetHeight(ImageMatrix);
                Bitmap ImageBMP = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
                unsafe
                {
                    BitmapData bmd = ImageBMP.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, ImageBMP.PixelFormat);
                    int nWidth = 0;
                    nWidth = Width * 3;
                    int nOffset = bmd.Stride - nWidth;
                    byte* p = (byte*)bmd.Scan0;
                    for (int i = 0; i < Height; i++)
                    {
                        for (int j = 0; j < Width; j++)
                        {
                            p[2] = ImageMatrix[i, j].red;
                            p[1] = ImageMatrix[i, j].green;
                            p[0] = ImageMatrix[i, j].blue;
                            p += 3;
                        }

                        p += nOffset;
                    }
                    ImageBMP.UnlockBits(bmd);
                }
                ImageBMP.Save(saveFileDialog1.FileName  , ImageFormat.Png);
            }
        }
    }
}
