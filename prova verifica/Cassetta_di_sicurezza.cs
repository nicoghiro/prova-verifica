using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_verifica
{
    public class Cassetta_di_sicurezza
    {
        private string pin;
        private string codice_sblocco;
        private string codice_seriale;
        private string produttore;
        public Oggetto_misterioso oggetto { get; set; }
        private  string Pin
        {
            get { return pin; }
            set {
                if (value.Length == 5 && value.All(char.IsDigit))
                    pin = value;
                else
                    throw new Exception("pin non valido");
            }
        }
        private string Codice_sblocco
        {
            get { return codice_sblocco; }
            set
            {
                if (value != null)
                    codice_sblocco = value;
                else
                    throw new Exception("codice di sblocco non valido");
            }
        }
        public string Codice_seriale
        {
            get { return produttore; }
            private set
            {
                codice_seriale=value;
            }
        }
        public string Produttore
        {
            get
            {
                return produttore;
            }
            private set
            {
                produttore = value;
            }
        }
        public Cassetta_di_sicurezza(string pin, string codice_sblocco, string codice_seriale, string produttore)
        {
            Pin = pin;
            Codice_sblocco = codice_sblocco;
            Codice_seriale = codice_seriale;
            Produttore = produttore;
            this.oggetto = null;
        }
        public Cassetta_di_sicurezza() : this("00000", "password", "codice", "N/D")
        {

        }
        public bool occupato()
        {
            if (oggetto != null)
            {
                return true;
            }
            return false;
        }
        public void Cambiapin(string npin , string codice)
        {
            if(codice == Codice_sblocco)
            {
                Pin = npin;
                return;
            }
            throw new Exception("codice sblocco errato");
        }
        public virtual float getPrezzoAssicurato()
        {
            return oggetto.getPrezzo_Assicurato();
        }
        public void InserisciOggetto(string pin ,Oggetto_misterioso ogg)
        {
            Console.WriteLine(Pin);
            if ( pin==Pin && ogg!=null && this.occupato()==false)
            {
                oggetto = ogg;
                return;
            }
            throw new Exception("pin non valido o cassetta gia occupata");
        }
        public void RimuoviOggetto(string pin)
        {
            if (pin ==Pin && this.occupato() == true)
            {
                oggetto = null;
                return;
            }
            throw new Exception("pin non valido o cassetta gia vuota");
        }
        public virtual float getPrezzoassicurato()
        {
            if (this.occupato()==true)
            {
                return oggetto.getPrezzo_Assicurato();
            }
            return 0;
        }
       
    }
}
