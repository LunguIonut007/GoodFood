using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using GoodFood.Databases;
using GoodFood.Classes;
using System.Diagnostics;
using GoodFood.Classes.Repositories;

namespace GoodFood
{
    public class DatabaseUtils
    {

        public static void loadMenu()
        {
            String loc = "menu.txt";
            var menu = ConverterUtils.getMenu(loc);
            MenuRepository mn = new MenuRepository();

            if(!mn.isEmpty())
            foreach (Meniu m in menu)
            {
                mn.saveMenu(m);
            }
        }
    }
}
