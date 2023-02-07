using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_verifica
{
    public class gioielli : Oggetto_misterioso
    {
        public  string tipo { get; private set; }
        public gioielli(string id,float prezzo_dichiarato,string tipo) : base(id, prezzo_dichiarato)
        {
            this.tipo = tipo;
        }
        public override float getPrezzo_Assicurato()
        {
            return Prezzo_dichiarato * 5;
        }
        public override string gettipo()
        {
           return tipo;
        }

    }
}
