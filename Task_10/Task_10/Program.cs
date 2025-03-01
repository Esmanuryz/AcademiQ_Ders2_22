
// Task 10
// Bir sayı listesinde 10’dan küçük olanları silen uygulama


using System;
class HelloWorld
{
    static void Main()
    {
        List<int> sayilar = new List<int>();
       // List<int> silinecekler = new List<int>();

        sayilar.Add(56);
        sayilar.Add(12);
        sayilar.Add(97);
        sayilar.Add(7);
        sayilar.Add(4);
        sayilar.Add(10);
        sayilar.Add(78);
        sayilar.Add(44);
        sayilar.Add(9);
        sayilar.Add(0);
        sayilar.Add(-78);


        /* 
         
         // burada atlama yapiyor mu ? kontrol et
         foreach (int i in sayilar)
         {
             if(i < 10)
             {
                 silinecekler.Add(i);
             }
         }
         foreach(int x in silinecekler)
         {
             sayilar.Remove(x);

         }*/

        for (int i = sayilar.Count - 1; i >= 0; i--)
        {
            if (sayilar[i] < 10)
            {
                sayilar.RemoveAt(i);
            }
        }

        Console.WriteLine("10’dan küçük olan değerler silindiğinde oluşan liste:");
        foreach (int y in sayilar)
        {
            Console.Write(y + " ");
        }
       
    }
}