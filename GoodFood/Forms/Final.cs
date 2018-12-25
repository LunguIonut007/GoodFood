using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Configuration;
using GoodFood.Classes.Poco;

namespace GoodFood.Forms
{
    public partial class Final : Form
    {
        private Image starFull;
        private Image starEmpty;
        private NoteCounter noteCounter;

        public Final()
        {
            InitializeComponent();
            LoadImg();
            noteCounter = new NoteCounter();
        }

        private void LoadImg()
        {
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "starEmpty.png");
            Image img = Image.FromFile(path);
            starEmpty = img;

            path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "starFull.png");
            img = Image.FromFile(path);
            starFull = img;
        }

        private void Final_Load(object sender, EventArgs e)
        {
            label2.Text = noteCounter.GetNoteAsText(0, 0);
            for (int i = 1; i <= 5; i++)
            {
                PictureBox pictureBox = new PictureBox() { Name = i.ToString(), Size = new Size(50, 50), Image = starEmpty };
                pictureBox.Click += pictureBox_Click;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            int n = Int32.Parse(pb.Name);

            if(pb.Image.Equals(starEmpty))
            {
                for (int i = 0; i < n; i++)
                {
                    pb = flowLayoutPanel1.Controls[i] as PictureBox;
                    pb.Image = starFull;
                }
            }
            else
            {
                for (int i = n; i < 5; i++)
                {
                    pb = flowLayoutPanel1.Controls[i] as PictureBox;
                    pb.Image = starEmpty;
                }
            }
            string x =  noteCounter.GetNoteAsText(n, 1);
            Debug.WriteLine(x);
            label2.Text = x;

        }
    }
}
