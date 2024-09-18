using System;

namespace soru8;

public class Teacher : Person
{
    public Teacher(string name, int age, string subjectTaught, string attendClass) : base(name, age)
    {
        SubjectTaught = subjectTaught;
        AttendClass = attendClass;
    }
    public string SubjectTaught { get; set; }
    public string AttendClass { get; set; }


    public override void Makesound()
    {
        System.Console.WriteLine($"{Name} Hoca {AttendClass}");
    }
}
