using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupMan
{
    public partial class Form1 : Form
    {
        private logic mainLogic;
        private int currentState;
        /*
         * 0 - invalid/no config xml passed in
         * 1 - select backups
         * 2 - backup names and locations
         * 3 - do backups
         * 4 - end state
         * */
        private String[] chosenNames;
        private String[] chosenFrom;
        private String[] chosenTo;
        private int chosenCount;
        private int state2progress;

        /* init main form, and init the logic class*/
        public Form1()
        {
            InitializeComponent();
            mainLogic = null;
            setState(0);
        }

        public Form1(String xmlData)
        {
            InitializeComponent();
            setXmlData(xmlData);
            setState(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addItemsToCheckBox()
        {
            clb1.BeginUpdate();
            clb1.Items.Clear();
            clb1.Items.AddRange(mainLogic.getLocationNames());
            clb1.EndUpdate();
        }

        public void setXmlData(String loc)
        {
            try 
            { 
                mainLogic = new logic(loc);
            }
            catch (logic.InvalidDataFile)
            {
                doState0("Invalid XML File, please Reselect");
            }
        }


        /* main nav buttons*/
        private void goNext_Click(object sender, EventArgs e)
        {
            if (currentState == 4)
                exit();
            else if (currentState == 1)
                doState2();
            else if (currentState == 2 && state2progress < (chosenCount-1))
            {
                chosenTo[state2progress] = locTxt.Text;
                state2progress++;
                state2Check(state2progress);
            }
            else 
                doState3();
        }

        private void goPrev_Click(object sender, EventArgs e)
        {
            if (currentState == 0 || currentState == 1)
                doState0("Select XML Data File");
            else if (currentState == 2 && state2progress == 0)
                doState1();
            else
            {
                int i = state2progress - 1;
                doState2();
                state2progress = i;
                state2Check(i);
            }
        }

        /* quickly set values for progress bar*/
        private void prog(int val)
        {
            progBar.Value = val;
        }

        /* exit application*/
        public void exit()
        {
            Application.Exit();
        }


        /* Set various states of the program*/

        private void doState0(String msg)
        {
            currentState = 0;
            prog(0);
            Form2 x = new Form2(this, msg);
            x.ShowDialog();
            if (mainLogic == null)
                exit();
            else
                setState(1);
        }

        private void doState1()
        {
            currentState = 1;
            prog(20);
            addItemsToCheckBox();
            prompt.Text = "Select Location(s) to Back Up";
        }
        private void doState2()
        {
            currentState = 2;
            prog(40);
            int[] selectedLocs = whatsInTheCollection(clb1.SelectedIndices);
            getChosen(selectedLocs);
            groupBox1.Visible = false;
            gbNames.Visible = true;
            state2progress = 0;
            state2Check(state2progress);
            prompt.Text = "Select Names & Locations for Backups";
        }
        //display a name to confim state 2
        private void state2Check(int id){
            progBar.Value = 40 + ((20/chosenCount)*(id+1));
            currentOutputFor.Text = chosenNames[id];
            locTxt.Text = chosenTo[id];
            saveFileDialog1.FileName = locTxt.Text;
        }
        //browse for file save loc in state 2
        private void doBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            locTxt.Text = saveFileDialog1.FileName;
        }
        //get the chosen strings from the xml in the logic class
        private void getChosen(int[] chnums)
        {
            String[] names = mainLogic.getLocationNames();
            String[] from = mainLogic.getFromLocations();
            String[] to = mainLogic.getToLocations();
            chosenNames = null;
            List<String> cn = new List<string>();
            chosenFrom = null;
            List<String> cf = new List<string>();
            chosenTo = null;
            List<String> ct = new List<string>();
            for (int i = 0; i < chnums.Length; i++)
                cn.Add(names[chnums[i]]);
            for (int i = 0; i < chnums.Length; i++)
                cf.Add(from[chnums[i]]);
            for (int i = 0; i < chnums.Length; i++)
                ct.Add(to[chnums[i]]);
            chosenNames = cn.ToArray();
            chosenFrom = cf.ToArray();
            chosenTo = ct.ToArray();
            chosenCount = chnums.Length;
        }
        //extract the indeces used from the listbox
        private int[] whatsInTheCollection(ListBox.SelectedIndexCollection col)
        {
            int[] x = new int[col.Count];
            int arrIndex = 0;
            for(int i = 0; i< mainLogic.count(); i++){
                if(col.Contains(i))
                    x[arrIndex++] = i;
            }
            return x;
        }
        private void doState3()
        {
            currentState = 3;
            prog(60);
            prompt.Text = "Backup Operations Working...";
            goPrev.Enabled = false;
            goNext.Enabled = false;
            //do ops
            zPbar.Value = 0;
            int zpbarincrement = 100;
            try
            {
                zpbarincrement = 100 / chosenCount;
            }
            catch (DivideByZeroException) { }
            for (int i = 0; i < chosenCount; i++)
            {
                mainLogic.doBackup(chosenFrom[i], chosenTo[i]);
                zPbar.Value = zPbar.Value + zpbarincrement;
            }
            doState4();
        }
        private void doState4()
        {
            currentState = 4;
            prog(100);
            prompt.Text = "Backup Operations Completed!";
            goNext.Enabled = true;
            goNext.Text = "Exit";
        }

        private void setState(int state)
        {
            switch (state)
            {
                case 0:
                    doState0("Select XML Datafile");
                    break;

                case 1:
                    doState1();
                    break;

                case 2:
                    doState2();
                    break;

                case 3:
                    doState3();
                    break;

                case 4:
                    doState4();
                    break;

                default:
                    currentState = -1;
                    break;

            }
        }



    }
}
