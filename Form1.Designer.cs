namespace Lab_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonClose = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            roundedPanel1 = new RoundedPanel();
            rjTextBox1Amount = new RJTextBox();
            rjButtonClear = new RJButton();
            rjButtonOk = new RJButton();
            labelAmount = new Label();
            comboBoxCurrency = new ComboBox();
            labelCurrency = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panelKurs = new Panel();
            labelB7 = new Label();
            labelB6 = new Label();
            labelS7 = new Label();
            labelS6 = new Label();
            labelP7 = new Label();
            pictureBoxV7 = new PictureBox();
            labelP6 = new Label();
            labelValuta7 = new Label();
            pictureBoxV6 = new PictureBox();
            labelValuta6 = new Label();
            labelB5 = new Label();
            labelS5 = new Label();
            labelP5 = new Label();
            pictureBoxV5 = new PictureBox();
            labelValuta5 = new Label();
            labelB4 = new Label();
            labelS4 = new Label();
            labelP4 = new Label();
            pictureBoxV4 = new PictureBox();
            labelValuta4 = new Label();
            labelB3 = new Label();
            labelS3 = new Label();
            labelP3 = new Label();
            pictureBoxV3 = new PictureBox();
            labelValuta3 = new Label();
            labelB2 = new Label();
            labelS2 = new Label();
            labelP2 = new Label();
            pictureBoxV2 = new PictureBox();
            labelValuta2 = new Label();
            labelV = new Label();
            labelB = new Label();
            labelS = new Label();
            labelP = new Label();
            pictureBoxV1 = new PictureBox();
            labelSale = new Label();
            labelBNM = new Label();
            labelPurchase = new Label();
            labelValuta = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelKurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(buttonClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 37);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // buttonClose
            // 
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatAppearance.MouseDownBackColor = Color.Silver;
            buttonClose.FlatAppearance.MouseOverBackColor = Color.Silver;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.iconsclose;
            buttonClose.Location = new Point(882, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(50, 37);
            buttonClose.TabIndex = 0;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Moccasin;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 225);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(861, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 27F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(305, 51);
            label1.Name = "label1";
            label1.Size = new Size(334, 54);
            label1.TabIndex = 0;
            label1.Text = "Currency converter";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Gold;
            roundedPanel1.Controls.Add(rjTextBox1Amount);
            roundedPanel1.Controls.Add(rjButtonClear);
            roundedPanel1.Controls.Add(rjButtonOk);
            roundedPanel1.Controls.Add(labelAmount);
            roundedPanel1.Controls.Add(comboBoxCurrency);
            roundedPanel1.Controls.Add(labelCurrency);
            roundedPanel1.CornerRadius = 10;
            roundedPanel1.Location = new Point(118, 189);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(670, 165);
            roundedPanel1.TabIndex = 2;
            // 
            // rjTextBox1Amount
            // 
            rjTextBox1Amount.BackColor = SystemColors.Window;
            rjTextBox1Amount.BorderColor = Color.MediumSlateBlue;
            rjTextBox1Amount.BorderFocusColor = Color.HotPink;
            rjTextBox1Amount.BorderRadius = 15;
            rjTextBox1Amount.BorderSize = 2;
            rjTextBox1Amount.ForeColor = Color.DimGray;
            rjTextBox1Amount.Location = new Point(245, 72);
            rjTextBox1Amount.Multiline = false;
            rjTextBox1Amount.Name = "rjTextBox1Amount";
            rjTextBox1Amount.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1Amount.PasswordChar = false;
            rjTextBox1Amount.PlaceholderColor = Color.DarkGray;
            rjTextBox1Amount.PlaceholderText = "";
            rjTextBox1Amount.Size = new Size(172, 35);
            rjTextBox1Amount.TabIndex = 6;
            rjTextBox1Amount.Texts = "";
            rjTextBox1Amount.UnderlinedStyle = false;
            rjTextBox1Amount.KeyPress += textBox_KeyPress;
            // 
            // rjButtonClear
            // 
            rjButtonClear.BackColor = Color.DarkOrange;
            rjButtonClear.BackgroundColor = Color.DarkOrange;
            rjButtonClear.BorderColor = Color.PaleVioletRed;
            rjButtonClear.BorderRadius = 27;
            rjButtonClear.BorderSize = 0;
            rjButtonClear.FlatAppearance.BorderSize = 0;
            rjButtonClear.FlatAppearance.MouseDownBackColor = Color.Peru;
            rjButtonClear.FlatAppearance.MouseOverBackColor = Color.Peru;
            rjButtonClear.FlatStyle = FlatStyle.Flat;
            rjButtonClear.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            rjButtonClear.ForeColor = Color.White;
            rjButtonClear.Location = new Point(504, 93);
            rjButtonClear.Name = "rjButtonClear";
            rjButtonClear.Size = new Size(134, 48);
            rjButtonClear.TabIndex = 5;
            rjButtonClear.Text = "Clear";
            rjButtonClear.TextColor = Color.White;
            rjButtonClear.UseVisualStyleBackColor = false;
            rjButtonClear.Click += rjButtonClear_Click;
            // 
            // rjButtonOk
            // 
            rjButtonOk.BackColor = Color.DarkOrange;
            rjButtonOk.BackgroundColor = Color.DarkOrange;
            rjButtonOk.BorderColor = Color.PaleVioletRed;
            rjButtonOk.BorderRadius = 27;
            rjButtonOk.BorderSize = 0;
            rjButtonOk.FlatAppearance.BorderSize = 0;
            rjButtonOk.FlatAppearance.MouseDownBackColor = Color.Peru;
            rjButtonOk.FlatAppearance.MouseOverBackColor = Color.Peru;
            rjButtonOk.FlatStyle = FlatStyle.Flat;
            rjButtonOk.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            rjButtonOk.ForeColor = Color.White;
            rjButtonOk.Location = new Point(504, 29);
            rjButtonOk.Name = "rjButtonOk";
            rjButtonOk.Size = new Size(134, 49);
            rjButtonOk.TabIndex = 4;
            rjButtonOk.Text = "OK";
            rjButtonOk.TextColor = Color.White;
            rjButtonOk.UseVisualStyleBackColor = false;
            rjButtonOk.Click += rjButtonOk_Click;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelAmount.ForeColor = Color.MidnightBlue;
            labelAmount.Location = new Point(245, 29);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(160, 34);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "Enter amount:";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.BackColor = SystemColors.Info;
            comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrency.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Items.AddRange(new object[] { "EUR", "LEI", "USD", "RUB", "RON", "UAH" });
            comboBoxCurrency.Location = new Point(61, 75);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(110, 32);
            comboBoxCurrency.TabIndex = 1;
            // 
            // labelCurrency
            // 
            labelCurrency.AutoSize = true;
            labelCurrency.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelCurrency.ForeColor = Color.MidnightBlue;
            labelCurrency.Location = new Point(61, 29);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(110, 34);
            labelCurrency.TabIndex = 0;
            labelCurrency.Text = "Currency:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(806, 679);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 726);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(112, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // panelKurs
            // 
            panelKurs.Controls.Add(labelB7);
            panelKurs.Controls.Add(labelB6);
            panelKurs.Controls.Add(labelS7);
            panelKurs.Controls.Add(labelS6);
            panelKurs.Controls.Add(labelP7);
            panelKurs.Controls.Add(pictureBoxV7);
            panelKurs.Controls.Add(labelP6);
            panelKurs.Controls.Add(labelValuta7);
            panelKurs.Controls.Add(pictureBoxV6);
            panelKurs.Controls.Add(labelValuta6);
            panelKurs.Controls.Add(labelB5);
            panelKurs.Controls.Add(labelS5);
            panelKurs.Controls.Add(labelP5);
            panelKurs.Controls.Add(pictureBoxV5);
            panelKurs.Controls.Add(labelValuta5);
            panelKurs.Controls.Add(labelB4);
            panelKurs.Controls.Add(labelS4);
            panelKurs.Controls.Add(labelP4);
            panelKurs.Controls.Add(pictureBoxV4);
            panelKurs.Controls.Add(labelValuta4);
            panelKurs.Controls.Add(labelB3);
            panelKurs.Controls.Add(labelS3);
            panelKurs.Controls.Add(labelP3);
            panelKurs.Controls.Add(pictureBoxV3);
            panelKurs.Controls.Add(labelValuta3);
            panelKurs.Controls.Add(labelB2);
            panelKurs.Controls.Add(labelS2);
            panelKurs.Controls.Add(labelP2);
            panelKurs.Controls.Add(pictureBoxV2);
            panelKurs.Controls.Add(labelValuta2);
            panelKurs.Controls.Add(labelV);
            panelKurs.Controls.Add(labelB);
            panelKurs.Controls.Add(labelS);
            panelKurs.Controls.Add(labelP);
            panelKurs.Controls.Add(pictureBoxV1);
            panelKurs.Controls.Add(labelSale);
            panelKurs.Controls.Add(labelBNM);
            panelKurs.Controls.Add(labelPurchase);
            panelKurs.Controls.Add(labelValuta);
            panelKurs.Location = new Point(118, 360);
            panelKurs.Name = "panelKurs";
            panelKurs.Size = new Size(670, 412);
            panelKurs.TabIndex = 5;
            panelKurs.Visible = false;
            // 
            // labelB7
            // 
            labelB7.AutoSize = true;
            labelB7.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB7.Location = new Point(552, 371);
            labelB7.Name = "labelB7";
            labelB7.Size = new Size(61, 24);
            labelB7.TabIndex = 37;
            labelB7.Text = "label2";
            // 
            // labelB6
            // 
            labelB6.AutoSize = true;
            labelB6.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB6.Location = new Point(552, 324);
            labelB6.Name = "labelB6";
            labelB6.Size = new Size(61, 24);
            labelB6.TabIndex = 32;
            labelB6.Text = "label2";
            // 
            // labelS7
            // 
            labelS7.AutoSize = true;
            labelS7.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelS7.Location = new Point(410, 371);
            labelS7.Name = "labelS7";
            labelS7.Size = new Size(61, 24);
            labelS7.TabIndex = 36;
            labelS7.Text = "label2";
            // 
            // labelS6
            // 
            labelS6.AutoSize = true;
            labelS6.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelS6.Location = new Point(410, 324);
            labelS6.Name = "labelS6";
            labelS6.Size = new Size(61, 24);
            labelS6.TabIndex = 31;
            labelS6.Text = "label2";
            // 
            // labelP7
            // 
            labelP7.AutoSize = true;
            labelP7.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelP7.Location = new Point(269, 371);
            labelP7.Name = "labelP7";
            labelP7.Size = new Size(61, 24);
            labelP7.TabIndex = 35;
            labelP7.Text = "label2";
            // 
            // pictureBoxV7
            // 
            pictureBoxV7.Location = new Point(34, 366);
            pictureBoxV7.Name = "pictureBoxV7";
            pictureBoxV7.Size = new Size(30, 29);
            pictureBoxV7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxV7.TabIndex = 34;
            pictureBoxV7.TabStop = false;
            // 
            // labelP6
            // 
            labelP6.AutoSize = true;
            labelP6.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelP6.Location = new Point(269, 324);
            labelP6.Name = "labelP6";
            labelP6.Size = new Size(61, 24);
            labelP6.TabIndex = 30;
            labelP6.Text = "label2";
            // 
            // labelValuta7
            // 
            labelValuta7.AutoSize = true;
            labelValuta7.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelValuta7.Location = new Point(70, 366);
            labelValuta7.Name = "labelValuta7";
            labelValuta7.Size = new Size(64, 29);
            labelValuta7.TabIndex = 33;
            labelValuta7.Text = "label2";
            // 
            // pictureBoxV6
            // 
            pictureBoxV6.Location = new Point(34, 319);
            pictureBoxV6.Name = "pictureBoxV6";
            pictureBoxV6.Size = new Size(30, 29);
            pictureBoxV6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxV6.TabIndex = 29;
            pictureBoxV6.TabStop = false;
            // 
            // labelValuta6
            // 
            labelValuta6.AutoSize = true;
            labelValuta6.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelValuta6.Location = new Point(70, 319);
            labelValuta6.Name = "labelValuta6";
            labelValuta6.Size = new Size(64, 29);
            labelValuta6.TabIndex = 28;
            labelValuta6.Text = "label2";
            // 
            // labelB5
            // 
            labelB5.AutoSize = true;
            labelB5.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB5.Location = new Point(552, 279);
            labelB5.Name = "labelB5";
            labelB5.Size = new Size(61, 24);
            labelB5.TabIndex = 27;
            labelB5.Text = "label2";
            // 
            // labelS5
            // 
            labelS5.AutoSize = true;
            labelS5.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelS5.Location = new Point(410, 279);
            labelS5.Name = "labelS5";
            labelS5.Size = new Size(61, 24);
            labelS5.TabIndex = 26;
            labelS5.Text = "label2";
            // 
            // labelP5
            // 
            labelP5.AutoSize = true;
            labelP5.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelP5.Location = new Point(269, 279);
            labelP5.Name = "labelP5";
            labelP5.Size = new Size(61, 24);
            labelP5.TabIndex = 25;
            labelP5.Text = "label2";
            // 
            // pictureBoxV5
            // 
            pictureBoxV5.Location = new Point(34, 274);
            pictureBoxV5.Name = "pictureBoxV5";
            pictureBoxV5.Size = new Size(30, 29);
            pictureBoxV5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxV5.TabIndex = 24;
            pictureBoxV5.TabStop = false;
            // 
            // labelValuta5
            // 
            labelValuta5.AutoSize = true;
            labelValuta5.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelValuta5.Location = new Point(70, 274);
            labelValuta5.Name = "labelValuta5";
            labelValuta5.Size = new Size(64, 29);
            labelValuta5.TabIndex = 23;
            labelValuta5.Text = "label2";
            // 
            // labelB4
            // 
            labelB4.AutoSize = true;
            labelB4.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB4.Location = new Point(552, 231);
            labelB4.Name = "labelB4";
            labelB4.Size = new Size(61, 24);
            labelB4.TabIndex = 22;
            labelB4.Text = "label2";
            // 
            // labelS4
            // 
            labelS4.AutoSize = true;
            labelS4.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelS4.Location = new Point(410, 231);
            labelS4.Name = "labelS4";
            labelS4.Size = new Size(61, 24);
            labelS4.TabIndex = 21;
            labelS4.Text = "label2";
            // 
            // labelP4
            // 
            labelP4.AutoSize = true;
            labelP4.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelP4.Location = new Point(269, 231);
            labelP4.Name = "labelP4";
            labelP4.Size = new Size(61, 24);
            labelP4.TabIndex = 20;
            labelP4.Text = "label2";
            // 
            // pictureBoxV4
            // 
            pictureBoxV4.Location = new Point(34, 226);
            pictureBoxV4.Name = "pictureBoxV4";
            pictureBoxV4.Size = new Size(30, 29);
            pictureBoxV4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxV4.TabIndex = 19;
            pictureBoxV4.TabStop = false;
            // 
            // labelValuta4
            // 
            labelValuta4.AutoSize = true;
            labelValuta4.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelValuta4.Location = new Point(70, 226);
            labelValuta4.Name = "labelValuta4";
            labelValuta4.Size = new Size(64, 29);
            labelValuta4.TabIndex = 18;
            labelValuta4.Text = "label2";
            // 
            // labelB3
            // 
            labelB3.AutoSize = true;
            labelB3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB3.Location = new Point(552, 182);
            labelB3.Name = "labelB3";
            labelB3.Size = new Size(61, 24);
            labelB3.TabIndex = 17;
            labelB3.Text = "label2";
            // 
            // labelS3
            // 
            labelS3.AutoSize = true;
            labelS3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelS3.Location = new Point(410, 182);
            labelS3.Name = "labelS3";
            labelS3.Size = new Size(61, 24);
            labelS3.TabIndex = 16;
            labelS3.Text = "label2";
            // 
            // labelP3
            // 
            labelP3.AutoSize = true;
            labelP3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelP3.Location = new Point(269, 182);
            labelP3.Name = "labelP3";
            labelP3.Size = new Size(61, 24);
            labelP3.TabIndex = 15;
            labelP3.Text = "label2";
            // 
            // pictureBoxV3
            // 
            pictureBoxV3.Location = new Point(34, 177);
            pictureBoxV3.Name = "pictureBoxV3";
            pictureBoxV3.Size = new Size(30, 29);
            pictureBoxV3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxV3.TabIndex = 14;
            pictureBoxV3.TabStop = false;
            // 
            // labelValuta3
            // 
            labelValuta3.AutoSize = true;
            labelValuta3.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelValuta3.Location = new Point(70, 177);
            labelValuta3.Name = "labelValuta3";
            labelValuta3.Size = new Size(64, 29);
            labelValuta3.TabIndex = 13;
            labelValuta3.Text = "label2";
            // 
            // labelB2
            // 
            labelB2.AutoSize = true;
            labelB2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB2.Location = new Point(552, 131);
            labelB2.Name = "labelB2";
            labelB2.Size = new Size(61, 24);
            labelB2.TabIndex = 12;
            labelB2.Text = "label2";
            // 
            // labelS2
            // 
            labelS2.AutoSize = true;
            labelS2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelS2.Location = new Point(410, 131);
            labelS2.Name = "labelS2";
            labelS2.Size = new Size(61, 24);
            labelS2.TabIndex = 11;
            labelS2.Text = "label2";
            // 
            // labelP2
            // 
            labelP2.AutoSize = true;
            labelP2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelP2.Location = new Point(269, 131);
            labelP2.Name = "labelP2";
            labelP2.Size = new Size(61, 24);
            labelP2.TabIndex = 10;
            labelP2.Text = "label2";
            // 
            // pictureBoxV2
            // 
            pictureBoxV2.Location = new Point(34, 126);
            pictureBoxV2.Name = "pictureBoxV2";
            pictureBoxV2.Size = new Size(30, 29);
            pictureBoxV2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxV2.TabIndex = 9;
            pictureBoxV2.TabStop = false;
            // 
            // labelValuta2
            // 
            labelValuta2.AutoSize = true;
            labelValuta2.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelValuta2.Location = new Point(70, 126);
            labelValuta2.Name = "labelValuta2";
            labelValuta2.Size = new Size(64, 29);
            labelValuta2.TabIndex = 8;
            labelValuta2.Text = "label2";
            // 
            // labelV
            // 
            labelV.AutoSize = true;
            labelV.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelV.Location = new Point(35, 29);
            labelV.Name = "labelV";
            labelV.Size = new Size(90, 29);
            labelV.TabIndex = 6;
            labelV.Text = "Валюта";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB.Location = new Point(552, 77);
            labelB.Name = "labelB";
            labelB.Size = new Size(61, 24);
            labelB.TabIndex = 7;
            labelB.Text = "label2";
            // 
            // labelS
            // 
            labelS.AutoSize = true;
            labelS.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelS.Location = new Point(410, 77);
            labelS.Name = "labelS";
            labelS.Size = new Size(61, 24);
            labelS.TabIndex = 6;
            labelS.Text = "label2";
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelP.Location = new Point(269, 77);
            labelP.Name = "labelP";
            labelP.Size = new Size(61, 24);
            labelP.TabIndex = 5;
            labelP.Text = "label2";
            // 
            // pictureBoxV1
            // 
            pictureBoxV1.Location = new Point(34, 72);
            pictureBoxV1.Name = "pictureBoxV1";
            pictureBoxV1.Size = new Size(30, 29);
            pictureBoxV1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxV1.TabIndex = 4;
            pictureBoxV1.TabStop = false;
            // 
            // labelSale
            // 
            labelSale.AutoSize = true;
            labelSale.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelSale.Location = new Point(394, 29);
            labelSale.Name = "labelSale";
            labelSale.Size = new Size(97, 29);
            labelSale.TabIndex = 3;
            labelSale.Text = "Продажа";
            // 
            // labelBNM
            // 
            labelBNM.AutoSize = true;
            labelBNM.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelBNM.Location = new Point(529, 29);
            labelBNM.Name = "labelBNM";
            labelBNM.Size = new Size(118, 29);
            labelBNM.TabIndex = 2;
            labelBNM.Text = "Курс BNM";
            // 
            // labelPurchase
            // 
            labelPurchase.AutoSize = true;
            labelPurchase.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPurchase.Location = new Point(257, 29);
            labelPurchase.Name = "labelPurchase";
            labelPurchase.Size = new Size(94, 29);
            labelPurchase.TabIndex = 1;
            labelPurchase.Text = "Покупка";
            // 
            // labelValuta
            // 
            labelValuta.AutoSize = true;
            labelValuta.Font = new Font("Monotype Corsiva", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelValuta.Location = new Point(70, 72);
            labelValuta.Name = "labelValuta";
            labelValuta.Size = new Size(64, 29);
            labelValuta.TabIndex = 0;
            labelValuta.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 809);
            Controls.Add(panelKurs);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(roundedPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelKurs.ResumeLayout(false);
            panelKurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonClose;
        private Panel panel2;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private ComboBox comboBoxCurrency;
        private Label labelCurrency;
        private Label labelAmount;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private RJButton rjButtonOk;
        private RJButton rjButtonClear;
        private RJTextBox rjTextBox1Amount;
        private Panel panelKurs;
        private Label labelPurchase;
        private Label labelValuta;
        private PictureBox pictureBoxV1;
        private Label labelSale;
        private Label labelBNM;
        private Label labelB;
        private Label labelS;
        private Label labelP;
        private Label labelV;
        private Label labelB2;
        private Label labelS2;
        private Label labelP2;
        private PictureBox pictureBoxV2;
        private Label labelValuta2;
        private Label labelB3;
        private Label labelS3;
        private Label labelP3;
        private PictureBox pictureBoxV3;
        private Label labelValuta3;
        private Label labelB4;
        private Label labelS4;
        private Label labelP4;
        private PictureBox pictureBoxV4;
        private Label labelValuta4;
        private Label labelB5;
        private Label labelS5;
        private Label labelP5;
        private PictureBox pictureBoxV5;
        private Label labelValuta5;
        private Label labelB6;
        private Label labelS6;
        private Label labelP6;
        private PictureBox pictureBoxV6;
        private Label labelValuta6;
        private Label labelB7;
        private Label labelS7;
        private Label labelP7;
        private PictureBox pictureBoxV7;
        private Label labelValuta7;
    }
}
