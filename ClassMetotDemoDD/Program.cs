using System;

namespace ClassMetotDemoDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "mehmet";
            musteri1.Soyadi = "aslan";
            musteri1.TcNo = 12315123;

            Musteri musteri2 = new Musteri();
            musteri1.Id = 2;
            musteri1.Adi = "ahmet";
            musteri1.Soyadi = "cakır";
            musteri1.TcNo = 789456;

            Musteri musteri3 = new Musteri();
            musteri1.Id = 3;
            musteri1.Adi = "kadir";
            musteri1.Soyadi = "hoca";
            musteri1.TcNo = 456469871;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.ekle(musteri2);
            Console.WriteLine("-----------");
            musteriManager.sil(musteri3);
            Console.WriteLine("-----------");
            musteriManager.HerkesiListele(musteriler);


        }
    }
}
