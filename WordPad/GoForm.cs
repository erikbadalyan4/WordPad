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
    public partial class GoForm : Form
    {
        Form1 form1;
        public GoForm(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void GoForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lineNumber = Convert.ToInt32(textBox1.Text);
            int totalChars = form1.richTextBox1.Text.Length;
            int totalLines = form1.richTextBox1.GetLineFromCharIndex(totalChars) + 1;
            if (lineNumber > 0 && lineNumber <= totalLines)
            {
                form1.richTextBox1.SelectionStart = form1.richTextBox1.GetFirstCharIndexFromLine(lineNumber - 1);
                form1.richTextBox1.SelectionLength = 0;
                form1.richTextBox1.ScrollToCaret();
                this.Close();

            }
            else
            {
                MessageBox.Show("Номер строки превышает общее число строк", "Переход на строку");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    
                    button1.Focus();
                }
                return;
            }
            
            e.Handled = true;
        }
    }
}
