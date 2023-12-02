namespace pag374ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            voti studente:
            input: 4 voti
            output: media e promosso se avg >=6
            */

            //inizializzazione variabili
            double voto, avg_voto = 0;

            //richieste all'utente dei voti e aumento della variabile avg_voto
            Console.Write("Inserisci il primo voto: ");
            voto = double.Parse(Console.ReadLine());
            avg_voto += voto;

            Console.Write("Inserisci il secondo voto: ");
            voto = double.Parse(Console.ReadLine());
            avg_voto += voto;

            Console.Write("Inserisci il terzo voto: ");
            voto = double.Parse(Console.ReadLine());
            avg_voto += voto;

            Console.Write("Inserisci il quarto voto: ");
            voto = double.Parse(Console.ReadLine());
            avg_voto += voto;

            //calcolo la media dei voti
            avg_voto /= 4;

            //controllo che la media sia >= 6
            if(avg_voto >= 6)
                Console.WriteLine(String.Format("lo studente ha la media del: {0:0.00}\nRisulta promosso", avg_voto));
            else
                Console.WriteLine(String.Format("lo studente ha la media del: {0:0.00}\nRisulta bocciato", avg_voto));



        }
    }
}