using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D5_Progetto
{
    internal class Contribuente
    {
        private string _nome;
        private string _cognome;
        private DateTime _dataDiNascita;
        private string _codiceFiscale;
        private char _sesso;
        private string _comuneResidenza;
        private decimal _redditoAnnuale;

        // Definisco le proprietà pubbliche con le relative proprietà private
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public DateTime DataDiNascita
        {
            get { return _dataDiNascita; }
            set { _dataDiNascita = value; }
        }

        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        public char Sesso
        {
            get { return _sesso; }
            set { _sesso = value; }
        }

        public string ComuneResidenza
        {
            get { return _comuneResidenza; }
            set { _comuneResidenza = value; }
        }

        public decimal RedditoAnnuale
        {
            get { return _redditoAnnuale; }
            set { _redditoAnnuale = value; }
        }

        //Definisco il costruttore Contribuente con una lista di parametri (firma)
        public Contribuente(string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
        {
            Nome= nome;
            Cognome= cognome;
            DataDiNascita= dataDiNascita;
            CodiceFiscale= codiceFiscale;
            Sesso= sesso;
            ComuneResidenza= comuneResidenza;
            RedditoAnnuale= redditoAnnuale;
        }

        // Definisco il metodo CalcoloImposta per calcolare l'imposta che deve versare il contribuente in base alla fascia del suo reddito annuale
        public decimal CalcoloImposta()
        {
            decimal imposta = 0;

            if (RedditoAnnuale < 15000)
            {
                imposta = RedditoAnnuale * 0.23m;
            }
            else if (RedditoAnnuale > 15000 && RedditoAnnuale < 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale < 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale < 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
            }
            else if (RedditoAnnuale>75000)
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;
            }
            else
            {
                Console.WriteLine("Errore calcolo imposta.");
            }

            return imposta;
        }


    }
}
