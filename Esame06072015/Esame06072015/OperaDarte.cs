using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esame06072015
{
    public abstract class OperaDarte
    {
        private string nomeOpera;
        private string nomeAutore;
        private readonly int id;
        private readonly DateTime dataDiRealizzazione;
        private Sala sala;

        public OperaDarte(string nomeOpera, string nomeAutore, int id, DateTime dataRealizzazione, Sala sala)
        {
            this.nomeOpera = nomeOpera;
            this.nomeAutore = nomeAutore;
            this.id = id;
            this.dataDiRealizzazione = dataRealizzazione;
            this.sala = sala;
        }

        public string NomeOpera
        {
            get { return nomeAutore; }
            set { nomeAutore = value; }
        }

        public string NomeAutore
        {
            get { return nomeAutore; }
            set { nomeAutore = value; }
        }

        public int Id
        {
            get { return id; }
        }

        public DateTime DataRealizzazione
        {
            get { return dataDiRealizzazione; }
        }

        public Sala LaSala
        {
            get { return sala; }
            set { sala = value; }
        }

        public abstract Tipologia TipoOpera { set; get; }
    }
}
