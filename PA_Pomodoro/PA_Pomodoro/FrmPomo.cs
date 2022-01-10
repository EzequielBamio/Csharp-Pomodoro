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
        const int MINUTES_POMODORO = 25;
        const int MINUTES_SHORT_BREAK = 1;
        const int MINUTES_LONG_BREAK = 15;
        int countPomodoro = 0;
        int countShortBreak = 0;
        int countLongBreak = 0;

        bool isExecute;
        Time time;
        public FrmPomo()
        {
            InitializeComponent();
            this.isExecute = false;
        }

        private void FrmPomo_Load(object sender, EventArgs e)
        {
            this.time = new Time();


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
                this.tTime_Cancel();
            }
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            this.Start(this.time);
        }

        private void Start(Time time) 
        {
            if (time.Minutes == 0 && time.Seconds == 0)
            {
                this.tTime_Cancel();
                this.CountTime(time.Type);
            }
            else
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

        private void tTime_Cancel() 
        {
            this.tTime.Stop();
            this.btnStart.Text = "Start";
            this.isExecute = false;
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            this.time = new Time(MINUTES_POMODORO, Time.EType.Pomodoro);
            this.ColourPomodoro();
            this.tTime_Cancel();
            this.NotifyTime(this.time.Minutes, this.time.Seconds);
            
        }

        private void btnShoBreak_Click(object sender, EventArgs e)
        {
            this.time = new Time(MINUTES_SHORT_BREAK, Time.EType.ShortB);
            this.ColourBreak();
            this.tTime_Cancel();
            this.NotifyTime(this.time.Minutes, this.time.Seconds);

        }

        private void btnLonBreak_Click(object sender, EventArgs e)
        {
            this.time = new Time(MINUTES_LONG_BREAK, Time.EType.LongB);
            this.ColourBreak();
            this.tTime_Cancel();
            this.NotifyTime(this.time.Minutes, this.time.Seconds);
        }

        private void CountTime(Time.EType type) 
        {
            switch (type) 
            {
                case Time.EType.Pomodoro:
                    this.countPomodoro++;
                    break;
                case Time.EType.ShortB:
                    this.countShortBreak++;
                    break;
                case Time.EType.LongB:
                    this.countLongBreak++;
                    break;
            }

            this.CountLoad();
        }

        private void CountLoad() 
        {
            this.lblPomodoro.Text = this.countPomodoro.ToString();
            this.lblShoBreak.Text = this.countShortBreak.ToString();
            this.lblLonBreak.Text = this.countLongBreak.ToString();
        }

        private void ColourBreak() 
        {
            this.BackColor = Color.FromArgb(94, 178, 100); //176; 60; 52
            this.btnShoBreak.ForeColor = Color.FromArgb(94, 178, 100);
            this.btnPomodoro.ForeColor = Color.FromArgb(94, 178, 100);
            this.btnLonBreak.ForeColor = Color.FromArgb(94, 178, 100);
            this.btnStart.ForeColor = Color.FromArgb(94, 178, 100);
            this.btnReset.ForeColor = Color.FromArgb(94, 178, 100);
        }
        private void ColourPomodoro()
        {
            this.BackColor = Color.FromArgb(176, 60, 52);
            this.btnLonBreak.ForeColor = Color.FromArgb(176, 60, 52);
            this.btnPomodoro.ForeColor = Color.FromArgb(176, 60, 52);
            this.btnShoBreak.ForeColor = Color.FromArgb(176, 60, 52);
            this.btnStart.ForeColor = Color.FromArgb(176, 60, 52);
            this.btnReset.ForeColor = Color.FromArgb(176, 60, 52);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tTime_Cancel();
            this.btnPomodoro_Click(sender, e);
            this.NotifyTime(this.time.Minutes, this.time.Seconds);
        }
    }
}
