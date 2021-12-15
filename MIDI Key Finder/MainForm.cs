using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDI_Key_Finder
{
    public partial class MainForm : Form
    {

        private Form activeForm;
        public Button buttonHome = new Button();

        
        public static string myFirst = "";
        public static string mySecond = "";
        public static string myThird = "";

        public MainForm()
        {
            InitializeComponent();
            this.mainLabel.DragDrop += new
                DragEventHandler(this.mainLabel_DragDrop);
            this.mainLabel.DragEnter += new
                DragEventHandler(this.mainLabel_DragEnter);


        }


        private void mainLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mainLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string sAuxFile = null;

                string[] arFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

                for (int nI = 0; nI < arFiles.Length; nI++)
                {
                    sAuxFile = arFiles[nI];

                    if (Convert.ToBoolean((System.IO.File.GetAttributes(sAuxFile) & System.IO.FileAttributes.Directory)))
                        continue;

                    bool bCorrectFormat = sAuxFile.EndsWith(".mid");

                    if (bCorrectFormat)
                    {
                        processMidiFile(sAuxFile, sender);
                        createHomeButton();
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void findKeyButton_Click(object sender, EventArgs e)
        {
            Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => x.Name == "DisplayKey").ToArray();
            foreach (Form openForm in formsList)
            {
                openForm.Close();
            }

        }
        private void alignButtons(Button newButton)
        {
            newButton.Location = new Point(425, 41);
            buttonBrowseFiles.Location = new Point(200, 41);
        }
        private void createHomeButton()
        {
            buttonHome.Anchor = AnchorStyles.None;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.FlatAppearance.BorderSize = 2;
            buttonHome.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            alignButtons(buttonHome);
            buttonHome.Name = "buttonHomeForm";
            buttonHome.Size = new Size(150, 44);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += new EventHandler(this.buttonHome_Click);
            panel1.Controls.Add(buttonHome);

            Debug.WriteLine("button created");
        }



        private void buttonBrowseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.Filter = "MIDI files (*.mid)|*.mid|All files (*.*)|*.*";
            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                processMidiFile(loadFile.FileName,sender);
                createHomeButton();
            }
        }


        public void processMidiFile(string fileName, object sender)
        {
            //MessageBox.Show(fileName);
            var myChords = Midi.getChordsFromMIDI(fileName);
            Key myKey = new Key(myChords);

            myFirst = myKey.First_Key;
            mySecond = myKey.Second_Key;
            myThird = myKey.Third_Key;

            OpenChildForm(new DisplayKey(), sender);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void panelOfParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            
            
            
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelOfParent.Controls.Add(childform);
            this.panelOfParent.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {

            //super lazy implementation xD
            //Application.Restart();
            activeForm.Close();
            removeButton(sender, e);
            
            
            
        }
        private void removeButton(object sender, System.EventArgs e)
        {
            if (panel1.Controls.Contains(buttonHome))
            {
                panel1.Controls.Remove(buttonHome);
                buttonBrowseFiles.Location = new Point(316, 41);
            }
        }
    }
}
