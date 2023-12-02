namespace pag373ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, ris, right_ris;

            Console.Write("Inserisci il primo numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Inserisci il risultato: ");
            ris = int.Parse(Console.ReadLine());

            right_ris = a + b;

            if(ris == right_ris)
            {
                Console.WriteLine("Bravo.");
            }
            else
            {
                Console.Write("Hai sbagliato prova ancora: ");
                ris = int.Parse(Console.ReadLine());
                if(ris == right_ris)
                {
                    Console.WriteLine("Bravino hai indovinato al secondo tentativo.");
                }
                else
                {
                    Console.WriteLine("Ti serve un ripasso di matematica.");
                }
            }
        }
    }
}