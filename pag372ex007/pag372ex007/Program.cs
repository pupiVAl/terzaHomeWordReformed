namespace pag372ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            letto in input il valore X, calcola il valore dell'espressione 
            A * X^2 + B * X    
            A = 10
            B = 15
             */
            //creo le constanti A e B essendo che il loro valore rimane invariato
            const int A = 10, B = 15;
            //creo le variabili x e ris
            int x, ris;

            //chiedo in input all'utente il valore di x
            Console.Write("Inserisci il valore di X: ");
            //trasformo la stringa di input dell'utente in int e lo assegno alla variabile x
            x = int.Parse(Console.ReadLine());

            //assegno alla variabile ris il risultato dell'equazione
            //per calcolare la potenza di x si poteva usare anche la funzione Math.Pow(x, 2)
            ris = A * (x * x) + B * x;

            //restituisco in output all'utente il risultato dell'espressione
            Console.WriteLine(String.Format("Il risultato e' uguale a: {0}", ris));
        }
    }
}