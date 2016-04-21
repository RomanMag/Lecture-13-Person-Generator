using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    public class ComplexFilter:Filter
    {
        private List<Filter> filterscollection=new List<Filter>();

        public void AddFilter(Filter newfilter)
        {
            filterscollection.Add(newfilter);
        }


        public override bool Apply(string inputstring)
        {
            
            foreach (Filter CurrentFilter in filterscollection)
            {
                if (!CurrentFilter.Apply(inputstring))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
