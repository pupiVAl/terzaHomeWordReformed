namespace pag373ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            determina se un numero e' positivo o negativo
            */

            int num;
            Console.Write("inserisci un numero: ");
            num = int.Parse(Console.ReadLine());

            if(num >= 0)
            {
                Console.WriteLine(String.Format("Il numero {0} e' positivo", num));
            }
            else
            {
                Console.WriteLine(String.Format("Il numero {0} e' negativo", num));
            }
        }
    }
}