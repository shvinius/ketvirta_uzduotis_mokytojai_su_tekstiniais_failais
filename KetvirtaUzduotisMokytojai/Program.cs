using System;

namespace KetvirtaUzduotisMokytojai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string text = System.IO.File.ReadAllText(@"C:\Users\Paulius\Documents\VZ programavimas\C sharp\penkta pamoka klase\4 Uzduotis Mokytojai\KetvirtaUzduotisMokytojai\MokytojuSarasas2.csv");
             Console.WriteLine(text);

             Console.WriteLine("----------------------");

             string[] eilutes = System.IO.File.ReadAllLines(@"C:\Users\Paulius\Documents\VZ programavimas\C sharp\penkta pamoka klase\4 Uzduotis Mokytojai\KetvirtaUzduotisMokytojai\MokytojuSarasas2.csv");

             foreach (string eilute in eilutes)
             {
                 Console.WriteLine("eilutė: " + eilute);
             }
            */

           

           List<Mokytojas> mokytojai = NuskaitytiMokytojusIsFailo();

            foreach (Mokytojas mokytojas in mokytojai)
            {
                Console.WriteLine(mokytojas.Vardas);
                Console.WriteLine(mokytojas.Pavarde);
                Console.WriteLine(mokytojas.Klase);
                Console.WriteLine(mokytojas.Pareigos);
                Console.WriteLine(mokytojas.Stazas);
                Console.WriteLine(mokytojas.Issilavinimas);
                StazuSuma(mokytojas.Stazas);
            }

            
             
        }

        /// <summary>
        /// Funkcija nuskaito Mokytojas klasės objektus iš tekstinio failo ir juos išsaugo į Listą.
        /// </summary>
        /// <returns>Grąžina Mokytojas objektų Listą </returns>
        static List<Mokytojas> NuskaitytiMokytojusIsFailo()
        {
            List<Mokytojas> mokytojasList = new List<Mokytojas>();

            // Nuskaitau kiekvieną tekstinę eilutę iš failo - į string kintamuosius, o jie yra string masyve (tai kiekvienas masyvo elementas yra atskira eilutė)

            string[] eilutes = System.IO.File.ReadAllLines(@"C:\Users\Paulius\Documents\VZ programavimas\C sharp\penkta pamoka klase\4 Uzduotis Mokytojai\KetvirtaUzduotisMokytojai\MokytojuSarasas2.csv");
            
            for (int i = 1; i < eilutes.Length; i++)
            {
                
               Mokytojas mokytojas = KonvertuotiEiluteIMokytojas(eilutes[i]);
               mokytojasList.Add(mokytojas);
            }
            return mokytojasList;
        }
        static Mokytojas KonvertuotiEiluteIMokytojas(string eilute)
        {
            Mokytojas mokytojas = new Mokytojas();

            string[] stulpeliai = eilute.Split(';');

            // Sudedame visus stulpelius į atitinkamus Mokytojas kintamuosius
            mokytojas.Vardas = stulpeliai[0];
            
            mokytojas.Pavarde = stulpeliai[1];
            
            mokytojas.Klase = stulpeliai[2];
            
            mokytojas.Pareigos = stulpeliai[3];
            mokytojas.Stazas = Convert.ToInt32(stulpeliai[4]);
            mokytojas.Issilavinimas = stulpeliai[5];
            
            return mokytojas;

        }
        static int StazuSuma(List<int> listas)
        {
            int suma = 0;
            for (int i = 0; i < listas.Count; i++)
            {
                suma += listas[i];
            }
            return suma;
        }
        static double StazuVidurkis(List<int> listas)
        {
            double vidurkis;
            vidurkis = (double)StazuSuma(listas) / (double)listas.Count;
            Console.WriteLine(vidurkis);
            return vidurkis;
        }
    }
}