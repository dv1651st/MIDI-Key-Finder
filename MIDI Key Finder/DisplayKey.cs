using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDI_Key_Finder
{
    public partial class DisplayKey : Form
    {
        public DisplayKey()
        {
            InitializeComponent();
            


        }

        private void firstPlaceLabel_Click(object sender, EventArgs e)
        {

        }

        private void secondPlaceLabel_Click(object sender, EventArgs e)
        {

        }

        private void thirdPlaceLabel_Click(object sender, EventArgs e)
        {

        }

        private void DisplayKey_Load(object sender, EventArgs e)
        {
            firstPlaceLabel.Text = MainForm.myFirst;
            secondPlaceLabel.Text = MainForm.mySecond;
            thirdPlaceLabel.Text = MainForm.myThird;
        }

        private void mainResultsPanel_Click(object sender, EventArgs e)
        {

        }

        private void mainResultsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
