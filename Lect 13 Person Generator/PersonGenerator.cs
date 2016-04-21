using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    public class PersonGenerator
    {
        int timeout;
        List<string> ListOfNames = new List<string>();
        List<string> ListOfSurNames = new List<string>();
        Random rnd = new Random();
        public System.Timers.Timer aTimer;


        public PersonGenerator(int GenerationTimeoutMS, string NamesFilePath, string SurNamesFilePath)
        {
            timeout = GenerationTimeoutMS;
            ListIO.ReadListFromFile(NamesFilePath, ref ListOfNames);
            ListIO.ReadListFromFile(SurNamesFilePath, ref ListOfSurNames);
        }


        public Person Generate()
        {
            Person NewPerson = new Person(GetRandomListValue(ListOfNames), GetRandomListValue(ListOfSurNames));
            return NewPerson;
        }

        public Person Generate(string timestamp)
        {
            Person NewPerson = new Person(GetRandomListValue(ListOfNames), GetRandomListValue(ListOfSurNames), timestamp);
            return NewPerson;
        }

        private string GetRandomListValue(List<string> MyList)
        {
            return MyList[rnd.Next(MyList.Count - 1)];
        }


        public void RunPersonGeneration()
        {
            aTimer = new System.Timers.Timer(timeout);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Elapsed += OnTimedEvent;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Generate(e.SignalTime.ToString()).Print();
            //EventHandler handler = NewPersonGenerated;
            //if (handler != null)
            //{
                //handler(Generate(e.SignalTime.ToString()), e);
            //}
        }

        public event EventHandler NewPersonGenerated;

    }
}
