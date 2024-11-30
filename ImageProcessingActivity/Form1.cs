using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ImageProcessingActivity
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed, imageA, imageB, colorgreen, coinpic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dIPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
                pictureBox2.Image = processed;
            }
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int ave, tr, tg, tb;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    tr = (int)((0.393 * pixel.R) + (0.769 * pixel.G) + (0.189 * pixel.B));
                    tg = (int)((0.349 * pixel.R) + (0.686 * pixel.G) + (0.168 * pixel.B));
                    tb = (int)((0.272 * pixel.R) + (0.534 * pixel.G) + (0.131 * pixel.B));
                    tr = Math.Min(255, tr);
                    tg = Math.Min(255, tg);
                    tb = Math.Min(255, tb);
                    Color sepia = Color.FromArgb(tr, tg, tb);
                    processed.SetPixel(x, y, sepia);
                }
                pictureBox2.Image = processed;
            }
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int ave;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    ave = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(ave, ave, ave);
                    processed.SetPixel(x, y, gray);
                }
                pictureBox2.Image = processed;
            }
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int ave;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, inv);
                }
                pictureBox2.Image = processed;
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            Color gray;
            int ave;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    ave = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    gray = Color.FromArgb(ave, ave, ave);
                    loaded.SetPixel(x, y, gray);
                }
            }
            int[] histdata = new int[256];
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    histdata[pixel.R]++;
                }
            }
            processed = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    processed.SetPixel(x, y, Color.Gainsboro);
                }
            }
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, processed.Height - 1); y++)
                {
                    processed.SetPixel(x, (processed.Height - 1) - y, Color.Black);
                }
            }
            pictureBox2.Image = processed;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void greenScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
            pictureBox3.Image = imageB;
        }

        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
            pictureBox4.Image = imageA;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gscreen();
            pictureBox5.Image = processed;
        }

        private void gscreen()
        {
            processed = new Bitmap(imageB.Width, imageB.Height);
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue < threshold)
                    {
                        processed.SetPixel(x, y, backpixel);
                    }
                    else
                    {
                        processed.SetPixel(x, y, pixel);
                    }
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog4_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            coinpic = new Bitmap(openFileDialog4.FileName);
            pictureBox6.Image = coinpic;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loaded = (Bitmap)pictureBox6.Image.Clone();
            processed = (Bitmap)loaded.Clone();
            for (int i = 10; i != 0; --i)
            {
                ImageProcess2.BitmapFilter.GaussianBlur(processed, 3);
                ImageProcess2.BitmapFilter.Contrast(processed, 100);
            }
            int x = 0;
            int y = 0;
            Color px;
            for (x = processed.Width - 1; x >= 0; --x)
            {
                for (y = processed.Height - 1; y >= 0; --y)
                {
                    px = processed.GetPixel(x, y);
                    int r = 0;
                    if (px.R < 120) r = 1;
                    processed.SetPixel(x, y, Color.FromArgb(255, r, 0, 0));
                }
            }
            List<int> areas = new List<int>();
            int count = 0;
            for (x = 0; x < processed.Width; x++)
            {
                for (y = 0; y < processed.Height; y++)
                {
                    px = processed.GetPixel(x, y);
                    if (px.R == 1 && px.B == 0)
                    {
                        int area = dfsCoin(processed, x, y);
                        areas.Add(area);
                    }
                }
            }
            int[] coins = { 0, 0, 0, 0, 0 };
            foreach (int area in areas)
            {
                if (area < 2900)
                    coins[0]++;
                else if (area < 4000)
                    coins[1]++;
                else if (area < 5000)
                    coins[2]++;
                else if (area < 7000)
                    coins[3]++;
                else
                    coins[4]++;
            }

            richTextBox1.Text += ($"COUNTS:\n");

            richTextBox1.Text += ($"5 cents:{coins[0]}\n");
            richTextBox1.Text += ($"10 cents:{coins[1]}\n");
            richTextBox1.Text += ($"25 cents:{coins[2]}\n");
            richTextBox1.Text += ($"1 peso:{coins[3]}\n");
            richTextBox1.Text += ($"5 peso:{coins[4]}\n\n");

            richTextBox1.Text += ($"VALUES:\n");

            richTextBox1.Text += ($"5 cents:{coins[0] * 0.05}\n");
            richTextBox1.Text += ($"10 cents:{coins[1] * 0.10}\n");
            richTextBox1.Text += ($"25 cents:{coins[2] * 0.25}\n");
            richTextBox1.Text += ($"1 peso:{coins[3] * 1.00}\n");
            richTextBox1.Text += ($"5 peso:{coins[4] * 5.00}\n\n");

            richTextBox1.Text += ($"TOTAL VALUE: {coins[0] * 0.05 + coins[1] * 0.10 + coins[2] * 0.25 + coins[3] * 1.00 + coins[4] * 5.00}\n");

        }
        private int dfsCoin(Bitmap b, int x, int y)
        {
            int count = 0;
            int dx, dy, i;
            Tuple<int, int> pos;
            Stack<Tuple<int, int>> fringe = new Stack<Tuple<int, int>>();
            int[,] dir = { { 0, -1 }, { 0, 1 }, { -1, 0 }, { 1, 0 } };
            fringe.Push(Tuple.Create(x, y));
            while (fringe.Count > 0)
            {
                pos = fringe.Pop();
                x = pos.Item1;
                y = pos.Item2;
                count += visit(x, y);
                for (i = 0; i < dir.GetLength(0); i++)
                {
                    dx = x + dir[i, 0];
                    dy = y + dir[i, 1];
                    if (dx < 0 || dy < 0 || dx >= processed.Width || dy >= processed.Height) continue;
                    Color px = processed.GetPixel(dx, dy);
                    if (px.R == 1 && px.B == 0)
                        fringe.Push(Tuple.Create(dx, dy));
                }
            }
            return count;
        }
        private int visit(int x, int y)
        {
            Color px = processed.GetPixel(x, y);
            processed.SetPixel(x, y, Color.FromArgb(255, px.R, px.G, 1));
            if (px.B == 1)
                return 0;
            return px.R;
        }

        private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.Swirl(processed, 0.02, true);
            pictureBox2.Image = processed;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.GaussianBlur(processed, 11);
            pictureBox2.Image = processed;
        }

        private void sharpenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.Sharpen(processed, 11);
            pictureBox2.Image = processed;
        }

        private void meanRemovalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.MeanRemoval(processed, 11);
            pictureBox2.Image = processed;
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.EmbossLaplacian(processed);
            pictureBox2.Image = processed;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
