namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        CheckingAccount checkingAccount1=new CheckingAccount(23421567,8740.20m,true);
        checkingAccount1.HesapHareketleri();
        System.Console.WriteLine(checkingAccount1.HesapHareketleri());
        SavingsAccount savingsAccount1=new SavingsAccount(2341568,34500.23m,false);
        savingsAccount1.HesapHareketleri();
        System.Console.WriteLine(savingsAccount1.HesapHareketleri());
    }
}
