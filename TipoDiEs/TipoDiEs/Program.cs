using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDiEs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            List<IMyInterface> listInterfacciata = new List<IMyInterface>();

            listInterfacciata.Add(new Class1("Lopo"));
            listInterfacciata.Add(new Class2("Loose"));

            string[] mystring = new string[2];
            int indexer = 0;

            foreach(IMyInterface singleInter in listInterfacciata)
            {
                mystring[indexer] = singleInter.FaiQualcosa();
                indexer++;
            }

            foreach(string nameClass in mystring)
            {
                Console.WriteLine(nameClass);
            }

        }
    }
}
