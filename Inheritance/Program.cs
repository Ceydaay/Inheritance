using static Inheritance.BaseKisi;

public class Program
{
    public static void Main(string[] args)
    {
        // Ogrenci nesnesi oluşturma ve değer atama
        Ogrenci ogrenci = new Ogrenci
        {
            ad = "Ahmet",
            soyad = "Yılmaz",
            OgrenciNumarasi = "123456"
        };

        // Ogretmen nesnesi oluşturma ve değer atama
        Ogretmen ogretmen = new Ogretmen
        {
            ad = "Ayşe",
            soyad = "Kara",
            MaasBilgisi = "7500.50m"
        };

        // Ogrenci ve Ogretmen nesnelerini yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci.OgrenciYazdir();

        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen.OgretmenYazdir();
    }
}