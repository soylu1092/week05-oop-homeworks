namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        Warrior warrior1=new Warrior("Savasci",10,"Ağir SALDİRİ!!!!!!!");
        warrior1.KarakterStats();
        System.Console.WriteLine(warrior1.KarakterStats());
        Mage mage1=new Mage("Büyücü",6,"Büyülü KİLİC!!!!");
        mage1.KarakterStats();
        System.Console.WriteLine(mage1.KarakterStats());
        Archer archer1=new Archer("Okcu",15,"Altin OK !!!!!!!!!!!");
        archer1.KarakterStats();
        System.Console.WriteLine(archer1.KarakterStats());

    }
}
