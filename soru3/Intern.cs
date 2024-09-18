using System;

namespace soru3;

public class Intern : Employee
{
    public Intern(string name, int ıd, int salary, string mezun) : base(name, ıd, salary)
    {
        Mezun = mezun;
    }


    public string Mezun { get; set; }

    public override string CalisanBilgisi()
    {
        return $"{base.CalisanBilgisi()} ve Mezun oldugu okul:{Mezun}";
    }
}
