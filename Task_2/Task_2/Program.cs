// Task 2
// (while)Kullanıcıdan 10 ile 100 arasında bir sayı alma ve eğer bu aralık dışında girerse tekrar isteme
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("10 ile 100 arasinda bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());


        while (sayi < 10 || sayi > 100)
        {
            Console.WriteLine("Hatali giris. Tekrar giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("Girilen sayi 10 ile 100 arasindadir. Girilen sayi: " + sayi);

    }
}