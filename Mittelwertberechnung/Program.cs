using System;

namespace Mittelwertberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continueCreation = true;
            while(continueCreation)
            {
                starteProgramm();

                Console.Write("Ein weiteres Array erstellen? (y/n): ");
                String eingabe = Console.ReadLine();
                if (eingabe != "y")
                {
                    continueCreation = false;
                }
            }
        }
        
        static void starteProgramm()
        {
            int eingabe = benutzerEingabe();

            int[] array = erzeugeArray(eingabe);
            ausgabe(array);

            double mittelwert = berechneMittelwert(array);
            Console.WriteLine("Der Mittelwert der Zahlen in meinem Array ist: " + mittelwert);
        }

        static int benutzerEingabe()
        {
            Console.Write("Wie viele Ganzzahlen sollen per Zufall generiert werden?: ");
            return int.Parse(Console.ReadLine());
        }

        static int[] erzeugeArray(int count)
        {
            var rand = new Random();
            int[] arr = new int[count];
            for(int i = 0; i < count; i++)
            {
                arr[i] = rand.Next(1,100);
            }
            return arr;
        }

        static void ausgabe(int[] arr)
        {
            Console.WriteLine("Ausgabe des Arrays mit " + arr.Length + " Zufallszahlen zwischen 1 und 99:");
            foreach (int number in arr)
            {
                if (number < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(number);
                Console.Write("  ");
            }
            Console.WriteLine();
        }

        static double berechneMittelwert(int[] arr) 
        {
            double mW = ((double) berechneSumme(arr) / arr.Length);
            return mW;
        }

        static int berechneSumme(int[] arr)
        {
            int summe = 0;
            foreach (int number in arr)
            {
                summe = summe + number;
            }
            return summe;
        }
    }
}
