using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodFood.Classes.Poco
{
    class Subcomanda
    {
        public int Id { get; set; }
        public int IdComanda { get; set; }
        public int IdProdus { get; set; }
        public int Cantiate { get; set; }

        public static Subcomanda FromMenu(Meniu menu)
        {
            var subcomanda = new Subcomanda();

            subcomanda.Cantiate = menu.Cantitate;
            subcomanda.IdProdus = menu.Id;

            return subcomanda;
        }
    }
}
