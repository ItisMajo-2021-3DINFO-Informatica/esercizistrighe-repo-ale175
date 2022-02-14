using System;

namespace EserciziStringhe1Giardina
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione variabili
            string parole;
            int i = 0;
            char lettere;
            int numParole;
            int numVocali = 0;
            int numConsonanti = 0;

            //codice del programma
            Console.WriteLine("PROGRAMMA 1");
            Console.Write("Quante parole vuoi inserire? ");
            numParole = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci una sequenza di parole: ");
            parole = Console.ReadLine();

            for (i = 0; i < numParole; ++i)
            {
                Console.Write("Inserisci una sequenza di parole: ");
                parole = Console.ReadLine();

                lettere = parole[0];

                if(lettere == 'a')
                {
                    numVocali++;
                }
                else if(lettere == 'e')
                {
                    numVocali++;
                }
                else if(lettere == 'i')
                {
                    numVocali++;
                }
                else if(lettere == 'o')
                {
                    numVocali++;
                }
                else if(lettere == 'u')
                {
                    numVocali++;
                }
                else
                {
                    numConsonanti++;
                }
            }


        }
    }
}
