using System;

namespace soru5;

public class Meeting : Event
{
    public Meeting(string name, DateTime eventTime, string location) : base(name, eventTime, location)
    {
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Toplanti için tüm hazirliklar başladi.");
    }
    public override string Gorev()
    {
        return base.Gorev();
    }
}
