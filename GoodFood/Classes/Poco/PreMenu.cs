using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace GoodFood.Classes
{
    public class PreMenu
    {
        [DisplayName("Fel 1"),ReadOnly(true)]
        public Meniu fel1 { get; set; }

        [DisplayName("Fel 2"),ReadOnly(true)]
        public Meniu fel2 { get; set; }

        [DisplayName("Fel 3"),ReadOnly(true)]
        public Meniu fel3 { get; set; }

        [DisplayName("Total kcal"),ReadOnly(true)]
        public int totalKcal { get; set; }

        [DisplayName("Pret total"),ReadOnly(true)]
        public int totalPrice { get; set; }

        [DisplayName("Cantitate"),ReadOnly(false)]
        public int Quantity { get; set; }

        public PreMenu(Meniu f1, Meniu f2, Meniu f3)
        {
            fel1 = f1;
            fel2 = f2;
            fel3 = f3;
            Quantity = 1;
            totalKcal = f1.kcal + f2.kcal + f3.kcal;
            totalPrice = f1.Pret + f2.Pret + f3.Pret;
        }
    }
}
