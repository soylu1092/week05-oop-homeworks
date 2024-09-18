using System;

namespace soru3;

public class Developer : Employee
{
    public Developer(string name, int ıd, int salary, string programmingLanguage) : base(name, ıd, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public string ProgrammingLanguage { get; set; }



    public override string CalisanBilgisi()
    {
        return $"{base.CalisanBilgisi()} ve Programlama dili:{ProgrammingLanguage}";
    }
}
