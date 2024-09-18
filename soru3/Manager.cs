using System;

namespace soru3;

public class Manager : Employee
{
    public Manager(string name, int ıd, int salary, int numberOfTeams) : base(name, ıd, salary)
    {
        NumberOfTeams = numberOfTeams;
    }
    public int NumberOfTeams { get; set; }


    public override string CalisanBilgisi()
    {
        return $"{base.CalisanBilgisi()} ve Takim sayisi:{NumberOfTeams}";
    }
}
