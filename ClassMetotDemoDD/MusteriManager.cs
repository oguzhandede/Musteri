using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemoDD
{
    class MusteriManager
    {

        public void ekle (Musteri musteri)
            {
            Console.WriteLine("müsteri başarıyle eklendir " + musteri.Adi);
            }
        public void sil (Musteri musteri)
        {
            Console.WriteLine("musteri başarıyla kaldırıldı " + musteri.Adi);
        }
       
        public void HerkesiListele(Musteri[]  musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Id:" + musteri.Id);
                Console.WriteLine("Ad:" + musteri.Adi);
                Console.WriteLine("Soyadı:" + musteri.Soyadi);
                Console.WriteLine("TC:" + musteri.TcNo);
                Console.WriteLine("-----------");


            }

        }

    }
}
