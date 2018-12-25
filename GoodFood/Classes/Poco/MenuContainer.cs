using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
namespace GoodFood.Classes
{
    public class MenuContainer
    {
        public delegate void eventDelegate(int totalPrice,int totalKcal);
        public event eventDelegate MenuContainerChangeEventHandler;

        private Dictionary<int, Meniu> menuContainer;
        private List<Meniu> list;
        private int totalPrice, totalKcal;

        public int NecKcal { get; set; }

        public int TotalPrice
        {
            get { return totalPrice; }
            set
            { 
                totalPrice = value; 
                if(MenuContainerChangeEventHandler!=null)
                    MenuContainerChangeEventHandler.Invoke(totalPrice, totalKcal); 
            }
        }

        public int TotalKcal
        {
            get { return totalKcal; }
            set {
                totalKcal = value;

                if (MenuContainerChangeEventHandler != null)
                    MenuContainerChangeEventHandler.Invoke(totalPrice, totalKcal);

                if (totalKcal > LogedInClient.Client.Kcal)
                    MessageBox.Show("Atentie! Numarul de kcal este peste necesarul zilnic!");
            }
        }

        public MenuContainer(List<Meniu> l)
        {
            NecKcal = LogedInClient.Client.Kcal;
            menuContainer = new Dictionary<int, Meniu>();
            list = l;
          //  MenuContainerChangeEventHandler = new eventDelegate();
        }

        public void Add(int idMenu,int quantity)
        {
            if (quantity == 0) return;
              
            if (menuContainer.ContainsKey(idMenu))
                menuContainer[idMenu].Cantitate += quantity;
            else
            {
                Meniu m = list[idMenu];
                m.Cantitate = quantity;
                menuContainer.Add(idMenu, m);
            }

            TotalPrice += list[idMenu].Pret * quantity;
            TotalKcal += list[idMenu].kcal * quantity;
        }

        public void Erase(int idMenu)
        {
            if (menuContainer.ContainsKey(idMenu))
            {
                TotalPrice -= list[idMenu].Pret * list[idMenu].Cantitate;
                TotalKcal -= list[idMenu].kcal * list[idMenu].Cantitate;
                 menuContainer.Remove(idMenu);
            }
            else
            {
                throw new Exception("Menu id is not in the dictionary!");
            }
        }

        public List<Meniu> getList()
        {
            return menuContainer.Values.ToList();
        }

        public void Clear()
        {
            TotalKcal = 0;
            TotalPrice = 0;
            menuContainer = new Dictionary<int, Meniu>();
        }
    }
}
