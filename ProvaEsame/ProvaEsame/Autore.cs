using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEsame
{
    public class Autore
    {
        private string nome;
        private string cognome;
        private DateTime dataDiNascita;
        private readonly int id;

        public Autore(string nome, string cognome, DateTime dataDiNascita, int id)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.id = id;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public DateTime DataDiNascita
        {
            get { return dataDiNascita; }
            set { dataDiNascita = value; }
        }

        public int Id
        {
            get { return id; }
        }

    }
}
