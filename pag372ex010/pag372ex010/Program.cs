namespace pag372ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            costo per la pavimentazione di un'area 7*4 metri:
            avendo in input il costo per ogni mq di piastrella
            il costo orario della manodopera
            numero ore impiegate
            aggiungere alla fine x% iva
            */

            //cre la costante iva che contiene la percentuale di iva (gia' trasformata in decimale)
            const double iva = 0.22;
            //creo la constante area che contiene i mq di piastrelle (ho usato un double invece di un intero perche' dopo dovro' fare operazioni matematiche con altri double)
            const double area = 7 * 4;
            //creo le variabili costo_mq, costo_h, num_h che conterrano l'input dell'utente
            //creo la variabile costo_tot che conterra' il prezzo finale dopo il calcolo
            double costo_mq, costo_h, num_h, costo_tot;

            Console.Write("Inserisci il costo per mq di piastrella: ");
            costo_mq = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il costo per ora di manodopera: ");
            costo_h = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il numero di ore di manodopera: ");
            num_h = double.Parse(Console.ReadLine());

            costo_tot = (costo_mq * area) + (costo_h * num_h);
            costo_tot = costo_tot * iva + costo_tot;

            Console.WriteLine(String.Format("il costo totale per {0} mq e' di {1} euro", area, costo_tot));

        }
    }
}