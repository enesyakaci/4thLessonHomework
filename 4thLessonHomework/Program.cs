using System;
using System.Collections.Generic;

namespace _4thLessonHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> telefonKodu = new Dictionary<int, string>();
            telefonKodu.Add(322, "Adana");
            telefonKodu.Add(312, "Ankara");
            telefonKodu.Add(242, "Antalya");
            telefonKodu.Add(222, "Eskişehir");
            telefonKodu.Add(246, "Isparta");
            telefonKodu.Add(216, "İstanbul");
            telefonKodu.Add(212, "İstanbul");
            telefonKodu.Add(274, "Kütahya");
            telefonKodu.Add(412, "Diyarbakır");
            telefonKodu.Add(342, "Şanlıurfa");

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("Anahtar - Key");
            foreach (var telefon in telefonKodu.Keys)
            {
                Console.WriteLine(telefon);
            }

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("Değer - Value");
            foreach (var telefon in telefonKodu.Values)
            {
                Console.WriteLine(telefon);
            }

            Console.WriteLine("Dizi");
            foreach (var telefon in telefonKodu)
            {
                Console.WriteLine(telefon);
            }
        }
    }
}
