namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитькакToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            скрытьToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            mainpanel = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            defaultButton = new Button();
            minusButton = new Button();
            plusButton = new Button();
            label5 = new Label();
            goButton = new Button();
            allselectButton = new Button();
            swapButton = new Button();
            psearchButton = new Button();
            nsearchButton = new Button();
            searchButton = new Button();
            label4 = new Label();
            plusIndentButton = new Button();
            minusIndentButton = new Button();
            label3 = new Label();
            rightLevelingButton = new Button();
            middleLevelingButton = new Button();
            leftLevelingButton = new Button();
            strikeoutButton = new Button();
            underlineButton = new Button();
            italicButton = new Button();
            boldButton = new Button();
            label2 = new Label();
            fontMinusButton = new Button();
            fontPlusButton = new Button();
            fontsizecomboBox = new ComboBox();
            fontcomboBox = new ComboBox();
            delButton = new Button();
            label1 = new Label();
            copyButton = new Button();
            сutButton = new Button();
            insertButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            mainpanel.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem1, главнаяToolStripMenuItem, видToolStripMenuItem, скрытьToolStripMenuItem, redoToolStripMenuItem, undoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1542, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.BackColor = SystemColors.Highlight;
            файлToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, сохранитькакToolStripMenuItem, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(48, 20);
            файлToolStripMenuItem1.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Image = (Image)resources.GetObject("создатьToolStripMenuItem.Image");
            создатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            создатьToolStripMenuItem.Size = new Size(173, 22);
            создатьToolStripMenuItem.Text = "&Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(173, 22);
            открытьToolStripMenuItem.Text = "&Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(170, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(173, 22);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитькакToolStripMenuItem
            // 
            сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            сохранитькакToolStripMenuItem.Size = new Size(173, 22);
            сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            сохранитькакToolStripMenuItem.Click += сохранитькакToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(170, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Image = (Image)resources.GetObject("выходToolStripMenuItem.Image");
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(173, 22);
            выходToolStripMenuItem.Text = "Вы&ход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(63, 20);
            главнаяToolStripMenuItem.Text = "Главная";
            главнаяToolStripMenuItem.Click += главнаяToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            видToolStripMenuItem.Click += видToolStripMenuItem_Click;
            // 
            // скрытьToolStripMenuItem
            // 
            скрытьToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            скрытьToolStripMenuItem.BackColor = SystemColors.Control;
            скрытьToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            скрытьToolStripMenuItem.Name = "скрытьToolStripMenuItem";
            скрытьToolStripMenuItem.Size = new Size(32, 20);
            скрытьToolStripMenuItem.Text = "︿";
            скрытьToolStripMenuItem.Click += скрытьToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.RightToLeft = RightToLeft.No;
            redoToolStripMenuItem.Size = new Size(29, 20);
            redoToolStripMenuItem.Text = "↪️";
            redoToolStripMenuItem.ToolTipText = "Вернуть (CTRL+Y)";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(29, 20);
            undoToolStripMenuItem.Text = "↩️";
            undoToolStripMenuItem.ToolTipText = "Отменить (CTRL+Z)";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            undoToolStripMenuItem.MouseLeave += undoToolStripMenuItem_MouseLeave;
            undoToolStripMenuItem.MouseHover += undoToolStripMenuItem_MouseHover;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(224, 224, 224);
            mainpanel.Controls.Add(checkBox2);
            mainpanel.Controls.Add(checkBox1);
            mainpanel.Controls.Add(label6);
            mainpanel.Controls.Add(defaultButton);
            mainpanel.Controls.Add(minusButton);
            mainpanel.Controls.Add(plusButton);
            mainpanel.Controls.Add(label5);
            mainpanel.Controls.Add(goButton);
            mainpanel.Controls.Add(allselectButton);
            mainpanel.Controls.Add(swapButton);
            mainpanel.Controls.Add(psearchButton);
            mainpanel.Controls.Add(nsearchButton);
            mainpanel.Controls.Add(searchButton);
            mainpanel.Controls.Add(label4);
            mainpanel.Controls.Add(plusIndentButton);
            mainpanel.Controls.Add(minusIndentButton);
            mainpanel.Controls.Add(label3);
            mainpanel.Controls.Add(rightLevelingButton);
            mainpanel.Controls.Add(middleLevelingButton);
            mainpanel.Controls.Add(leftLevelingButton);
            mainpanel.Controls.Add(strikeoutButton);
            mainpanel.Controls.Add(underlineButton);
            mainpanel.Controls.Add(italicButton);
            mainpanel.Controls.Add(boldButton);
            mainpanel.Controls.Add(label2);
            mainpanel.Controls.Add(fontMinusButton);
            mainpanel.Controls.Add(fontPlusButton);
            mainpanel.Controls.Add(fontsizecomboBox);
            mainpanel.Controls.Add(fontcomboBox);
            mainpanel.Controls.Add(delButton);
            mainpanel.Controls.Add(label1);
            mainpanel.Controls.Add(copyButton);
            mainpanel.Controls.Add(сutButton);
            mainpanel.Controls.Add(insertButton);
            mainpanel.Dock = DockStyle.Top;
            mainpanel.Location = new Point(0, 24);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1542, 93);
            mainpanel.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(920, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(135, 19);
            checkBox2.TabIndex = 35;
            checkBox2.Text = "Перенос по словам";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(920, 17);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Строка состояния";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.Location = new Point(920, 74);
            label6.Name = "label6";
            label6.Size = new Size(137, 17);
            label6.TabIndex = 33;
            label6.Text = "Параметры";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // defaultButton
            // 
            defaultButton.FlatStyle = FlatStyle.Flat;
            defaultButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            defaultButton.Image = (Image)resources.GetObject("defaultButton.Image");
            defaultButton.Location = new Point(856, 6);
            defaultButton.Name = "defaultButton";
            defaultButton.Size = new Size(35, 66);
            defaultButton.TabIndex = 32;
            defaultButton.UseVisualStyleBackColor = true;
            // 
            // minusButton
            // 
            minusButton.FlatStyle = FlatStyle.Flat;
            minusButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            minusButton.Image = (Image)resources.GetObject("minusButton.Image");
            minusButton.Location = new Point(788, 6);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(69, 66);
            minusButton.TabIndex = 31;
            minusButton.UseVisualStyleBackColor = true;
            // 
            // plusButton
            // 
            plusButton.FlatStyle = FlatStyle.Flat;
            plusButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            plusButton.Image = (Image)resources.GetObject("plusButton.Image");
            plusButton.Location = new Point(720, 6);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(69, 66);
            plusButton.TabIndex = 30;
            plusButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Location = new Point(720, 74);
            label5.Name = "label5";
            label5.Size = new Size(171, 17);
            label5.TabIndex = 29;
            label5.Text = "Масштаб";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // goButton
            // 
            goButton.FlatStyle = FlatStyle.Flat;
            goButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            goButton.Image = (Image)resources.GetObject("goButton.Image");
            goButton.Location = new Point(563, 42);
            goButton.Name = "goButton";
            goButton.Size = new Size(23, 23);
            goButton.TabIndex = 28;
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // allselectButton
            // 
            allselectButton.FlatStyle = FlatStyle.Flat;
            allselectButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            allselectButton.Image = (Image)resources.GetObject("allselectButton.Image");
            allselectButton.Location = new Point(541, 42);
            allselectButton.Name = "allselectButton";
            allselectButton.Size = new Size(23, 23);
            allselectButton.TabIndex = 27;
            allselectButton.UseVisualStyleBackColor = true;
            allselectButton.Click += allselectButton_Click;
            // 
            // swapButton
            // 
            swapButton.FlatStyle = FlatStyle.Flat;
            swapButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            swapButton.Image = (Image)resources.GetObject("swapButton.Image");
            swapButton.Location = new Point(519, 42);
            swapButton.Name = "swapButton";
            swapButton.Size = new Size(23, 23);
            swapButton.TabIndex = 26;
            swapButton.UseVisualStyleBackColor = true;
            swapButton.Click += swapButton_Click;
            // 
            // psearchButton
            // 
            psearchButton.FlatStyle = FlatStyle.Flat;
            psearchButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            psearchButton.Image = (Image)resources.GetObject("psearchButton.Image");
            psearchButton.Location = new Point(563, 13);
            psearchButton.Name = "psearchButton";
            psearchButton.Size = new Size(23, 23);
            psearchButton.TabIndex = 25;
            psearchButton.UseVisualStyleBackColor = true;
            psearchButton.Click += psearchButton_Click;
            // 
            // nsearchButton
            // 
            nsearchButton.FlatStyle = FlatStyle.Flat;
            nsearchButton.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            nsearchButton.Image = (Image)resources.GetObject("nsearchButton.Image");
            nsearchButton.Location = new Point(541, 13);
            nsearchButton.Name = "nsearchButton";
            nsearchButton.Size = new Size(23, 23);
            nsearchButton.TabIndex = 24;
            nsearchButton.TextAlign = ContentAlignment.BottomRight;
            nsearchButton.UseVisualStyleBackColor = true;
            nsearchButton.Click += nsearchButton_Click;
            // 
            // searchButton
            // 
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(519, 13);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(23, 23);
            searchButton.TabIndex = 23;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label4
            // 
            label4.Location = new Point(502, 75);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 22;
            label4.Text = "Правка";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // plusIndentButton
            // 
            plusIndentButton.FlatStyle = FlatStyle.Flat;
            plusIndentButton.Font = new Font("Arial", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
            plusIndentButton.Image = (Image)resources.GetObject("plusIndentButton.Image");
            plusIndentButton.Location = new Point(442, 13);
            plusIndentButton.Name = "plusIndentButton";
            plusIndentButton.Size = new Size(23, 23);
            plusIndentButton.TabIndex = 20;
            plusIndentButton.UseVisualStyleBackColor = true;
            plusIndentButton.Click += plusIndentButton_Click;
            // 
            // minusIndentButton
            // 
            minusIndentButton.FlatStyle = FlatStyle.Flat;
            minusIndentButton.Font = new Font("Arial", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            minusIndentButton.Image = (Image)resources.GetObject("minusIndentButton.Image");
            minusIndentButton.Location = new Point(421, 13);
            minusIndentButton.Name = "minusIndentButton";
            minusIndentButton.Size = new Size(23, 23);
            minusIndentButton.TabIndex = 19;
            minusIndentButton.UseVisualStyleBackColor = true;
            minusIndentButton.Click += minusIndentButton_Click;
            // 
            // label3
            // 
            label3.Location = new Point(394, 75);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 18;
            label3.Text = "Абзац";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // rightLevelingButton
            // 
            rightLevelingButton.FlatStyle = FlatStyle.Flat;
            rightLevelingButton.Font = new Font("Arial", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            rightLevelingButton.Image = (Image)resources.GetObject("rightLevelingButton.Image");
            rightLevelingButton.Location = new Point(451, 44);
            rightLevelingButton.Name = "rightLevelingButton";
            rightLevelingButton.Size = new Size(23, 23);
            rightLevelingButton.TabIndex = 16;
            rightLevelingButton.UseVisualStyleBackColor = true;
            rightLevelingButton.Click += rightLevelingButton_Click;
            // 
            // middleLevelingButton
            // 
            middleLevelingButton.FlatStyle = FlatStyle.Flat;
            middleLevelingButton.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            middleLevelingButton.Image = (Image)resources.GetObject("middleLevelingButton.Image");
            middleLevelingButton.Location = new Point(431, 44);
            middleLevelingButton.Name = "middleLevelingButton";
            middleLevelingButton.Size = new Size(23, 23);
            middleLevelingButton.TabIndex = 15;
            middleLevelingButton.UseVisualStyleBackColor = true;
            middleLevelingButton.Click += middleLevelingButton_Click;
            // 
            // leftLevelingButton
            // 
            leftLevelingButton.FlatStyle = FlatStyle.Flat;
            leftLevelingButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            leftLevelingButton.Image = (Image)resources.GetObject("leftLevelingButton.Image");
            leftLevelingButton.Location = new Point(410, 44);
            leftLevelingButton.Name = "leftLevelingButton";
            leftLevelingButton.Size = new Size(23, 23);
            leftLevelingButton.TabIndex = 14;
            leftLevelingButton.UseVisualStyleBackColor = true;
            leftLevelingButton.Click += leftLevelingButton_Click;
            // 
            // strikeoutButton
            // 
            strikeoutButton.FlatStyle = FlatStyle.Flat;
            strikeoutButton.Font = new Font("Arial", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
            strikeoutButton.Location = new Point(240, 44);
            strikeoutButton.Name = "strikeoutButton";
            strikeoutButton.Size = new Size(23, 23);
            strikeoutButton.TabIndex = 13;
            strikeoutButton.Text = "b";
            strikeoutButton.UseVisualStyleBackColor = true;
            strikeoutButton.Click += strikeoutButton_Click;
            // 
            // underlineButton
            // 
            underlineButton.FlatStyle = FlatStyle.Flat;
            underlineButton.Font = new Font("Arial", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            underlineButton.Location = new Point(219, 44);
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(23, 23);
            underlineButton.TabIndex = 12;
            underlineButton.Text = "Ч";
            underlineButton.UseVisualStyleBackColor = true;
            underlineButton.Click += underlineButton_Click;
            // 
            // italicButton
            // 
            italicButton.FlatStyle = FlatStyle.Flat;
            italicButton.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            italicButton.ImageAlign = ContentAlignment.TopCenter;
            italicButton.Location = new Point(199, 44);
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(23, 23);
            italicButton.TabIndex = 11;
            italicButton.Text = "К";
            italicButton.UseVisualStyleBackColor = true;
            italicButton.Click += italicButton_Click;
            // 
            // boldButton
            // 
            boldButton.FlatStyle = FlatStyle.Flat;
            boldButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            boldButton.Location = new Point(178, 44);
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(23, 23);
            boldButton.TabIndex = 10;
            boldButton.Text = "Ж";
            boldButton.UseVisualStyleBackColor = true;
            boldButton.Click += boldButton_Click;
            // 
            // label2
            // 
            label2.Location = new Point(178, 74);
            label2.Name = "label2";
            label2.Size = new Size(217, 17);
            label2.TabIndex = 9;
            label2.Text = "Шрифт";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // fontMinusButton
            // 
            fontMinusButton.FlatStyle = FlatStyle.Flat;
            fontMinusButton.Image = (Image)resources.GetObject("fontMinusButton.Image");
            fontMinusButton.Location = new Point(365, 13);
            fontMinusButton.Name = "fontMinusButton";
            fontMinusButton.Size = new Size(23, 23);
            fontMinusButton.TabIndex = 8;
            fontMinusButton.UseVisualStyleBackColor = true;
            fontMinusButton.Click += fontMinusButton_Click;
            // 
            // fontPlusButton
            // 
            fontPlusButton.FlatStyle = FlatStyle.Flat;
            fontPlusButton.Image = (Image)resources.GetObject("fontPlusButton.Image");
            fontPlusButton.Location = new Point(344, 13);
            fontPlusButton.Name = "fontPlusButton";
            fontPlusButton.Size = new Size(23, 23);
            fontPlusButton.TabIndex = 7;
            fontPlusButton.UseVisualStyleBackColor = true;
            fontPlusButton.Click += fontPlusButton_Click;
            // 
            // fontsizecomboBox
            // 
            fontsizecomboBox.BackColor = Color.White;
            fontsizecomboBox.FlatStyle = FlatStyle.Flat;
            fontsizecomboBox.FormattingEnabled = true;
            fontsizecomboBox.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            fontsizecomboBox.Location = new Point(298, 13);
            fontsizecomboBox.Name = "fontsizecomboBox";
            fontsizecomboBox.Size = new Size(44, 23);
            fontsizecomboBox.TabIndex = 6;
            fontsizecomboBox.SelectedIndexChanged += fontsizecomboBox_SelectedIndexChanged;
            fontsizecomboBox.TextChanged += fontsizecomboBox_TextChanged;
            fontsizecomboBox.Click += fontsizecomboBox_Click;
            fontsizecomboBox.KeyPress += fontsizecomboBox_KeyPress;
            // 
            // fontcomboBox
            // 
            fontcomboBox.BackColor = Color.White;
            fontcomboBox.FlatStyle = FlatStyle.Flat;
            fontcomboBox.FormattingEnabled = true;
            fontcomboBox.Location = new Point(178, 13);
            fontcomboBox.Name = "fontcomboBox";
            fontcomboBox.Size = new Size(121, 23);
            fontcomboBox.TabIndex = 5;
            fontcomboBox.DrawItem += fontcomboBox_DrawItem;
            fontcomboBox.SelectedIndexChanged += fontcomboBox_SelectedIndexChanged;
            fontcomboBox.Click += fontcomboBox_Click;
            fontcomboBox.KeyPress += fontcomboBox_KeyPress;
            // 
            // delButton
            // 
            delButton.Enabled = false;
            delButton.FlatStyle = FlatStyle.Flat;
            delButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            delButton.Image = (Image)resources.GetObject("delButton.Image");
            delButton.ImageAlign = ContentAlignment.MiddleLeft;
            delButton.Location = new Point(61, 49);
            delButton.Name = "delButton";
            delButton.Size = new Size(83, 23);
            delButton.TabIndex = 4;
            delButton.Text = "     Удалить";
            delButton.TextAlign = ContentAlignment.MiddleLeft;
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 74);
            label1.Name = "label1";
            label1.Size = new Size(156, 17);
            label1.TabIndex = 3;
            label1.Text = "Буфер обмена";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // copyButton
            // 
            copyButton.Enabled = false;
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Image = (Image)resources.GetObject("copyButton.Image");
            copyButton.ImageAlign = ContentAlignment.MiddleLeft;
            copyButton.Location = new Point(61, 27);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(97, 23);
            copyButton.TabIndex = 2;
            copyButton.Text = "     Копировать";
            copyButton.TextAlign = ContentAlignment.MiddleLeft;
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // сutButton
            // 
            сutButton.Enabled = false;
            сutButton.FlatStyle = FlatStyle.Flat;
            сutButton.Image = (Image)resources.GetObject("сutButton.Image");
            сutButton.ImageAlign = ContentAlignment.MiddleLeft;
            сutButton.Location = new Point(61, 6);
            сutButton.Name = "сutButton";
            сutButton.Size = new Size(83, 23);
            сutButton.TabIndex = 1;
            сutButton.Text = "     Вырезать";
            сutButton.TextAlign = ContentAlignment.MiddleLeft;
            сutButton.UseVisualStyleBackColor = true;
            сutButton.Click += сutButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.FromArgb(224, 224, 224);
            insertButton.Enabled = false;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            insertButton.Image = (Image)resources.GetObject("insertButton.Image");
            insertButton.Location = new Point(7, 6);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(55, 66);
            insertButton.TabIndex = 0;
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 821);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1542, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolStripStatusLabel1.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(120, 17);
            toolStripStatusLabel1.Text = "  UTF-8";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.BackColor = SystemColors.Control;
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolStripStatusLabel2.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(120, 17);
            toolStripStatusLabel2.Text = "  Windows(CRLF)";
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.AutoSize = false;
            toolStripStatusLabel3.BackColor = SystemColors.Control;
            toolStripStatusLabel3.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolStripStatusLabel3.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(50, 17);
            toolStripStatusLabel3.Text = "  100%";
            toolStripStatusLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.AutoSize = false;
            toolStripStatusLabel4.BackColor = SystemColors.Control;
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolStripStatusLabel4.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(141, 17);
            toolStripStatusLabel4.Text = "  Стр 1, стлб 1";
            toolStripStatusLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Location = new Point(362, 120);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(816, 701);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            richTextBox1.Click += richTextBox1_Click;
            richTextBox1.MouseClick += richTextBox1_MouseClick;
            richTextBox1.FontChanged += richTextBox1_FontChanged;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.Enter += richTextBox1_Enter;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            richTextBox1.MouseDown += richTextBox1_MouseDown;
            richTextBox1.MouseUp += richTextBox1_MouseUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1542, 843);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip1);
            Controls.Add(mainpanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(617, 285);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private Panel mainpanel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private Button insertButton;
        private Button сutButton;
        private Label label1;
        private Button copyButton;
        private Button delButton;
        private ComboBox fontcomboBox;
        private ComboBox fontsizecomboBox;
        private Button fontPlusButton;
        private Button fontMinusButton;
        private Button strikeoutButton;
        private Button underlineButton;
        private Button italicButton;
        private Button boldButton;
        private Label label2;
        private Label label3;
        private Button rightLevelingButton;
        private Button middleLevelingButton;
        private Button leftLevelingButton;
        private Button plusIndentButton;
        private Button minusIndentButton;
        private Button swapButton;
        private Button psearchButton;
        private Button nsearchButton;
        private Button searchButton;
        private Label label4;
        private Button allselectButton;
        private Button goButton;
        private Button button2;
        private Button plusButton;
        private Label label5;
        private Button defaultButton;
        private Button minusButton;
        private Label label6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ToolStripMenuItem скрытьToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитькакToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem повторитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem выбратьвсеToolStripMenuItem;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem содержимоеToolStripMenuItem;
        private ToolStripMenuItem индексToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        public RichTextBox richTextBox1;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolTip toolTip1;
    }
}
