using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSV_Uhr
{
    public partial class Form1 : Form
    {
        

        Timer time = new Timer();
        Timer Raute = new Timer();
        Timer count = new Timer();

        List<int> liz = new List<int>();
        public Form1()
        {
            InitializeComponent();
            initialTimer();
            initialRaute();
            initCountdown();

            
            //Start Timer
            this.Raute.Start();
            this.time.Start();
            this.count.Start();
        }

        
        public void initialTimer()
        {
            this.time.Interval = 1000;
            this.time.Tick += new EventHandler(time_tick);
        }

        public void initialRaute()
        {
            this.Raute.Interval = 3000;
            this.Raute.Tick += new EventHandler(Raute_tick);
        }

        public void initCountdown()
        {
            this.count.Interval = 500;
            this.count.Tick += new EventHandler(countdown_tick);
        }
        public void time_tick(object sender, EventArgs e)
        {
            int year = 0;
            int days = 0;
            int hours = 0;
            int min = 0;
            int sec = 0;

            Zeit z = new Zeit(year, days, hours, min, sec);

            liz = z.Zeit_seit();

            lb_YEARS.Text = liz[0].ToString();
            lb_days.Text = liz[1].ToString();
            lb_hours.Text = liz[2].ToString();
            lb_min.Text = liz[3].ToString();
            lb_sec.Text = liz[4].ToString();

            
        }

        public void countdown_tick(object sender,EventArgs s)
        {
            Countdown c = new Countdown();

            List<int> Erstkl = new List<int>();

            Erstkl = c.Erstklassig();

            lb_days_to.Text = Erstkl[0].ToString();
            lb_hours_to.Text = Erstkl[1].ToString();
            lb_min_to.Text = Erstkl[2].ToString();
            lb_sek_to.Text = Erstkl[3].ToString();

        }

        public void Raute_tick(object sender, EventArgs e)
        {
            if(pic_Raute.Visible==true && pic_Raute2.Visible == true)
            {
                pic_Raute.Visible = false;
                pic_Raute2.Visible = false;
            }
            else
            {
                pic_Raute.Visible = true;
                pic_Raute2.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


       

        private void bt_erstklassig_Click(object sender, EventArgs e)
        {
           if(p_erstklassig.Visible==false)
            {
                p_erstklassig.Visible = true;
                bt_erstklassig.Text = "Countdown ausblenden";
            }else
            {
                p_erstklassig.Visible = false;
                bt_erstklassig.Text = "Erstklassig in"; 
            }
                 
        }
        WebBrowser web = new WebBrowser();

        private void bt_abZumHSV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hsv.de/");
        }

        private void bt_tickets_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hsv.de/de/tickets/ticketinfos-preise/");
        }
    }
}
