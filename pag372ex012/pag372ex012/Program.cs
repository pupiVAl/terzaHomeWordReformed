namespace pag372ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            un meccanico deve automatizzare i preventivi;
            sapendo:
            il costo orario della manodopera

            riceve in input:
            il valore dell' iva
            il costo dei pezzi di ricambio
            il numero di ore di manodopera

            restituisce il valore del preventivo
            */

            //creo la costante COST_H che contiene il costo orario della manodopera
            const double COST_H = 20.70;
            //creo le variabili spare_parts che conterra' il costo dei pezzi di ricambio
            //creo la variabile num_h che conterra' il numero di ore di manodopera
            //creo la variabile iva che conterra' il valore dell'iva in percentuale
            //creo la variabile preventivo che conterra' il costo del preventivo
            double spare_parts, num_h, iva, preventivo;

            Console.Write("Inserisci il costo dei pezzi di ricambio: ");
            spare_parts = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il numero delle ore di manodopera: ");
            num_h = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il valore dell'iva (in decimale): ");
            iva = double.Parse(Console.ReadLine());

            //calcolo il preventivo
            preventivo = (COST_H * num_h) + spare_parts;
            preventivo = preventivo + preventivo * iva;

            //restituisco in output il valore del preventivo
            Console.WriteLine(String.Format("Il prezzo del preventivo e' di: {0:0.00} euro", preventivo));
        }
    }
}