using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSV_Uhr
{
    class Zeit
    {

        int years = 0;
        int Days = 0;
        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        DateTime firstDate = new DateTime(1887,09,29);
        
        
      

        public Zeit(int year,int days,int hours,int minutes,int seconds)
        {
            this.years = year;
            this.Days = days;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

       

        public List<int> Zeit_seit()
        {
            DateTime dateOfBirth = new DateTime(1887, 9, 29, 0, 0, 0);
            int lastYear = DateTime.Now.Year - 1;
            DateTime lastBirthday = new DateTime(lastYear, 9, 29, 0, 0, 0);
            

            TimeSpan sp = DateTime.Now - dateOfBirth;
            TimeSpan days = DateTime.Now - lastBirthday;

            years = sp.Days / 365;
            Days = days.Days;
            hours = DateTime.Now.Hour;
            minutes = DateTime.Now.Minute;
            seconds = DateTime.Now.Second;
            
            List<int> Liz = new List<int>();

            Liz.Clear();
            
            
            Liz.Add(years);
            Liz.Add(Days);
            Liz.Add(hours);
            Liz.Add(minutes);
            Liz.Add(seconds);

            return Liz;
        }

    }
}
