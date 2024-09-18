using System;

namespace soru8;

public class Student : Person
{
    public Student(string name, int age, int gradeLevel, string attendClass) : base(name, age)
    {
        GradeLevel = gradeLevel;
        AttendClass = attendClass;
    }
    public int GradeLevel { get; set; }
    public string AttendClass { get; set; }

    public override void Makesound()
    {
        System.Console.WriteLine($"{GradeLevel}. Öğrencisi {Name} {AttendClass}");
    }

}
