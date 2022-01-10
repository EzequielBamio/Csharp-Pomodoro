using System;
using System.Threading;

namespace PO_Library
{
    public class Time
    {
        private int minutes;
        private int seconds;

        #region Propierties
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        #endregion

        #region Builders
        public Time(int minutes, int seconds)
        {
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Time(int minutes)
           : this(minutes, 0)
        { }
        #endregion


    }
}
