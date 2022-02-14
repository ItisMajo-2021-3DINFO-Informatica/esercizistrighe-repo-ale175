using System;

namespace EserciziStringhe7Giardina
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione variabili
            int numParole;
            string parole;
            char lettere;
            int i = 0;
            char prec = ' ';
            int numFrasi = 0;

            //codice del programma
            Console.WriteLine("ESERCIZIO 7");

            Console.Write("Inserisci il numero di parole da digitare: ");
            numParole = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < numParole; i++)
            {
                Console.Write("Inserisci la parola: ");
                parole = Console.ReadLine();
                lettere = parole[0];

                if (lettere == prec)
                {
                    numFrasi++;
                }
                prec = lettere;
            }
            Console.WriteLine($"Le parole che iniziano con la stessa lettera della parola precedente sono: {numFrasi}");
        }
    }
}
