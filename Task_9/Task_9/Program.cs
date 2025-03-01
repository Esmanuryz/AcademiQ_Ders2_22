
// Task 9
// Kullanıcıdan rastgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan program


using System;
class HelloWorld
{
    static void Main()
    {
        List<int> sayilar = new List<int>();

        Console.WriteLine("Lutfen listeye eklemek istediginiz sayilari giriniz, isleminiz bitince -1 girmeniz yeterli olacaktir: ");
        int kontrol = 0;
        int toplam = 0;

        while (true)
        {
            kontrol = Convert.ToInt32(Console.ReadLine());
            if (kontrol == -1) break; 
            sayilar.Add(kontrol);
        }


        foreach (int i in sayilar)
        {
            toplam += i;
        }

        //ortalamasi
        int ort = toplam / (sayilar.Count == 0 ? 1 : sayilar.Count);
        Console.WriteLine("Listenin Ortalamasi: " + ort);


        // Kucukten buyuge dogru olan kisim
        sayilar.Sort();

        Console.WriteLine("Kucukten buyuge dogru siralanmis yeni dizi: ");
        foreach (int x in sayilar)
        {

            Console.WriteLine(x);

        }



    }
}