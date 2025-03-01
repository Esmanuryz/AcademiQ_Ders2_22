
// Task 6
// Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan program


using System;
class HelloWorld
{
    static void Main()
    {
        
        Console.WriteLine("Alfabetik olarak siralanmasini istediginiz cumleyi giriniz: ");

        string cumle = Console.ReadLine();
        string[] kelimeler = cumle.Split(' '); //bosluklara gore kelimeleri ayirma

        Array.Sort(kelimeler, StringComparer.OrdinalIgnoreCase); //alfabetik siralama

        Console.WriteLine("ALfabetik siralanmis Kelimeler: ");

        foreach(string i in kelimeler) // ekrana kelimeleri yazdirma kismi
        {
            Console.WriteLine(i);
        }

    }
}