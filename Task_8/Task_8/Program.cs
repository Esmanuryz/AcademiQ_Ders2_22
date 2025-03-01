
// Task 8
// Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran program


using System;
class HelloWorld
{
    static void Main()
    {

        List<string> kelimeler = new List<string>();
        string temp_kelime;

        Console.WriteLine("Girilen kelimeleri tersten yazdiran program");
        Console.WriteLine("Kelimelerinizi giriniz (bitince -1 yaziniz) : ");


        while (true)
        {
            temp_kelime = Console.ReadLine();

            if (temp_kelime == "-1") // cikis yeri
            {

                break;

            }
            else
            {
                kelimeler.Add(temp_kelime); //kelimeleri listeye ekleme
            }
        }

        for(int i = kelimeler.Count() - 1 ; i >= 0; i--) //tersten yazdirma kismi 
        {
            Console.WriteLine(kelimeler[i]);
        }


    }
}