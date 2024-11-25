namespace AS2425._3F.INF.MicheleFalco.FascePrezzo1

{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MicheleFalco.3F.Inf.22/11/2024.FascePrezzo1");
            Random random = new Random();
            int spesaTotale = 0;
            int numeroProdotti = 0;
            int prezzoMassimo = 0;
            int prezzoMinimo = 301;

            // generazione dei prodotti
            while (true)
            {
                int prezzo = random.Next(0, 301);
                if (prezzo == 0)
                    break;

                spesaTotale += prezzo;
                numeroProdotti++;

                if (prezzo > prezzoMassimo)
                    prezzoMassimo = prezzo;
                if (prezzo < prezzoMinimo)
                    prezzoMinimo = prezzo;
            }

            // dichiariazioni delle variabili delle fascie
            int numeroProdottiFascia1_50 = 0, sommaFascia1_50 = 0;
            int numeroProdottiFascia51_100 = 0, sommaFascia51_100 = 0;
            int numeroProdottiFascia101_150 = 0, sommaFascia101_150 = 0;
            int numeroProdottiFascia151 = 0, sommaFascia151 = 0;

            // calcoli delle fasce di spesa
            for (int i = 1; i <= numeroProdotti; i++)
            {
                int prezzo = random.Next(0, 301);
                if (prezzo >= 1 && prezzo <= 50)
                {
                    numeroProdottiFascia1_50++;
                    sommaFascia1_50 += prezzo;
                }
                else if (prezzo >= 51 && prezzo <= 100)
                {
                    numeroProdottiFascia51_100++;
                    sommaFascia51_100 += prezzo;
                }
                else if (prezzo >= 101 && prezzo <= 150)
                {
                    numeroProdottiFascia101_150++;
                    sommaFascia101_150 += prezzo;
                }
                else if (prezzo > 150)
                {
                    numeroProdottiFascia151++;
                    sommaFascia151 += prezzo;
                }
            }

            // Calcolo delle medie
            double mediaFascia1_50 = 0;
            if (numeroProdottiFascia1_50 > 0)
            {
                mediaFascia1_50 = (double)sommaFascia1_50 / numeroProdottiFascia1_50;
            }

            double mediaFascia51_100 = 0;
            if (numeroProdottiFascia51_100 > 0)
            {
                mediaFascia51_100 = (double)sommaFascia51_100 / numeroProdottiFascia51_100;
            }

            double mediaFascia101_150 = 0;
            if (numeroProdottiFascia101_150 > 0)
            {
                mediaFascia101_150 = (double)sommaFascia101_150 / numeroProdottiFascia101_150;
            }

            double mediaFascia151 = 0;
            if (numeroProdottiFascia151 > 0)
            {
                mediaFascia151 = (double)sommaFascia151 / numeroProdottiFascia151;
            }

            // Risultati
            Console.WriteLine($"Spesa totale: {spesaTotale}");
            Console.WriteLine($"Fascia 1-50: Numero prodotti: {numeroProdottiFascia1_50}, Somma: {sommaFascia1_50}, Media: {mediaFascia1_50:F2}");
            Console.WriteLine($"Fascia 51-100: Numero prodotti: {numeroProdottiFascia51_100}, Somma: {sommaFascia51_100}, Media: {mediaFascia51_100:F2}");
            Console.WriteLine($"Fascia 101-150: Numero prodotti: {numeroProdottiFascia101_150}, Somma: {sommaFascia101_150}, Media: {mediaFascia101_150:F2}");
            Console.WriteLine($"Fascia 151+: Numero prodotti: {numeroProdottiFascia151}, Somma: {sommaFascia151}, Media: {mediaFascia151:F2}");
            Console.WriteLine($"Prezzo massimo: {prezzoMassimo}, Prezzo minimo: {prezzoMinimo}");
        }
    }
}
