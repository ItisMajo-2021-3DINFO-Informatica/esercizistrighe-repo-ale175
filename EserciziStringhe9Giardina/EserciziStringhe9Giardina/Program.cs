using System;

namespace EserciziStringhe9Giardina
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
            int frasiPari = 0;
            int frasiDispari = 0;

            //codice del programma
            Console.WriteLine("ESERCIZIO 9");
            Console.Write("Inserisci il numero di frasi da digitare: ");
            numParole = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < numParole; i++)
            {
                Console.Write("Inserisci la parola: ");
                parole = Console.ReadLine();
                lettere = parole.Length;

                if (lettere % 2 == 0)
                {
                    frasiPari++;
                }
                else
                {
                    frasiDispari++;
                }
            }
            Console.WriteLine($"Le parole con un numero di lettere pari sono: {frasiPari}, le parole con un numero di lettere dispari invece sono: {frasiDispari}");
        }
    }
}
