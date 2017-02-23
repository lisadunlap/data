using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Stopwatch timer1 = new Stopwatch();
        object misValue = System.Reflection.Missing.Value;
        String statename;
        String eventname;
        ArrayList events;
        String researcherName;
        String researcherAnimal;
        String stateStart;
        String eventStart;
        //int events;
        int num;
        String behavior;
        public Form1()
        {
            InitializeComponent();
            events = new ArrayList();
        }
        
        private void state1_Click(object sender, EventArgs args)
        {
            // Compose a string that consists of three lines.
            timer1.Start();
            stateStart = DateTime.Now.ToString();
            if (behavior != null && statename != null && eventname != null)
            {
                /*string lines = "    " + behavior + " state start: " + DateTime.Now.ToString();
                stateStart = DateTime.Now.ToString();
        
                System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Data.txt", true);
                file.WriteLine(lines);

                file.Close();*/
            }
            else
            {
                MessageBox.Show("Please make sure all the fields have been completed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            
        }

        private void state1stop_Click(object sender, EventArgs e)
        {
            long time = timer1.ElapsedMilliseconds;
            string lines = researcherName + "," + researcherAnimal + "," + behavior + ",State,"+ statename + "," + stateStart + "," + time.ToString() + "," + eventname + "," + num.ToString();
            foreach (string eventTime in events)
            {
                lines += "," + eventTime;
            }
            //Debug.Write(lines);
            events.Clear();
            //string lines = "    " + behavior + " state time elapsed: " + time.ToString();
            //string lines2 = "    --Number of events in state: " + num.ToString();
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
            file.WriteLine(lines);
            //file.WriteLine(lines2);

            file.Close();
            timer1.Stop();
            num = 0;
        }

        private void event1_Click(object sender, EventArgs args)
        {
            if(behavior != null && statename != null && eventname != null)
            {
                //Compose a string that consists of three lines.
                string time = DateTime.Now.ToString();
                string lines = "        " + behavior + " event " + DateTime.Now.ToString();
                if (timer1.IsRunning != false){
                    num++;
                    events.Add(time);
                }
                else
                {
                    string line = researcherName + "," + researcherAnimal + "," + behavior + ",Event, , , ," + eventname + ", ," +time;
                    foreach (string eventTime in events)
                    {
                        lines += "," + eventTime;
                    }
                    events.Clear();
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
                    file.WriteLine(line);

                    file.Close();
                }
                /*Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Data.txt", true);
                file.WriteLine(lines);

                file.Close();*/
            }
            else
            {
                MessageBox.Show("Please make sure all the fields have been completed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
           
        }

        private void behavior1_Click(object sender, EventArgs args)
        {
            behavior = Microsoft.VisualBasic.Interaction.InputBox("Enter New Behavior Name", "New Behavior", "Default Text");
            tabPage1.Text = behavior;
            behaviorlabel1.Name = behavior;
            Properties.Settings.Default.tab1name = behavior;
            Properties.Settings.Default.behaviorname = behavior; 
            /*var newTabPage = new TabPage()
            {
                Text = behavior
            };
            tabControl1.TabPages.Add(newTabPage);*/


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Form Form1 = new Form();
            this.WindowState = Properties.Settings.Default.F1State;
            //data.Columns.Add("Name", typeof(string));
            behavior =behaviorlabel1.Text;
            statename = stateLabel1.Text;
            eventname = eventLabel1.Text;
            String[] lines = label1.Text.Split(' ');
            researcherName = lines[0];
            researcherAnimal = lines[1];
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            /*String researcher = Microsoft.VisualBasic.Interaction.InputBox("Name, animal", "Sign In", "Default Text");
            String[] things = researcher.Split(' ');
            researcherName = things[0];
            researcherAnimal = things[1];
            if(things.Length != 2)
            {
                MessageBox.Show("There was a problem with your input. Make sure you enter your last name followed by a space and the animal", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Mentorship\\Data.txt", true);
                String write = "Researcher: " + things[0] + "       Animal: " + things[1];
                String write2 = "--------------------------------------------------";
                file.WriteLine(write);
                file.WriteLine(write2);

                file.Close();
                label1.Text = researcher;
                //addValue(1, 1, researcher);
                Properties.Settings.Default.researcher1 = researcher;
            }*/
            
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            /*string lines = "";
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Data.txt", true);
            file.WriteLine(lines);

            file.Close();
            System.Diagnostics.Debug.Write("how about here");*/
            Properties.Settings.Default.Save();
        }

        private void signin1_Click(object sender, EventArgs e)
        {
            String researcher = Microsoft.VisualBasic.Interaction.InputBox("Name, animal", "Sign In", "Default Text");
            String[] things = researcher.Split(' ');
            if (things.Length != 2)
            {
                MessageBox.Show("There was a problem with your input. Make sure you enter your last name followed by a space and the animal", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                researcherName = things[0];
                researcherAnimal = things[1];
                label1.Text = researcher;
                Properties.Settings.Default.researcher1 = researcher;
            }
        }

        private void eventName1_Click(object sender, EventArgs e)
        {
            eventname = Microsoft.VisualBasic.Interaction.InputBox("Enter an event name", "Event Name", "Default Text");
            eventLabel1.Text = eventname;
            Properties.Settings.Default.event_name1 = eventname;
        }

        private void stateName1_Click(object sender, EventArgs e)
        {
            statename = Microsoft.VisualBasic.Interaction.InputBox("Enter a state name", "State Name", "Default Text");
            stateLabel1.Text = statename;
            Properties.Settings.Default.state_name1 = statename;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
   

    
}
