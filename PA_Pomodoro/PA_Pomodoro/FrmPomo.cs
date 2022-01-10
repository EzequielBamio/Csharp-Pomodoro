using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PO_Library;
namespace PA_Pomodoro
{
    public partial class FrmPomo : Form
    {
        bool isExecute;
        Time tPomodoro;
        Time tBreak;
        public FrmPomo()
        {
            InitializeComponent();
            this.isExecute = false;
        }

        private void FrmPomo_Load(object sender, EventArgs e)
        {
            this.tPomodoro = new Time(25);

            this.NotifyTime(this.tPomodoro.Minutes, this.tPomodoro.Seconds);

        }

        private void NotifyTime(int min, int seg) 
        {
            string sSeg = Convert.ToString(seg);
            string sMin = Convert.ToString(min);

            if (seg < 10) 
            {
                sSeg = Convert.ToString("0" + seg);
            }
            if (min < 10)
            {
                sMin = Convert.ToString("0" + min);
            }
            this.lblTime.Text = $"{sMin}:{sSeg}";
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!this.isExecute)
            {
                tTime.Start();
                this.btnStart.Text = "Stop";
                this.isExecute = true;
            }
            else 
            {
                tTime.Stop();
                this.btnStart.Text = "Start";
                this.isExecute = false;
            }
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            this.Start(this.tPomodoro);
        }

        private void Start(Time time) 
        {
            time.Seconds--;

            if (time.Seconds < 0)
            {
                time.Minutes--;
                time.Seconds = 59;

            }
            this.NotifyTime(time.Minutes, time.Seconds);
            Thread.Sleep(1000);
        }
    }
}
