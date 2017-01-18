using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esame06072015
{
    public class DatabaseMuseo
    {
        private static Hashtable sale = new Hashtable();
        private static Hashtable opere = new Hashtable();

        public static void AggiungiSala(Sala nuovaSala)
        {
            sale[nuovaSala.NumeroUnivoco] = nuovaSala;
        }

        public static Sala GetSala(int id)
        {
            return sale[id] as Sala;
        }

        public static void RimuoviSala(int id)
        {
            sale.Remove(id);
        }


        public static ArrayList GetAllSalaId()
        {
            return new ArrayList(sale.Keys);
        }

        public static IList getAllSale()
        {
            return new ArrayList(sale.Values);
        }

        public static void Clear()
        {
            sale.Clear();
        }
    }
}
