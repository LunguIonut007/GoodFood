using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodFood.Classes.Poco
{
    class BodyType
    {
        public String Name { get; set; } 
        public List<Question> Questions { get; set; }
        public String Characteristics { get; set; }

        public BodyType()
        {
            Questions = new List<Question>();
        }
    }
}
