using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_Part1
{
    public class Outside : Location
    {
        private bool hot;
        public Outside(string name, bool hot)
            : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                return base.Description + (hot ? " It's very hot." : "");
            }
        }
    }
}
