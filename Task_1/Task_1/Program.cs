// Task 1
// For döngüsü ile sayının rakamlarının toplamını bulma
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Bu program girdiginiz sayinin rakamlari toplamini verir.");
        Console.WriteLine("Bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int toplam = 0;

        /*
        

        6789
         for(int i = 0; i!= -1; ){
        6789 % 10 = 9 //birinci basamak
        basamak_degeri = 6789 % 10
        sum += basamak_degeri
        6789 // 10 = 678
        sayi = 6789 // 10
        

        sayi 0 a esit olmadigi surece devam eder.
        if(sayi == 0){
        i = -1;
        }
        }
         //ekrana sum u yazdir.

         
         */

        for (int i = 0; i != -1;)
        {
            toplam += sayi % 10;
            sayi = sayi / 10;


            //sayi 0 a esit olmadigi surece devam eder.
            if (sayi == 0)
            {
                i = -1;
            }
        }

        Console.WriteLine("Girilen sayinin basamaklari toplami: " + toplam);






    }
}