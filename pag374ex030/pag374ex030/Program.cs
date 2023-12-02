namespace pag374ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            caldaia:
            input: temperatura max
            input: 3 temperatura
            fatta la media confrontarla con la temperatura max
            */

            //inizializzo le variabili
            double temp_max, temp, avg_temp = 0;

            //chiedo in input la temperatura max e la temperatura nei vari punti
            Console.Write("Inserisci la temperatura alla quale la caldaia si spegnera': ");
            temp_max = double.Parse(Console.ReadLine());

            Console.Write("Inserisci la temperatura nel punto 1: ");
            temp = double.Parse(Console.ReadLine());
            //sommo alla variabile avg_temp le varia temperature rilevate
            avg_temp += temp;

            Console.Write("Inserisci la temperatura nel punto 2: ");
            temp = double.Parse(Console.ReadLine());
            avg_temp += temp;

            Console.Write("Inserisci la temperatura nel punto 3: ");
            temp = double.Parse(Console.ReadLine());
            avg_temp += temp;

            //calcolo la media
            avg_temp /= 3;

            //controllo se la temperatura media sia uguale o maggiore a quella massima inserita dall'utente
            if(avg_temp >= temp_max)
                Console.WriteLine("La caldaia verra' spenta!");
            else
                Console.WriteLine("La caldaia verra' accesa");
        }
    }
}