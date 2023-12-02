namespace pag374ex034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            risoluzione equazione di primo grado 
            */
            int a, b;

            Console.Write("Inserisci la a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Inserisci la b: ");
            b = int.Parse(Console.ReadLine());

            if(a < 0)
            {
                a *= -1;
                b *= -1;
            }

            Console.WriteLine("X e' uguale a: {0}/{1}", a, b);


        }
    }
}