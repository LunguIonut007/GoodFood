using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace GoodFood.Classes
{
    public class ConverterUtils
    {
        public static List<Meniu> getMenu(String location)
        {
            var m = new List<Meniu>();

            using (StreamReader sw = new StreamReader(location))
            {
                String s = sw.ReadLine();

                while((s = sw.ReadLine() )!=String.Empty)
                {
                    String []args = s.Split(new char[] { ';' });
                    args[0] = "0";
                    var menu = MenuUtils.convertStringToMenu(args);
                    m.Add(menu);
                }
            }
            return m;
        }
    }
}
