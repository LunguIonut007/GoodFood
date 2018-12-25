using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace GoodFood.Classes
{
    public class Meniu
    {
           
        public int fel;

        [ReadOnly(true)]
        public int Id { get; set; }

        [ReadOnly(true)]
        public String DenumireProdus { get; set; }

        [ReadOnly(true)]
        public String Descriere { get; set; }

        [ReadOnly(true)]
        public int Pret { get; set; }

        [ReadOnly(true)]
        public int kcal { get; set; }

        [ReadOnly(false),DisplayName("Cantitate de adaugat")]
        public int Cantitate { get; set; }

        [ReadOnly(true)]
        public int Fel
        {
            get
            {
                return fel;
            }
            set
            {
                if (value <= 0 || value > 3)
                    throw new Exception("fel inexact");
                else
                    fel = value;
            }
        }

        public Meniu()
        {
            Cantitate = 1;
        }

       
        public override String ToString()
        {
            return DenumireProdus;
        }
    }

}
