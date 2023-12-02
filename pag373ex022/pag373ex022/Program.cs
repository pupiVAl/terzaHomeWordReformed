namespace pag373ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Inserisci un numero: ");
            a = int.Parse(Console.ReadLine());

            if(a <= -5 || a >= 10)
            {
                Console.WriteLine("Il dato e' fuori dall'intervallo");
            }
            else
            {
                Console.WriteLine("OK");
            }

        }
    }
}