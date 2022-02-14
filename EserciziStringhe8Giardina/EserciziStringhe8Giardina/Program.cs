using System;

namespace EserciziStringhe8Giardina
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione variabili
            int numParole;
            string parole;
            char letteraInizio;
            char letteraUtente;
            int numFrasi = 0;
            int i = 0;

            //codice del programma
            Console.WriteLine("ESERCIZIO 5");

            Console.Write("Digita quante parole vuoi immettere: ");
            numParole = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci una lettera: ");
            letteraUtente = Convert.ToChar(Console.ReadLine());

            for (i = 0; i < numParole; i++)
            {
                Console.Write("Inserisci la parola: ");
                parole = Console.ReadLine();
                letteraInizio = parole[0];

                if (letteraInizio == letteraUtente)
                {
                    numFrasi++;
                }
            }
            Console.WriteLine($"Le perole che iniziano con la tua stessa lettera sono: {numFrasi}");
        }
    }
}
