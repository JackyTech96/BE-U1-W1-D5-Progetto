using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D5_Progetto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chiedo le info necessarie al contribuente
            Console.WriteLine("Inserisci il nome del contribuente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome del contribuente:");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci la data di nascita del contribuente (dd/mm/yyyy)");
            DateTime dataDiNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            
            Console.WriteLine("Inserisci il codice fiscale del contribuente:");

            // Condizione di verifica per il dato sul codice fiscale del contribuente
            string codiceFiscale;
            while (true)
            {
                codiceFiscale = Console.ReadLine();

                if (codiceFiscale.Length == 16)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Inserisci un codice fiscale valido");
                }
            }
            

            Console.WriteLine("Inserisci il genere del contribuente:");
            char sesso;

            // Condizione di verifica per il dato sul genere del contribuente
            while (true)
            {
                string genere= Console.ReadLine().ToUpper();
                if (genere =="M" || genere =="F" || genere=="A") 
                {
                    sesso=char.Parse(genere);
                    break;
                }
                else 
                {
                    Console.WriteLine("Inserisci un genere valido (M per maschio, F per femmina o A per altro)");
                }
            }
            Console.WriteLine("Inserisci il comune di residenza del contribuente:");
            string comuneResidenza = Console.ReadLine();

            Console.WriteLine("Inserisci il reddito annuale del contribuente:");
            decimal redditoAnnuale;

            // Condizione di verifica per il dato sul reddito annuale del contribuente
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out redditoAnnuale) && redditoAnnuale >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Inserisci un valore di reddito annuale valido e positivo.");
                }
            }

            // Creo un oggetto Contribuente utilizzando il costruttore 
            Contribuente contribuente1= new Contribuente(nome, cognome, dataDiNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale );

            // Calcolo l'imposta usando il metodo
            decimal imposta = contribuente1.CalcoloImposta();

            //Stampo i risultati
            Console.WriteLine("=======================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine("Contribuente: " + contribuente1.Nome + " " + contribuente1.Cognome);
            Console.WriteLine("Nato il " + contribuente1.DataDiNascita);
            Console.WriteLine("Residente in " + contribuente1.ComuneResidenza);
            Console.WriteLine("Codice Fiscale: " + contribuente1.CodiceFiscale);
            Console.WriteLine("Reddito dichiarato: " + contribuente1.RedditoAnnuale);
            Console.WriteLine("IMPOSTA DA VERSARE: " + imposta);
            Console.ReadLine();
        }
    }
}
