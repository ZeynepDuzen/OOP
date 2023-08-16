using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();

            string ad = "Zeynep";
            insan.SetAdi(ad);
            Console.WriteLine("Ad : " + insan.GetAdi());

            string soyAd = "Cankus";
            insan.SetSoyAdi(soyAd);
            Console.WriteLine("Soyad : " + insan.GetSoyAdi());

            int yas = 38;
            insan.SetYasi(yas);
            Console.WriteLine("Yas : " + insan.GetYasi());

            

           
           

           

            Console.Read();

        }
    }

    class Insan
    {
        string _adi;
        string _soyAdi;
        int _yasi;

        //public void SetAdi(string adi) // java kullanimi
        //{
        //    this.adi = adi;
        //}

        public void SetAdi(string ad)
        {
            _adi = ad;
        }

        public string GetAdi()
        {
            return _adi;
        }

        public void SetSoyAdi(string soyAd)
        {
            _soyAdi = soyAd;
        }

        public string GetSoyAdi()
        {
            return _soyAdi;
        }

        public void SetYasi(int yas)
        {
            _yasi = yas;
        }

        public int GetYasi()
        {
            return _yasi;
        }
    }
}
