// Task 3
// (foreach) kişilerin yaş kategorilerini belirleme ( 0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı.)

using System;
using System.Collections.Generic;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Yas kategorilerinin belirlenmesini istediginiz yaslari giriniz, gireceginiz yas sayisi bitince -1 yazmaniz yeterli: ");
        int yas = 0;

        List<int> yaslar = new List<int>();

        while(true) 
        {

            if (yas == -1)
            {
                break;
            }
            yas = Convert.ToInt32(Console.ReadLine());
            yaslar.Add(yas);
        }
        List<int> cocuk = new List<int>();
        List<int> genc = new List<int>();
        List<int> yetiskin = new List<int>();
        List<int> yasli = new List<int>();
        List<int> gecersiz = new List<int>();


        foreach (int i in yaslar)
        {
            if (i>=0 && i <= 12) //0-12 = cocuk
            {
                cocuk.Add(i);

            } else if (i >= 13 && i <= 19) //13-19 = genc
                {
                    genc.Add(i);

                }else if (i >= 20 && i <= 64) //20-64 = yetiskin
            {
                yetiskin.Add(i);

            } else if (i >= 65) //65+ = yasli
            {
                yasli.Add(i);

            }
            else //-1 harici degerler girilmesi durumunda 
            {
                gecersiz.Add(i);
            }
        }

        Console.WriteLine("Cocuklarin yaslari: ");
        foreach(int x in cocuk)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();


        Console.WriteLine("genclerin yaslari: ");
        foreach (int x in genc)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();


        Console.WriteLine("yetiskin yaslari: ");
        foreach (int x in yetiskin)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.WriteLine("yasli yaslari: ");
        foreach (int x in yasli)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Gecersiz girilen yaslar: ");
        foreach (int x in gecersiz)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}