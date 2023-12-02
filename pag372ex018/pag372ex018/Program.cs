namespace pag373ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            su un prodotto viene applicato lo sconto di X% se si acquistano fino a 10 pezzi
            e del Y% se vengono acquistati piu' di 10 oggetti
            
            prendere in input 
            il costo del prodotto 
            il numero di prodotti comprati

            restituisci il costo finale
            */

            const double X = 0.08, Y = 0.12;
            double costo_prodotto, num_prodotti, costo_finale;

            Console.Write("Inserisci il costo del prodotto: ");
            costo_prodotto = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il numero di prodotti: ");
            num_prodotti = double.Parse(Console.ReadLine());

            if(num_prodotti <= 10)
            {
                costo_finale = num_prodotti * costo_prodotto;
                costo_finale -= costo_finale * X;
            }
            else
            {
                costo_finale = num_prodotti * costo_prodotto;
                costo_finale -= costo_finale * Y;
            }

            Console.WriteLine(String.Format("Il costo per {0:0} prodotti e' di: {1:0.00} euro", num_prodotti, costo_finale));
        }
    }
}
