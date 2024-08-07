using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStajDefterOrnek
{
    public class StajDefteri
    {
        public List<Gorev> Gorevler { get; set; } = new List<Gorev>();
        public List<GunlukKaydi> GunlukKayitlari { get; set; }=new List<GunlukKaydi>();
        public List<Proje> Projeler { get; set; }= new List<Proje>();

        public  void gunlukEkle(GunlukKaydi gunlukEkle)
        {
            GunlukKayitlari.Add(gunlukEkle);
        }
        public  void projeEkle(Proje proje)
        {
            Projeler.Add(proje);
        }
        public void gorev(Gorev gorev)
        {
            Gorevler.Add(gorev);
        }

        public void yazdir()
        {
            Console.WriteLine("Günlük Kayıtları");
            foreach (var item in GunlukKayitlari)
            {   
                Console.WriteLine($"{item.History.ToShortDateString()}-{item.Description}");
            }
            Console.WriteLine("Görevler");
            foreach(var gorev in Gorevler)
            {
                Console.WriteLine($"{gorev.Name}-{gorev.Description}-{gorev.Complete}");
            }
            Console.WriteLine("projeler");
            foreach(var proje in Projeler)
            {
                Console.WriteLine($"{proje.Name}-{proje.Description}");
            }
        }
    }
}
