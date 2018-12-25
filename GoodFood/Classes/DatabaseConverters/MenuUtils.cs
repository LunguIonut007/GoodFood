using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using GoodFood.Databases;


namespace GoodFood.Classes
{
    class MenuUtils
    {
        public static Meniu convertStringToMenu(String[] args)
        {

            Meniu meniu = new Meniu();
            meniu.Id = Convert.ToInt32(args[0]);
            meniu.DenumireProdus = args[1];
            meniu.Descriere = args[2];
            meniu.Pret = Convert.ToInt32(args[3]);
            meniu.kcal = Convert.ToInt32(args[4]);
            meniu.Fel = Convert.ToInt32(args[5]);

            return meniu;
        }

        public static Meniu converDataRowToMenu(good_foodDataSet1.MeniuRow mr)
        {
            Meniu menu = new Meniu();

            menu.Id = (int)mr["id_produs"]; // converters
            menu.Descriere = ((string)mr["descriere"]).Trim();
            menu.DenumireProdus = ((string)mr["denumire_produs"]).Trim();
            menu.Pret = (int)mr["pret"];
            menu.kcal = (int)mr["kcal"];
            menu.Fel = (int)mr["felul"];

            return menu;
        }

        public static DataRow convertMenuToDataRow(Meniu menu)
        {

            DataRow mr = (new good_foodDataSet1.MeniuDataTable() ).NewRow();

            mr["id_produs"]= menu.Id;
            mr["descriere"] = menu.Descriere;
            mr["denumire_produs"] = menu.DenumireProdus;
            mr["pret"] = menu.Pret;
            mr["kcal"] = menu.kcal;
            mr["felul"] = menu.Fel;

            return mr;

        }
    }
}
