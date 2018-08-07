using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSV_Uhr
{
   

    class Countdown
    {
        int Days = 0;
        int Hours = 0;
        int Minutes = 0;
        int Seconds = 0;

        DateTime CurrentTime = DateTime.Now;
        DateTime Finish = new DateTime(2019, 5, 19,17,30,00);
        

        public List<int> Erstklassig()
        {
            List<int> liErst = new List<int>();

            TimeSpan sp = Finish - CurrentTime;

            Days = sp.Days;
            Hours = sp.Hours;
            Minutes = sp.Minutes;
            Seconds = sp.Seconds;

           

            liErst.Add(Days);
            liErst.Add(Hours);
            liErst.Add(Minutes);
            liErst.Add(Seconds);


            return liErst;
        }
    }
}
