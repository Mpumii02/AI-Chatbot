using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace tutorialAIChatbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot AI = new Bot();
            AI.loadSettings(); // it will load settings from its config folder 
            AI.loadAIMLFromFiles(); // withthis code it will load aiml files from aiml folder

            AI.isAcceptingUserInput = false; // with this code it will disable user input for now

            User myUser = new User("Username here", AI); //with this code we will add the user through AI/Bot
            //Now enable user

            AI.isAcceptingUserInput = true; // now user input is enabled
            Request r = new Request(textBox1.Text, myUser, AI); // code requests a response from aiml
            Result res = AI.Chat(r); // this will get response from aiml

            textBox2.Text = "JARVIS: " + res.Output; // this will write the reults from first text box

            //end

        }
    }
}
