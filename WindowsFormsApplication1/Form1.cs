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
        Stopwatch timer2 = new Stopwatch();
        Stopwatch timer3 = new Stopwatch();
        Stopwatch timer4 = new Stopwatch();
        Stopwatch timer5 = new Stopwatch();
        Stopwatch timer6 = new Stopwatch();
        object misValue = System.Reflection.Missing.Value;
        String statename;
        String eventname;
        ArrayList events;
        ArrayList events2;
        ArrayList events3;
        ArrayList events4;
        ArrayList events5;
        ArrayList events6;
        String researcherName;
        String researcherAnimal;
        String stateStart;
        String stateStart2;
        String stateStart3;
        String stateStart4;
        String stateStart5;
        String stateStart6;
        int num;
        int num2;
        int num3;
        int num4;
        int num5;
        int num6;
        String behavior;
        public Form1()
        {
            InitializeComponent();
            events = new ArrayList();
            events2 = new ArrayList();
            events3 = new ArrayList();
            events4 = new ArrayList();
            events5 = new ArrayList();
            events6 = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Form1 = new Form();
            this.WindowState = Properties.Settings.Default.F1State;
            //data.Columns.Add("Name", typeof(string));
            /*behavior =behaviorlabel1.Text;
            statename = stateLabel1.Text;
            eventname = eventLabel1.Text;*/
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
                \String write2 = "--------------------------------------------------";
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
            string lines = researcherName + "," + researcherAnimal + "," + behaviorlabel1.Text + ",State,"+ stateLabel1.Text + "," + stateStart + "," + time.ToString() + "," + eventLabel1.Text + "," + num.ToString();
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
            if(behaviorlabel1.Text != null && stateLabel1.Text != null && eventLabel1.Text != null)
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
                    string line = researcherName + "," + researcherAnimal + "," + behaviorlabel1.Text + ",Event, , , ," + eventLabel1.Text + ", ," +time;
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
        private void state2_Click(object sender, EventArgs e)
        {
            // Compose a string that consists of three lines.
            timer2.Start();
            stateStart2 = DateTime.Now.ToString();
        }

        private void state2stop_Click(object sender, EventArgs e)
        {
            long time = timer2.ElapsedMilliseconds;
            string lines = researcherName + "," + researcherAnimal + "," + behaviorlabel2.Text + ",State," + stateLabel2.Text + "," + stateStart2 + "," + time.ToString() + "," + eventLabel2.Text + "," + num2.ToString();
            foreach (string eventTime in events2)
            {
                lines += "," + eventTime;
            }
            events2.Clear();
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
            file.WriteLine(lines);

            file.Close();
            timer2.Stop();
            num2 = 0;
        }

        private void event2_Click(object sender, EventArgs e)
        {
            if (behaviorlabel2.Text != null && stateLabel2.Text != null && eventLabel2.Text != null)
            {
                //Compose a string that consists of three lines.
                string time = DateTime.Now.ToString();
                if (timer2.IsRunning != false)
                {
                    num2++;
                    events2.Add(time);
                }
                else
                {
                    string line = researcherName + "," + researcherAnimal + "," + behaviorlabel2.Text + ",Event, , , ," + eventLabel2.Text + ", ," + time;
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
                    file.WriteLine(line);

                    file.Close();
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the fields have been completed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
        private void behavior2_Click(object sender, EventArgs e)
        {
            behavior = Microsoft.VisualBasic.Interaction.InputBox("Enter New Behavior Name", "New Behavior", "Default Text");
            tabPage2.Text = behavior;
            behaviorlabel2.Name = behavior;
            Properties.Settings.Default.tab2name = behavior;
            Properties.Settings.Default.behaviorname2 = behavior;
        }
        private void stateName2_Click(object sender, EventArgs e)
        {
            statename = Microsoft.VisualBasic.Interaction.InputBox("Enter a state name", "State Name", "Default Text");
            stateLabel2.Text = statename;
            Properties.Settings.Default.state_name2 = statename;
        }

        private void eventName2_Click(object sender, EventArgs e)
        {
            eventname = Microsoft.VisualBasic.Interaction.InputBox("Enter an event name", "Event Name", "Default Text");
            eventLabel2.Text = eventname;
            Properties.Settings.Default.event_name2 = eventname;
        }

        private void behavior3_Click(object sender, EventArgs e)
        {
            behavior = Microsoft.VisualBasic.Interaction.InputBox("Enter New Behavior Name", "New Behavior", "Default Text");
            tabPage3.Text = behavior;
            behaviorlabel3.Name = behavior;
            Properties.Settings.Default.tab3name = behavior;
            Properties.Settings.Default.behaviorname3 = behavior;
        }

        private void state3_Click(object sender, EventArgs e)
        {
            timer3.Start();
            stateStart3 = DateTime.Now.ToString();
        }

        private void state3stop_Click(object sender, EventArgs e)
        {
            long time = timer3.ElapsedMilliseconds;
            string lines = researcherName + "," + researcherAnimal + "," + behaviorlabel3.Text + ",State," + stateLabel3.Text + "," + stateStart3 + "," + time.ToString() + "," + eventLabel3.Text + "," + num3.ToString();
            foreach (string eventTime in events3)
            {
                lines += "," + eventTime;
            }
            events3.Clear();
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
            file.WriteLine(lines);

            file.Close();
            timer3.Stop();
            num3 = 0;
        }

        private void event3_Click(object sender, EventArgs e)
        {
            if (behaviorlabel3.Text != null && stateLabel3.Text != null && eventLabel3.Text != null)
            {
                //Compose a string that consists of three lines.
                string time = DateTime.Now.ToString();
                if (timer3.IsRunning != false)
                {
                    num3++;
                    events3.Add(time);
                }
                else
                {
                    string line = researcherName + "," + researcherAnimal + "," + behaviorlabel3.Text + ",Event, , , ," + eventLabel3.Text + ", ," + time;
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
                    file.WriteLine(line);

                    file.Close();
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the fields have been completed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void stateName3_Click(object sender, EventArgs e)
        {
            statename = Microsoft.VisualBasic.Interaction.InputBox("Enter a state name", "State Name", "Default Text");
            stateLabel3.Text = statename;
            Properties.Settings.Default.state_name3 = statename;
        }

        private void EventName3_Click(object sender, EventArgs e)
        {
            eventname = Microsoft.VisualBasic.Interaction.InputBox("Enter an event name", "Event Name", "Default Text");
            eventLabel3.Text = eventname;
            Properties.Settings.Default.event_name3 = eventname;
        }

        private void behavior4_Click(object sender, EventArgs e)
        {
            behavior = Microsoft.VisualBasic.Interaction.InputBox("Enter New Behavior Name", "New Behavior", "Default Text");
            tabPage4.Text = behavior;
            behaviorlabel4.Name = behavior;
            Properties.Settings.Default.tab4name = behavior;
            Properties.Settings.Default.behaviorname4 = behavior;
        }

        private void state4_Click(object sender, EventArgs e)
        {
            timer4.Start();
            stateStart4 = DateTime.Now.ToString();
        }

        private void state4stop_Click(object sender, EventArgs e)
        {
            long time = timer4.ElapsedMilliseconds;
            string lines = researcherName + "," + researcherAnimal + "," + behaviorlabel4.Text + ",State," + stateLabel4.Text + "," + stateStart4 + "," + time.ToString() + "," + eventLabel4.Text + "," + num4.ToString();
            foreach (string eventTime in events4)
            {
                lines += "," + eventTime;
            }
            events4.Clear();
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
            file.WriteLine(lines);

            file.Close();
            timer4.Stop();
            num4 = 0;
        }

        private void event4_Click(object sender, EventArgs e)
        {
            if (behaviorlabel4.Text != null && stateLabel4.Text != null && eventLabel4.Text != null)
            {
                //Compose a string that consists of three lines.
                string time = DateTime.Now.ToString();
                if (timer4.IsRunning != false)
                {
                    num4++;
                    events4.Add(time);
                }
                else
                {
                    string line = researcherName + "," + researcherAnimal + "," + behaviorlabel4.Text + ",Event, , , ," + eventLabel4.Text + ", ," + time;
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
                    file.WriteLine(line);

                    file.Close();
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the fields have been completed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void stateName4_Click(object sender, EventArgs e)
        {
            statename = Microsoft.VisualBasic.Interaction.InputBox("Enter a state name", "State Name", "Default Text");
            stateLabel4.Text = statename;
            Properties.Settings.Default.state_name4 = statename;
        }

        private void EventName4_Click(object sender, EventArgs e)
        {
            eventname = Microsoft.VisualBasic.Interaction.InputBox("Enter an event name", "Event Name", "Default Text");
            eventLabel4.Text = eventname;
            Properties.Settings.Default.event_name4 = eventname;
        }


        private void behavior5_Click(object sender, EventArgs e)
        {
            behavior = Microsoft.VisualBasic.Interaction.InputBox("Enter New Behavior Name", "New Behavior", "Default Text");
            tabPage5.Text = behavior;
            behaviorlabel5.Name = behavior;
            Properties.Settings.Default.tab5name = behavior;
            Properties.Settings.Default.behaviorname5 = behavior;
        }

        private void state5_Click(object sender, EventArgs e)
        {
            timer5.Start();
            stateStart5 = DateTime.Now.ToString();
        }

        private void state5stop_Click(object sender, EventArgs e)
        {
            long time = timer5.ElapsedMilliseconds;
            string lines = researcherName + "," + researcherAnimal + "," + behaviorlabel5.Text + ",State," + stateLabel5.Text + "," + stateStart5 + "," + time.ToString() + "," + eventLabel5.Text + "," + num5.ToString();
            foreach (string eventTime in events5)
            {
                lines += "," + eventTime;
            }
            events5.Clear();
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
            file.WriteLine(lines);

            file.Close();
            timer5.Stop();
            num5 = 0;
        }

        private void event5_Click(object sender, EventArgs e)
        {
            if (behaviorlabel5.Text != null && stateLabel5.Text != null && eventLabel5.Text != null)
            {
                //Compose a string that consists of three lines.
                string time = DateTime.Now.ToString();
                if (timer5.IsRunning != false)
                {
                    num5++;
                    events5.Add(time);
                }
                else
                {
                    string line = researcherName + "," + researcherAnimal + "," + behaviorlabel5.Text + ",Event, , , ," + eventLabel5.Text + ", ," + time;
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Mentorship\\Datacsv.csv", true);
                    file.WriteLine(line);

                    file.Close();
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the fields have been completed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void stateName5_Click(object sender, EventArgs e)
        {
            statename = Microsoft.VisualBasic.Interaction.InputBox("Enter a state name", "State Name", "Default Text");
            stateLabel5.Text = statename;
            Properties.Settings.Default.state_name5 = statename;
        }

        private void EventName5_Click(object sender, EventArgs e)
        {
            eventname = Microsoft.VisualBasic.Interaction.InputBox("Enter an event name", "Event Name", "Default Text");
            eventLabel5.Text = eventname;
            Properties.Settings.Default.event_name5 = eventname;
        }

 
    }
   
    
}
