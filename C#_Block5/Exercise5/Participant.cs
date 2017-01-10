using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Participant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Participant(string name, int age)
        {
           this.Name = name;
           this.Age = age;
        }
    }
}
