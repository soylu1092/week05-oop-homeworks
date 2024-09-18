namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        Meeting meeting1=new Meeting("Yazilim Bootcamp",new DateTime(2024,9,24),"İstanbul");
        meeting1.MakeSound();
        meeting1.Gorev();
        System.Console.WriteLine(meeting1.Gorev());
        System.Console.WriteLine("-----------------------------------------------------");
        Birthday birthday1=new Birthday("Dogum günü",new DateTime(2024,09,16),"Bursa");
        birthday1.MakeSound();
        birthday1.Gorev();
        System.Console.WriteLine(birthday1.Gorev());
        System.Console.WriteLine("-----------------------------------------------------------");

        Task task1=new Task("Yazilim ödevleri",new DateTime(2024,09,16),"Ev");
        task1.MakeSound();
        task1.Gorev();
        System.Console.WriteLine(task1.Gorev());
    }
}
