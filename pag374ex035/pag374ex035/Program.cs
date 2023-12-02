namespace pag374ex035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            stampa numeri in ordine crescente 
            */

            int a, b, c, idk;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());


            if(a < b && b > c)
            {
                idk = a;
                a = b;
                b = idk;
            }
            if(a < b && c > b)
            {
                idk = a;
            }

            Console.WriteLine(String.Format("", a, b, c));




        }

    }
}