using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esame06072015
{
    public class Dipinto : OperaDarte
    {

        public Dipinto(string nomeOpera, string nomeAutore, int id, DateTime dataRealizzazione, Sala sala, Tipologia tipo)
            :base(nomeOpera, nomeAutore, id, dataRealizzazione, sala)
        {
            this.TipoOpera = tipo;
        }

        public override Tipologia TipoOpera
        {
            get
            {
                return TipoOpera;
            }

            set
            {
                if(value ==  Tipologia.DIPINTO)
                {
                    TipoOpera = value;
                }
                else
                {
                    throw new FormatException("This tipy is wrong!!");
                }
            }
        }
    }
}
