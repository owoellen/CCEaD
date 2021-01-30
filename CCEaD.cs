using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCEaD
{
    public partial class CCEaD : Form
    {
        public CCEaD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string NoEInput = NoEText.Text;
            
            int shiftInput = Int32.Parse(shiftAmount.Text);

            if (checkBox1.Checked)
            {
                shiftInput = -shiftInput;
            }

            EoDText.Text = Encrypt(NoEInput.ToLower(), shiftInput);
        }

        static string Encrypt(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpScreen helpForm = new helpScreen();

            helpForm.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutScreen aboutForm = new aboutScreen();

            aboutForm.Show();
        }

        public CCEaD(IContainer components, MenuStrip menuStrip1, ToolStripMenuItem aboutToolStripMenuItem, ToolStripMenuItem helpToolStripMenuItem, Label label1, TextBox noEText, TextBox eoDText, Label label2, TextBox shiftAmount, Button button1, Label label3, ToolStripMenuItem aboutToolStripMenuItem1, RadioButton encryptRadioButton, RadioButton decryptRadioButton, Label label4)
        {
            this.components = components;
            this.menuStrip1 = menuStrip1;
            this.aboutToolStripMenuItem = aboutToolStripMenuItem;
            this.helpToolStripMenuItem = helpToolStripMenuItem;
            this.label1 = label1;
            NoEText = noEText;
            EoDText = eoDText;
            this.label2 = label2;
            this.shiftAmount = shiftAmount;
            this.button1 = button1;
            this.label3 = label3;
            this.aboutToolStripMenuItem1 = aboutToolStripMenuItem1;
            this.label4 = label4;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
