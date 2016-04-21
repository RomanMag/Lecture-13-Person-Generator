using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    interface IFIlter
    {
        bool Apply(string input);
    }
}
