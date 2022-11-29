using System;

namespace Enum
{
    class program
    {
        static void Main(string[]args)
        { 
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);

            int sıcaklık=9;

            if(sıcaklık<=(int)HavaDurumu.Normal)
              Console.WriteLine("Dışarıya Çıkabilmek İçin Havanın Isınmasını Bekleyelim");
            else if (sıcaklık>=(int)HavaDurumu.Sıcak)
              Console.WriteLine("Dışarı Çıkmak İçin Hava Çok Sıcak");
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int) HavaDurumu.ÇokSıcak)
              Console.WriteLine("Hadi Dışarıya Çıkalım");  
        }
    }

    enum Gunler
    { 
        pazartesi = 1,
        salı,
        çarşamba,
        perşembe,
        cuma = 23,
        cumartesi,
        pazar,
    }

    enum HavaDurumu
    { 
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30,
    }
}      