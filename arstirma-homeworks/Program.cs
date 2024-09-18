namespace arstirma_homeworks;

class Program
{
    static void Main(string[] args)
    {
        
        /*
        1)Veri tabanı nedir(Relational Database Management System(RDBMS))?

        --tablolarda satır ve sütunlar hâlinde tutulduğu ve yüksek bir veri tutarlılığına sahip veri depolama sistemidir.
İlişkisel veri tabanını çeşitli tablolar arasında organize edilmiş verilerden oluşan veri tabanı olarak açıklanabilir. Bu farklı tablolar arasındaki veriler, çeşitli anahtarlar vasıtası ile birbirlerine bağlanırlar İlgili tablolarda, sütunlar arasında bir anahtar sütun yer alır. Bu anahtar sütun aracılığı ile birden çok tablo verileri birbiriyle bağlantı sağlayabilir ve herhangi bir sorgulamada birlikte görüntülenebilir Bu tür veri tabanları arasında dBase, Informix, Ingres, MySQL Oracle ve PostgreSQL başta gelmektedir.
Örnek olarak isim ve numaralardan oluşan bir liste ilişkisel veri tabanıdır. Yalnızca kişilerin numaralarının gözüktüğü beyaz sayfalar bir çeşit veri tabanını oluşturur. Polis ve itfaiye gibi kurumların sıralaması ise beyaz sayfalardaki gibi kişi adlarına göre değil numaralarına göre yapılır Belirli bir amaç için yapılan bu sıralama veriye erişim kolaylığı sağlamaktadır.
        
         2)SQL ve Veri Yönetimi(Structured Query Language)
SQL, verilerin yönetilmesi, silinmesi, aktif edilmesi ve üzerinde çalışmasını sağlayan veri tabanı yönetim sistemidir. Structured Query Language kelimelerinin kısaltılmışı olan SQL'in Türkçe karşılığı yapılandırılmış sorgu dili anlamına gelir.

Temel Komutları:
1=Select
2=Count
3=Upper/Lower
4=Select where
5=Select Distinct
6=Orde by
7=Limit
8=Between
9=Like ve Ilike
10=In
11=Aggregate



             3)Dapper nedir?
             Dapper, .NET dünyası için basit bir Mikro ORM’dir. Veritabanı işlemleri için herhangi bir .NET projesine eklenebilen bir NuGet kitaplığıdır. ORM (Object Relational Mapping), Nesne İlişkisel Eşleme anlamına gelir. Yani tüm veritabanı, class’lar, interface’ler vb. açısından çalıştırılabilir. ORM, sınıflar açısından bir “sanal veritabanı” oluşturur ve bu sınıflarla çalışmak için yöntemler sağlar. Dapper ise veritabanı şeması oluşturmak, veritabanı şemasını değiştirmek, değişikleri izlemek gibi işlemler yerine veritabanı tablolarıyla çalışmak gibi önemli görevlere odaklanmak üzere tasarlanmış bir Mikro ORM’dir.


             Dapper kullanmak için sebepler
             1)Dapper bir NuGet kitaplığı olduğu için yüksek performanslı ve hafiftir.
             2)Veritabanı erişim kodunu büyük ölçüde azaltır.
             3)ORM'nin tüm görevleri yerine veritabanı görevlerine odaklanır.
             4)Herhangi bir veritabanı ile çalışabilir. SQL Server, Oracle, SQLite, MySQL, PoestgreSQL vb.
             Dapper KULLANMAMAK için sebepler!
             1)Daha Az Soyutlama: Entity Framework gibi daha büyük ORM araçları, veritabanındaki tablolarımıza karşılık gelen entity nesnelerini otomatik oluşturmaktadır. Dapper’de ise ihtiyaç duyduğumuz bu nesneleri kendimiz oluşturmalıyız.
             2)Karmaşıklıkla Başa Çıkma: Dapper, daha basit projeler için idealdir, ancak karmaşık veritabanı yapıları veya çoklu ilişkiler içeren projelerde daha fazla manuel iş yapma gerektirebilir. Entity Framework, karmaşık ilişkileri daha kolay yönetmeye yardımcı olabilir.
             3)Belirli Senaryolara Odaklanma: Dapper, performans ve hız odaklı olduğu için, her tür projeye uygun olmayabilir. Belirli senaryolara odaklanmış bir araçtır ve bu nedenle her projede en iyi seçenek olmayabilir.
             4)İnline olarak yazılan sql cümleciklerinde hata yapılabilme ihtimali. Ve bu hataların çalışma zamanında farkedilebilmesi.




                 4)Veri Normalizasyonu?
            Normalizasyon; veri tabanı tasarım aşamasında veri tekrarını, veri kaybını veya veri yetersizliğini önlemek için gerçekleştirilen işlemlerdir. tekrarlardan arındırmak için daha az satır ve sütun içeren alt kümelerine ayrıştırma işlemidir. her birine normal form adı verilir.

              NORMALİZASYONUN FAYDALARI
              1)Veri tekrarını engeller ve tablolar arasında daha tutarlı bir çalışma sağlar.
              2)Saklanan verilerimiz daha anlaşılır hale gelir.
              3)Veri tabanı sorgularımızın hızlı bir şekilde çekilmesi sağlar.
              4)Verimli bir veri yapısı sunar.



             5)SQL Injection Nedir?
             SQL injection, bir bilgisayar korsanının uygulama tarafından veri tabanına gönderilen SQL sorgularını manipüle etmesine olanak tanıyan bir güvenlik tehdidi türüdür. Bilgisayar korsanı, izni olmayan verilere erişim elde edebilir. 

             Önlenme Yoları

             1)Parametrelendirilmiş sorgular içeren hazır deyimler:
             Bu, bir saldırıyı önlemek için güçlü bir korumadır. Geliştiriciler, veri ve uygulama kodu arasında ayrım yapamayan dinamik sorgular yazmaktan kaçınmak için hazır deyimler tarafından zorlanmaktadır. Bunun yerine, statik SQL sorguları kullanmalı ve sorguya harici girdi aktarmalıdırlar. Bu, SQL yorumlayıcısının kod ve veri arasında ayrım yapmasını sağlar.

             2)Saklı yordamlar:
             Bunlar, bir veri tabanında tanımlanıp saklanan ve daha sonra bir uygulamadan çağrılabilen SQL deyimleridir. Geliştiricilerin genellikle otomatik olarak parametrelendirilebilen parametrelere sahip SQL deyimleri oluşturmaları gerekir. Bununla birlikte, saklı yordamlar içinde dinamik SQL sorguları oluşturmak mümkündür.

             3)Girdi doğrulama:
             Kötü niyetle hazırlanmış girdi, SQL enjeksiyonunun yaygın bir kaynağıdır. En iyisi, girdi doğrulama olarak bilinen bir uygulama ile yalnızca onaylanmış girdiyi kabul etmektir. Buna karşı koruma sağlamak için iki tür girdi doğrulaması vardır: blok listesi doğrulaması veya izin listesi doğrulaması.

             4)En az ayrıcalık ilkesi:
             Bu güvenlik önlemi, başarılı bir saldırının neden olabileceği hasarı en aza indirmeye yardımcı olur. Uygulama hesaplarına veri tabanı sunucusuna DBA ve admin erişimi verilmemelidir. Erişim, erişim gereksinimlerine bağlı olarak her zaman en kısıtlı olarak ayarlanmalıdır. Yalnızca okuma erişimi gerektiren hesaplara yalnızca ihtiyaç duydukları tablolara erişim izni verilecektir. Bu, uygulamanın ele geçirilmesi durumunda bir saldırganın veri tabanına yazma erişimine sahip olmayacağı anlamına gelir.
             



        */
    }
}
