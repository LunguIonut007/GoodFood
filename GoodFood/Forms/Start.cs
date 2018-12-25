using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodFood.Classes.Repositories;
using GoodFood.Classes;
using System.Diagnostics;
using GoodFood.Classes.Poco;

namespace GoodFood
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btInreg_Click(object sender, EventArgs e)
        {
            var c = new Creare_cont_client();
            c.FormClosed += (obj, ev) => { this.Show(); }; 
            this.Hide();
            c.ShowDialog();
            
        }

        private void btAut_Click(object sender, EventArgs e)
        {
            var c = new Autentificare_client();
            c.FormClosed += (obj, ev) => { this.Show(); }; 
            this.Hide();
            c.ShowDialog();
        }
    }
}
