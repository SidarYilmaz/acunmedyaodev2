//For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.

/*
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int temp = Math.Abs(number); temp > 0; temp /= 10)
        {
            sum += temp % 10; // Son basamağı toplama ekle
        }

        Console.WriteLine("Rakamların toplamı: " + sum);
    }
}
*/

//while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız(Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste.)

/*using System;

class Program
{
    static void Main()
    {
        int number;

        // Kullanıcıdan geçerli bir sayı almak için while döngüsü
        while (true)
        {
            Console.Write("Lütfen 10 ile 100 arasında bir sayı giriniz: ");

            // Kullanıcının girdiği değeri kontrol et
            if (int.TryParse(Console.ReadLine(), out number))
            {
                // Sayı 10 ile 100 arasında mı?
                if (number >= 10 && number <= 100)
                {
                    Console.WriteLine($"Girilen sayı: {number} başarılı bir şekilde alındı.");
                    break; // Geçerli bir sayı girildiğinde döngüden çık
                }
                else
                {
                    Console.WriteLine("Hata: Lütfen 10 ile 100 arasında bir sayı giriniz.");
                }
            }
            else
            {
                Console.WriteLine("Hata: Geçerli bir sayı giriniz.");
            }
        }
    }
}
*/

//foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.( 0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı.)

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Yaşları içeren bir liste
        List<int> ages = new List<int> { 8, 15, 25, 45, 70, 10, 30, 18, 66 };

        // foreach döngüsü ile yaşları kontrol et
        foreach (int age in ages)
        {
            // Yaş kategorilerini belirle
            if (age >= 0 && age <= 12)
            {
                Console.WriteLine($"{age} yaşındaki kişi: Çocuk");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine($"{age} yaşındaki kişi: Genç");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine($"{age} yaşındaki kişi: Yetişkin");
            }
            else if (age >= 65)
            {
                Console.WriteLine($"{age} yaşındaki kişi: Yaşlı");
            }
        }
    }
}
*/

//Bir dizide tekrar eden elemanları bulan algoritmayı yazınız
/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 2, 7, 3, 8, 5 }; // Örnek dizi
        HashSet<int> seen = new HashSet<int>(); // Önceden görülen elemanları tutar
        HashSet<int> duplicates = new HashSet<int>(); // Tekrar eden elemanları tutar

        // Dizideki her eleman için döngü
        foreach (int number in numbers)
        {
            // Eğer bu eleman daha önce görüldüyse, tekrar eden bir eleman
            if (!seen.Add(number))
            {
                duplicates.Add(number); // Tekrar eden elemanları duplicates setine ekle
            }
        }

        // Tekrar eden elemanları yazdır
        if (duplicates.Count > 0)
        {
            Console.WriteLine("Tekrar eden elemanlar:");
            foreach (int duplicate in duplicates)
            {
                Console.WriteLine(duplicate);
            }
        }
        else
        {
            Console.WriteLine("Tekrar eden eleman yok.");
        }
    }
}
*/

//Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız

/*using System;

class Program
{
    static void Main()
    {
        string[] words = { "elma", "armut", "kavun", "muz", "portakal", "karpuz" }; // Örnek dizi

        // En uzun ve en kısa kelimeleri başlangıçta ilk kelimeye eşitle
        string shortest = words[0];
        string longest = words[0];

        // Dizideki her kelimeyi kontrol et
        foreach (string word in words)
        {
            // Eğer şu anki kelime daha kısa ise, shortest'ı güncelle
            if (word.Length < shortest.Length)
            {
                shortest = word;
            }

            // Eğer şu anki kelime daha uzun ise, longest'ı güncelle
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        // Sonuçları yazdır
        Console.WriteLine("En kısa kelime: " + shortest);
        Console.WriteLine("En uzun kelime: " + longest);
    }
}
*/

//Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.

/*using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan cümle al
        Console.Write("Bir cümle girin: ");
        string sentence = Console.ReadLine();

        // Cümleyi boşluklara göre ayırarak kelimeleri diziye kaydet
        string[] words = sentence.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Diziyi alfabetik olarak sıralama
        Array.Sort(words);

        // Sıralı diziyi yazdırma
        Console.WriteLine("Alfabetik olarak sıralanmış kelimeler:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}*/

//Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.
/*
 * using System;

class Program
{
    static void Main()
    {
        // Başlangıçta bir dizi oluşturuyoruz
        string[] words = new string[3] { "Merhaba", "Dünya", "C#" };

        // Yeni bir kelime eklemek için dizi boyutunu artırıyoruz
        string newWord = "Kod";

        // Dizi boyutunu dinamik olarak genişletmek
        words = AddElementToArray(words, newWord);

        // Genişletilmiş diziyi yazdırma
        Console.WriteLine("Genişletilmiş Dizi:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    // Diziye yeni bir eleman ekleyen metod
    static string[] AddElementToArray(string[] array, string newElement)
    {
        // Yeni bir dizi oluşturuyoruz, eski dizinin bir eleman fazlası olacak
        string[] newArray = new string[array.Length + 1];

        // Eski dizinin elemanlarını yeni diziye kopyalıyoruz
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }

        // Yeni elemanı sonuna ekliyoruz
        newArray[array.Length] = newElement;

        // Yeni diziyi döndürüyoruz
        return newArray;
    }
}
*/

//Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız.

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Kullanıcıdan kelimeleri alacağız
        List<string> words = new List<string>();
        string input;

        Console.WriteLine("Kelime girmeye başlayın. Durmak için 'exit' yazın.");

        // Kullanıcı 'exit' yazana kadar kelime al
        while (true)
        {
            Console.Write("Kelime: ");
            input = Console.ReadLine();

            // Eğer kullanıcı 'exit' yazarsa, döngüyü sonlandır
            if (input.ToLower() == "exit")
                break;

            // Kelimeyi listeye ekle
            words.Add(input);
        }

        // Listeyi tersten yazdır
        Console.WriteLine("\nKelimeler tersten:");
        for (int i = words.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(words[i]);
        }
    }
}*/

//Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.

/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sayıları tutacak liste
        List<int> numbers = new List<int>();
        string input;

        Console.WriteLine("Rastgele sayılar girin (çıkmak için 'exit' yazın):");

        // Kullanıcıdan sayılar al
        while (true)
        {
            Console.Write("Sayı girin: ");
            input = Console.ReadLine();

            // Eğer kullanıcı 'exit' yazarsa döngüyü sonlandır
            if (input.ToLower() == "exit")
                break;

            // Girilen sayıyı tam sayıya çevir
            if (int.TryParse(input, out int number))
            {
                numbers.Add(number); // Sayıyı listeye ekle
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
            }
        }

        // Eğer liste boşsa, kullanıcıdan sayı almadı demektir
        if (numbers.Count == 0)
        {
            Console.WriteLine("Hiç sayı girmediniz.");
            return;
        }

        // Sayıların ortalamasını hesapla
        double average = numbers.Average();
        Console.WriteLine($"Sayılardan oluşan ortalama: {average}");

        // Sayıları küçükten büyüğe sırala
        numbers.Sort();

        // Sıralı sayıları yazdır
        Console.WriteLine("\nSayılar küçükten büyüğe sıralandı:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}*/

//Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Örnek sayı listesi
        List<int> numbers = new List<int> { 5, 12, 3, 8, 15, 2, 20, 7 };

        // 10'dan küçük olanları silme
        numbers.RemoveAll(n => n < 10);

        // Sonuçları yazdır
        Console.WriteLine("10'dan küçük olan sayılar silindi. Kalan sayılar:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}*/

//Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.

/*
 using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Öğrenci notlarının bulunduğu liste
        List<int> studentGrades = new List<int> { 45, 70, 30, 90, 55, 42, 60, 25 };

        // 50'nin altındaki notları 50 olarak güncelle
        for (int i = 0; i < studentGrades.Count; i++)
        {
            if (studentGrades[i] < 50)
            {
                studentGrades[i] = 50;  // Notu 50 ile güncelle
            }
        }

        // Güncellenmiş notları yazdır
        Console.WriteLine("Güncellenmiş öğrenci notları:");
        foreach (int grade in studentGrades)
        {
            Console.WriteLine(grade);
        }
    }
}*/

//12-13-14-15 soruların cevapları
/*
 Metot (fonksiyon), belirli bir görevi yerine getiren, kodun bir kısmını tanımlayan ve belirli bir adı olan bir yapıdır. Bir metot, bir işlem gerçekleştirebilir veya bir değeri döndürebilir. Programın tekrar kullanılabilirliğini artırır ve kodun daha düzenli ve okunabilir olmasını sağlar.

Metotları kullanmamızın ana nedeni, kodu modüler hale getirmektir. Yani, belirli işlemleri metotlara ayırarak, her birini bağımsız olarak çalıştırabilir ve gerektiğinde tekrar tekrar kullanabiliriz. Bu, hem kodun daha okunabilir olmasını sağlar hem de tekrar eden işlemleri minimize ederek yazılımın bakımını kolaylaştırır.

Geriye değer döndüren metotlar (return kullanan) ile void metotlar arasındaki fark şudur: Geriye değer döndüren bir metot, işlemini tamamladıktan sonra bir değer geri döndürür. Bu değer, metodu çağıran yere iletilir ve genellikle hesaplamalar veya veri işlemleri gibi işlerde kullanılır. Void metotlar ise geriye herhangi bir değer döndürmez, sadece belirli bir işlemi gerçekleştirir ve genellikle ekrana yazı yazdırmak gibi yan etkileri olan işlemlerde kullanılır.

Metotların parametreleri, metotlara dışarıdan değer geçirebilmemizi sağlar. Parametreler, metotlar çağrılırken iletilen verilerdir. Bu, metotların esnek olmasını ve farklı durumlarda kullanılmasını sağlar. Parametreler bir metot tarafından işleme alınır ve metot içinde kullanılabilir. Parametreler, genellikle metotların çalışmasını etkileyen dışarıdan gelen değerleri temsil eder.
*/





