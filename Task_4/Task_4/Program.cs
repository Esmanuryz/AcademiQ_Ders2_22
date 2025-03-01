
// Task 4
// Bir dizide tekrar eden elemanları bulan uygulama


using System;
class HelloWorld
{
    static void Main()
    {

        /*
        array olustur 

        icini doldur, ayni elemanlar olmasi lazim
         
        dongu butun elemanlari kontrol etme kisma (foreach) {

        list<int> temp_list = 
        
        }
         */

        int[] sayilar = new int[10] {5,76,5,12,12,65,76,9,9,5};

        List<int> tekrar_sayilar = new List<int>();

        for (int i = 0; i < sayilar.Length - 1; i++)
        {
            for (int y = i + 1; y < sayilar.Length; y++) // Kendini kontrol etmemek için y = i+1 başlar!!!
            {
                if (sayilar[i] == sayilar[y] && !tekrar_sayilar.Contains(sayilar[i])) // Daha önce eklenmediyse ekle
                {
                    tekrar_sayilar.Add(sayilar[i]);
                }
            }
        }

        foreach(int x in tekrar_sayilar)
        {
            Console.WriteLine(x + " tekrar eden bir sayidir.");
        }



    }
}