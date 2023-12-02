using System;

namespace pag373ex027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            compagnia aerea:
            i bagagli sotto i 20kg sono gratis;
            sopra i 20kg ogni kg equivale al 2% in piu' sulla tariffa
            */

            double price_ticket;
            int weight, diff_weight;
            double over_price = 0.02;

            Console.Write("Inserisci il prezzo del biglietto aereo iniziale: ");
            price_ticket = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il peso del bagaglio: ");
            weight = int.Parse(Console.ReadLine());

            if(weight <= 20)
            {
                Console.WriteLine(String.Format("Il costo del biglietto e' rimasto invariato: {0} euro. Perche' il bagaglio pesa {1} kg", price_ticket, weight));
            }
            else
            {
                over_price *= weight - 20;
                price_ticket += price_ticket * over_price;
                Console.WriteLine(String.Format("Il costo del biglietto e' aumentato a: {0} euro. Perche' il bagaglio pesa {1} kg", price_ticket, weight));
            }
        }
    }
}