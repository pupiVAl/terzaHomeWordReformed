namespace pag373ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            dati in input 3 numeri stabilisci qual'e' il piu' grande
            */

            int a = 55, b = 200, c = 144, max;
            max = a;
            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            Console.WriteLine(String.Format("il numero piu' grande e': {0}", max));
        }

    }
}