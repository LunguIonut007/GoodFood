using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
using GoodFood.Databases;

namespace GoodFood.Classes.Repositories
{
    public class ClientRepository
    {
        private static ClientRepository clientRepository;
        public static ClientRepository Instance
        {
            get
            {
                if(clientRepository == null) clientRepository = new ClientRepository();
                return clientRepository;
            } 
        }

        public void setKcalOfClient(int kcal,Client client)
        {
            var clientTableAdapter = new ClientiTableAdapter();
            client.Kcal = kcal;
            clientTableAdapter.SetKcalUser(kcal, client.Email);
        }

        public Boolean UserExists(String email, String password)
        {
            var clientTableAdapter = new ClientiTableAdapter();
            if (clientTableAdapter.UserExits(email, password) > 0)
            {
                return true;
            }

            return false;
        }

        public Client GetUser(String email)
        {
            var clientTableAdapter = new ClientiTableAdapter();
            var dataTable =new good_foodDataSet1.ClientiDataTable();
            clientTableAdapter.GetUser(dataTable, email);

            return ClientUtils.ConvertRowToClient(dataTable[0]);
        }
    }
}
