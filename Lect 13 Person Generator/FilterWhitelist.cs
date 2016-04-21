using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    public class FilterWhitelist : Filter
    {
        private List<string> filterlist;

        public FilterWhitelist(string FilterFilePath)
        {
            ListIO.ReadListFromFile(FilterFilePath, ref filterlist);
        }

        public override bool Apply(string inputstring)
        {
            return filterlist.Contains(inputstring);
        }
    }
}
