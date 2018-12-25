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

namespace GoodFood
{
    public partial class Creare_cont_client : Form
    {
        public Creare_cont_client()
        {
            InitializeComponent();
        }

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            if (validateForm(c))
            {
                c.Save();
                this.Close();
            }
           
        }

        private bool validateForm(Client c)
        {
            c.Nume = txtNume.Text;
            c.Prenume = txtPrenume.Text;
            c.Adresa = txtAdresa.Text;
            if (txtParola.Text.Equals(txtRParola.Text))
            {
                c.Parola = txtParola.Text;
            }
            else
            {
                MessageBox.Show("Parolele nu corespund");
                txtRParola.Text = txtParola.Text = "";
                return false;
            }


            if (!c.setEmail(txtEmail.Text))
            {
                MessageBox.Show("Email ilegal");
                txtEmail.Text = "";
                return false;
            }

            return true;

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        
    }
}

















//http://stackoverflow.com/questions/11938044/what-are-the-best-practices-for-using-a-guid-as-a-primary-key-specifically-rega?rq=1
