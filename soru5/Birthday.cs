using System;

namespace soru5;

public class Birthday : Event
{
    public Birthday(string name, DateTime eventTime, string location) : base(name, eventTime, location)
    {
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Dogum günü için pasta alindi.");

    }
    public override string Gorev()
    {
        return base.Gorev();
    }
}
