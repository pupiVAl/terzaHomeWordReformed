namespace pag373ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            dati in input 2 numeri stampali in ordine crescente
            */
            int a, b;

            Console.Write("Inserisci il primo numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            b = int.Parse(Console.ReadLine());

            if(a < b)
            {
                Console.WriteLine(String.Format("{0} {1}", a, b));
            }
            else
            {
                Console.WriteLine(String.Format("{0} {1}", b, a));
            }

        }
    }
}