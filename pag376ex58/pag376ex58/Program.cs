namespace pag376ex58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            input il numero di seggi elettorali;
            ogni seggio hai le seguenti informazioni:
                numero iscritti
                numero votanti 
                numero schede nulle
                numero schede bianche
            */


            int n_tot = 0, n_voti = 0, n_schede_bia = 0, n_schede_nul = 0, count = 0;
            string user;

            do
            {
                count++;
                Console.WriteLine("-----------------------");
                Console.WriteLine("|   SEGGIO NUMERO {0}   |", count);
                Console.WriteLine("-----------------------");

                Console.Write("Numero totale di iscritti: ");
                n_tot += int.Parse(Console.ReadLine());

                Console.Write("Numero totale di votanti: ");
                n_voti += int.Parse(Console.ReadLine());

                Console.Write("Numero totale di schede nulle: ");
                n_schede_bia += int.Parse(Console.ReadLine());

                Console.Write("Numero totale di schede bianche: ");
                n_schede_nul += int.Parse(Console.ReadLine());

                Console.Write("inserisci 'Y' per continuare e qualsiasi altra cosa per smettere di inserire i dati: ");
                user = Console.ReadLine();

            } while (user.ToUpper() == "Y");

            double percet_votanti = ((double)n_voti * 100.0) / (double)n_tot;
            double percet_schede_bia = ((double)n_schede_bia * 100.0) / (double)n_voti;
            double percet_schede_nul = ((double)n_schede_nul * 100.0) / (double)n_voti;

            Console.WriteLine(String.Format("Percentuale votanti: {0}%. Percentuale schede bianche {1}%. Percentuale schede nulle {2}%.", percet_votanti, percet_schede_bia, percet_schede_nul));

        }
    }
}
