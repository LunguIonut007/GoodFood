using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodFood.Classes.Poco
{
    class Question
    {
        public Question(string question, int value)
        {
            //Question = question;
            Value = value;
        }
      //  public String Question { get; set; }
        public int Value { get; set; } 
    }
}
