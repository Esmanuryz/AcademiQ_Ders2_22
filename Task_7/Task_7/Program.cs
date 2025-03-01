
// Task 7
// Bir string dizisinin boyutunu dinamik olarak genişleten program


using System;
class HelloWorld
{
    static void Main()
    {
        string[] kelimeler = { "Esmanur", "Yorulmaz", "Merhabalar", "Nasilsiniz?" };
        Array.Resize(ref kelimeler, 6); //iki yeni kelime ekleyecegim, dinamik olarak buyuttum
        kelimeler[4] = "dort";
        kelimeler[5] = "bes";

        foreach(string word in kelimeler)
        {
            Console.WriteLine(word);

        }

    }
}