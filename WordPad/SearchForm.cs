using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class SearchForm : Form
    {
        int SearchIndex;
        Form1 form1;
        public SearchForm(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            button1.Enabled = false;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = form1.SearchText;
            if (form1.nextSearch) 
            {
                radioButton2.Checked = true;
            }
            else 
            {
                radioButton1.Checked =  true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (radioButton1.Checked)
                {
                    if (form1.richTextBox1.SelectionLength > 1)
                    {
                        SearchIndex = form1.richTextBox1.SelectionStart;
                    }
                    else 
                    {
                        SearchIndex = form1.richTextBox1.SelectionStart-1;
                    }
                    if (SearchIndex >= 0)
                    {
                        if (checkBox1.Checked)
                        {
                            SearchIndex = form1.richTextBox1.Text.LastIndexOf(textBox1.Text, SearchIndex);
                        }
                        else
                        {
                            SearchIndex = form1.richTextBox1.Text.LastIndexOf(textBox1.Text, SearchIndex, StringComparison.OrdinalIgnoreCase);
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
                        MessageBox.Show("Не удается найти" + "\"" + textBox1.Text + "\"", "WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (radioButton2.Checked)
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

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.SearchInd = SearchIndex;
            form1.SearchText = textBox1.Text;
            if (form1.nextSearch)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
            form1.registr = checkBox1.Checked;
        }
    }
}
