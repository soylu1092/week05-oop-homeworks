using System;

namespace soru5;

public class Event
{
    public Event(string name, DateTime eventTime, string location)
    {
        Name = name;
        EventTime = eventTime;
        Location = location;
    }

    public string Name { get; set; }
public DateTime EventTime { get; set; }
public string Location { get; set; }


public virtual void MakeSound(){
    System.Console.WriteLine("");
}
public virtual string Gorev(){
    return $"Etkinlik adi:{Name} Etkinlik tarihi:{EventTime} Etkinlik yeri:{Location}";
}
}
