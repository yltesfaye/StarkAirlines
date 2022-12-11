using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarkAirlines
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }
        private Timer timer;
        public Timer Timer { get { return timer; } set { timer = value; } }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        Timer MyTimer = new Timer();

        public void Timer_FrontPage()
        {
            
            MyTimer.Interval = (3 * 1000); // 45 mins
            MyTimer.Tick += new EventHandler(timer1_Tick);
            MyTimer.Start();
            Progressbar.Value = 1;
            if(Progressbar.Value == 3000)
            {
               Progressbar.Value = 0;
                LoginPage login = new LoginPage();
                login.Show();
                this.Hide();
                MyTimer.Stop();
            }
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 10;
            Progressbar.Value = startpoint;
            if(Progressbar.Value == 100)
            {
                Progressbar.Value = 0;
                timer1.Stop();
                LoginPage login = new LoginPage();
                login.Show();
                this.Hide();
            }
           



        }
    }
}
