using System;
using System.Diagnostics;
namespace GoodFood
{
    public class LogedInClient
    {
        //private static LogedInClient instance = new LogedInClient();
        private static Client client;

        public static Client Client
        {
            get
            {
                return client;
            }

            set
            {

                if (LogedInClient.client == null)
                {
                    client = value;
                }
                else
                {
                    throw new Exception("Can't set client");
                }
                
            }
        }

        public static void LogOut()
        {
            client = null;
        }

    }
}
