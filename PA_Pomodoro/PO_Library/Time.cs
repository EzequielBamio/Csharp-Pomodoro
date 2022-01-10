using System;
using System.Threading;

namespace PO_Library
{
    public delegate void InformationTime(object time, NotifyTimeEventArgs info);
    public class Time
    {
        public event InformationTime MessageTime;
        private int minute;
        private int seconds;

        #region Propierties
        public int Minute { get => minute; set => minute = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        #endregion

        #region Builders
        public Time(int minute, int seconds)
        {
            this.minute = minute;
            this.seconds = seconds;
        }
        public Time(int minute)
           : this(minute, 59)
        { }
        #endregion

        public string ShowTime() 
        {
            return $"{this.minute}-{this.seconds}";
        }

        #region Methods
        public void Start() 
        {
            do
            {
                Thread.Sleep(1000);
                DateTime dt = DateTime.Now;


                if (dt.Second != this.seconds)
                {
                    NotifyTimeEventArgs infoTime = new NotifyTimeEventArgs(dt.Minute, dt.Second);
                    if (this.MessageTime is not null)
                    {
                        this.MessageTime.Invoke(this, infoTime);
                    }
                }

                this.minute = dt.Minute;
                this.seconds = dt.Second;
                
                


            } while (this.seconds != 0);


        }

        public void Reset() 
        {
        
        }

        public void Cancele() 
        {

        }
        #endregion

    }
}
