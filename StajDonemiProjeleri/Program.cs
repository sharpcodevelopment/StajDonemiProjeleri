namespace CsharpStajDefterOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StajDefteri defter = new StajDefteri();
            defter.projeEkle(new Proje { Name = "e-ticaret sitesi", Description = "full responsive e ticaret sitesi tasarlama" });
            defter.gunlukEkle(new GunlukKaydi{History=DateTime.Now, Description="ilk gün" });
            defter.gunlukEkle(new GunlukKaydi { History = DateTime.Now.AddDays(1), Description ="html ve css tasarlanacak"});

            defter.gorev(new Gorev { Name="veritabanı",Description="veritabanı tasarlama ve yönetme",Complete=true});
            defter.gorev(new Gorev { Name="web sayfa tasarımı ",Description="tasarımları kodlama",Complete=false});

            defter.yazdir();

            Console.WriteLine("Bitti");




        }
    }
}
