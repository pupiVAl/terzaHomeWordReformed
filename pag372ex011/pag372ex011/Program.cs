namespace pag372ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            hai deciso di costruire una piccola casetta in legno;
            chiedi in input:
            L (assi di legno grandi per il tetto)
            P (assi di legno piccole per le pareti)
            Q (quadratini di legno per il pavimento)
            Il prezzo per le varie parti (L P Q)

            calcola il costo da sostenere sapendo che si applichera' uno sconto del 10% 
            ma si paghera' sicuramente 30$ per la spedizione
            */


            //creo le variabili l, p, q che conterrano il numero di pezzi per ogni tipo
            //creo le variabili price_l/p/q che conterranno il prezzo per ogni tipo 
            //creo la variabile prezzo_tot che conterra' il prezzo totale della cosruzione
            double l, p, q, price_l, price_p, price_q, prezzo_tot;
            //creo la costante VOUCH che contiene lo sconto il decimi 
            //creo la costante SHIP che contiene il costo fisso di spedizione
            const double VOUCH = 0.10, SHIP = 30;

            //chiedo in input il numero di assi l
            Console.Write("Inserisci il numero di assi da comprare per il soffitto: ");
            l = double.Parse(Console.ReadLine());

            //chiedo in input il prezzo per ogni asse di legno l
            Console.Write("Inserisci il costo per le assi di legno per il soffitto: ");
            price_l = double.Parse(Console.ReadLine());
            //moltiplico price_l per il numero di assi di legno l
            price_l *= l;

            Console.Clear();

            Console.Write("Inserisci il numero di assi da comprare per le pareti: ");
            p = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il costo per le assi di legno per le pareti: ");
            price_p = double.Parse(Console.ReadLine());
            price_p *= p;

            Console.Clear();

            Console.Write("Inserisci il numero di quadrati da comprare per il pavimento: ");
            q = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il costo per i quadrati di legno per il pavimento: ");
            price_q = double.Parse(Console.ReadLine());
            price_q *= q;

            Console.Clear();

            prezzo_tot = price_l + price_p + price_q;
            prezzo_tot = prezzo_tot - prezzo_tot * VOUCH;
            prezzo_tot += SHIP;

            Console.WriteLine(String.Format("Il prezzo finale e' di: {0:0.00} euro", prezzo_tot));




        }
    }
}