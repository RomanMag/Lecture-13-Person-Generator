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
        private Filter myfilter;
        private string outputpath;

        public PersonSaver(string OutputPath)
        {
            outputpath = OutputPath;
            using (StreamWriter sw = File.CreateText(outputpath)) ;
        }


        public PersonSaver(Filter MyFilter, string OutputPath)
            : this(OutputPath)
        {
            myfilter=MyFilter;
        }

        public void  SavePerson(Person GeneratedPerson, EventArgs args)
        {
            string fullname = (GeneratedPerson.name+" "+GeneratedPerson.surname);
            if (myfilter.Apply(fullname))
            {
                using (StreamWriter sw = File.AppendText(outputpath))
                {
                    sw.WriteLine(fullname);
                }
            }
        }


    }
}
