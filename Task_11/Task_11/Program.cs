
// Task 11
// Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen program


using System;
class HelloWorld
{
    static void Main()
    {

        Console.WriteLine("Bu program 50’nin altındaki tüm notları 50 olarak günceller."); 
        List<int> notlar = new List<int>();

        notlar.Add(26); //notlari manuel belirledim.
        notlar.Add(52);
        notlar.Add(42);
        notlar.Add(98);
        notlar.Add(76);
        notlar.Add(82);
        notlar.Add(26);
        notlar.Add(10);
        notlar.Add(8);
        notlar.Add(64);
        notlar.Add(58);
        notlar.Add(16);
        notlar.Add(9);
        notlar.Add(64);
        notlar.Add(3);

        for(int i = 0; i < notlar.Count(); i++ ) // not guncelleme kismi
        {
            if (notlar[i] < 50)
            {
                notlar[i] = 50;
            }
        }

        Console.WriteLine("Guncellenen notlar: ");

        foreach(int num in notlar)
        {
            Console.WriteLine(num);
        }


    }
}