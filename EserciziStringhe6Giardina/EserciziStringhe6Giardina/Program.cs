using System;

namespace EserciziStringhe6Giardina
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione variabili
            int numParole;
            string parole;
            char lettere;
            char letteraUtente;
            int numFrasi = 0;
            int i = 0;

            //codice del programma
            Console.WriteLine("ESERCIZIO 6");
            Console.Write("Inserisci il numero di parole da immettere: ");
            numParole = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci una lettera: ");
            letteraUtente = Convert.ToChar(Console.ReadLine());

            for (i = 0; i < numParole; i++)
            {
                Console.Write("Inserisci la parola: ");
                parole = Console.ReadLine();
                lettere = parole[(parole.Length) - 1];

                if (lettere == letteraUtente)
                {
                    numFrasi++;
                }
            }
            Console.WriteLine($"Le parole che finiscono con la tua lettera sono: {numFrasi}");
        }
    }
}
