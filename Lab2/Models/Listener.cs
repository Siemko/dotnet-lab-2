using System;

namespace Lab2.Models
{
    public class Listener
    {
        public Listener(string name)
        {
            Name = name;
        }

        private string Name { get; }

        public void Subscribe(Clock clock) => clock.ClockTriggeredEvent += WriteTime;

        private void WriteTime(Clock clock, TimeEventArgs timeEventArgs)
        {
            Console.WriteLine("Listener - Nazwa: {0}, Czas: {1}:{2}:{3}", Name, timeEventArgs.Hour,
                timeEventArgs.Minute, timeEventArgs.Second);
        }
    }
}