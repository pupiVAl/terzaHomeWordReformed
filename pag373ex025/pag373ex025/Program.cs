namespace pag373ex025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            richiedi in input:
            -codice merce
            -descrizione
            -quantita'
            -prezzo unitario
            -tipo di pagamento (contanti o rateale)

            calcola il costo complessivo della merce
            sapendo che 
            il prezzo diminuisce del 10% se si paga in contanti
            il prezzo aumenta del 15% se si paga in modo rateale
            */

            string code, desc, type_payment;
            double num, price, final_price;

            Console.Write("Inserisci il codice della merce: ");
            code = Console.ReadLine();

            Console.Write("Inserisci la descrizione della merca: ");
            desc = Console.ReadLine();

            Console.Write("Inserisci la quantita' della merce: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Inserisci il prezzo della merce: ");
            price = int.Parse(Console.ReadLine());

            Console.Write("pagamento contanti ('cont') o rateale ('rate'): ");
            type_payment = Console.ReadLine().ToLower();

            final_price = price * num;

            if(type_payment == "cont")
            {
                final_price -= final_price * 0.10;
            }
            else if(type_payment == "rate")
            {
                final_price += final_price * 0.15;
            }
            else
            {
                Console.WriteLine("Tipo di pagamento non riconosciuto");
            }

            Console.WriteLine(String.Format("il prezzo finale e' di: {0} euro", final_price));
        }
    }
}