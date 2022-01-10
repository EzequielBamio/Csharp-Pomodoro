using System;

namespace PO_Library
{
    public class NotifyTimeEventArgs : EventArgs
    {
        private int minute;
        private int seconds;

        #region Propierties
        public int Minute { get => minute; set => minute = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        #endregion

        #region Builders
        public NotifyTimeEventArgs(int minute, int seconds)
        {
            this.minute = minute;
            this.seconds = seconds;
        }
        #endregion


    }
}
