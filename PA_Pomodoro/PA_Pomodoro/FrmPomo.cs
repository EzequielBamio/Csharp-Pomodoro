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
using System.Media;
namespace PA_Pomodoro
{
    public partial class FrmPomo : Form
    {
        const int MINUTES_SHORT_BREAK = 1;
        const int MINUTES_LONG_BREAK = 15;
        const int MINUTES_POMODORO = 25;
        int countShortBreak = 0;
        int countLongBreak = 0;
        int countPomodoro = 0;
        bool isExecute;
        SoundPlayer alarm;
        Time time;

        public FrmPomo()
        {
            InitializeComponent();
            this.alarm = new SoundPlayer();
            this.alarm.SoundLocation = Environment.CurrentDirectory + "/alarm.wav";
            this.GenerateTime(Time.EType.Pomodoro);
            this.isExecute = false;
        }

        private void NotifyTime(int min, int seg) 
        {
            string sSeg = Convert.ToString(seg);
            string sMin = Convert.ToString(min);

            if (seg < 10) 
            {
                sSeg = $"0{ sSeg }";
            }
            if (min < 10)
            {
                sMin = $"0{ sMin }";
            }
            this.lblTime.Text = $"{sMin}:{sSeg}";
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!this.isExecute)
            {
                this.tTime.Start();
                this.OutButton(time.Type);
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
                this.alarm.PlayLooping();
                this.CountTime(time.Type);
                Thread.Sleep(3000);
                this.tTime_Reset();
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
            this.OnButton();
            this.isExecute = false;
            this.btnStart.Text = "Start";
            this.alarm.Stop();

        }

        private void tTime_Reset()
        {
            this.tTime_Cancel();
            this.GenerateTime(time.Type);
        }

        private void OutButton(Time.EType type)
        {
            switch (type)
            {
                case Time.EType.Pomodoro:
                    this.btnLonBreak.Enabled = false;
                    this.btnShoBreak.Enabled = false;
                    break;
                case Time.EType.ShortB:
                    this.btnLonBreak.Enabled = false;
                    this.btnPomodoro.Enabled = false;
                    break;
                case Time.EType.LongB:
                    this.btnPomodoro.Enabled = false;
                    this.btnShoBreak.Enabled = false;
                    break;
            }
        }

        private void OnButton()
        {
            this.btnPomodoro.Enabled = true;
            this.btnLonBreak.Enabled = true;
            this.btnShoBreak.Enabled = true;
                    
        }

        private void GenerateTime(Time.EType type)
        {
            switch (type)
            {
                case Time.EType.Pomodoro:
                    this.time = new Time(MINUTES_POMODORO, Time.EType.Pomodoro);
                    this.ColourPomodoro();
                    break;
                case Time.EType.ShortB:
                    this.time = new Time(MINUTES_SHORT_BREAK, Time.EType.ShortB);
                    this.ColourBreak();
                    break;
                case Time.EType.LongB:
                    this.time = new Time(MINUTES_LONG_BREAK, Time.EType.LongB);
                    this.ColourBreak();
                    break;
            }
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

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            this.GenerateTime(Time.EType.Pomodoro);
        }

        private void btnShoBreak_Click(object sender, EventArgs e)
        {
            this.GenerateTime(Time.EType.ShortB);
        }

        private void btnLonBreak_Click(object sender, EventArgs e)
        {
            this.GenerateTime(Time.EType.LongB);
        }

        private void ColourBreak()
        {
            this.BackColor = Color.FromArgb(94, 178, 100); //176; 60; 52
            this.btnShoBreak.ForeColor = Color.FromArgb(94, 178, 100);
            this.btnPomodoro.ForeColor = Color.FromArgb(94, 178, 100);
            this.btnLonBreak.ForeColor = Color.FromArgb(94, 178, 100);
            this.btnStart.ForeColor = Color.FromArgb(94, 178, 100);
        }

        private void ColourPomodoro()
        {
            this.BackColor = Color.FromArgb(176, 60, 52);
            this.btnLonBreak.ForeColor = Color.FromArgb(176, 60, 52);
            this.btnPomodoro.ForeColor = Color.FromArgb(176, 60, 52);
            this.btnShoBreak.ForeColor = Color.FromArgb(176, 60, 52);
            this.btnStart.ForeColor = Color.FromArgb(176, 60, 52);
        }

    }
}
