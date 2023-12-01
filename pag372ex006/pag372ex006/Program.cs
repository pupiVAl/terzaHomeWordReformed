namespace pag372ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            calcola lo sconto del 15% su due oggetti;
            mostra in output i soldi risparmiati e il prezzo finale.
             */

            //creo la costante voucher che contiene lo sconto del 15% gia' trasformato in decimale
            const double voucher = 0.15;
            //tutte le variabili sono double perche' stiamo parlando di prezzi e quindi di valori decimali
            //creo le variabili obj1 e obj2 che contengono rispettivamente il primo ed il secondo prezzo degli oggetti
            //creo la variabile sum_obj che conterra' la somma tra il primo ed il secondo oggetto
            //creo la variabile diff che conterra' i soldi risparmiati che andranno sottratti al prezzo iniziale
            //creo la variabile final_price che conterra' il prezzo finale dei due prodotti dopo lo sconto
            double obj1, obj2, sum_obj, diff, final_price;

            //chiedo in input il prezzo del primo prodotto
            Console.Write("Insersci il prezzo del primo prodotto: ");
            //trasformo l'input string dell'utente in double
            obj1 = double.Parse(Console.ReadLine());

            Console.Write("Insersci il prezzo del secondo prodotto: ");
            obj2 = double.Parse(Console.ReadLine());

            //sommo i prezzi dei due oggetti
            sum_obj = obj1 + obj2;

            //calcolo i soldi risparmiati
            diff = sum_obj * voucher;

            //calcolo il prezzo finale dei 2 prodotti
            final_price = sum_obj - diff;

            //restituisco in output all'utente i soldi risparmiati e il prezzo finale dopo lo sconto
            //utilizzo la sintassi {i:0.00} per restituire all'utente solo 2 cifre decimali ex.
            //double i = 5.555555; >> 5.55
            Console.WriteLine(String.Format("hai risparmiato {0:0.00} euro e il prezzo finale dei due prodotti e' {1:0.00} euro", diff, final_price));
        }
    }
}