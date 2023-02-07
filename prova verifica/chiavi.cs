using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_verifica
{
    public class chiavi :  Oggetto_misterioso
    {
        public bool tipo { get; private set; }
        //true = fisica; false = elettronica
        public chiavi(string id, float prezzo_dichiarato, bool tipo) : base(id, prezzo_dichiarato)
        {
            this.tipo = tipo;
        }
        public override float getPrezzo_Assicurato()
        {
            return Prezzo_dichiarato * 1000;
        }
        public override string gettipo()
        {
            if (tipo == false)
            {
                return "elettronica";
            }
            else
                return "fisica";
        }
    }
}
