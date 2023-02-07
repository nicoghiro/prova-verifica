using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_verifica
{
   abstract public class Oggetto_misterioso
    {
        private string id;
        private float prezzo_dichiarato;
        public string Id
        {
            get { return id; }
            private set {
                if (value != null&& string.IsNullOrEmpty(value)==false)
                    id = value;
                else
                    throw new Exception("inserire valore valido");
           
            }
        }
        public float Prezzo_dichiarato
        {
            get { return prezzo_dichiarato; }
            private set {
                if (value > 0)
                    prezzo_dichiarato = value;
                else
                    throw new Exception("inserire prezzo positivo");
            }
        }
        public Oggetto_misterioso(string id, float prezzo_dichiarato)
        {
            Id = id;
            Prezzo_dichiarato = prezzo_dichiarato;
        }
        public Oggetto_misterioso(string id) : this(id, 1)
        {

        }
        public Oggetto_misterioso() :this("N/D",1)
        {
           
        }


        public virtual float getPrezzo_Assicurato()
        {
            return prezzo_dichiarato;
        }
        public virtual string gettipo()
        {
            return "N/D";
        }
    }
}
