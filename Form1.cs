namespace Lab_5
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 40;

            // create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // bottom-left corner

            // create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValuteEUR()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV1.Image = Image.FromFile(@"..\..\..\image\icon-flag.png");
            labelValuta.Text = "LEI";
            purchase = amount * 19.2000;
            labelP.Text = purchase.ToString(("F3"));
            sale = amount * 19.5000;
            labelS.Text = sale.ToString(("F3"));
            BNM = amount * 19.2586;
            labelB.Text = BNM.ToString("F3");

            pictureBoxV2.Image = Image.FromFile(@"..\..\..\image\united-states-of-america.png");
            labelValuta2.Text = "USD";
            purchase = amount * 1.0768;
            labelP2.Text = purchase.ToString(("F3"));
            sale = amount * 1.08;
            labelS2.Text = sale.ToString(("F3"));
            BNM = amount * 1.0778;
            labelB2.Text = BNM.ToString("F3");

            pictureBoxV3.Image = Image.FromFile(@"..\..\..\image\russia.png");
            labelValuta3.Text = "RUB";
            purchase = amount * 98.89;
            labelP3.Text = purchase.ToString(("F3"));
            sale = amount * 99.62;
            labelS3.Text = sale.ToString(("F3"));
            BNM = amount * 100.4098;
            labelB3.Text = BNM.ToString("F3");

            pictureBoxV4.Image = Image.FromFile(@"..\..\..\image\romania.png");
            labelValuta4.Text = "RON";
            purchase = amount * 4.95;
            labelP4.Text = purchase.ToString(("F3"));
            sale = amount * 4.98;
            labelS4.Text = sale.ToString(("F3"));
            BNM = amount * 4.9766;
            labelB4.Text = BNM.ToString("F3");

            pictureBoxV5.Image = Image.FromFile(@"..\..\..\image\ukraine.png");
            labelValuta5.Text = "UAH";
            purchase = amount * 41.26;
            labelP5.Text = purchase.ToString(("F3"));
            sale = amount * 41.23;
            labelS5.Text = sale.ToString(("F3"));
            BNM = amount * 41.0281;
            labelB5.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = false;
            labelValuta6.Visible = false;
            labelP6.Visible = false;
            labelS6.Visible = false;
            labelB6.Visible = false;
            pictureBoxV7.Visible = false;
            labelValuta7.Visible = false;
            labelP7.Visible = false;
            labelS7.Visible = false;
            labelB7.Visible = false;
            panelKurs.Visible = true;
        }

        private void ValuteUSD()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV1.Image = Image.FromFile(@"..\..\..\image\european-union.png");
            labelValuta.Text = "EUR";
            purchase = amount * 0.9282278;
            labelP.Text = purchase.ToString(("F3"));
            sale = amount * 0.93;
            labelS.Text = sale.ToString(("F3"));
            BNM = amount * 0.9278;
            labelB.Text = BNM.ToString("F3");

            pictureBoxV2.Image = Image.FromFile(@"..\..\..\image\icon-flag.png");
            labelValuta2.Text = "LEI";
            purchase = amount * 17.87289;
            labelP2.Text = purchase.ToString(("F3"));
            sale = amount * 17.88;
            labelS2.Text = sale.ToString(("F3"));
            BNM = amount * 17.8685;
            labelB2.Text = BNM.ToString("F3");

            pictureBoxV3.Image = Image.FromFile(@"..\..\..\image\russia.png");
            labelValuta3.Text = "RUB";
            purchase = amount * 92.29553;
            labelP3.Text = purchase.ToString(("F3"));
            sale = amount * 92.50;
            labelS3.Text = sale.ToString(("F3"));
            BNM = amount * 93.1621;
            labelB3.Text = BNM.ToString("F3");

            pictureBoxV4.Image = Image.FromFile(@"..\..\..\image\romania.png");
            labelValuta4.Text = "RON";
            purchase = amount * 4.62;
            labelP4.Text = purchase.ToString(("F3"));
            sale = amount * 4.6191973;
            labelS4.Text = sale.ToString(("F3"));
            BNM = amount * 4.6174;
            labelB4.Text = BNM.ToString("F3");

            pictureBoxV5.Image = Image.FromFile(@"..\..\..\image\ukraine.png");
            labelValuta5.Text = "UAH";
            purchase = amount * 37.9638;
            labelP5.Text = purchase.ToString(("F3"));
            sale = amount * 38.29;
            labelS5.Text = sale.ToString(("F3"));
            BNM = amount * 38.0667;
            labelB5.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = false;
            labelValuta6.Visible = false;
            labelP6.Visible = false;
            labelS6.Visible = false;
            labelB6.Visible = false;
            pictureBoxV7.Visible = false;
            labelValuta7.Visible = false;
            labelP7.Visible = false;
            labelS7.Visible = false;
            labelB7.Visible = false;
            panelKurs.Visible = true;
        }

        private void ValuteLEI()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV1.Image = Image.FromFile(@"..\..\..\image\european-union.png");
            labelValuta.Text = "EUR";
            purchase = amount * 0.052066;
            labelP.Text = purchase.ToString(("F3"));
            sale = amount * 0.052;
            labelS.Text = sale.ToString(("F3"));
            BNM = amount * 0.0519;
            labelB.Text = BNM.ToString("F3");

            pictureBoxV2.Image = Image.FromFile(@"..\..\..\image\united-states-of-america.png");
            labelValuta2.Text = "USD";
            purchase = amount * 0.05593;
            labelP2.Text = purchase.ToString(("F3"));
            sale = amount * 0.07;
            labelS2.Text = sale.ToString(("F3"));
            BNM = amount * 0.056;
            labelB2.Text = BNM.ToString("F3");

            pictureBoxV3.Image = Image.FromFile(@"..\..\..\image\russia.png");
            labelValuta3.Text = "RUB";
            purchase = amount * 5.18;
            labelP3.Text = purchase.ToString(("F3"));
            sale = amount * 5.19;
            labelS3.Text = sale.ToString(("F3"));
            BNM = amount * 5.2138;
            labelB3.Text = BNM.ToString("F3");

            pictureBoxV4.Image = Image.FromFile(@"..\..\..\image\romania.png");
            labelValuta4.Text = "RON";
            purchase = amount * 0.25905;
            labelP4.Text = purchase.ToString(("F3"));
            sale = amount * 0.26;
            labelS4.Text = sale.ToString(("F3"));
            BNM = amount * 0.2584;
            labelB4.Text = BNM.ToString("F3");

            pictureBoxV5.Image = Image.FromFile(@"..\..\..\image\ukraine.png");
            labelValuta5.Text = "UAH";
            purchase = amount * 2.128391;
            labelP5.Text = purchase.ToString(("F3"));
            sale = amount * 2.15;
            labelS5.Text = sale.ToString(("F3"));
            BNM = amount * 2.1304;
            labelB5.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = false;
            labelValuta6.Visible = false;
            labelP6.Visible = false;
            labelS6.Visible = false;
            labelB6.Visible = false;
            pictureBoxV7.Visible = false;
            labelValuta7.Visible = false;
            labelP7.Visible = false;
            labelS7.Visible = false;
            labelB7.Visible = false;
            panelKurs.Visible = true;
        }

        private void ValuteRUB()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV1.Image = Image.FromFile(@"..\..\..\image\european-union.png");
            labelValuta.Text = "EUR";
            purchase = amount * 0.01004;
            labelP.Text = purchase.ToString(("F3"));
            sale = amount * 0.010;
            labelS.Text = sale.ToString(("F3"));
            BNM = amount * 0.01;
            labelB.Text = BNM.ToString("F3");

            pictureBoxV2.Image = Image.FromFile(@"..\..\..\image\icon-flag.png");
            labelValuta2.Text = "LEI";
            purchase = amount * 0.19505669;
            labelP2.Text = purchase.ToString(("F3"));
            sale = amount * 0.196;
            labelS2.Text = sale.ToString(("F3"));
            BNM = amount * 0.1918;
            labelB2.Text = BNM.ToString("F3");

            pictureBoxV3.Image = Image.FromFile(@"..\..\..\image\united-states-of-america.png");
            labelValuta3.Text = "USD";
            purchase = amount * 0.01081;
            labelP3.Text = purchase.ToString(("F3"));
            sale = amount * 0.011;
            labelS3.Text = sale.ToString(("F3"));
            BNM = amount * 0.0107;
            labelB3.Text = BNM.ToString("F3");

            pictureBoxV4.Image = Image.FromFile(@"..\..\..\image\romania.png");
            labelValuta4.Text = "RON";
            purchase = amount * 0.050180;
            labelP4.Text = purchase.ToString(("F3"));
            sale = amount * 0.050;
            labelS4.Text = sale.ToString(("F3"));
            BNM = amount * 0.0496;
            labelB4.Text = BNM.ToString("F3");

            pictureBoxV5.Image = Image.FromFile(@"..\..\..\image\ukraine.png");
            labelValuta5.Text = "UAH";
            purchase = amount * 0.40982;
            labelP5.Text = purchase.ToString(("F3"));
            sale = amount * 0.41;
            labelS5.Text = sale.ToString(("F3"));
            BNM = amount * 0.4086;
            labelB5.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = false;
            labelValuta6.Visible = false;
            labelP6.Visible = false;
            labelS6.Visible = false;
            labelB6.Visible = false;
            pictureBoxV7.Visible = false;
            labelValuta7.Visible = false;
            labelP7.Visible = false;
            labelS7.Visible = false;
            labelB7.Visible = false;
            panelKurs.Visible = true;
        }

        private void ValuteRON()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV1.Image = Image.FromFile(@"..\..\..\image\european-union.png");
            labelValuta.Text = "EUR";
            purchase = amount * 0.200864;
            labelP.Text = purchase.ToString(("F3"));
            sale = amount * 0.21;
            labelS.Text = sale.ToString(("F3"));
            BNM = amount * 0.2009;
            labelB.Text = BNM.ToString("F3");

            pictureBoxV2.Image = Image.FromFile(@"..\..\..\image\icon-flag.png");
            labelValuta2.Text = "LEI";
            purchase = amount * 3.87233;
            labelP2.Text = purchase.ToString(("F3"));
            sale = amount * 3.87;
            labelS2.Text = sale.ToString(("F3"));
            BNM = amount * 3.8698;
            labelB2.Text = BNM.ToString("F3");

            pictureBoxV3.Image = Image.FromFile(@"..\..\..\image\united-states-of-america.png");
            labelValuta3.Text = "USD";
            purchase = amount * 0.216553;
            labelP3.Text = purchase.ToString(("F3"));
            sale = amount * 0.22;
            labelS3.Text = sale.ToString(("F3"));
            BNM = amount * 0.2166;
            labelB3.Text = BNM.ToString("F3");

            pictureBoxV4.Image = Image.FromFile(@"..\..\..\image\russia.png");
            labelValuta4.Text = "RUB";
            purchase = amount * 19.66460;
            labelP4.Text = purchase.ToString(("F3"));
            sale = amount * 20.03;
            labelS4.Text = sale.ToString(("F3"));
            BNM = amount * 20.1762;
            labelB4.Text = BNM.ToString("F3");

            pictureBoxV5.Image = Image.FromFile(@"..\..\..\image\ukraine.png");
            labelValuta5.Text = "UAH";
            purchase = amount * 8.28762;
            labelP5.Text = purchase.ToString(("F3"));
            sale = amount * 8.29;
            labelS5.Text = sale.ToString(("F3"));
            BNM = amount * 8.2441;
            labelB5.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = false;
            labelValuta6.Visible = false;
            labelP6.Visible = false;
            labelS6.Visible = false;
            labelB6.Visible = false;
            pictureBoxV7.Visible = false;
            labelValuta7.Visible = false;
            labelP7.Visible = false;
            labelS7.Visible = false;
            labelB7.Visible = false;
            panelKurs.Visible = true;
        }

        private void ValuteUAH()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV1.Image = Image.FromFile(@"..\..\..\image\european-union.png");
            labelValuta.Text = "EUR";
            purchase = amount * 0.024228;
            labelP.Text = purchase.ToString(("F3"));
            sale = amount * 0.024;
            labelS.Text = sale.ToString(("F3"));
            BNM = amount * 0.0244;
            labelB.Text = BNM.ToString("F3");

            pictureBoxV2.Image = Image.FromFile(@"..\..\..\image\icon-flag.png");
            labelValuta2.Text = "LEI";
            purchase = amount * 0.47087;
            labelP2.Text = purchase.ToString(("F3"));
            sale = amount * 0.47;
            labelS2.Text = sale.ToString(("F3"));
            BNM = amount * 0.4694;
            labelB2.Text = BNM.ToString("F3");

            pictureBoxV3.Image = Image.FromFile(@"..\..\..\image\united-states-of-america.png");
            labelValuta3.Text = "USD";
            purchase = amount * 0.026275;
            labelP3.Text = purchase.ToString(("F3"));
            sale = amount * 0.0269;
            labelS3.Text = sale.ToString(("F3"));
            BNM = amount * 0.0263;
            labelB3.Text = BNM.ToString("F3");

            pictureBoxV4.Image = Image.FromFile(@"..\..\..\image\russia.png");
            labelValuta4.Text = "RUB";
            purchase = amount * 2.413527;
            labelP4.Text = purchase.ToString(("F3"));
            sale = amount * 2.42;
            labelS4.Text = sale.ToString(("F3"));
            BNM = amount * 2.4473;
            labelB4.Text = BNM.ToString("F3");

            pictureBoxV5.Image = Image.FromFile(@"..\..\..\image\romania.png");
            labelValuta5.Text = "RON";
            purchase = amount * 0.12258;
            labelP5.Text = purchase.ToString(("F3"));
            sale = amount * 0.126;
            labelS5.Text = sale.ToString(("F3"));
            BNM = amount * 0.1213;
            labelB5.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = false;
            labelValuta6.Visible = false;
            labelP6.Visible = false;
            labelS6.Visible = false;
            labelB6.Visible = false;
            pictureBoxV7.Visible = false;
            labelValuta7.Visible = false;
            labelP7.Visible = false;
            labelS7.Visible = false;
            labelB7.Visible = false;
            panelKurs.Visible = true;
        }

        private void ValuteGBP_CHF_EUR()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV6.Image = Image.FromFile(@"..\..\..\image\united-kingdom.png");
            labelValuta6.Text = "GBP";
            purchase = amount * 0.8541;
            labelP6.Text = purchase.ToString(("F3"));
            sale = amount * 0.86;
            labelS6.Text = sale.ToString(("F3"));
            BNM = amount * 0.8555;
            labelB6.Text = BNM.ToString("F3");

            pictureBoxV7.Image = Image.FromFile(@"..\..\..\image\switzerland.png");
            labelValuta7.Text = "CHF";
            purchase = amount * 0.948983;
            labelP7.Text = purchase.ToString(("F3"));
            sale = amount * 0.95;
            labelS7.Text = sale.ToString(("F3"));
            BNM = amount * 0.949;
            labelB7.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = true;
            labelValuta6.Visible = true;
            labelP6.Visible = true;
            labelS6.Visible = true;
            labelB6.Visible = true;
            pictureBoxV7.Visible = true;
            labelValuta7.Visible = true;
            labelP7.Visible = true;
            labelS7.Visible = true;
            labelB7.Visible = true;
            panelKurs.Visible = true;
        }

        private void ValuteGBP_CHF_LEI()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV6.Image = Image.FromFile(@"..\..\..\image\united-kingdom.png");
            labelValuta6.Text = "GBP";
            purchase = amount * 0.044425;
            labelP6.Text = purchase.ToString(("F3"));
            sale = amount * 0.045;
            labelS6.Text = sale.ToString(("F3"));
            BNM = amount * 0.0444;
            labelB6.Text = BNM.ToString("F3");

            pictureBoxV7.Image = Image.FromFile(@"..\..\..\image\switzerland.png");
            labelValuta7.Text = "CHF";
            purchase = amount * 0.049636;
            labelP7.Text = purchase.ToString(("F3"));
            sale = amount * 0.050;
            labelS7.Text = sale.ToString(("F3"));
            BNM = amount * 0.0493;
            labelB7.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = true;
            labelValuta6.Visible = true;
            labelP6.Visible = true;
            labelS6.Visible = true;
            labelB6.Visible = true;
            pictureBoxV7.Visible = true;
            labelValuta7.Visible = true;
            labelP7.Visible = true;
            labelS7.Visible = true;
            labelB7.Visible = true;
            panelKurs.Visible = true;
        }

        private void ValuteGBP_CHF_USD()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV6.Image = Image.FromFile(@"..\..\..\image\united-kingdom.png");
            labelValuta6.Text = "GBP";
            purchase = amount * 0.7924;
            labelP6.Text = purchase.ToString(("F3"));
            sale = amount * 0.795;
            labelS6.Text = sale.ToString(("F3"));
            BNM = amount * 0.7937;
            labelB6.Text = BNM.ToString("F3");

            pictureBoxV7.Image = Image.FromFile(@"..\..\..\image\switzerland.png");
            labelValuta7.Text = "CHF";
            purchase = amount * 0.881111;
            labelP7.Text = purchase.ToString(("F3"));
            sale = amount * 0.88;
            labelS7.Text = sale.ToString(("F3"));
            BNM = amount * 0.8805;
            labelB7.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = true;
            labelValuta6.Visible = true;
            labelP6.Visible = true;
            labelS6.Visible = true;
            labelB6.Visible = true;
            pictureBoxV7.Visible = true;
            labelValuta7.Visible = true;
            labelP7.Visible = true;
            labelS7.Visible = true;
            labelB7.Visible = true;
            panelKurs.Visible = true;
        }

        private void ValuteGBP_CHF_RUB()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV6.Image = Image.FromFile(@"..\..\..\image\united-kingdom.png");
            labelValuta6.Text = "GBP";
            purchase = amount * 0.008622;
            labelP6.Text = purchase.ToString(("F3"));
            sale = amount * 0.0086;
            labelS6.Text = sale.ToString(("F3"));
            BNM = amount * 0.0085;
            labelB6.Text = BNM.ToString("F3");

            pictureBoxV7.Image = Image.FromFile(@"..\..\..\image\switzerland.png");
            labelValuta7.Text = "CHF";
            purchase = amount * 0.00953;
            labelP7.Text = purchase.ToString(("F3"));
            sale = amount * 0.0096;
            labelS7.Text = sale.ToString(("F3"));
            BNM = amount * 0.0095;
            labelB7.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = true;
            labelValuta6.Visible = true;
            labelP6.Visible = true;
            labelS6.Visible = true;
            labelB6.Visible = true;
            pictureBoxV7.Visible = true;
            labelValuta7.Visible = true;
            labelP7.Visible = true;
            labelS7.Visible = true;
            labelB7.Visible = true;
            panelKurs.Visible = true;
        }

        private void ValuteGBP_CHF_RON()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV6.Image = Image.FromFile(@"..\..\..\image\united-kingdom.png");
            labelValuta6.Text = "GBP";
            purchase = amount * 0.171576;
            labelP6.Text = purchase.ToString(("F3"));
            sale = amount * 0.175;
            labelS6.Text = sale.ToString(("F3"));
            BNM = amount * 0.1719;
            labelB6.Text = BNM.ToString("F3");

            pictureBoxV7.Image = Image.FromFile(@"..\..\..\image\switzerland.png");
            labelValuta7.Text = "CHF";
            purchase = amount * 0.19057;
            labelP7.Text = purchase.ToString(("F3"));
            sale = amount * 0.196;
            labelS7.Text = sale.ToString(("F3"));
            BNM = amount * 0.1907;
            labelB7.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = true;
            labelValuta6.Visible = true;
            labelP6.Visible = true;
            labelS6.Visible = true;
            labelB6.Visible = true;
            pictureBoxV7.Visible = true;
            labelValuta7.Visible = true;
            labelP7.Visible = true;
            labelS7.Visible = true;
            labelB7.Visible = true;
            panelKurs.Visible = true;
        }

        private void ValuteGBP_CHF_UAH()
        {
            double purchase = 0, sale = 0, BNM = 0;
            double amount = Convert.ToDouble(rjTextBox1Amount.Texts);

            pictureBoxV6.Image = Image.FromFile(@"..\..\..\image\united-kingdom.png");
            labelValuta6.Text = "GBP";
            purchase = amount * 0.02093;
            labelP6.Text = purchase.ToString(("F3"));
            sale = amount * 0.021;
            labelS6.Text = sale.ToString(("F3"));
            BNM = amount * 0.0209;
            labelB6.Text = BNM.ToString("F3");

            pictureBoxV7.Image = Image.FromFile(@"..\..\..\image\switzerland.png");
            labelValuta7.Text = "CHF";
            purchase = amount * 0.02303;
            labelP7.Text = purchase.ToString(("F3"));
            sale = amount * 0.0237;
            labelS7.Text = sale.ToString(("F3"));
            BNM = amount * 0.0231;
            labelB7.Text = BNM.ToString("F3");

            pictureBoxV6.Visible = true;
            labelValuta6.Visible = true;
            labelP6.Visible = true;
            labelS6.Visible = true;
            labelB6.Visible = true;
            pictureBoxV7.Visible = true;
            labelValuta7.Visible = true;
            labelP7.Visible = true;
            labelS7.Visible = true;
            labelB7.Visible = true;
            panelKurs.Visible = true;
        }

        private void rjButtonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rjTextBox1Amount.Texts) || comboBoxCurrency.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCurrency.Focus();
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Хотите ли вы использовать курс валют для карточных операций?", "Запрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (comboBoxCurrency.SelectedItem.ToString() == "EUR")
                    {
                        ValuteEUR();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "LEI")
                    {
                        ValuteLEI();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "USD")
                    {
                        ValuteUSD();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "RUB")
                    {
                        ValuteRUB();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "RON")
                    {
                        ValuteRON();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "UAH")
                    {
                        ValuteUAH();
                    }
                }
                else
                {
                    if (comboBoxCurrency.SelectedItem.ToString() == "EUR")
                    {
                        ValuteEUR();
                        ValuteGBP_CHF_EUR();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "LEI")
                    {
                        ValuteLEI();
                        ValuteGBP_CHF_LEI();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "USD")
                    {
                        ValuteUSD();
                        ValuteGBP_CHF_USD();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "RUB")
                    {
                        ValuteRUB();
                        ValuteGBP_CHF_RUB();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "RON")
                    {
                        ValuteRON();
                        ValuteGBP_CHF_RON();
                    }
                    if (comboBoxCurrency.SelectedItem.ToString() == "UAH")
                    {
                        ValuteUAH();
                        ValuteGBP_CHF_UAH();
                    }
                }
            }
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            comboBoxCurrency.SelectedItem = null;
            rjTextBox1Amount.Clear();
            panelKurs.Visible = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox textBox = (RJTextBox)sender;
            if (e.KeyChar == '.') e.KeyChar = ',';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == ',' && Text.IndexOf(',') > -1)
                e.Handled = true;
        }
    }
}
