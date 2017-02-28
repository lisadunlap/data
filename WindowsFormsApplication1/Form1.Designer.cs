namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.signin1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stateLabel1 = new System.Windows.Forms.Label();
            this.stateName1 = new System.Windows.Forms.Button();
            this.eventName1 = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.eventLabel1 = new System.Windows.Forms.Label();
            this.behaviorlabel1 = new System.Windows.Forms.Label();
            this.state1stop = new System.Windows.Forms.Button();
            this.state1 = new System.Windows.Forms.Button();
            this.behavior1 = new System.Windows.Forms.Button();
            this.event1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.state2stop = new System.Windows.Forms.Button();
            this.eventLabel2 = new System.Windows.Forms.Label();
            this.stateLabel2 = new System.Windows.Forms.Label();
            this.behaviorlabel2 = new System.Windows.Forms.Label();
            this.eventName2 = new System.Windows.Forms.Button();
            this.stateName2 = new System.Windows.Forms.Button();
            this.event2 = new System.Windows.Forms.Button();
            this.state2 = new System.Windows.Forms.Button();
            this.behavior2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.eventLabel3 = new System.Windows.Forms.Label();
            this.stateLabel3 = new System.Windows.Forms.Label();
            this.behaviorlabel3 = new System.Windows.Forms.Label();
            this.state3stop = new System.Windows.Forms.Button();
            this.eventName3 = new System.Windows.Forms.Button();
            this.event3 = new System.Windows.Forms.Button();
            this.state3 = new System.Windows.Forms.Button();
            this.stateName3 = new System.Windows.Forms.Button();
            this.behavior3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // signin1
            // 
            this.signin1.Location = new System.Drawing.Point(16, 35);
            this.signin1.Name = "signin1";
            this.signin1.Size = new System.Drawing.Size(168, 32);
            this.signin1.TabIndex = 5;
            this.signin1.Text = "Sign In";
            this.signin1.UseVisualStyleBackColor = true;
            this.signin1.Click += new System.EventHandler(this.signin1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "researcher1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = global::WindowsFormsApplication1.Properties.Settings.Default.researcher1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "tab1name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabControl1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::WindowsFormsApplication1.Properties.Settings.Default, "tab1name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabControl1.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::WindowsFormsApplication1.Properties.Settings.Default, "tab1name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = global::WindowsFormsApplication1.Properties.Settings.Default.tab1name;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 379);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Tag = global::WindowsFormsApplication1.Properties.Settings.Default.tab1name;
            this.tabControl1.Text = global::WindowsFormsApplication1.Properties.Settings.Default.tab1name;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stateLabel1);
            this.tabPage1.Controls.Add(this.stateName1);
            this.tabPage1.Controls.Add(this.eventName1);
            this.tabPage1.Controls.Add(this.startLabel);
            this.tabPage1.Controls.Add(this.eventLabel1);
            this.tabPage1.Controls.Add(this.behaviorlabel1);
            this.tabPage1.Controls.Add(this.state1stop);
            this.tabPage1.Controls.Add(this.state1);
            this.tabPage1.Controls.Add(this.behavior1);
            this.tabPage1.Controls.Add(this.event1);
            this.tabPage1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "tab1name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = global::WindowsFormsApplication1.Properties.Settings.Default.tab1name;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stateLabel1
            // 
            this.stateLabel1.AutoSize = true;
            this.stateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "state_name1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stateLabel1.Location = new System.Drawing.Point(37, 120);
            this.stateLabel1.Name = "stateLabel1";
            this.stateLabel1.Size = new System.Drawing.Size(0, 20);
            this.stateLabel1.TabIndex = 11;
            this.stateLabel1.Text = global::WindowsFormsApplication1.Properties.Settings.Default.state_name1;
            // 
            // stateName1
            // 
            this.stateName1.Location = new System.Drawing.Point(30, 160);
            this.stateName1.Name = "stateName1";
            this.stateName1.Size = new System.Drawing.Size(145, 55);
            this.stateName1.TabIndex = 10;
            this.stateName1.Text = "State Name";
            this.stateName1.UseVisualStyleBackColor = true;
            this.stateName1.Click += new System.EventHandler(this.stateName1_Click);
            // 
            // eventName1
            // 
            this.eventName1.Location = new System.Drawing.Point(352, 160);
            this.eventName1.Name = "eventName1";
            this.eventName1.Size = new System.Drawing.Size(145, 55);
            this.eventName1.TabIndex = 9;
            this.eventName1.Text = "Event Name";
            this.eventName1.UseVisualStyleBackColor = true;
            this.eventName1.Click += new System.EventHandler(this.eventName1_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(37, 120);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(0, 20);
            this.startLabel.TabIndex = 8;
            // 
            // eventLabel1
            // 
            this.eventLabel1.AutoSize = true;
            this.eventLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "event_name1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.eventLabel1.Location = new System.Drawing.Point(364, 120);
            this.eventLabel1.Name = "eventLabel1";
            this.eventLabel1.Size = new System.Drawing.Size(0, 20);
            this.eventLabel1.TabIndex = 7;
            this.eventLabel1.Text = global::WindowsFormsApplication1.Properties.Settings.Default.event_name1;
            // 
            // behaviorlabel1
            // 
            this.behaviorlabel1.AutoSize = true;
            this.behaviorlabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "behaviorname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.behaviorlabel1.Location = new System.Drawing.Point(209, 28);
            this.behaviorlabel1.Name = "behaviorlabel1";
            this.behaviorlabel1.Size = new System.Drawing.Size(92, 20);
            this.behaviorlabel1.TabIndex = 6;
            this.behaviorlabel1.Text = global::WindowsFormsApplication1.Properties.Settings.Default.behaviorname;
            // 
            // state1stop
            // 
            this.state1stop.Location = new System.Drawing.Point(190, 247);
            this.state1stop.Name = "state1stop";
            this.state1stop.Size = new System.Drawing.Size(145, 55);
            this.state1stop.TabIndex = 4;
            this.state1stop.Text = "State: Stop";
            this.state1stop.UseVisualStyleBackColor = true;
            this.state1stop.Click += new System.EventHandler(this.state1stop_Click);
            // 
            // state1
            // 
            this.state1.Location = new System.Drawing.Point(30, 247);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(145, 55);
            this.state1.TabIndex = 0;
            this.state1.Text = "State: Start";
            this.state1.UseVisualStyleBackColor = true;
            this.state1.Click += new System.EventHandler(this.state1_Click);
            // 
            // behavior1
            // 
            this.behavior1.Location = new System.Drawing.Point(183, 64);
            this.behavior1.Name = "behavior1";
            this.behavior1.Size = new System.Drawing.Size(145, 55);
            this.behavior1.TabIndex = 3;
            this.behavior1.Text = "Behavior ";
            this.behavior1.UseVisualStyleBackColor = true;
            this.behavior1.Click += new System.EventHandler(this.behavior1_Click);
            // 
            // event1
            // 
            this.event1.Location = new System.Drawing.Point(352, 247);
            this.event1.Name = "event1";
            this.event1.Size = new System.Drawing.Size(145, 55);
            this.event1.TabIndex = 2;
            this.event1.Text = "Event";
            this.event1.UseVisualStyleBackColor = true;
            this.event1.Click += new System.EventHandler(this.event1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.state2stop);
            this.tabPage2.Controls.Add(this.eventLabel2);
            this.tabPage2.Controls.Add(this.stateLabel2);
            this.tabPage2.Controls.Add(this.behaviorlabel2);
            this.tabPage2.Controls.Add(this.eventName2);
            this.tabPage2.Controls.Add(this.stateName2);
            this.tabPage2.Controls.Add(this.event2);
            this.tabPage2.Controls.Add(this.state2);
            this.tabPage2.Controls.Add(this.behavior2);
            this.tabPage2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "tab2name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = global::WindowsFormsApplication1.Properties.Settings.Default.tab2name;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // state2stop
            // 
            this.state2stop.Location = new System.Drawing.Point(190, 247);
            this.state2stop.Name = "state2stop";
            this.state2stop.Size = new System.Drawing.Size(145, 55);
            this.state2stop.TabIndex = 8;
            this.state2stop.Text = "State: Stop";
            this.state2stop.UseVisualStyleBackColor = true;
            this.state2stop.Click += new System.EventHandler(this.state2stop_Click);
            // 
            // eventLabel2
            // 
            this.eventLabel2.AutoSize = true;
            this.eventLabel2.Location = new System.Drawing.Point(372, 117);
            this.eventLabel2.Name = "eventLabel2";
            this.eventLabel2.Size = new System.Drawing.Size(51, 20);
            this.eventLabel2.TabIndex = 7;
            this.eventLabel2.Text = "label4";
            // 
            // stateLabel2
            // 
            this.stateLabel2.AutoSize = true;
            this.stateLabel2.Location = new System.Drawing.Point(41, 117);
            this.stateLabel2.Name = "stateLabel2";
            this.stateLabel2.Size = new System.Drawing.Size(51, 20);
            this.stateLabel2.TabIndex = 6;
            this.stateLabel2.Text = "label3";
            // 
            // behaviorlabel2
            // 
            this.behaviorlabel2.AutoSize = true;
            this.behaviorlabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "behaviorname2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.behaviorlabel2.Location = new System.Drawing.Point(191, 32);
            this.behaviorlabel2.Name = "behaviorlabel2";
            this.behaviorlabel2.Size = new System.Drawing.Size(0, 20);
            this.behaviorlabel2.TabIndex = 5;
            this.behaviorlabel2.Text = global::WindowsFormsApplication1.Properties.Settings.Default.behaviorname2;
            // 
            // eventName2
            // 
            this.eventName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "event_name2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.eventName2.Location = new System.Drawing.Point(352, 160);
            this.eventName2.Name = "eventName2";
            this.eventName2.Size = new System.Drawing.Size(145, 55);
            this.eventName2.TabIndex = 4;
            this.eventName2.Text = global::WindowsFormsApplication1.Properties.Settings.Default.event_name2;
            this.eventName2.UseVisualStyleBackColor = true;
            this.eventName2.Click += new System.EventHandler(this.eventName2_Click);
            // 
            // stateName2
            // 
            this.stateName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "state_name2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stateName2.Location = new System.Drawing.Point(30, 160);
            this.stateName2.Name = "stateName2";
            this.stateName2.Size = new System.Drawing.Size(145, 55);
            this.stateName2.TabIndex = 3;
            this.stateName2.Text = global::WindowsFormsApplication1.Properties.Settings.Default.state_name2;
            this.stateName2.UseVisualStyleBackColor = true;
            this.stateName2.Click += new System.EventHandler(this.stateName2_Click);
            // 
            // event2
            // 
            this.event2.Location = new System.Drawing.Point(352, 247);
            this.event2.Name = "event2";
            this.event2.Size = new System.Drawing.Size(145, 55);
            this.event2.TabIndex = 2;
            this.event2.Text = "Event";
            this.event2.UseVisualStyleBackColor = true;
            this.event2.Click += new System.EventHandler(this.event2_Click);
            // 
            // state2
            // 
            this.state2.Location = new System.Drawing.Point(30, 247);
            this.state2.Name = "state2";
            this.state2.Size = new System.Drawing.Size(145, 55);
            this.state2.TabIndex = 1;
            this.state2.Text = "State: Start";
            this.state2.UseVisualStyleBackColor = true;
            this.state2.Click += new System.EventHandler(this.state2_Click);
            // 
            // behavior2
            // 
            this.behavior2.Location = new System.Drawing.Point(183, 64);
            this.behavior2.Name = "behavior2";
            this.behavior2.Size = new System.Drawing.Size(145, 55);
            this.behavior2.TabIndex = 0;
            this.behavior2.Text = "Behavior";
            this.behavior2.UseVisualStyleBackColor = true;
            this.behavior2.Click += new System.EventHandler(this.behavior2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.eventLabel3);
            this.tabPage3.Controls.Add(this.stateLabel3);
            this.tabPage3.Controls.Add(this.behaviorlabel3);
            this.tabPage3.Controls.Add(this.state3stop);
            this.tabPage3.Controls.Add(this.eventName3);
            this.tabPage3.Controls.Add(this.event3);
            this.tabPage3.Controls.Add(this.state3);
            this.tabPage3.Controls.Add(this.stateName3);
            this.tabPage3.Controls.Add(this.behavior3);
            this.tabPage3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "tab3name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(526, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = global::WindowsFormsApplication1.Properties.Settings.Default.tab3name;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // eventLabel3
            // 
            this.eventLabel3.AutoSize = true;
            this.eventLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "event_name3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.eventLabel3.Location = new System.Drawing.Point(359, 125);
            this.eventLabel3.Name = "eventLabel3";
            this.eventLabel3.Size = new System.Drawing.Size(0, 20);
            this.eventLabel3.TabIndex = 8;
            this.eventLabel3.Text = global::WindowsFormsApplication1.Properties.Settings.Default.event_name3;
            // 
            // stateLabel3
            // 
            this.stateLabel3.AutoSize = true;
            this.stateLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "state_name3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stateLabel3.Location = new System.Drawing.Point(35, 125);
            this.stateLabel3.Name = "stateLabel3";
            this.stateLabel3.Size = new System.Drawing.Size(0, 20);
            this.stateLabel3.TabIndex = 7;
            this.stateLabel3.Text = global::WindowsFormsApplication1.Properties.Settings.Default.state_name3;
            // 
            // behaviorlabel3
            // 
            this.behaviorlabel3.AutoSize = true;
            this.behaviorlabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "behaviorname3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.behaviorlabel3.Location = new System.Drawing.Point(186, 32);
            this.behaviorlabel3.Name = "behaviorlabel3";
            this.behaviorlabel3.Size = new System.Drawing.Size(0, 20);
            this.behaviorlabel3.TabIndex = 6;
            this.behaviorlabel3.Text = global::WindowsFormsApplication1.Properties.Settings.Default.behaviorname3;
            // 
            // state3stop
            // 
            this.state3stop.Location = new System.Drawing.Point(190, 247);
            this.state3stop.Name = "state3stop";
            this.state3stop.Size = new System.Drawing.Size(145, 55);
            this.state3stop.TabIndex = 5;
            this.state3stop.Text = "State: Stop";
            this.state3stop.UseVisualStyleBackColor = true;
            this.state3stop.Click += new System.EventHandler(this.state3stop_Click);
            // 
            // eventName3
            // 
            this.eventName3.Location = new System.Drawing.Point(352, 160);
            this.eventName3.Name = "eventName3";
            this.eventName3.Size = new System.Drawing.Size(145, 55);
            this.eventName3.TabIndex = 4;
            this.eventName3.Text = "Event Name";
            this.eventName3.UseVisualStyleBackColor = true;
            this.eventName3.Click += new System.EventHandler(this.EventName3_Click);
            // 
            // event3
            // 
            this.event3.Location = new System.Drawing.Point(352, 247);
            this.event3.Name = "event3";
            this.event3.Size = new System.Drawing.Size(145, 55);
            this.event3.TabIndex = 3;
            this.event3.Text = "Event";
            this.event3.UseVisualStyleBackColor = true;
            this.event3.Click += new System.EventHandler(this.event3_Click);
            // 
            // state3
            // 
            this.state3.Location = new System.Drawing.Point(30, 247);
            this.state3.Name = "state3";
            this.state3.Size = new System.Drawing.Size(145, 55);
            this.state3.TabIndex = 2;
            this.state3.Text = "State: Start";
            this.state3.UseVisualStyleBackColor = true;
            this.state3.Click += new System.EventHandler(this.state3_Click);
            // 
            // stateName3
            // 
            this.stateName3.Location = new System.Drawing.Point(30, 160);
            this.stateName3.Name = "stateName3";
            this.stateName3.Size = new System.Drawing.Size(145, 55);
            this.stateName3.TabIndex = 1;
            this.stateName3.Text = "State Name";
            this.stateName3.UseVisualStyleBackColor = true;
            this.stateName3.Click += new System.EventHandler(this.stateName3_Click);
            // 
            // behavior3
            // 
            this.behavior3.Location = new System.Drawing.Point(183, 64);
            this.behavior3.Name = "behavior3";
            this.behavior3.Size = new System.Drawing.Size(145, 55);
            this.behavior3.TabIndex = 0;
            this.behavior3.Text = "Reset Behavior";
            this.behavior3.UseVisualStyleBackColor = true;
            this.behavior3.Click += new System.EventHandler(this.behavior3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(526, 346);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(526, 346);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(526, 346);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 463);
            this.Controls.Add(this.signin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Doug I Hope This Makes You Happy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button state1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button event1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button behavior1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button event2;
        private System.Windows.Forms.Button state2;
        private System.Windows.Forms.Button behavior2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button state3;
        private System.Windows.Forms.Button stateName3;
        private System.Windows.Forms.Button behavior3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button state1stop;
        private System.Windows.Forms.Button signin1;
        private System.Windows.Forms.Label behaviorlabel1;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label eventLabel1;
        private System.Windows.Forms.Label stateLabel1;
        private System.Windows.Forms.Button stateName1;
        private System.Windows.Forms.Button eventName1;
        private System.Windows.Forms.Button state2stop;
        private System.Windows.Forms.Label eventLabel2;
        private System.Windows.Forms.Label stateLabel2;
        private System.Windows.Forms.Label behaviorlabel2;
        private System.Windows.Forms.Button eventName2;
        private System.Windows.Forms.Button stateName2;
        private System.Windows.Forms.Button state3stop;
        private System.Windows.Forms.Button eventName3;
        private System.Windows.Forms.Button event3;
        private System.Windows.Forms.Label eventLabel3;
        private System.Windows.Forms.Label stateLabel3;
        private System.Windows.Forms.Label behaviorlabel3;
    }
}

