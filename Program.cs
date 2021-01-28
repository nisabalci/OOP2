using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            TuzelMusteri musteri1 = new TuzelMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "545454";
            musteri1.SirketAdi = "NB Software";
            musteri1.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri3);

        }
    }
}
