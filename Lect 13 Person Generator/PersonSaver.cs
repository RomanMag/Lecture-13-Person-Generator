using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    public class PersonSaver
    {
        private List<Filter> myfilter;

        public PersonSaver(string OutputPath)
        {
            using (StreamWriter sw = File.CreateText(OutputPath)) ;
        }


        public PersonSaver(Filter MyFilter, string OutputPath)
            : this(OutputPath)
        {

        }




        public void c_NewPersonGenerated(Person sender, EventArgs e)
        {

        }
    }
}
