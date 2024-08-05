class AlisverisListesi:
    def __init__(self):
        self.urunler = []

    def urunEkleme(self, isim, fiyat):
        self.urunler.append({"isim": isim, "fiyat": fiyat})
        print(f"{isim} ürünü {fiyat} TL fiyatıyla listeye eklendi.")

    def urunSilme(self, silinen_isim):
        self.urunler = [urun for urun in self.urunler if urun["isim"] != silinen_isim]
        print(f"{silinen_isim} ürünü listeden silindi.")
    
    def urunDondur(self):
        if not self.urunler:
            print("Alışveriş listesi boş.")
        else:
            for urun in self.urunler:
                print(f"{urun['isim']} ürününün fiyatı {urun['fiyat']} TL")

    def toplamFiyat(self):
        toplam = sum(urun['fiyat'] for urun in self.urunler)
        print(f"Toplam fiyat: {toplam} TL")

    def urunAra(self, isim):
        bulunan_urunler = [urun for urun in self.urunler if urun['isim'] == isim]
        if not bulunan_urunler:
            print(f"{isim} ürünü bulunamadı.")
        else:
            for urun in bulunan_urunler:
                print(f"{urun['isim']} ürününün fiyatı {urun['fiyat']} TL")


def main():
    alisveris_listesi = AlisverisListesi()

    while True:
        print("\nAlışveriş Listesi Uygulaması")
        print("1. Ürün Ekleme")
        print("2. Ürün Silme")
        print("3. Ürünleri Listeleme")
        print("4. Toplam Fiyat Hesaplama")
        print("5. Ürün Arama")
        print("6. Çıkış")
        secim = input("Bir işlem seçiniz (1-6): ")

        if secim == '1':
            isim = input("Ürün adı: ")
            fiyat = float(input("Ürün fiyatı: "))
            alisveris_listesi.urunEkleme(isim, fiyat)
        elif secim == '2':
            silinen_isim = input("Silinecek ürün adı: ")
            alisveris_listesi.urunSilme(silinen_isim)
        elif secim == '3':
            alisveris_listesi.urunDondur()
        elif secim == '4':
            alisveris_listesi.toplamFiyat()
        elif secim == '5':
            isim = input("Aranacak ürün adı: ")
            alisveris_listesi.urunAra(isim)
        elif secim == '6':
            print("Çıkış yapılıyor...")
            break
        else:
            print("Geçersiz seçim. Lütfen tekrar deneyin.")

if __name__ == "__main__":
    main()


