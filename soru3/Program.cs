using System.Runtime.InteropServices;

namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        Manager manager1=new Manager("Yusuf",324567,100000,5);
        manager1.CalisanBilgisi();
        System.Console.WriteLine(manager1.CalisanBilgisi());
        Developer developer1=new Developer("Cem",23145125,50000,"Java Script");
        developer1.CalisanBilgisi();
        System.Console.WriteLine(developer1.CalisanBilgisi());
        Intern ıntern1=new Intern("Cemil",231451251,12000,"Ege Üniversitesi");
        ıntern1.CalisanBilgisi();
        System.Console.WriteLine(ıntern1.CalisanBilgisi());
    }
}
