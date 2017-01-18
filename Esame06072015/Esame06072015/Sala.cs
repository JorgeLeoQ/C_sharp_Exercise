using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esame06072015
{
    public class Sala
    {
        private string nome;
        private readonly int numeroU;

        public Sala(string nome, int id)
        {
            this.nome = nome;
            this.numeroU = id;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroUnivoco
        {
            get { return numeroU; }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Nome sala: {0}\nCodice univoco: {1}", Nome, NumeroUnivoco);
            return info.ToString();
        }
    }
}
