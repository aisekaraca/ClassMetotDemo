using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine("Yeni müşteri eklendi.");

        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.AdiSoyadi + "isimli müşteri kaydı silindi.");
        }

        public void Listele(Musteri musteri)
        {
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (Musteri musteri in musteriler)
            {

            }
        }
    }
}
