using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using GoodFood.Classes.Poco;

namespace GoodFood.Classes.Repositories
{
    class CommandRepository
    {
        private ComenziTableAdapter comenziTableAdapter = new ComenziTableAdapter();
        private SubcommandRepository subcommandRepository = new SubcommandRepository();

        public void Save(Command command, int quantity)
        {
            for(int i=0;i<quantity;i++)
            {
                Save(command);
            }
        }

        public void Save(Command command)
        {
            comenziTableAdapter.InsertQuery(command.ClientId, DateTime.Now);
            int commandId = (int)comenziTableAdapter.ScalarQuery();

            foreach (Subcomanda s in command.SubcommandList)
            {
                s.IdComanda = commandId;
                subcommandRepository.Save(s);
            }
        }
    }
}
