namespace pag374ex028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            determina se un anno e' bisestile (divisibile per 4) 
            gli anni secolari sono bisestili solo se sono anche divisibili per 400
            */

            int year;

            Console.Write("Inserisci l'anno da controllare: ");
            year = int.Parse(Console.ReadLine());

            //se l'anno diviso per 100 restituisce 0 vuol dire che e' secolare e va controllato in un'altro modo
            if(year % 100 == 0)
            {
                //gli anni secolari bisestili sono divisibili per 400
                if(year % 400 == 0)
                {
                    Console.WriteLine(String.Format("{0} e' un'anno bisestile", year));
                }
                else
                {
                    Console.WriteLine(String.Format("{0} non e' un'anno bisestile", year));
                }

            }
            //se non e' un'anno secolare basta vedere se % 4 restituisce 0
            else if(year % 4 == 0)
            {
                Console.WriteLine(String.Format("{0} e' un'anno bisestile", year));
            }
            else
            {
                Console.WriteLine(String.Format("{0} non e' un'anno bisestile", year));
            }

        }
    }
}