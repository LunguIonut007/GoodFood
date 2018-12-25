using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using GoodFood.Classes.Repositories;
using System.Diagnostics;
using GoodFood.Classes;
using GoodFood.Forms;
using GoodFood.Classes.Poco;

namespace GoodFood
{
    public partial class Optiuni : Form
    {
        private MenuContainer menuContainer = new MenuContainer(MenuRepository.getInstance().getAllMenuItems());

        public Optiuni()
        {
            InitializeComponent();
        }

        private void Optiuni_Load(object sender, EventArgs e)
        {
            var m = new List<Meniu>();
            tbBuget.Text = "33";
            button2.Enabled = menuContainer.TotalPrice > 0;
            textBox1.KeyPress += textBox_KeyPress;
            textBox2.KeyPress += textBox_KeyPress;
            textBox3.KeyPress += textBox_KeyPress;
            tbBuget.KeyPress += textBox_KeyPress;

            dataGridView1.DataSource = MenuRepository.getInstance().getAllMenuItems();

            DataGridViewButtonColumn cb = new DataGridViewButtonColumn();
            cb.HeaderText = "Adaugare";
            cb.Name = "adaugare";
            cb.Text = "Adaugare";
            cb.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(cb);

            textBox4.Text = LogedInClient.Client.Kcal != 0 ? LogedInClient.Client.Kcal.ToString() : "";
            

            tbNecesarZilnic.Text = LogedInClient.Client.Kcal.ToString();
            tbKcalTotal.Text = "0";
            tbPretTotal.Text = "0";

            menuContainer.MenuContainerChangeEventHandler += menuContainer_MenuContainerChangeEventHandler;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
            int kcal;

            if (sum < 250)
            {
                kcal = 1800;
            }
            else if (sum <= 275)
            {
                kcal = 2200;
            }
            else
            {
                kcal = 2500;
            }
            LogedInClient.Client.Kcal = kcal;
            ClientRepository.Instance.setKcalOfClient(kcal, LogedInClient.Client);

            textBox4.Text = kcal.ToString();

        }

        void menuContainer_MenuContainerChangeEventHandler(int totalPrice, int totalKcal)
        {
            tbKcalTotal.Text = totalKcal.ToString();
            tbPretTotal.Text = totalPrice.ToString();
            button2.Enabled = totalPrice > 0;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
                MessageBox.Show("Va rugam inserati doar cifre");
            }
           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Se pot introduce doar cifre.Va rugam stergeti informatia.");
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int x;
            int.TryParse((string)e.FormattedValue, out x);
            if (x<0)
            {
                e.Cancel = true;
                MessageBox.Show("Va rugam introduceti numere pozitive!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["adaugare"].Index && e.RowIndex>=0)
            {
                int columnIndex = dataGridView1.Columns["Cantitate"].Index;
                int menuId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                int quantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[columnIndex].FormattedValue.ToString());

                menuContainer.Add(menuId,quantity);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Alege"].Index && e.RowIndex >= 0)
            {
                var commandRepository = new CommandRepository();
                PreMenu pM = ((List<PreMenu>)dataGridView2.DataSource).ElementAt(e.RowIndex);
                commandRepository.Save(new Command(pM),pM.Quantity);
                //MessageBox.Show("Comanda efectuata!");
                Final final = new Final();
                final.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vizualizare_comanda form = new Vizualizare_comanda(menuContainer);
            form.ShowDialog();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            tbNecesarZilnic.Text = LogedInClient.Client.Kcal != 0 ? LogedInClient.Client.Kcal.ToString() : "";
            tbNecesarZilnic2.Text = LogedInClient.Client.Kcal != 0 ? LogedInClient.Client.Kcal.ToString() : "";
        }

        GenerateMenus g;
        private void button3_Click(object sender, EventArgs e)
        {
            int budget = Int32.Parse(tbBuget.Text);
            g = new GenerateMenus();
            dataGridView2.DataSource = g.generate(budget); 

            if (!dataGridView2.Columns.Contains("Alege"))
            {
                DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
                bc.Name = "Alege";
                bc.Text = "Alege";
                bc.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(bc);
            }
        
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogedInClient.LogOut();
            this.Close();
        }

        private void Optiuni_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogedInClient.LogOut();
        }

        private void tbNecesarZilnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var g = new Grafic(menuContainer);

            g.Show();
        }

        

   
    }
}
