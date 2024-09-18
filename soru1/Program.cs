namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        Lion lion1=new Lion("Aslan",2,"Yirtici");
        lion1.Makesound();
        Elephant elephant1=new Elephant("Fil,",14,"Memeli");
        elephant1.Makesound();
        Giraffe giraffe1=new Giraffe("Zürafa",24,"Memeli");
        giraffe1.Makesound();
    }
}
