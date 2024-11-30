namespace ImageProcessingActivity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            openFileDialog4 = new OpenFileDialog();
            tabPage5 = new TabPage();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            fileToolStripMenuItem2 = new ToolStripMenuItem();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabPage1 = new TabPage();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            basicCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            convolutionToolStripMenuItem = new ToolStripMenuItem();
            shrinkToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            menuStrip2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            openFileDialog4.FileOk += openFileDialog4_FileOk;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(richTextBox1);
            tabPage5.Controls.Add(button4);
            tabPage5.Controls.Add(pictureBox6);
            tabPage5.Controls.Add(menuStrip2);
            tabPage5.ForeColor = Color.Black;
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(973, 464);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Coins";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(457, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(218, 296);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(504, 379);
            button4.Name = "button4";
            button4.Size = new Size(122, 29);
            button4.TabIndex = 2;
            button4.Text = "Count Coins";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(79, 63);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(277, 345);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(973, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, fileToolStripMenuItem2 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(46, 24);
            fileToolStripMenuItem1.Text = "File";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(128, 26);
            openToolStripMenuItem1.Text = "Open";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // fileToolStripMenuItem2
            // 
            fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            fileToolStripMenuItem2.Size = new Size(128, 26);
            fileToolStripMenuItem2.Text = "File";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(973, 464);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "WebCam";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(973, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Green Screen";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(737, 383);
            button3.Name = "button3";
            button3.Size = new Size(122, 29);
            button3.TabIndex = 5;
            button3.Text = "Subtract";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 383);
            button2.Name = "button2";
            button2.Size = new Size(162, 29);
            button2.TabIndex = 4;
            button2.Text = "Load Background";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(108, 383);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 3;
            button1.Text = "Load Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(647, 63);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(306, 304);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(335, 63);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(306, 304);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(23, 63);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(306, 304);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(973, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DIP's";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, convolutionToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(203, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicCopyToolStripMenuItem, greyscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(46, 24);
            dIPToolStripMenuItem.Text = "DIP";
            dIPToolStripMenuItem.Click += dIPToolStripMenuItem_Click;
            // 
            // basicCopyToolStripMenuItem
            // 
            basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            basicCopyToolStripMenuItem.Size = new Size(191, 26);
            basicCopyToolStripMenuItem.Text = "Basic Copy";
            basicCopyToolStripMenuItem.Click += basicCopyToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(191, 26);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // colorInversionToolStripMenuItem
            // 
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Size = new Size(191, 26);
            colorInversionToolStripMenuItem.Text = "Color Inversion";
            colorInversionToolStripMenuItem.Click += colorInversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(191, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(191, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // convolutionToolStripMenuItem
            // 
            convolutionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shrinkToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem });
            convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            convolutionToolStripMenuItem.Size = new Size(103, 24);
            convolutionToolStripMenuItem.Text = "Convolution";
            convolutionToolStripMenuItem.Click += convolutionToolStripMenuItem_Click;
            // 
            // shrinkToolStripMenuItem
            // 
            shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            shrinkToolStripMenuItem.Size = new Size(191, 26);
            shrinkToolStripMenuItem.Text = "Swirl";
            shrinkToolStripMenuItem.Click += shrinkToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(191, 26);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(191, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click_1;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(191, 26);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click_1;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(191, 26);
            embossingToolStripMenuItem.Text = "Emboss";
            embossingToolStripMenuItem.Click += embossingToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(414, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 325);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(-1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(981, 497);
            tabControl1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 499);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private OpenFileDialog openFileDialog4;
        private TabPage tabPage5;
        private Button button4;
        private PictureBox pictureBox6;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem1;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private TabPage tabPage1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem basicCopyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private ToolStripMenuItem convolutionToolStripMenuItem;
        private ToolStripMenuItem shrinkToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem fileToolStripMenuItem2;
    }
}
