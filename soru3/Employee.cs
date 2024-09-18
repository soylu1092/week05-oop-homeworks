using System;

namespace soru3;

public class Employee
{
    public Employee(string name, int ıd, int salary)
    {
        Name = name;
        Id = ıd;
        Salary = salary;
    }

    public string Name { get; set; }
public int Id { get; set; }
public int Salary { get; set; }

public virtual string CalisanBilgisi(){
    return $"İsim:{Name},Kimlik numarasi:{Id},Maas:{Salary}";
}

}
