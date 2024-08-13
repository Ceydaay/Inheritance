using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi
    {
        public string ad {  get; set; }
        public string soyad { get; set; }

        public void Yazdir ()
        {
            Console.WriteLine($"Ad:{ad} Soyad:{soyad}");
        }

        public class Ogrenci: BaseKisi
        {
            public string OgrenciNumarasi { get; set; }

            public void OgrenciYazdir()
            {
                Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
                Yazdir();
            }

        }

        public class Ogretmen : BaseKisi
        {
            public string MaasBilgisi { get; set; }

            public void OgretmenYazdir()
            {
                Console.WriteLine($"Öğrenci Numarası: {MaasBilgisi}");
                Yazdir();

            }
        }

    }
}
