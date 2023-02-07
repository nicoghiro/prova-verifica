using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace prova_verifica
{
    public class cassetta_speciale : Cassetta_di_sicurezza
    {
        public cassetta_speciale(string pin, string codice_sblocco, string codice_seriale, string produttore) :base(pin,codice_sblocco, codice_seriale, produttore)
        {
         
        }
        public cassetta_speciale() : this("00000", "password", "codice", "N/D")
        {

        }
        public override float getPrezzoassicurato()
        {
            if (this.occupato() == true)
            {
                if(oggetto is chiavi)
                return oggetto.getPrezzo_Assicurato() /100 * 70;
                if (oggetto is documento)
                return oggetto.getPrezzo_Assicurato() / 100 * 80;
                if (oggetto is gioielli)
                return oggetto.getPrezzo_Assicurato() / 100 * 90;
            }
            Console.WriteLine("jhsdfjo");
            return 0;
        }
    }
}
