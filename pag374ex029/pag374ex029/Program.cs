namespace pag374ex029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            impresa trasporti: 
            costo fisso: 52$
            1.30$/km
            10$/quintale
            */

            //inizializo le costanti e le variabili
            const double FISSO = 52.0, DIST = 1.30, PESO = 10.0;
            double km, quint, price;

            //chiedo in input all'utente alcune informazioni
            Console.Write("Inserisci la distanza in km: ");
            km = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il peso in quintali: ");
            quint = double.Parse(Console.ReadLine());

            //calcolo il costo finale e lo stampo in console
            price = FISSO + DIST * km + PESO * quint;

            Console.WriteLine(String.Format("Il prezzo finale e' di: {0}$", price));




        }
    }
}