namespace pag372ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            tassa sulla raccolta dei rifiuti:
            prendere in input la grandezza dell'appartamente in metri quadrati
            calcolare la tassa moltiplicando i metri quadrati per X (una costante scelta da noi)
            sommando al risultato Y (una costante scelta da noi)
            aggiugere la percentuale aggiunta P (una costante scelta da noi)
            */

            //creo le costanti X, Y, P (gia' sotto forma di percentuale)
            const double X = 10.5, Y = 50.90, P = 0.18;
            //creo le variabili mq e tax
            double mq, tax;

            //chiedo in input all'utente i mq dell'appartamento
            Console.Write("Inserisci i metri quadrati dell'appartamento: ");
            //trasformo l'input string dell'utente in double
            mq = double.Parse(Console.ReadLine());

            //calcolo la tassa in base ai mq
            tax = ((mq * X) + Y) + ((mq * X) + Y) * P;

            //mostro in output i metri quadri inseriti e la tassa totale
            Console.WriteLine(String.Format("La tassa finale su {0}mq e' di: {1:0.00} euro", mq, tax));
        }
    }
}