using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using GoodFood.Databases;

namespace GoodFood.Classes.Repositories
{
   public class MenuRepository
    {
        private static MenuRepository instace;

        public static MenuRepository getInstance()
        {
            if (instace == null)
                instace = new MenuRepository();
            return instace;
        }

        public List<Meniu> getAllMenuItems()
        {
            var list = new List<Meniu>();
            var mn = new good_foodDataSet1.MeniuDataTable();
            MeniuTableAdapter meniuTableAdapter = new MeniuTableAdapter();
            meniuTableAdapter.Fill(mn);

            foreach (good_foodDataSet1.MeniuRow r in mn)
            {
                list.Add(MenuUtils.converDataRowToMenu(r));
            }

            return list;
        }

        public Boolean isEmpty()
        {
            MeniuTableAdapter meniuTableAdapter = new MeniuTableAdapter();
            if (meniuTableAdapter.ScalarQuery() > 0)
            {
                return true;
            }

            return false;
        }

        public void saveMenu(Meniu menu)
        {
            var tb = new MeniuTableAdapter();

            if (menu.Id == 0)
            {
                  tb.InsertMenuValue2(menu.DenumireProdus, menu.Descriere, menu.Pret, menu.kcal, menu.Fel);
            }
            else
            {
                  tb.UpdateQuery(menu.DenumireProdus, menu.Descriere, menu.Pret, menu.kcal, menu.Fel,menu.Id);
            }
        }


    }
}
