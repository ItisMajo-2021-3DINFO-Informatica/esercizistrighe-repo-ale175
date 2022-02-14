using System;

namespace EserciziStringhe3Giardina
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione variabili
            int numParole;
            string parole;
            int i = 0;
            char letteraInizio;
            char letteraFine;
            int paroleUguali = 0;

            //codice del programma
            Console.WriteLine("ESECIZIO 3");
            Console.Write("Inserisci il numero di parole da immettere: ");
            numParole = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < numParole; i++)
            {
                Console.Write("Inserisci la parola: ");
                parole = Console.ReadLine();
                letteraInizio = parole[0];
                letteraFine = parole[(parole.Length) - 1];

                if (letteraInizio == letteraFine)
                {
                    paroleUguali++;
                }
            }
            Console.WriteLine($"Le parole che iniziano e terminano con la stessa lettera sono: {paroleUguali}");
        }
    }
}
