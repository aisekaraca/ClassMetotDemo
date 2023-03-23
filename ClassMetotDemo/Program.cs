using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1= new Musteri();
        musteri1.Id = 1;
        musteri1.AdiSoyadi = "Aise Karaca";
        musteri1.DogumTarihi = "27.12.1994";
        musteri1.Sube = "Adana Üniversite Şube";

        Musteri musteri2 = new Musteri();
        musteri2.Id = 2;
        musteri2.AdiSoyadi = "Ahmet Karaca";
        musteri2.DogumTarihi = "10.10.1994";
        musteri2.Sube = "Hatay Kırıkhan Şube";

        Musteri musteri3 = new Musteri();
        musteri3.Id = 3;
        musteri3.AdiSoyadi = "Vedat Ağba";
        musteri3.DogumTarihi = "17.06.1968";
        musteri3.Sube = "Adana Pınar Şube";

        Musteri musteri4 = new Musteri();
        musteri4.Id = 4;
        musteri4.AdiSoyadi = "Fatma Özkurt";
        musteri4.DogumTarihi = "31.01.1977";
        musteri4.Sube = "Adana Çarşı Şube";
        
        Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };




    }
}