using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GoodFood.Classes.Poco
{
    class NoteCounter
    {
        private int nr;
        private float sum;

        public NoteCounter()
        {
            nr = Properties.Settings.Default.Nr;
            sum = Properties.Settings.Default.Note;

            Debug.WriteLine(nr + "    " + sum);
        }

        public void Update(int x,int nr)
        {
            sum +=x;
            this.nr += nr;
            Properties.Settings.Default.Nr = this.nr;
            Properties.Settings.Default.Note = (int)sum;
            Properties.Settings.Default.Save();
        }

        public String GetNoteAsText(int x,int nr)
        {
            //Debug.Wr
            if (this.nr == 0) return "0";
            Update(x, nr);
            Debug.WriteLine(sum + "   " + this.nr);
            float rez = (sum / this.nr);
            return rez.ToString("0.00");
        }
    }
}
