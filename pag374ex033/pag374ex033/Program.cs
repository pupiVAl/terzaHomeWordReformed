namespace pag374ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            idraulico:
            12.50$/h
            costo materiali
            min = 30$

            input:
            h, costo materiali

            output
            price, if price<30 {price = 30}
            */

            //inizializzo le variabili
            double h, price_mat, price;

            //chiedo in input i vari dati
            Console.Write("Inserisci le ore di lavoro: ");
            h = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il costo dei materiali: ");
            price_mat = double.Parse(Console.ReadLine());

            //calcolo il prezzo
            price = 12.50 * h + price_mat;

            //controllo che il prezzo sia maggiore o uguale a 30
            if(price < 30)
                price = 30;

            //stampo il costo finale
            Console.WriteLine(String.Format("Il preventivo e' di: {0}$", price));
        }
    }
}