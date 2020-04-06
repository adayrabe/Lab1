using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private String[] arr = {
            "Hello my dear friend!",
            "Oh, I realy like you.",
            "I'm feeling lost without you",
            "Boring people, stupid people",
            "Oh, magic!"
        };

        public Form1()
        {
            InitializeComponent();
        }

        public string getAnswer() {
            int number = new Random().Next(5);
            return arr[number];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            listBox1.Items.Add("User: " + text);
            listBox1.Items.Add("Bot: " + getAnswer());
        }
    }
}
