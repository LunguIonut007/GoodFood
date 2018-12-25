using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Databases;
using System.Diagnostics;

namespace GoodFood.Classes
{
    class ClientUtils
    {
        public static Client ConvertRowToClient(good_foodDataSet1.ClientiRow dr)
        {
            Client c = new Client();
            c.Id = (int)dr["id_client"];
            c.Adresa = (String)dr["adresa"];
            c.Nume = (String)dr["nume"];
            c.Parola = (String)dr["parola"];
            c.Prenume = (String)dr["prenume"];
            c.setEmail( (String)dr["email"]);
            int x = 0;
            Int32.TryParse(dr["kcal_zilnice"].ToString(), out x);
            c.Kcal = x;
            return c;
        }
    }
}
