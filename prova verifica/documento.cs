using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_verifica
{
    public class documento : Oggetto_misterioso
    {
        public string tipo { get; private set; }
        public  documento(string id, float prezzo_dichiarato, string tipo) : base(id, prezzo_dichiarato)
        {
            this.tipo = tipo;
        }
        public override float getPrezzo_Assicurato()
        {
            if (Prezzo_dichiarato >= 100)
                return Prezzo_dichiarato;
            else
                return 50;
        }
        public override string gettipo()
        {
            return tipo;
        }
    }
}
