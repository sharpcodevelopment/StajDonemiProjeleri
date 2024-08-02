namespace StajDonemiProjeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //while (true)
            //{
            //    Console.WriteLine("lütfen dersin adını giriniz");
            //    string ders = Console.ReadLine();
            //    Console.WriteLine("not girmek istiyormusunuz" +
            //        "evet için e /" +
            //        "hayır için h basınız");
            //    char devammi=Convert.ToChar(Console.ReadLine());
            //    if (devammi == 'e')
            //    {
            //        Console.WriteLine("başarılı");
            //    }
            //    else if(devammi=='h')
            //    {
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("lütfen bir ders giriniz");
            //    }
            //}
            Dictionary<string, List<int>> dersNotlari = new Dictionary<string, List<int>>();
            Dictionary<string, double> dersOrtalamalari = new Dictionary<string, double>();

            while (true)
            {
                Console.WriteLine("Ders girecek misiniz? (evet için 'e', hayır için 'h' basınız)");
                char cevap = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

                if (cevap == 'h')
                {
                    break;
                }

                if (cevap == 'e')
                {
                    Console.WriteLine("Lütfen ders adını girin:");
                    string ders = Console.ReadLine();

                    if (!dersNotlari.ContainsKey(ders))
                    {
                        dersNotlari[ders] = new List<int>();
                    }

                    while (true)
                    {
                        Console.WriteLine("Lütfen notu girin (bitirmek için 'b' basınız):");
                        string notInput = Console.ReadLine();
                        if (notInput.ToLower() == "b")
                        {
                            break;
                        }

                        if (int.TryParse(notInput, out int not))
                        {
                            dersNotlari[ders].Add(not);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz not, lütfen bir sayı girin.");
                        }
                    }

                    double ortalama = NotHesapla(dersNotlari[ders]);
                    dersOrtalamalari[ders] = ortalama;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş, lütfen 'e' veya 'h' basınız.");
                }
            }

            foreach (var ders in dersOrtalamalari)
            {
                Console.WriteLine($"{ders.Key} dersinin not ortalaması: {ders.Value:F2}");
            }
        }

        static double NotHesapla(List<int> notlar)
        {
            if (notlar.Count == 0)
            {
                return 0;
            }

            double toplam = 0;
            foreach (int not in notlar)
            {
                toplam += not;
            }

            return toplam / notlar.Count;
        }


    }

      

        //public static void dersAdi()
        //{
        //    List<string> dersler = new List<string>();
        //    while (true)
        //    {

        //        Console.WriteLine("ders girecekmisiniz");

        //        char cevap = Convert.ToChar(Console.ReadLine());
                

        //        if (cevap == 'h')
        //        {
        //            break;
        //        }

        //        if (cevap == 'e')
        //        {
        //            Console.WriteLine("lütfen ders gir ");
        //            string ders = Console.ReadLine();
        //            dersler.Add(ders);
        //        }
        //        else
        //        {
        //            Console.WriteLine("geçersiz değer girdiniz");
        //        }

        //    }
        //    foreach (string s in dersler)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
        //public static int notHesaplama()
        //{
        //    string ders1;
        //    return 0;
        //}
    }
     

