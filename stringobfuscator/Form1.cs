using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringobfuscate
{
    public partial class Form1 : Form
    {
        private string key = "changeme";

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = key;
        }

        private string ObfuscateString(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputBytes.Length; i++)
            {
                sb.Append((char)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]));
            }

            return sb.ToString();
        }

        private string DeobfuscateString(string input)
        {
            return ObfuscateString(input);
        }

        private void ObfuscateButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            string obfuscated = ObfuscateString(input);
            OutputTextBox.Text = obfuscated;
        }

        private void DeobfuscateButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            string deobfuscated = DeobfuscateString(input);
            OutputTextBox.Text = deobfuscated;
        }

        private void ObfuscateButton_Click_1(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            string obfuscated = ObfuscateString(input);
            OutputTextBox.Text = obfuscated;
        }

        private void DeobfuscateButton_Click_1(object sender, EventArgs e)
        {
            string input = OutputTextBox.Text;
            string deobfuscated = DeobfuscateString(input);
            InputTextBox.Text = deobfuscated;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            key = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}