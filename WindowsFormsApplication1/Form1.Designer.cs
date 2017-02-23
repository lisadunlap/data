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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.stateName1.Location = new System.Drawing.Point(23, 153);
            this.stateName1.Name = "stateName1";
            this.stateName1.Size = new System.Drawing.Size(115, 42);
            this.stateName1.TabIndex = 10;
            this.stateName1.Text = "State Name";
            this.stateName1.UseVisualStyleBackColor = true;
            this.stateName1.Click += new System.EventHandler(this.stateName1_Click);
            // 
            // eventName1
            // 
            this.eventName1.Location = new System.Drawing.Point(349, 153);
            this.eventName1.Name = "eventName1";
            this.eventName1.Size = new System.Drawing.Size(128, 42);
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
            this.state1stop.Location = new System.Drawing.Point(186, 255);
            this.state1stop.Name = "state1stop";
            this.state1stop.Size = new System.Drawing.Size(115, 47);
            this.state1stop.TabIndex = 4;
            this.state1stop.Text = "State: Stop";
            this.state1stop.UseVisualStyleBackColor = true;
            this.state1stop.Click += new System.EventHandler(this.state1stop_Click);
            // 
            // state1
            // 
            this.state1.Location = new System.Drawing.Point(23, 255);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(115, 47);
            this.state1.TabIndex = 0;
            this.state1.Text = "State: Start";
            this.state1.UseVisualStyleBackColor = true;
            this.state1.Click += new System.EventHandler(this.state1_Click);
            // 
            // behavior1
            // 
            this.behavior1.Location = new System.Drawing.Point(186, 64);
            this.behavior1.Name = "behavior1";
            this.behavior1.Size = new System.Drawing.Size(132, 49);
            this.behavior1.TabIndex = 3;
            this.behavior1.Text = "Behavior ";
            this.behavior1.UseVisualStyleBackColor = true;
            this.behavior1.Click += new System.EventHandler(this.behavior1_Click);
            // 
            // event1
            // 
            this.event1.Location = new System.Drawing.Point(349, 255);
            this.event1.Name = "event1";
            this.event1.Size = new System.Drawing.Size(128, 47);
            this.event1.TabIndex = 2;
            this.event1.Text = "Event";
            this.event1.UseVisualStyleBackColor = true;
            this.event1.Click += new System.EventHandler(this.event1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(306, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 52);
            this.button6.TabIndex = 2;
            this.button6.Text = "Event";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 52);
            this.button5.TabIndex = 1;
            this.button5.Text = "State";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 51);
            this.button4.TabIndex = 0;
            this.button4.Text = "Reset Behavior";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(526, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(338, 202);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 53);
            this.button9.TabIndex = 2;
            this.button9.Text = "Event";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(42, 202);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 53);
            this.button8.TabIndex = 1;
            this.button8.Text = "State";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(172, 72);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 53);
            this.button7.TabIndex = 0;
            this.button7.Text = "Reset Behavior";
            this.button7.UseVisualStyleBackColor = true;
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
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
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
    }
}

