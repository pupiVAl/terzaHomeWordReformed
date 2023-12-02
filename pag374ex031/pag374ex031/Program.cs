namespace pag374ex031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Copisteria:
            if n <= 19          --> 0.10$/p
            if 20 <= n <=100    --> 0.08$/p
            if n > 100          --> 0.05$/p

            if da rilegare      --> + 1.80$ 

            input:
            n, nome_cliente, rilegatura
            */

            //inizializzazione variabili
            double num, price = 0;
            string nome_cliente;
            char rilegatura;

            //richiesta all'utente delle informazioni
            Console.Write("Inserisci il numero delle fotocopie: ");
            num = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il nome del cliente: ");
            nome_cliente = Console.ReadLine();

            Console.Write("Inserisci 's' per la rilegatura e 'n' per non metterla: ");
            rilegatura = char.Parse(Console.ReadLine());

            //ramo delle possibilita'
            if(num <= 19)
                if(rilegatura == 's')
                    price = num * 0.10 + 1.80;
                else
                    price = num * 0.10;

            else if(num <= 100)
                if(rilegatura == 's')
                    price = num * 0.08 + 1.80;
                else
                    price = num * 0.08;

            else if(num > 100)
                if(rilegatura == 's')
                    price = num * 0.05 + 1.80;
                else
                    price = num * 0.05;

            //stampa dell'output
            if(rilegatura == 's')
                Console.WriteLine(String.Format("Gentil signor {0} il preventivo e' di: {1}$ con rilegatura", nome_cliente, price));
            else
                Console.WriteLine(String.Format("Gentil signor {0} il preventivo e' di: {1}$", nome_cliente, price));


        }
    }
}