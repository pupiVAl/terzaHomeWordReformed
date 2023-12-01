namespace pag372ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            calcola il tempo trascorso tra 2 date espresse in giorni, mesi, anni.
            considera l'anno commerciale (anno = 360, mese = 30)
             */

            //creo le variabili gg mm aaaa che conterranno prima i valori rappresentativi della prima data e poi verranno riscritti con i dati della seconda data
            //date1 e date2 conterranno la somma in giorni rispettivamente della prima e della seconda data
            //diff conterra' la differenza in giorni fra la prima e la seconda data
            int gg, mm, aaaa, date1, date2, diff;

            //chiedo in input i giorni della prima data
            Console.Write("Inserisci i giorni della prima data: ");
            //trasformo l'input dell'utente in un intero e lo assegno alla variabile gg
            gg = int.Parse(Console.ReadLine());

            //chiedo in input i mesi della prima data
            Console.Write("Inserisci i mesi della prima data: ");
            //trasformo l'input dell'utente in un intero e poi lo moltiplico per 30 trasformando i mesi in giorno e lo assegno alla variabile mm
            mm = int.Parse(Console.ReadLine()) * 30;

            //chiedo in input i mesi della prima data
            Console.Write("Inserisci gli anni della prima data: ");
            //trasformo l'input dell'utente in un intero e poi lo moltiplico per 360 trasformando gli anni in giorno e lo assegno alla variabile aaaa
            aaaa = int.Parse(Console.ReadLine()) * 360;

            //assegno nella variabile date1 la somma in giorni dei 3 interi che formano la data 
            date1 = gg + mm + aaaa;

            //questo comando mi permette di ripulire la console per rendere il tutto piu' pulito
            Console.Clear();

            Console.Write("Inserisci i giorni della seconda data: ");
            gg = int.Parse(Console.ReadLine());

            Console.Write("Inserisci i mesi della seconda data: ");
            mm = int.Parse(Console.ReadLine()) * 30;

            Console.Write("Inserisci gli anni della seconda data: ");
            aaaa = int.Parse(Console.ReadLine()) * 360;

            date2 = gg + mm + aaaa;

            //nella variabile diff assegno la differenza in giorni tra la prima e la seconda data
            diff = date1 - date2;

            //se diff e' un numero negativo lo trasformo in potivo moltiplicandolo per -1
            if(diff < 0)
            {
                diff *= -1;
            }
            //restituisco in output all'utente la differenza in giorni
            Console.WriteLine(String.Format("La differenza fra la prima e la seconda data e' di {0} giorni.", diff));
        }
    }
}