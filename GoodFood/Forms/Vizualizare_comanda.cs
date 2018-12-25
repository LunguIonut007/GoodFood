using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodFood.Classes;
using GoodFood.Classes.Repositories;
using GoodFood.Classes.Poco;
using System.Diagnostics;

namespace GoodFood.Forms
{
    public partial class Vizualizare_comanda : Form
    {
        private BindingList<Meniu> bd;
        private MenuContainer menuContainer;
        public Vizualizare_comanda(MenuContainer mC)
        {
            InitializeComponent();
            this.menuContainer = mC;
        }

        private void Vizualizare_comanda_Load(object sender, EventArgs e)
        {
            button1.Enabled = menuContainer.TotalPrice > 0;
            var list = menuContainer.getList();
            bd = new BindingList<Meniu>(list);
            dataGridView1.DataSource = bd;
            menuContainer.MenuContainerChangeEventHandler += SetValues;
            textBox1.Text = menuContainer.NecKcal.ToString();
            textBox2.Text = menuContainer.TotalKcal.ToString();
            textBox3.Text = menuContainer.TotalPrice.ToString();

            DataGridViewButtonColumn cl = new DataGridViewButtonColumn();
            cl.Text = "Sterge";
            cl.Name = "Sterge";
            cl.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(cl);
        }

        private void SetValues(int totalPrice, int totalKcal)
        {
            textBox2.Text = menuContainer.TotalKcal.ToString();
            textBox3.Text = menuContainer.TotalPrice.ToString();

            button1.Enabled = totalPrice > 0;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int StergeColumnIndex = dataGridView1.Columns.IndexOf(dataGridView1.Columns["Sterge"]);
            if (StergeColumnIndex == e.ColumnIndex)
            {
                if (e.RowIndex < bd.Count)
                {
                    menuContainer.Erase(bd[e.RowIndex].Id);
                    bd.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var commandRepository = new CommandRepository();
            var command = new Command(menuContainer);
            commandRepository.Save(command);
            bd.Clear();
            menuContainer.Clear();
           // MessageBox.Show("Comanda finalizata!");

            var final = new Final();
            final.FormClosed += (s, ev) => { this.Close(); };
            final.ShowDialog();
            
        }


    }
}
