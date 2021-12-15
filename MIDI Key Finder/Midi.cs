using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;


namespace MIDI_Key_Finder
{

    class Midi
    {
        public static List<int[]> getChordsFromMIDI(string fileName)
        {
            ChordDetectionSettings settings = new ChordDetectionSettings();
            settings.NotesMinCount = 3;
            var Chords = ChordsManagingUtilities.GetChords(MidiFile.Read(fileName), settings);

            List<int> myNotes = new List<int>();
            foreach (Chord i in Chords)
            {
                foreach (Note j in i.Notes)
                {
                    string pitchClass = j.ToString();
                    myNotes.Add(Utilities.ConvertFromPitchClass(pitchClass));
                }
            }
            var freqList = myNotes.GroupBy(x => x)
                .Select(x => new int[] { x.Key, x.Count() }).ToList();
            freqList = freqList.OrderByDescending(x => x[1]).ToList();
            return freqList;
        }

    }
}
