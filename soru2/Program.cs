namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        Car car1=new Car("Toyota","corolla",2009,5);
        car1.AracBilgileri();
        System.Console.WriteLine(car1.AracBilgileri());
        Motorcycle motorcycle1=new Motorcycle("Yamaha","Mt-25",2019,false);
        motorcycle1.AracBilgileri();
        System.Console.WriteLine(motorcycle1.AracBilgileri());
        Bicycle bicycle1=new Bicycle("Bisikletix","Climb bicycle",2023,13.25);
        bicycle1.AracBilgileri();
        System.Console.WriteLine(bicycle1.AracBilgileri());
        
    }
}
