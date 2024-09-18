using System;

namespace soru5;

public class Task : Event
{
    public Task(string name, DateTime eventTime, string location) : base(name, eventTime, location)
    {
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Ödevler tamamlandi.");
    }
    public override string Gorev()
    {
        return base.Gorev();
    }
}
