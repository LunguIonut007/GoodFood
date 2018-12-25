using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using System.Diagnostics;

namespace GoodFood.Classes.Poco
{
    class Command
    {
        public int ClientId { get; set; }
        public List<Subcomanda> SubcommandList { get; private set;}

        public Command(MenuContainer menuContainer)
        {
            SubcommandList = new List<Subcomanda>();
            ClientId = LogedInClient.Client.Id;

            foreach (Meniu m in menuContainer.getList())
            {
                SubcommandList.Add(Subcomanda.FromMenu(m));
            }
        }

        public Command(PreMenu preMenu)
        {
            SubcommandList = new List<Subcomanda>();
            ClientId = LogedInClient.Client.Id;

            SubcommandList.Add(Subcomanda.FromMenu(preMenu.fel1));
            SubcommandList.Add(Subcomanda.FromMenu(preMenu.fel2));
            SubcommandList.Add(Subcomanda.FromMenu(preMenu.fel3));
        }
       
    }
}
