using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WordPad
{
    public partial class Form1 : Form
    {
        int SavingFormat = 0;//0 - файл еще не был сохранен; 1 - сохранен в txt; 2 - сохранен в rtf;
        string FilePath;//Путь файла
        public string SearchText;
        public string SwapText;
        public int SearchInd;
        public bool nextSearch = true;
        public bool registr;
        bool MouseUP;
        bool SizeDetectingOver = true;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.HideSelection = false;
            richTextBox1.WordWrap = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Тексторые документы(*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Тексторые документы(*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            toolTip1.SetToolTip(insertButton, "Вставить (CTRL+V)");
            toolTip1.SetToolTip(copyButton, "Копировать (CTRL+С)");
            toolTip1.SetToolTip(сutButton, "Вырезать (CTRL+Z)");
            toolTip1.SetToolTip(delButton, "Удалить (DEl)");
            toolTip1.SetToolTip(fontcomboBox, "Семейство шрифтов");
            toolTip1.SetToolTip(fontsizecomboBox, "Размер шрифта");
            toolTip1.SetToolTip(fontPlusButton, "Увеличить размер шрифта");
            toolTip1.SetToolTip(fontMinusButton, "Уменьшить размер шрифта");
            toolTip1.SetToolTip(boldButton, "Полужирный");
            toolTip1.SetToolTip(italicButton, "Курсив");
            toolTip1.SetToolTip(underlineButton, "Подчеркнутый");
            toolTip1.SetToolTip(strikeoutButton, "Зачеркнутый");
            toolTip1.SetToolTip(minusIndentButton, "Уменьшить отступ");
            toolTip1.SetToolTip(plusIndentButton, "Увкличить отступ");
            toolTip1.SetToolTip(leftLevelingButton, "Выравнивание по левому краю");
            toolTip1.SetToolTip(middleLevelingButton, "Выравнивание по центру");
            toolTip1.SetToolTip(rightLevelingButton, "Выравнивание по правому краю");
            toolTip1.SetToolTip(searchButton, "Найти");
            toolTip1.SetToolTip(nsearchButton, "Найти далее");
            toolTip1.SetToolTip(psearchButton, "Найти ранее");
            toolTip1.SetToolTip(swapButton, "Замена");
            toolTip1.SetToolTip(allselectButton, "Выделить все (CTRL+A)");
            toolTip1.SetToolTip(goButton, "Перейти к строке");
            toolTip1.SetToolTip(plusButton, "Увеличить масштаб");
            toolTip1.SetToolTip(minusButton, "Уменьшить масштаб");
            toolTip1.SetToolTip(goButton, "Масштаб по умолчанию");
            toolTip1.SetToolTip(checkBox1, "Выключить строку состояния");
            toolTip1.SetToolTip(checkBox2, "Выключить перенос по словам");


            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;
            foreach (FontFamily fontFamily in fontFamilies)
            {
                fontcomboBox.Items.Add(fontFamily.Name);
            }
            foreach (Control control in mainpanel.Controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)control;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            главнаяToolStripMenuItem.PerformClick();
            this.Text = "Новый документ - WordPad";
            fontcomboBox.Text = richTextBox1.Font.FontFamily.Name;
            fontsizecomboBox.Text = Convert.ToString(richTextBox1.Font.Size);
            richTextBox1.Modified = false;
            fontPlusButton.Tag = false;
            fontMinusButton.Tag = false;
            boldButton.Tag = false;
            italicButton.Tag = false;
            underlineButton.Tag = false;
            strikeoutButton.Tag = false;
            middleLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
            rightLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
            leftLevelingButton.BackColor = SystemColors.ActiveCaption;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if ((this.Width <= 816 && this.WindowState != FormWindowState.Minimized) || (!checkBox2.Checked))
            {
                richTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                richTextBox1.Width = this.Width - 23;
                richTextBox1.Location = new Point(3, richTextBox1.Location.Y);
            }
            else
            {
                richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                richTextBox1.Width = 816;
                richTextBox1.Location = new Point((this.Width / 2) - (richTextBox1.Width / 2) - 9, richTextBox1.Location.Y);
            }
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void скрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainpanel.Visible == true)
            {
                richTextBox1.Location = new Point((this.Width / 2) - (richTextBox1.Width / 2) - 9, 27);
                richTextBox1.Size = new Size(richTextBox1.Width, richTextBox1.Height + 93);
                скрытьToolStripMenuItem.Text = "﹀";
                mainpanel.Visible = false;
                главнаяToolStripMenuItem.BackColor = SystemColors.Control;
                видToolStripMenuItem.BackColor = SystemColors.Control;
            }
            else
            {
                richTextBox1.Location = new Point((this.Width / 2) - (richTextBox1.Width / 2) - 9, 120);
                richTextBox1.Size = new Size(richTextBox1.Width, richTextBox1.Height - 93);
                скрытьToolStripMenuItem.Text = "︿";
                mainpanel.Visible = true;
                if (plusButton.Visible)
                {
                    видToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    главнаяToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
                }
            }
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainpanel.Visible == false)
            {
                richTextBox1.Location = new Point((this.Width / 2) - (richTextBox1.Width / 2) - 9, 120);
                richTextBox1.Size = new Size(richTextBox1.Width, richTextBox1.Height - 93);
                скрытьToolStripMenuItem.Text = "︿";
                mainpanel.Visible = true;
            }
            foreach (Control control in mainpanel.Controls)
            {
                control.Visible = true;
            }
            plusButton.Visible = false;
            minusButton.Visible = false;
            defaultButton.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            главнаяToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            видToolStripMenuItem.BackColor = SystemColors.Control;

        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainpanel.Visible == false)
            {
                richTextBox1.Location = new Point((this.Width / 2) - (richTextBox1.Width / 2) - 9, 120);
                richTextBox1.Size = new Size(richTextBox1.Width, richTextBox1.Height - 93);
                скрытьToolStripMenuItem.Text = "︿";
                mainpanel.Visible = true;
            }
            foreach (Control control in mainpanel.Controls)
            {
                control.Visible = false;
            }
            plusButton.Visible = true;
            plusButton.Location = new Point(7, 6);
            minusButton.Visible = true;
            minusButton.Location = new Point(7 + plusButton.Width, 6);
            defaultButton.Visible = true;
            defaultButton.Location = new Point(minusButton.Location.X + plusButton.Width, 6);
            checkBox1.Visible = true;
            checkBox1.Location = new Point(defaultButton.Location.X + 64, 17);
            checkBox2.Visible = true;
            checkBox2.Location = new Point(defaultButton.Location.X + 64, 45);
            label5.Visible = true;
            label5.Location = new Point(7, 74);
            label6.Visible = true;
            label6.Location = new Point(defaultButton.Location.X + 64, 74);
            видToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            главнаяToolStripMenuItem.BackColor = SystemColors.Control;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                statusStrip1.Visible = true;
                richTextBox1.Size = new Size(richTextBox1.Width, richTextBox1.Height - statusStrip1.Height);
            }
            else
            {
                statusStrip1.Visible = false;
                richTextBox1.Size = new Size(richTextBox1.Width, richTextBox1.Height + statusStrip1.Height);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                richTextBox1.WordWrap = true;
                richTextBox1.Width = 816;
                richTextBox1.Location = new Point((this.Width / 2) - (richTextBox1.Width / 2) - 9, richTextBox1.Location.Y);
                richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
                leftLevelingButton.Enabled = true;
                middleLevelingButton.Enabled = true;
                rightLevelingButton.Enabled = true;
            }
            else
            {
                richTextBox1.WordWrap = false;
                richTextBox1.Location = new Point(3, richTextBox1.Location.Y);
                richTextBox1.Width = this.Width - 23;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
                leftLevelingButton.Enabled = false;
                middleLevelingButton.Enabled = false;
                rightLevelingButton.Enabled = false;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == false)
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (openFileDialog1.FileName == null) return;
                try
                {
                    switch (System.IO.Path.GetExtension(openFileDialog1.FileName).ToLower())
                    {
                        case ".rtf":
                            FilePath = openFileDialog1.FileName;
                            openFileDialog1.FileName = "";
                            richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.RichText);
                            this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                            fontPlusButton.Tag = false;
                            fontMinusButton.Tag = false;
                            boldButton.Tag = false;
                            italicButton.Tag = false;
                            underlineButton.Tag = false;
                            strikeoutButton.Tag = false;
                            richTextBox1.Modified = false;
                            SavingFormat = 2;
                            break;
                        case ".txt":
                            FilePath = openFileDialog1.FileName;
                            openFileDialog1.FileName = "";
                            richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.PlainText);
                            this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                            fontPlusButton.Tag = false;
                            fontMinusButton.Tag = false;
                            boldButton.Tag = false;
                            italicButton.Tag = false;
                            underlineButton.Tag = false;
                            strikeoutButton.Tag = false;
                            richTextBox1.Modified = false;
                            SavingFormat = 1;
                            break;
                    }
                }
                catch (System.IO.FileNotFoundException Ситуация)
                {
                    MessageBox.Show(Ситуация + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (System.Exception Ситуация)
                {
                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }
            DialogResult MBox = MessageBox.Show("Текст был изменен.\nСохранить изменения?", "WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (MBox)
            {
                case DialogResult.No:
                    if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                    if (openFileDialog1.FileName == null) return;
                    try
                    {
                        switch (System.IO.Path.GetExtension(openFileDialog1.FileName).ToLower())
                        {
                            case ".rtf":
                                FilePath = openFileDialog1.FileName;
                                openFileDialog1.FileName = "";
                                richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.RichText);
                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                fontPlusButton.Tag = false;
                                fontMinusButton.Tag = false;
                                boldButton.Tag = false;
                                italicButton.Tag = false;
                                underlineButton.Tag = false;
                                strikeoutButton.Tag = false;
                                richTextBox1.Modified = false;
                                SavingFormat = 2;
                                break;
                            case ".txt":
                                FilePath = openFileDialog1.FileName;
                                openFileDialog1.FileName = "";
                                richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.PlainText);
                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                fontPlusButton.Tag = false;
                                fontMinusButton.Tag = false;
                                boldButton.Tag = false;
                                italicButton.Tag = false;
                                underlineButton.Tag = false;
                                strikeoutButton.Tag = false;
                                richTextBox1.Modified = false;
                                SavingFormat = 1;
                                break;
                        }
                    }
                    catch (System.IO.FileNotFoundException Ситуация)
                    {
                        MessageBox.Show(Ситуация + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (System.Exception Ситуация)
                    {
                        MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return;
                case DialogResult.Cancel:
                    return;
                case DialogResult.Yes:
                    switch (SavingFormat)
                    {
                        case 0:
                            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

                            try
                            {
                                switch (saveFileDialog1.FilterIndex)
                                {
                                    case 1:
                                        FilePath = saveFileDialog1.FileName;
                                        saveFileDialog1.FileName = "";
                                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                                        richTextBox1.Modified = false;
                                        SavingFormat = 1;
                                        break;
                                    case 2:
                                        FilePath = saveFileDialog1.FileName;
                                        saveFileDialog1.FileName = "";
                                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                                        richTextBox1.Modified = false;
                                        SavingFormat = 2;
                                        break;
                                }
                                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                                if (openFileDialog1.FileName == null) return;
                                try
                                {
                                    switch (System.IO.Path.GetExtension(openFileDialog1.FileName).ToLower())
                                    {
                                        case ".rtf":
                                            FilePath = openFileDialog1.FileName;
                                            openFileDialog1.FileName = "";
                                            richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.RichText);
                                            this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                            fontPlusButton.Tag = false;
                                            fontMinusButton.Tag = false;
                                            boldButton.Tag = false;
                                            italicButton.Tag = false;
                                            underlineButton.Tag = false;
                                            strikeoutButton.Tag = false;
                                            richTextBox1.Modified = false;
                                            SavingFormat = 2;
                                            break;
                                        case ".txt":
                                            FilePath = openFileDialog1.FileName;
                                            openFileDialog1.FileName = "";
                                            richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.PlainText);
                                            this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                            fontPlusButton.Tag = false;
                                            fontMinusButton.Tag = false;
                                            boldButton.Tag = false;
                                            italicButton.Tag = false;
                                            underlineButton.Tag = false;
                                            strikeoutButton.Tag = false;
                                            richTextBox1.Modified = false;
                                            SavingFormat = 1;
                                            break;
                                    }
                                }
                                catch (System.IO.FileNotFoundException Ситуация)
                                {
                                    MessageBox.Show(Ситуация + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                catch (System.Exception Ситуация)
                                {
                                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                return;
                            }
                            catch (System.Exception Ситуация)
                            {
                                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;

                        case 1:
                            if (!string.IsNullOrEmpty(FilePath))
                            {
                                try
                                {
                                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                                    richTextBox1.Modified = false;
                                    if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                                    if (openFileDialog1.FileName == null) return;
                                    try
                                    {
                                        switch (System.IO.Path.GetExtension(openFileDialog1.FileName).ToLower())
                                        {
                                            case ".rtf":
                                                FilePath = openFileDialog1.FileName;
                                                openFileDialog1.FileName = "";
                                                richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.RichText);
                                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                                fontPlusButton.Tag = false;
                                                fontMinusButton.Tag = false;
                                                boldButton.Tag = false;
                                                italicButton.Tag = false;
                                                underlineButton.Tag = false;
                                                strikeoutButton.Tag = false;
                                                richTextBox1.Modified = false;
                                                SavingFormat = 2;
                                                break;
                                            case ".txt":
                                                FilePath = openFileDialog1.FileName;
                                                openFileDialog1.FileName = "";
                                                richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.PlainText);
                                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                                fontPlusButton.Tag = false;
                                                fontMinusButton.Tag = false;
                                                boldButton.Tag = false;
                                                italicButton.Tag = false;
                                                underlineButton.Tag = false;
                                                strikeoutButton.Tag = false;
                                                richTextBox1.Modified = false;
                                                SavingFormat = 1;
                                                break;
                                        }
                                    }
                                    catch (System.IO.FileNotFoundException Ситуация)
                                    {
                                        MessageBox.Show(Ситуация + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    catch (System.Exception Ситуация)
                                    {
                                        MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    return;
                                }
                                catch (System.Exception Ситуация)
                                {
                                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            break;
                        case 2:
                            if (!string.IsNullOrEmpty(FilePath))
                            {
                                try
                                {
                                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                                    richTextBox1.Modified = false;
                                    if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                                    if (openFileDialog1.FileName == null) return;
                                    try
                                    {
                                        switch (System.IO.Path.GetExtension(openFileDialog1.FileName).ToLower())
                                        {
                                            case ".rtf":
                                                FilePath = openFileDialog1.FileName;
                                                openFileDialog1.FileName = "";
                                                richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.RichText);
                                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                                fontPlusButton.Tag = false;
                                                fontMinusButton.Tag = false;
                                                boldButton.Tag = false;
                                                italicButton.Tag = false;
                                                underlineButton.Tag = false;
                                                strikeoutButton.Tag = false;
                                                richTextBox1.Modified = false;
                                                SavingFormat = 2;
                                                break;
                                            case ".txt":
                                                FilePath = openFileDialog1.FileName;
                                                openFileDialog1.FileName = "";
                                                richTextBox1.LoadFile(FilePath, RichTextBoxStreamType.PlainText);
                                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                                fontPlusButton.Tag = false;
                                                fontMinusButton.Tag = false;
                                                boldButton.Tag = false;
                                                italicButton.Tag = false;
                                                underlineButton.Tag = false;
                                                strikeoutButton.Tag = false;
                                                richTextBox1.Modified = false;
                                                SavingFormat = 1;
                                                break;
                                        }
                                    }
                                    catch (System.IO.FileNotFoundException Ситуация)
                                    {
                                        MessageBox.Show(Ситуация + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    catch (System.Exception Ситуация)
                                    {
                                        MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    return;
                                }
                                catch (System.Exception Ситуация)
                                {
                                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            try
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        FilePath = saveFileDialog1.FileName;
                        saveFileDialog1.FileName = "";
                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                        this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                        richTextBox1.Modified = false;
                        SavingFormat = 1;
                        break;
                    case 2:
                        FilePath = saveFileDialog1.FileName;
                        saveFileDialog1.FileName = "";
                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                        this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                        richTextBox1.Modified = false;
                        SavingFormat = 2;
                        break;
                }
            }
            catch (System.Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (SavingFormat)
            {
                case 0:
                    if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

                    try
                    {
                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                FilePath = saveFileDialog1.FileName;
                                saveFileDialog1.FileName = "";
                                richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                richTextBox1.Modified = false;
                                SavingFormat = 1;
                                break;
                            case 2:
                                FilePath = saveFileDialog1.FileName;
                                saveFileDialog1.FileName = "";
                                richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                                this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                richTextBox1.Modified = false;
                                SavingFormat = 2;
                                break;
                        }
                    }
                    catch (System.Exception Ситуация)
                    {
                        MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case 1:
                    if (!string.IsNullOrEmpty(FilePath))
                    {
                        try
                        {

                            richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                            richTextBox1.Modified = false;
                        }
                        catch (System.Exception Ситуация)
                        {
                            MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;
                case 2:
                    if (!string.IsNullOrEmpty(FilePath))
                    {
                        try
                        {
                            richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                            richTextBox1.Modified = false;
                        }
                        catch (System.Exception Ситуация)
                        {
                            MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified == false) return;
            DialogResult MBox = MessageBox.Show("Текст был изменен.\nСохранить изменения?", "WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (MBox)
            {
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    switch (SavingFormat)
                    {
                        case 0:
                            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

                            try
                            {
                                switch (saveFileDialog1.FilterIndex)
                                {
                                    case 1:
                                        FilePath = saveFileDialog1.FileName;
                                        saveFileDialog1.FileName = "";
                                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                                        this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                        richTextBox1.Modified = false;
                                        SavingFormat = 1;
                                        break;
                                    case 2:
                                        FilePath = saveFileDialog1.FileName;
                                        saveFileDialog1.FileName = "";
                                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                                        this.Text = System.IO.Path.GetFileName(FilePath) + " - WordPad";
                                        richTextBox1.Modified = false;
                                        SavingFormat = 2;
                                        break;
                                }
                            }
                            catch (System.Exception Ситуация)
                            {
                                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;

                        case 1:
                            if (!string.IsNullOrEmpty(FilePath))
                            {
                                try
                                {

                                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                                    richTextBox1.Modified = false;
                                }
                                catch (System.Exception Ситуация)
                                {
                                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            break;
                        case 2:
                            if (!string.IsNullOrEmpty(FilePath))
                            {
                                try
                                {
                                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                                    richTextBox1.Modified = false;
                                }
                                catch (System.Exception Ситуация)
                                {
                                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Modified == false)
            {
                this.Text = "Новый документ - WordPad";
                SavingFormat = 0;
                FilePath = null;
                richTextBox1.Clear();
                openFileDialog1.FileName = null;
                saveFileDialog1.FileName = null;
                richTextBox1.Modified = false;
                fontPlusButton.Tag = false;
                fontMinusButton.Tag = false;
                boldButton.Tag = false;
                italicButton.Tag = false;
                underlineButton.Tag = false;
                strikeoutButton.Tag = false;
                return;
            };
            DialogResult MBox = MessageBox.Show("Текст был изменен.\nСохранить изменения?", "WordPad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (MBox)
            {
                case DialogResult.No:
                    this.Text = "Новый документ - WordPad";
                    SavingFormat = 0;
                    FilePath = null;
                    richTextBox1.Clear();
                    openFileDialog1.FileName = null;
                    saveFileDialog1.FileName = null;
                    richTextBox1.Modified = false;
                    fontPlusButton.Tag = false;
                    fontMinusButton.Tag = false;
                    boldButton.Tag = false;
                    italicButton.Tag = false;
                    underlineButton.Tag = false;
                    strikeoutButton.Tag = false;
                    return;
                case DialogResult.Cancel:
                    return;
                case DialogResult.Yes:
                    switch (SavingFormat)
                    {
                        case 0:
                            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

                            try
                            {
                                switch (saveFileDialog1.FilterIndex)
                                {
                                    case 1:
                                        FilePath = saveFileDialog1.FileName;
                                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                                        richTextBox1.Modified = false;
                                        SavingFormat = 1;
                                        break;
                                    case 2:
                                        FilePath = saveFileDialog1.FileName;
                                        richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                                        richTextBox1.Modified = false;
                                        SavingFormat = 2;
                                        break;
                                }
                                this.Text = "Новый документ - WordPad";
                                SavingFormat = 0;
                                FilePath = null;
                                richTextBox1.Clear();
                                openFileDialog1.FileName = null;
                                saveFileDialog1.FileName = null;
                                richTextBox1.Modified = false;
                                fontPlusButton.Tag = false;
                                fontMinusButton.Tag = false;
                                boldButton.Tag = false;
                                italicButton.Tag = false;
                                underlineButton.Tag = false;
                                strikeoutButton.Tag = false;
                            }
                            catch (System.Exception Ситуация)
                            {
                                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;

                        case 1:
                            if (!string.IsNullOrEmpty(FilePath))
                            {
                                try
                                {
                                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                                    richTextBox1.Modified = false;
                                    this.Text = "Новый документ - WordPad";
                                    SavingFormat = 0;
                                    FilePath = null;
                                    richTextBox1.Clear();
                                    openFileDialog1.FileName = null;
                                    saveFileDialog1.FileName = null;
                                    richTextBox1.Modified = false;
                                    fontPlusButton.Tag = false;
                                    fontMinusButton.Tag = false;
                                    boldButton.Tag = false;
                                    italicButton.Tag = false;
                                    underlineButton.Tag = false;
                                    strikeoutButton.Tag = false;
                                }
                                catch (System.Exception Ситуация)
                                {
                                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            break;
                        case 2:
                            if (!string.IsNullOrEmpty(FilePath))
                            {
                                try
                                {
                                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                                    richTextBox1.Modified = false;
                                    this.Text = "Новый документ - WordPad";
                                    SavingFormat = 0;
                                    FilePath = null;
                                    richTextBox1.Clear();
                                    openFileDialog1.FileName = null;
                                    saveFileDialog1.FileName = null;
                                    richTextBox1.Modified = false;
                                    fontPlusButton.Tag = false;
                                    fontMinusButton.Tag = false;
                                    boldButton.Tag = false;
                                    italicButton.Tag = false;
                                    underlineButton.Tag = false;
                                    strikeoutButton.Tag = false;
                                }
                                catch (System.Exception Ситуация)
                                {
                                    MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            break;
                    }
                    break;
            }

        }





        private void insertButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
        }

        private void сutButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
            richTextBox1.SelectedRtf = "";
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedRtf = "";
        }

        private void fontcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int SelectStart = richTextBox1.SelectionStart;
            int SelectLenght = richTextBox1.SelectionLength;
            string nFont = fontcomboBox.SelectedItem.ToString();
            for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
            {
                richTextBox1.Select(i, 1);

                if (richTextBox1.SelectionFont != null)
                {
                    Font newFont = new Font(nFont, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }

            richTextBox1.Select(SelectStart, SelectLenght);
            richTextBox1.Focus();


        }

        private void fontsizecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int SelectStart = richTextBox1.SelectionStart;
            int SelectLenght = richTextBox1.SelectionLength;
            float newSize;
            if (float.TryParse(fontsizecomboBox.Text, out newSize))
            {
                for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
                {
                    richTextBox1.Select(i, 1);

                    if (richTextBox1.SelectionFont != null)
                    {
                        Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, newSize, richTextBox1.SelectionFont.Style);
                        richTextBox1.SelectionFont = newFont;
                    }
                }
            }

            richTextBox1.Select(SelectStart, SelectLenght);
            richTextBox1.Focus();

        }
        bool SizeChangingOver = true;
        private void fontPlusButton_Click(object sender, EventArgs e)
        {
            SizeChangingOver = false;

            int SelectStart = richTextBox1.SelectionStart;
            int SelectLength = richTextBox1.SelectionLength;
            richTextBox1.Select(SelectStart, SelectLength);
            for (int i = SelectStart; i < SelectStart + SelectLength; i++)
            {
                richTextBox1.Select(i, 1);

                if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Size < 999)
                {
                    Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size + 1, richTextBox1.SelectionFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }

            SizeChangingOver = true;
            richTextBox1.Select(SelectStart, SelectLength);
            if (richTextBox1.SelectionLength == 0)
            {
                fontsizecomboBox.Text = Convert.ToString(Convert.ToInt32(fontsizecomboBox.Text) + 1);
            }
            else if (richTextBox1.SelectionFont != null)
            {

                if (MouseUP && richTextBox1.SelectionLength > 1 && SizeChangingOver && SizeDetectingOver)
                {

                    SizeDetectingOver = false;
                    for (int i = SelectStart; i < SelectStart + SelectLength; i++)
                    {
                        richTextBox1.Select(i, 1);
                        if (richTextBox1.SelectionFont != null)
                        {
                            fontsizecomboBox.Text = Convert.ToString(richTextBox1.SelectionFont.Size);
                            break;
                        }
                    }
                    richTextBox1.Select(SelectStart, SelectLength);
                    SizeDetectingOver = true;
                }
                else if (Math.Abs(richTextBox1.SelectionLength) <= 1)
                {
                    fontsizecomboBox.Text = Convert.ToString(richTextBox1.SelectionFont.Size);
                }
            }
            richTextBox1.Focus();


        }

        private void fontMinusButton_Click(object sender, EventArgs e)
        {

            int SelectStart = richTextBox1.SelectionStart;
            int SelectLenght = richTextBox1.SelectionLength;
            for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
            {
                richTextBox1.Select(i, 1);

                if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Size > 1)
                {
                    Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size - 1, richTextBox1.SelectionFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }
            richTextBox1.Select(SelectStart, SelectLenght);
            if (richTextBox1.SelectionLength == 0)
            {
                fontsizecomboBox.Text = Convert.ToString(Convert.ToInt32(fontsizecomboBox.Text) - 1);
            }
            else if (richTextBox1.SelectionFont != null)
            {
                fontsizecomboBox.Text = Convert.ToString(richTextBox1.SelectionFont.Size);
            }
            richTextBox1.Focus();

        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                int SelectStart = richTextBox1.SelectionStart;
                int SelectLenght = richTextBox1.SelectionLength;
                for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
                {
                    richTextBox1.Select(i, 1);

                    if (richTextBox1.SelectionFont != null)
                    {
                        Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
                        richTextBox1.SelectionFont = newFont;
                    }
                }
                richTextBox1.Select(SelectStart, SelectLenght);
            }
            else
            {
                if (!Convert.ToBoolean(boldButton.Tag))
                {
                    boldButton.Tag = true;
                    boldButton.BackColor = SystemColors.ActiveCaption;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                }
                else
                {
                    boldButton.Tag = false;
                    boldButton.BackColor = Color.FromArgb(224, 224, 224);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);

                }

            }
            richTextBox1.Focus();
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                int SelectStart = richTextBox1.SelectionStart;
                int SelectLenght = richTextBox1.SelectionLength;
                for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
                {
                    richTextBox1.Select(i, 1);

                    if (richTextBox1.SelectionFont != null)
                    {
                        Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
                        richTextBox1.SelectionFont = newFont;
                    }
                }
                richTextBox1.Select(SelectStart, SelectLenght);
            }
            else
            {
                if (!Convert.ToBoolean(italicButton.Tag))
                {
                    italicButton.Tag = true;
                    italicButton.BackColor = SystemColors.ActiveCaption;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Italic);

                }
                else
                {
                    italicButton.Tag = false;
                    italicButton.BackColor = Color.FromArgb(224, 224, 224);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);

                }

            }

            richTextBox1.Focus();
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionLength != 0)
            {
                int SelectStart = richTextBox1.SelectionStart;
                int SelectLenght = richTextBox1.SelectionLength;
                for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
                {
                    richTextBox1.Select(i, 1);

                    if (richTextBox1.SelectionFont != null)
                    {
                        Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
                        richTextBox1.SelectionFont = newFont;
                    }
                }
                richTextBox1.Select(SelectStart, SelectLenght);
            }
            else
            {
                if (!Convert.ToBoolean(underlineButton.Tag))
                {
                    underlineButton.Tag = true;
                    underlineButton.BackColor = SystemColors.ActiveCaption;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                }
                else
                {
                    underlineButton.Tag = false;
                    underlineButton.BackColor = Color.FromArgb(224, 224, 224);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                }

            }
            richTextBox1.Focus();

        }

        private void strikeoutButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                int SelectStart = richTextBox1.SelectionStart;
                int SelectLenght = richTextBox1.SelectionLength;
                for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
                {
                    richTextBox1.Select(i, 1);

                    if (richTextBox1.SelectionFont != null)
                    {
                        Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);
                        richTextBox1.SelectionFont = newFont;
                    }
                }
                richTextBox1.Select(SelectStart, SelectLenght);
            }
            else
            {
                if (!Convert.ToBoolean(strikeoutButton.Tag))
                {
                    strikeoutButton.Tag = true;
                    strikeoutButton.BackColor = SystemColors.ActiveCaption;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
                }
                else
                {
                    strikeoutButton.Tag = false;
                    strikeoutButton.BackColor = Color.FromArgb(224, 224, 224);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Strikeout);
                }
            }
            richTextBox1.Focus();

        }

        private void leftLevelingButton_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                middleLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                rightLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                leftLevelingButton.BackColor = SystemColors.ActiveCaption;
                richTextBox1.Focus();
            }
        }

        private void middleLevelingButton_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                middleLevelingButton.BackColor = SystemColors.ActiveCaption;
                rightLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                leftLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                richTextBox1.Focus();
            }
        }

        private void rightLevelingButton_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                middleLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                rightLevelingButton.BackColor = SystemColors.ActiveCaption;
                leftLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                richTextBox1.Focus();
            }
        }

        private void plusIndentButton_Click(object sender, EventArgs e)
        {
            if (TextRenderer.MeasureText(richTextBox1.SelectedText, richTextBox1.Font).Width + richTextBox1.SelectionIndent + 100 < richTextBox1.Width)
            {
                richTextBox1.SelectionIndent += 60;
            }
            else
            {
                richTextBox1.SelectionIndent = richTextBox1.Width - TextRenderer.MeasureText(richTextBox1.SelectedText, richTextBox1.Font).Width;
            }
        }

        private void minusIndentButton_Click(object sender, EventArgs e)
        {
            if (TextRenderer.MeasureText(richTextBox1.SelectedText, richTextBox1.Font).Width + richTextBox1.SelectionIndent - 60 > 0)
            {
                richTextBox1.SelectionIndent -= 60;
            }
            else
            {
                richTextBox1.SelectionIndent = 0;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.ShowDialog();

        }

        private void nsearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchText))
            {
                SearchInd = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                if (registr)
                {
                    SearchInd = richTextBox1.Text.IndexOf(SearchText, SearchInd);
                }
                else
                {
                    SearchInd = richTextBox1.Text.IndexOf(SearchText, SearchInd, StringComparison.OrdinalIgnoreCase);
                }

                if (SearchInd != -1)
                {
                    richTextBox1.Select(SearchInd, SearchText.Length);
                }
                else
                {
                    MessageBox.Show("Не удается найти" + "\"" + SearchText + "\"", "WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                nextSearch = true;
            }

        }

        private void psearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchText))
            {
                if (richTextBox1.SelectionLength > 1)
                {
                    SearchInd = richTextBox1.SelectionStart;
                }
                else
                {
                    SearchInd = richTextBox1.SelectionStart - 1;
                }
                if (SearchInd >= 0)
                {
                    if (registr)
                    {
                        SearchInd = richTextBox1.Text.LastIndexOf(SearchText, SearchInd);
                    }
                    else
                    {
                        SearchInd = richTextBox1.Text.LastIndexOf(SearchText, SearchInd, StringComparison.OrdinalIgnoreCase);
                    }

                    if (SearchInd != -1)
                    {
                        richTextBox1.Select(SearchInd, SearchText.Length);
                    }
                    else
                    {
                        MessageBox.Show("Не удается найти" + "\"" + SearchText + "\"", "WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Не удается найти" + "\"" + SearchText + "\"", "WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                nextSearch = false;
            }

        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            SwapForm swapForm = new SwapForm(this);
            swapForm.ShowDialog();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            GoForm goForm = new GoForm(this);
            goForm.ShowDialog();
            richTextBox1.Focus();
        }



        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int selStart = richTextBox1.SelectionStart;
            int lineNumber = richTextBox1.GetLineFromCharIndex(selStart) + 1;

            int columnNumber = selStart - richTextBox1.GetFirstCharIndexFromLine(lineNumber - 1) + 1;
            toolStripStatusLabel4.Text = "  Стр " + lineNumber + "," + " стлб " + columnNumber;

            if (richTextBox1.SelectionLength > 0)
            {
                сutButton.Enabled = true;
                copyButton.Enabled = true;
                delButton.Enabled = true;

            }
            else
            {

                сutButton.Enabled = false;
                copyButton.Enabled = false;
                delButton.Enabled = false;
            }

            if (richTextBox1.SelectionFont != null)
            {

                fontcomboBox.Text = richTextBox1.SelectionFont.FontFamily.Name;
                if (MouseUP && richTextBox1.SelectionLength > 1 && SizeChangingOver && SizeDetectingOver)
                {
                    SizeDetectingOver = false;
                    int SelectStart = richTextBox1.SelectionStart;
                    int SelectLength = richTextBox1.SelectionLength;

                    if (SelectStart > SelectStart + SelectLength)
                    {
                        SelectStart = SelectStart + SelectLength;
                        SelectLength = -SelectLength;
                    }
                    richTextBox1.Select(SelectStart, SelectLength);
                    for (int i = SelectStart; i < SelectStart + SelectLength; i++)
                    {
                        richTextBox1.Select(i, 1);
                        if (richTextBox1.SelectionFont != null)
                        {
                            fontsizecomboBox.Text = Convert.ToString(richTextBox1.SelectionFont.Size);
                            break;
                        }
                    }
                    richTextBox1.Select(SelectStart, SelectLength);
                    SizeDetectingOver = true;
                }
                else if (Math.Abs(richTextBox1.SelectionLength) <= 1)
                {
                    fontsizecomboBox.Text = Convert.ToString(richTextBox1.SelectionFont.Size);
                }
            }
            else
            {
                fontcomboBox.Text = "";
                fontsizecomboBox.Text = "";
            }


            if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Bold)
            {
                boldButton.Tag = true;
                boldButton.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                boldButton.Tag = false;
                boldButton.BackColor = Color.FromArgb(224, 224, 224);
            }

            if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Italic)
            {
                italicButton.Tag = true;
                italicButton.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                italicButton.Tag = false;
                italicButton.BackColor = Color.FromArgb(224, 224, 224);
            }

            if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Underline)
            {
                underlineButton.Tag = true;
                underlineButton.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                underlineButton.Tag = false;
                underlineButton.BackColor = Color.FromArgb(224, 224, 224);
            }

            if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Strikeout)
            {
                strikeoutButton.Tag = true;
                strikeoutButton.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                strikeoutButton.Tag = false;
                strikeoutButton.BackColor = Color.FromArgb(224, 224, 224);
            }
            switch (richTextBox1.SelectionAlignment)
            {
                case HorizontalAlignment.Center:
                    middleLevelingButton.BackColor = SystemColors.ActiveCaption;
                    rightLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                    leftLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                    break;
                case HorizontalAlignment.Right:
                    middleLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                    rightLevelingButton.BackColor = SystemColors.ActiveCaption;
                    leftLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                    break;
                case HorizontalAlignment.Left:
                    middleLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                    rightLevelingButton.BackColor = Color.FromArgb(224, 224, 224);
                    leftLevelingButton.BackColor = SystemColors.ActiveCaption;
                    break;
            }


        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (richTextBox1.SelectionFont != null && !Char.IsControl(e.KeyChar))
            {
                richTextBox1.SelectionFont = new Font(fontcomboBox.Text, Convert.ToInt32(fontsizecomboBox.Text), richTextBox1.SelectionFont.Style);
                if (Convert.ToBoolean(boldButton.Tag))
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                }

                if (Convert.ToBoolean(italicButton.Tag))
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                }

                if (Convert.ToBoolean(underlineButton.Tag))
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                }

                if (Convert.ToBoolean(strikeoutButton.Tag))
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style & ~FontStyle.Strikeout);
                }
                richTextBox1.SelectedText = e.KeyChar.ToString();
            }
            else if (!Char.IsControl(e.KeyChar) && richTextBox1.SelectionLength > 0)
            {
                Dictionary<FontFamily, int> fonts = new Dictionary<FontFamily, int>();
                Dictionary<int, int> size = new Dictionary<int, int>();
                Dictionary<FontStyle, int> styles = new Dictionary<FontStyle, int>();
                int selectionStart = richTextBox1.SelectionStart;
                int selectionLen = richTextBox1.SelectionLength;
                for (int i = selectionStart; i < selectionStart + selectionLen; i++)
                {
                    richTextBox1.Select(i, 1);

                    if (richTextBox1.SelectionFont != null)
                    {
                        if (fonts.ContainsKey(richTextBox1.SelectionFont.FontFamily))
                        {
                            fonts[richTextBox1.SelectionFont.FontFamily]++;
                        }
                        else
                        {
                            fonts.Add(richTextBox1.SelectionFont.FontFamily, 1);
                        }

                        if (size.ContainsKey(Convert.ToInt32(richTextBox1.SelectionFont.Size)))
                        {
                            size[Convert.ToInt32(richTextBox1.SelectionFont.Size)]++;
                        }
                        else
                        {
                            size.Add(Convert.ToInt32(richTextBox1.SelectionFont.Size), 1);
                        }

                        if (styles.ContainsKey(richTextBox1.SelectionFont.Style))
                        {
                            styles[richTextBox1.SelectionFont.Style]++;
                        }
                        else
                        {
                            styles.Add(richTextBox1.SelectionFont.Style, 1);
                        }
                    }
                }
                richTextBox1.Select(selectionStart, selectionLen);
                FontFamily newFont = fonts.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                int newSize = size.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                FontStyle newStyle = styles.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                richTextBox1.SelectionFont = new Font(newFont, newSize, newStyle);
                richTextBox1.SelectedText = e.KeyChar.ToString();
            }
            if (Char.IsControl(e.KeyChar))
            {

                return;
            }


            e.Handled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                undoToolStripMenuItem.Enabled = true;
            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
            }

            if (richTextBox1.CanRedo)
            {
                redoToolStripMenuItem.Enabled = true;
            }
            else
            {
                redoToolStripMenuItem.Enabled = false;
            }
        }

        private void fontsizecomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && fontsizecomboBox.Text.Length < 3)
                return;
            if (Char.IsControl(e.KeyChar) && e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
            if (MouseUP && SizeDetectingOver)
            {

                int SelectStart = richTextBox1.SelectionStart;
                int SelectLenght = richTextBox1.SelectionLength;
                float newSize;
                if (fontsizecomboBox.Text != "0" && float.TryParse(fontsizecomboBox.Text, out newSize))
                {
                    for (int i = SelectStart; i < SelectStart + SelectLenght; i++)
                    {
                        richTextBox1.Select(i, 1);

                        if (richTextBox1.SelectionFont != null)
                        {
                            Font newFont = new Font(richTextBox1.SelectionFont.FontFamily, newSize, richTextBox1.SelectionFont.Style);
                            richTextBox1.SelectionFont = newFont;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка при преобразовании размера шрифта");
                }

                richTextBox1.Select(SelectStart, SelectLenght);
                fontsizecomboBox.Focus();
                fontsizecomboBox.Select(fontsizecomboBox.Text.Length, 0);

            }
        }

        private void fontcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fontsizecomboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontsizecomboBox_Click(object sender, EventArgs e)
        {
            fontsizecomboBox.Select(fontsizecomboBox.Text.Length, 0);
        }

        private void fontcomboBox_Click(object sender, EventArgs e)
        {
            fontcomboBox.Select(fontcomboBox.Text.Length, 0);
        }

        private void allselectButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUP = true;
            int SelectStart = richTextBox1.SelectionStart;
            int SelectLength = richTextBox1.SelectionLength;
            richTextBox1.Select(0, 0);
            richTextBox1.Select(SelectStart, SelectLength);
        }


        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseUP = false;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseUP = false;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                insertButton.Enabled = true;
            }
            else
            {
                insertButton.Enabled = false;
            }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                insertButton.Enabled = true;
            }
            else
            {
                insertButton.Enabled = false;

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                undoToolStripMenuItem.Enabled = true;
            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
            }
            if (richTextBox1.CanRedo)
            {
                redoToolStripMenuItem.Enabled = true;
            }
            else
            {
                redoToolStripMenuItem.Enabled = false;
            }

            //if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Bold)
            //{
            //    boldButton.Tag = true;
            //    boldButton.BackColor = SystemColors.ActiveCaption;
            //}
            //else
            //{
            //    boldButton.Tag = false;
            //    boldButton.BackColor = Color.FromArgb(224, 224, 224);
            //}

            //if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Italic)
            //{
            //    italicButton.Tag = true;
            //    italicButton.BackColor = SystemColors.ActiveCaption;
            //}
            //else
            //{
            //    italicButton.Tag = false;
            //    italicButton.BackColor = Color.FromArgb(224, 224, 224);
            //}

            //if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Underline)
            //{
            //    underlineButton.Tag = true;
            //    underlineButton.BackColor = SystemColors.ActiveCaption;
            //}
            //else
            //{
            //    underlineButton.Tag = false;
            //    underlineButton.BackColor = Color.FromArgb(224, 224, 224);
            //}

            //if (richTextBox1.SelectionFont != null && richTextBox1.SelectionFont.Strikeout)
            //{
            //    strikeoutButton.Tag = true;
            //    strikeoutButton.BackColor = SystemColors.ActiveCaption;
            //}
            //else
            //{
            //    strikeoutButton.Tag = false;
            //    strikeoutButton.BackColor = Color.FromArgb(224, 224, 224);
            //}
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    richTextBox1.SelectAll();
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void undoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void fontcomboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
               
        }
    }

}
