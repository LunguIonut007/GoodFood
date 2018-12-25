using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Databases.good_foodDataSet1TableAdapters;
namespace GoodFood
{
    public class Client
    {
        private string email;

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Prenume { get;set;}
        public string Parola { get; set; }
        public int Kcal { get; set; }
        public string Email
        {
            get { return email; }
           
        }

        private bool validateEmail(String em)
        {
            if (!em.Contains("@"))
            {
                return false;
            }
            String[] s = em.Split(new char[] { '@' });

            if(s.Length >2 || s[0].Length==0)
            {
                return false;
            }

            if (!em.Contains("."))
            {
                return false;
            }

            s = s[1].Split(new char[] { '.'});

            if ((s.Length > 2) || (s[0].Length == 0) || (s[1].Length == 0))
            {
                return false;
            }

            return true;
        }

        public bool setEmail(String em)
        {
            if (validateEmail(em))
            {
                email = em;
                return true;
            }
            else return false;
        }

        public void Save()
        {
            ClientiTableAdapter dt = new ClientiTableAdapter();
            dt.InsertQuery( Parola,Nume, Prenume, Adresa, Email);
        }
    }
}
