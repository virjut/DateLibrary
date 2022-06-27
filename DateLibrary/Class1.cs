using System;

namespace DateLibrary
{
    public class Aikafunktio
    {
        public static bool Onkotulevaisuudessa(DateTime paivamaara) 
        {
            int result = DateTime.Compare(paivamaara, DateTime.Now);

            Console.WriteLine(result);

            if (result < 0)
                return false;
            else if (result == 0)
                return false;
            else
                return true;

        }

        public static void Opiskeluaika(DateTime aloitusAika, double opiskeluAika)
        {
            TimeSpan opiskeltuAika = DateTime.Now - aloitusAika;

            if (opiskeltuAika.TotalDays > opiskeluAika)
            {
                Console.WriteLine("Aiheen opiskelu on myöhässä!");
            }
            else
            {
                Console.WriteLine("Aiheen opiskelu etenee ajallaan.");
            }
            
        }

       
    }
}
