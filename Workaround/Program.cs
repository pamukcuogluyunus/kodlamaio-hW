// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using System;
using Entities.Concrete;

namespace Workaround
{

    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler

            //Vatandas olusturduk
            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer();

            int sonuc = Topla(3, 5);

            //Diziler / Arrays
            //
            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            //Diziler referans tiptir
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            //Bu sekilde ekranda sadece İlker yazar
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            //Döngü
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);

            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]); //Adana gelecektir ekrana

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            //sayi2 ?? burada referans degil deger tip kullanildi bu sebeple sayi2 10 olacaktir


            Person person1 = new Person();
            person1.FirstName = "SECANUR";
            person1.LastName = "KALFAOĞLU";
            person1.DateOfBirthYear = 1996;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "OKAN";

            //string referans tiptir ama deger tip gibi calisir.

            //foreach dongusu ile dizi formatindaki yapilar doner
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            //MyList diye bir collection yaz. Listeyi bilmiyor olsaydin nasil yapardin ? ekle fonksiyonu için


            //Artık diziler yerine asagidaki yapi kullanilir
            //Bu yapiya Generic Collection denir
            //TypeSafe
            List<string> yeniSehirler1 = new List<string>{"Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            //yeniSehirler1 dizisi artik 4 elemanli bir dizi 
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(person1);

        Console.ReadLine();
        }

        //Metod
        //Void metodlar deger return etmezler. Sadece verilen gorevi yaparlar. (Kaydet vs islemler icin kullanilir. Hesaplama yapmazlar)
        //Main'de kullanilacagi icin static olmak zorunda
        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        //sayi1 ve sayi2 verilmezse default olarak asagidaki degerler kullanilir.
        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            //Console.WriteLine icerisinde tip donusumu otomatik gerceklesir, bu sebeple burada ToString() yazilmasi zorunlu degildir.  
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            //bunun yerine mantiksal gruplara ayirarak nesneler olusturulacak ve projede o nesneler-classlar kullanilacak 
            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12354678910;



            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        //degiskenleri public yaparak bu class'in disinda da kullanilmasi saglandi.
        //Public olunca degiskenin adı buyuk harfle baslar. Pascal Casing
        //property ile degiskenler yonetilir
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

