using System;
using System.Threading;

namespace PO_Library
{
    public class Time
    {
        public enum EType { Pomodoro, ShortB, LongB }

        private int minutes;
        private int seconds;
        private EType type;

        #region Propierties
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        public EType Type { get => type; set => type = value; }

        #endregion

        #region Builders
        public Time() 
            : this(0, 0)
        { }  
        public Time(int minutes, EType type)
        {
            this.minutes = minutes;
            this.type = type;
        }
        #endregion


    }
}
