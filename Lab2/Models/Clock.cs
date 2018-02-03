using System;
using System.Timers;

namespace Lab2.Models
{
    public class Clock
    {
        public delegate void ClockTriggeredEventHandler(Clock sender, TimeEventArgs e);

        private Timer _timer;

        public event ClockTriggeredEventHandler ClockTriggeredEvent;

        public void Run()
        {
            _timer = new Timer(1000)
            {
                Enabled = true,
                AutoReset = true
            };
            _timer.Elapsed += TimerEvent;
        }


        private void TimerEvent(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var timeEventArgs = new TimeEventArgs(now.Hour, now.Minute, now.Second);

            ClockTriggeredEvent?.Invoke(this, timeEventArgs);
        }
    }
}