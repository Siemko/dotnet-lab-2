using System;

namespace Lab2.Models
{
    public class TimeEventArgs : EventArgs
    {
        public TimeEventArgs(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour { get; }
        public int Minute { get; }
        public int Second { get; }
    }
}