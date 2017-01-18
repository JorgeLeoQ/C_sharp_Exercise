using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEsame
{
    public class Libro
    {
        private string nome;
        private string genere;
        private DateTime publicatione;
        private readonly int idLibro;

        public Libro(string nome, string genere, DateTime publicazione, int idLibro)
        {
            this.nome = nome;
            this.genere = genere;
            this.publicatione = publicazione;
            this.idLibro = idLibro;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Genere
        {
            get { return genere; }
            set { genere = value; }
        }
        public DateTime Publicazione
        {
            get { return publicatione; }
            set { publicatione = value; }
        }
        public int IdLibro
        {
            get { return idLibro; }
        }
    }
}
