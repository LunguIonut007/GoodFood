using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoodFood.Classes;

namespace GoodFood.Forms
{
    public partial class Grafic : Form
    {
        private MenuContainer menuContainer;

        public Grafic(MenuContainer mnc)
        {
            InitializeComponent();
            menuContainer = mnc;
            menuContainer.MenuContainerChangeEventHandler +=menuContainer_MenuContainerChangeEventHandler;
            foreach (Meniu menu in menuContainer.getList())
            {
                chart1.Series[0].Points.AddXY(menu.DenumireProdus, menu.kcal * menu.Cantitate);
            }
        }

        void menuContainer_MenuContainerChangeEventHandler(int totalPrice, int totalKcal)
        {
            chart1.Series[0].Points.Clear();

            foreach (Meniu menu in menuContainer.getList())
            {
                chart1.Series[0].Points.AddXY(menu.DenumireProdus, menu.kcal * menu.Cantitate);
            }
        }

        private void Grafic_Load(object sender, EventArgs e)
        {

        }
    }
}
