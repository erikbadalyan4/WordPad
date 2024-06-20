using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WordPad
{
    public partial class SwapForm : Form
    {
        int SearchIndex;
        Form1 form1;

        public SwapForm(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void SwapForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = form1.SearchText;
            textBox2.Text = form1.SwapText;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SearchIndex = form1.richTextBox1.SelectionStart + form1.richTextBox1.SelectionLength;
            if (checkBox1.Checked)
            {
                SearchIndex = form1.richTextBox1.Text.IndexOf(textBox1.Text, SearchIndex);

            }
            else
            {
                SearchIndex = form1.richTextBox1.Text.IndexOf(textBox1.Text, SearchIndex, StringComparison.OrdinalIgnoreCase);
            }

            if (SearchIndex != -1)
            {
                form1.richTextBox1.Select(SearchIndex, textBox1.TextLength);
            }
            else
            {
                MessageBox.Show("Не удается найти" + "\"" + textBox1.Text + "\"", "WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form1.richTextBox1.SelectedText != textBox1.Text)
            {
                SearchIndex = form1.richTextBox1.SelectionStart + form1.richTextBox1.SelectionLength;
                if (checkBox1.Checked)
                {
                    SearchIndex = form1.richTextBox1.Text.IndexOf(textBox1.Text, SearchIndex);

                }
                else
                {
                    SearchIndex = form1.richTextBox1.Text.IndexOf(textBox1.Text, SearchIndex, StringComparison.OrdinalIgnoreCase);
                }

                if (SearchIndex != -1)
                {
                    form1.richTextBox1.Select(SearchIndex, textBox1.TextLength);
                }
                else
                {
                    MessageBox.Show("Не удается найти" + "\"" + textBox1.Text + "\"", "WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                form1.richTextBox1.SelectedText = textBox2.Text;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int SLStart = form1.richTextBox1.SelectionStart;
            form1.richTextBox1.SelectionStart = 0;
            bool isEmpty = false;
            while (!isEmpty)
            {
                SearchIndex = form1.richTextBox1.SelectionStart + form1.richTextBox1.SelectionLength;
                if (checkBox1.Checked)
                {
                    SearchIndex = form1.richTextBox1.Text.IndexOf(textBox1.Text, SearchIndex);

                }
                else
                {
                    SearchIndex = form1.richTextBox1.Text.IndexOf(textBox1.Text, SearchIndex, StringComparison.OrdinalIgnoreCase);
                }

                if (SearchIndex != -1)
                {
                    form1.richTextBox1.Select(SearchIndex, textBox1.TextLength);
                    form1.richTextBox1.SelectedText = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("Замена выполнена!", "WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isEmpty = true;
                }
            }
            form1.richTextBox1.SelectionStart = SLStart;

        }

        private void SwapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.SearchInd = SearchIndex;
            form1.SearchText = textBox1.Text;
            form1.SwapText = textBox2.Text; 
            form1.registr = checkBox1.Checked;
        }
    }
}
