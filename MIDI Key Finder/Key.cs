using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MIDI_Key_Finder
{
    class Key
    {
        List<int[]> myNotes;

        Dictionary<string, double> myResultsDict = new Dictionary<string, double>();

        static readonly double[] MajorKeyProfile = new double[] { 5.0F, 2.0F, 3.0F, 2.0F, 4.5F, 4.0F, 2.0F, 4.5F, 2.0F, 3.5F, 1.5F, 4.0F };
        static readonly double[] MinorKeyProfile = new double[] { 5.0F, 2.0F, 3.5F, 4.5F, 2.0F, 4.0F, 2.0F, 4.5F, 3.5F, 2.0F, 1.5F, 4.0F };
        //
        //
        //
        //
        //
        Dictionary<string, double[]> Modes = new Dictionary<string, double[]>()
        {
            {"Major",MajorKeyProfile},
            {"Minor",MinorKeyProfile},
        };

        public string First_Key { get; private set; } = "No Key";
        public string Second_Key { get; private set; } = "No Key";
        public string Third_Key { get; private set; } = "No Key";
        public double First_Score{ get; private set; } = 0;
        public double Second_Score { get; private set; } = 0;
        public double Third_Score { get; private set; } = 0;

        public Key(List<int[]> myNotes)
        {
            this.myNotes = myNotes;
            GenerateMyResults();
            Display();
            //Utilities.PrintKey("Major",11);
        }


        public void GenerateMyResults()
        {
            foreach (var Mode in Modes)
            {
                for (int i = 0; i < 12; i++)
                {
                    string myKey = $"{Utilities.ConvertToPitchClass(i)} {Mode.Key}";
                    double myValue = GenerateKeyProfile(Mode.Value, i);
                    
                    myResultsDict.Add(myKey, myValue);
                }
            }
        }
        public double GenerateKeyProfile(double[] mode,int offset)
        {
            // { 5.0F, 2.0F, 3.0F, 2.0F, 4.5F, 4.0F, 2.0F, 4.5F, 2.0F, 3.5F, 1.5F, 4.0F };

            double score = 0;
            foreach (var n in myNotes)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (i == (n[0]))
                    {
                        score += mode[(i + (12 - offset)) % 12];
                    }
                }
            }
            return score;
        }

        public void Display()
        {
            var mySortedList = myResultsDict.OrderByDescending(d => d.Value).ToList();

            First_Key = mySortedList[0].Key;
            Second_Key = mySortedList[1].Key;
            Third_Key = mySortedList[2].Key;

            First_Score = mySortedList[0].Value;
            Second_Score = mySortedList[1].Value;
            Third_Score = mySortedList[2].Value;
            
            string stringDebug = $"1st Place\nKey: {mySortedList[0].Key}\nScore: {mySortedList[0].Value}\n" +
                $"2nd Place\nKey: {mySortedList[1].Key}\nScore: {mySortedList[1].Value}\n" +
                $"3rd Place\nKey: {mySortedList[2].Key}\nScore: {mySortedList[2].Value}\n";
        }



    }
}
