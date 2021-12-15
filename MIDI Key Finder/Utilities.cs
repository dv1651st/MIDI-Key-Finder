using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MIDI_Key_Finder
{
    static class Utilities
    {
        static readonly string[] pitchClasses = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", };
        static readonly Dictionary<string, int[]> myKeys = new Dictionary<string, int[]>()
        {     //                c   d   e f   g   a   b
            {"Major",new int[] {1,0,1,0,1,1,0,1,0,1,0,1} },
            {"Minor",new int[] {1,0,1,1,0,1,0,1,1,0,1,0} },


        };
        public static string ConvertToPitchClass(int x)
        {
            return pitchClasses[x];
        }
        public static int ConvertFromPitchClass(string s)
        {
            // will convert a string representing a pitch class into its numeric version, example: c# -> 1, f -> 5
            int x = 0;
            if (Char.IsNumber(s.Last()))
            {
                s = s.Remove(s.Length - 1, 1);
            }
            for (int i = 0; i < 11; i++)
            {
                if (pitchClasses[i] == s)
                {
                    x = i;
                }
            }
            return x;
        }

        public static void PrintKey(string keyType, int Key)
        {
            // will print a string representation of a scale, example: c major -> c,d,e,f,g,a,b.
            string scale = "";
            for (int i = 0; i < 12; i++)
            {
                if (myKeys[keyType][(i + (12 - Key)) % 12] == 1)
                {
                    if (i != 11)
                    {
                        scale += $"{ConvertToPitchClass(i)}, ";
                    }
                    else
                    {
                        scale += $"{ConvertToPitchClass(i)}.";
                    }
                }

            }
            Debug.WriteLine(scale);
        }
    }
}
