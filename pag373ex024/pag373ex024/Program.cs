namespace pag373ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            scrivi un programma che possa trasformare in minuti o in secondi le ore in input 
            */

            int h, res;
            string change;

            Console.Write("Inserisci le ore: ");
            h = int.Parse(Console.ReadLine());

            Console.Write("se vuoi trasformarle in secondi digita 'sec', se vuoi trasformarle in minuti digita 'min': ");
            change = Console.ReadLine();
            change = change.ToLower();

            if(change == "sec")
            {
                res = h * 3600;
                Console.WriteLine(String.Format("{0} ore equivalgono a {1} secondi", h, res));
            }
            else if(change == "min")
            {
                res = h * 60;
                Console.WriteLine(String.Format("{0} ore equivalgono a {1} minuti", h, res));
            }
            else
            {
                Console.WriteLine("Parola inserita sbagliata");
            }
        }
    }
}