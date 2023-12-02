namespace pag373ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            parcheggio ha tariffa di:
            2$ per la prima ora
            1$ per ogni ora in piu' alla prima

            sapendo l'orario di entrata e di uscita dell'automobile espressi in (hh:mm)
            emetti uno scontrino con:
            -l'ora di entrata
            -l'ora di uscita
            -il tempo di durata della sosta (in m)
            -la relativa spesa
            */

            int hh1, mm1, hh2, mm2, date1, date2, diff, price = 0;


            Console.Write("Inserisci le ore del primo orario: ");
            hh1 = int.Parse(Console.ReadLine());

            Console.Write("Inserisci i minuti del primo orario: ");
            mm1 = int.Parse(Console.ReadLine());

            date1 = hh1 * 60 + mm1;


            Console.Clear();
            Console.Write("Inserisci le ore del secondo orario: ");
            hh2 = int.Parse(Console.ReadLine());

            Console.Write("Inserisci i minuti del secondo orario: ");
            mm2 = int.Parse(Console.ReadLine());

            date2 = hh2 * 60 + mm2;


            diff = (hh1 + mm1 / 60) - (hh2 + mm2 / 60);

            if(diff < 0)
            {
                diff *= -1;
            }

            if(diff > 1)
            {
                price += 2;
                diff -= 1;
                price += diff;
            }
            else
            {
                price += 2;
            }

            diff = date1 - date2;
            if(diff < 0)
            {
                diff *= -1;
            }

            Console.Clear();
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine(String.Format(" L'orario di entrata e': {0:00}:{1:00}", hh1, mm1));
            Console.WriteLine(String.Format(" L'orario di uscita e': {0:00}:{1:00}", hh2, mm2));
            Console.WriteLine(String.Format(" La durata della sosta e' stata di: {0} minuti", diff));
            Console.WriteLine(String.Format(" La spesa totale e' di: {0} euro", price));
            Console.WriteLine("|-----------------------------------------------|");

        }
    }
}