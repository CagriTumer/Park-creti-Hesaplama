using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_Ücreti_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //OTOPARK ÜCRET HESAPLAMA
            //Bu programda bir otoparkın ücretlendirme sistemi geliştirilecektir. Otopark ücretleri araç tipine göre değişkenlik göstermektedir.

            Console.WriteLine("OTOPARK ÜCRET HESAPLAMA");
            Console.WriteLine("Otomobil için 1’e basın");
            Console.WriteLine("Motosiklet için 2’ye basın");
            Console.WriteLine("Minibüs için 3’e basın");
            Console.WriteLine("Kamyon (ve diğer ticari araçlar) için 4’e basın");
        scm:
            bool dgrm = Int32.TryParse(Console.ReadLine(), out int secim);//arac bilgisini aldık
            if (dgrm == false)
            {
                Console.WriteLine("yanlış seçim yaptınız : tekrar giriş yapınız ");
                goto scm;
            }
        saat:
            Console.WriteLine("kaç saat boyunca park alanında kaldı (double)");
            bool dgr = double.TryParse(Console.ReadLine(), out double saat);//saatbilgisini aldık

            if (dgr == false)
            {
                Console.WriteLine("yanlış secim yaptınız : tekrar giriş yapınız");
                goto saat;
            }
            //otomobil icin saat ücreti
            int otoSaatUcret = 0;
            if (saat >= 0 && saat <= 2)
            {
                otoSaatUcret = 5;
            }
            else if (saat > 2 && saat <= 6)
            {
                otoSaatUcret = 10;
            }
            else if (saat > 6 && saat <= 12)
            {
                otoSaatUcret = 20;
            }
            else if (saat > 12 && saat <= 24)
            {
                otoSaatUcret = 35;
            }
            else
            {
                otoSaatUcret = 35 + (((Convert.ToInt32(saat) - 1) / 24) * 20);
            }
            //motosiklet için saat ücreti
            int motoSaatUcret = 0;
            if (saat >= 0 && saat <= 2)
            {
                motoSaatUcret = 0;
            }
            else if (saat > 2 && saat < 6)
            {
                motoSaatUcret = 3;
            }
            else if (saat > 6 && saat <= 12)
            {
                motoSaatUcret = 6;
            }
            else if (saat > 12 && saat <= 24)
            {
                motoSaatUcret = 20;
            }

            else
            {
                motoSaatUcret = 20 + (((Convert.ToInt32(saat) / 24) - 1) * 10);
            }
            //minibüs için saat ücreti
            int miniSaatUcret = 0;
            if (saat >= 0 && saat <= 2)
            {
                miniSaatUcret = 8;
            }
            else if (saat > 2 && saat < 6)
            {
                miniSaatUcret = 16;
            }
            else if (saat > 6 && saat <= 12)
            {
                miniSaatUcret = 32;
            }
            else if (saat > 12 && saat <= 24)
            {
                miniSaatUcret = 45;
            }

            else
            {
                miniSaatUcret = 45 + (((Convert.ToInt32(saat) / 24) - 1) * 25);
            }
            //kamyon ve ticari için saat ücreti
            int kamyonSaatUcret = 0;
            if (saat >= 0 && saat <= 2)
            {
                kamyonSaatUcret = 15;
            }
            else if (saat > 2 && saat < 6)
            {
                kamyonSaatUcret = 30;
            }
            else if (saat > 6 && saat <= 12)
            {
                kamyonSaatUcret = 60;
            }
            else if (saat > 12 && saat <= 24)
            {
                kamyonSaatUcret = 100;
            }

            else
            {
                kamyonSaatUcret = 20 + (((Convert.ToInt32(saat) / 24) - 1) * 55);
            }
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Ödenmesi Gereken Tutar : " + otoSaatUcret);
                    break;

                case 2:
                    Console.WriteLine("Ödenmesi Gereken Tutar : " + motoSaatUcret);
                    break;

                case 3:
                    Console.WriteLine("Ödenmesi Gereken Tutar : " + miniSaatUcret);
                    break;

                case 4:
                    Console.WriteLine("Ödenmesi Gereken Tutar : " + kamyonSaatUcret);
                    break;

                default:
                    Console.WriteLine("yanlış giriş yaptınız");
                    break;
            }

            Console.ReadKey();

        }
    }
}
