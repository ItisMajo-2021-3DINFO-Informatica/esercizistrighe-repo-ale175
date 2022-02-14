using System;

namespace EserciziStringhe2Giardina
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione variabili
            int parole;
            int lettere;
            string frase;
            int i = 0;
            int sommameno8 = 0;
            int mediameno8 = 0;
            int parolemeno8 = 0;
            int sommapiu8 = 0;
            int mediapiu8 = 0;
            int parolepiu8 = 0;

            //codice del programma
            Console.WriteLine("ESERCIZIO 2");
            Console.Write("Inserisci il numero di parole che vuoi immettere: ");
            parole = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < parole; i++)
            {
                Console.Write("Inserisci la frase: ");
                frase = Console.ReadLine();
                lettere = Convert.ToInt32(frase.Length);

                if (lettere < 8)
                {
                    parolemeno8++;
                    sommameno8 = sommameno8 + lettere;
                    mediameno8 = sommameno8 / parolemeno8;
                }
                else if (lettere >= 8)
                {
                    parolepiu8++;
                    sommapiu8 = sommapiu8 + lettere;
                    mediapiu8 = sommapiu8 / parolepiu8;
                }
            }
            Console.WriteLine($"La media delle parole con meno di 8 caratteri è: {mediameno8}, invece la media delle parole con più di 8 caratteri è {mediapiu8}.");
        }
    }
}
