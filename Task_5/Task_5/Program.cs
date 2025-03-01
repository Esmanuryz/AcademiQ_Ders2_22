
// Task 5
// Bir dizide en uzun ve en kısa kelimeyi bulan program

using System;

class HelloWorld
{
    static void Main()
    {

        string[] kelimeler = new string[6] { "Esmanur", "Yorulmaz", "deneme", "merhabalaarrr", "dunyanin en uzun kelimesi", "kisa" };
        List<int> harf_sayilari = new List<int>();
        
        for (int i = 0; i < kelimeler.Length; i++) // kelime uzunluklarini hesaplama
        {
            char[] kelime_in_char = kelimeler[i].ToCharArray();
            harf_sayilari.Add(kelime_in_char.Length);

        }

        int minIndex = 0;
        int maxIndex = 0;
        int minValue = harf_sayilari[0];
        int maxValue = harf_sayilari[0];

        for (int i = 1; i < harf_sayilari.Count; i++)
        {
            if (harf_sayilari[i] < minValue)
            {
                minValue = harf_sayilari[i];
                minIndex = i; //onemli
            }
            if (harf_sayilari[i] > maxValue)
            {
                maxValue = harf_sayilari[i];
                maxIndex = i; //onemli
            }
        }

        Console.WriteLine(kelimeler[maxIndex] + " en buyuk harf sayisina sahip olan kelimedir.");
        Console.WriteLine(kelimeler[minIndex] + " en kucuk harf sayisina sahip olan kelimedir.");



    }
}