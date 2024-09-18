namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        FoodProduct foodProduct1=new FoodProduct("Süt",22,234,new DateTime(2024,5,12));
        foodProduct1.MakeSound();
        foodProduct1.UpdateStock();
        System.Console.WriteLine(foodProduct1.UpdateStock());
        System.Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
        ElectronicProduct electronicProduct1=new ElectronicProduct("Telefon",34000,5,"2 Yil");
        electronicProduct1.MakeSound();
        electronicProduct1.UpdateStock();
        System.Console.WriteLine(electronicProduct1.UpdateStock());
    }
}
