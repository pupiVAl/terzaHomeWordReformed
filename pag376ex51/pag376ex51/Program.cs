namespace pag376ex51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            dati N numeri interi positivi e negativi trova la somma dei valori assoluti 
            */
            int sum = 0, n;
            string user;
            Console.WriteLine("Insert positive or negative numbers separated by a posting (when you want to stop write \"stop\"): ");

            do
            {
                user = Console.ReadLine();

                try
                {
                    n = int.Parse(user);
                    sum += Math.Abs(n);
                }
                catch (FormatException)
                {
                    if(user.ToUpper() != "STOP")
                        Console.WriteLine("You must insert a number!");
                } 
            } while (user.ToUpper() != "STOP");

            Console.WriteLine("the abs sum of the numbers is: {0}", sum);

        }
    }
}
