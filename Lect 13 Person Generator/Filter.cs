using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    public abstract class Filter:IFIlter
    {
        public abstract bool Apply(string inputstring);

    }
}
