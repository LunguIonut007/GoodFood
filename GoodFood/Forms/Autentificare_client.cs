using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using GoodFood.Databases;
using System.Diagnostics;
using GoodFood.Classes.Repositories;


namespace GoodFood
{
    public partial class Autentificare_client : Form
    {
        public Autentificare_client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ct = new ClientiTableAdapter();
            if (ClientRepository.Instance.UserExists(txte.Text,txtp.Text))
            {
                LogedInClient.Client = ClientRepository.Instance.GetUser(txte.Text);
                Optiuni op = new Optiuni();
                op.FormClosed += (obj, ev) => {  this.Show(); }; 
                this.Hide();
                op.Show();
            }
            else
            {
                MessageBox.Show("Incorect");
            }
        }

        private void Autentificare_client_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txte.Text = "1@1.1";
            txtp.Text = "as";
        }
    }
}
