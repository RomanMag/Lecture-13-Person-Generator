using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    public class ListIO
    {
        public static bool ReadListFromFile(string FilePath, ref List<string> OutList)
        {
            List<string> templist = new List<string>();
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    templist.Add(line);
                }
            }
            OutList = templist;
            return (OutList.Count() > 0);
        }


        public static bool SaveListToFile(string FilePath, List<string> ListToSave)
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (string Item in ListToSave)
                {
                    sw.WriteLine(Item);

                }
            }

            return (File.Exists(FilePath));
        }
    }
}
