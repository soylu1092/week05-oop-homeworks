namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher1=new Teacher("Yusuf",23,"Tarih","Derse Katildi.");
        teacher1.Makesound();
        Student student1=new Student("Cem",15,11,"Derse Katilmadi.");
        student1.Makesound();
    }
}
