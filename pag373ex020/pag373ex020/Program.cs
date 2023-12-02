namespace pag373ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            verifica se un carattere digitato corrisponde a:
            s or S
            n or N
            qualsiasi altra parola
            */

            char word;
            Console.Write("scrivi 's' 'n' oppure un'altra parola: ");
            word = char.Parse(Console.ReadLine());

            if(word == 's' || word == 'S')
            {
                Console.WriteLine("Si");
            }
            else if(word == 'n' || word == 'N')
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Errato");
            }


            //soluzione con Char.ToUpper();
            /*
            word = Char.ToUpper(word);
            if(word == 'S')
            {
                Console.WriteLine("Si");
            }
            else if(word == 'N')
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Errato");
            }
            */
        }
    }
}