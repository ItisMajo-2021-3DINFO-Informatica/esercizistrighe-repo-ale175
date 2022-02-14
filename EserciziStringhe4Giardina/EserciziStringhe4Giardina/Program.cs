using System;

namespace EserciziStringhe4Giardina
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione variabili
            int numParole;
            string parole;
            int lettere;
            int i = 0;
            int parole4e7 = 0;
            int parole7 = 0;
            int parole4 = 0;

            //codice del programma
            Console.WriteLine("ESERCIZIO 4");

            Console.Write("Inserisci il numero di parole da immettere: ");
            numParole = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < numParole; i++)
            {
                Console.Write("Inserisci la parola: ");
                parole = Console.ReadLine();
                lettere = parole.Length;

                if (lettere < 7 && lettere > 4)
                {
                    parole4e7++;
                }
                else if (lettere < 4)
                {
                    parole4++;
                }
                else if (lettere > 7)
                {
                    parole7++;
                }
            }
            Console.WriteLine($"Le parole con meno di 4 lettere sono: {parole4}, le parole tra le 4 e le 7 lettere sono: {parole4e7}, le parole con più di 7 lettere: {parole7}");
        }
    }
}
