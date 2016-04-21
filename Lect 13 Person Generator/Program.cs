using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------------------------------------
            //Blacklist/Whitelist
            //-----------------------------------------------------
            //IO path
            string folderpath = "d:\\testfilters\\";
            string inputpath = folderpath + "Input.txt";
            string outputpath = folderpath + "Output.txt";

            //Filters path
            string blacklistpath = folderpath + "black.txt";
            string whitelistpath = folderpath + "white.txt";

            //IO lists
            List<string> InputList = new List<string>();
            List<string> OutputList = new List<string>();

            ListIO.ReadListFromFile(inputpath, ref InputList);
            //Initialyze filters
            Filter MyBlackList = new FilterBlacklist(blacklistpath);
            Filter MyWhiteList = new FilterWhitelist(whitelistpath);
            //Create a complex filter
            ComplexFilter MyComplexFilter = new ComplexFilter();
            MyComplexFilter.AddFilter(MyBlackList);
            MyComplexFilter.AddFilter(MyWhiteList);

            //Apply filter in the input list
            foreach (string inputliststring in InputList)
            {
                if (MyComplexFilter.Apply(inputliststring))
                {
                    OutputList.Add(inputliststring);
                }
            }
            //Save output list
            ListIO.SaveListToFile(outputpath, OutputList);

            //-----------------------------------------------------
            string personnamespath = folderpath + "Names.txt";
            string personsurnamespath = folderpath + "SurNames.txt";
            string personwhitelistpath = folderpath + "PersonWhite.txt";
            string personblacklistpath = folderpath + "PersonBlack.txt";
            string personoutputpath = folderpath + "PersonOutput.txt";
            int persongenerationtimeoutmillisec = 2000;

            PersonGenerator MyPersonGenerator = new PersonGenerator(persongenerationtimeoutmillisec, personnamespath, personsurnamespath);
            MyPersonGenerator.RunPersonGeneration();
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
