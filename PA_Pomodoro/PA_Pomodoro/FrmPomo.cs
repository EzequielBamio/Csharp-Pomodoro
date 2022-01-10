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
        int seconds;
        int minutes;
        public FrmPomo()
        {
            InitializeComponent();
            this.isExecute = false;
        }

        private void FrmPomo_Load(object sender, EventArgs e)
        {
            this.minutes = 25;
            this.seconds = 00;
            this.NotifyTime(this.minutes, this.seconds);

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
            this.seconds--;

            if (this.seconds < 0)
            {
                this.minutes--;
                this.seconds = 59;

            }
            this.NotifyTime(this.minutes, this.seconds);
            Thread.Sleep(1000);
        }
    }
}
