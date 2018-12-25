using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using GoodFood.Classes.Poco;

namespace GoodFood.Classes.Repositories
{
    class SubcommandRepository
    {
        private SubcomenziTableAdapter subcomenziTableAdapter = new SubcomenziTableAdapter();

        public void Save(Subcomanda subcomanda)
        {
            subcomenziTableAdapter.InsertQuery(subcomanda.IdComanda, subcomanda.IdProdus, subcomanda.Cantiate);
        }
    }
}
