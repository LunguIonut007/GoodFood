using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodFood.Classes.Repositories;
using System.Diagnostics;
namespace GoodFood.Classes
{
    class GenerateMenus
    {
        private MenuRepository menuRepository;
        private List<Meniu> fel1, fel2, fel3,complete;
        private List<PreMenu> list;

        public GenerateMenus()
        {
            menuRepository = new MenuRepository();
            complete = menuRepository.getAllMenuItems();
            fel1 = Enumerable.Where(complete, meniu => meniu.Fel == 1).ToList();
            fel2 = Enumerable.Where(complete, meniu => meniu.Fel == 2).ToList();
            fel3 = Enumerable.Where(complete, meniu => meniu.Fel == 3).ToList();
        }

        public List<PreMenu> generate(int budget)
        {
            list = new List<PreMenu>();
            gen(1, budget);

            return list;
        }

        private void gen(int k, int budget)
        {
            PreMenu preMenu;
            foreach (Meniu f1 in fel1)
            {
                foreach (Meniu f2 in fel2)
                {
                    foreach (Meniu f3 in fel3)
                    {
                        preMenu = new PreMenu(f1,f2,f3);

                        if (preMenu.totalPrice <= budget && preMenu.totalKcal<=LogedInClient.Client.Kcal)
                        {
                            list.Add(preMenu);
                        }
                    }
                }
            }
        }
    }
}
