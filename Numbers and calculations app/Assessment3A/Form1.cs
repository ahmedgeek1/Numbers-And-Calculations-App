using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3A
{
    public partial class Form1 : Form
    {
        //constants
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTYFIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        // Variabls for number of times clicked on every coin
        private int FiveCentClickedNumber = 0;
        private int TenCentClickedNumber = 0;
        private int TwentyFiveCentClickedNumber = 0;
        private int FiftyCentClickedNumber = 0;

        // VARIABLE FOR THE TOTAL set to 0 in the begining
        private decimal total = 0m;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;
            FiveCentClickedNumber += 1;
            lbl5Cents.Text = FiveCentClickedNumber.ToString();
            lblTotalOutPut.Text = total.ToString("c");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbl5Cents.Text = "";
            lbl10Cents.Text = "";
            lbl25Cents.Text = "";
            lbl50Cents.Text = "";
            lblTotalOutPut.Text = "";
            FiveCentClickedNumber = 0;
            TenCentClickedNumber = 0;
            TwentyFiveCentClickedNumber = 0;
            FiftyCentClickedNumber = 0;
            total = 0;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic10CentCoin_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            TenCentClickedNumber += 1;
            lbl10Cents.Text = TenCentClickedNumber.ToString();
            lblTotalOutPut.Text = total.ToString("c");

        }

        private void pic25CentCoin_Click(object sender, EventArgs e)
        {
            total += TWENTYFIVE_CENTS_VALUE;
            TwentyFiveCentClickedNumber += 1;
            lbl25Cents.Text = TwentyFiveCentClickedNumber.ToString();
            lblTotalOutPut.Text = total.ToString("c");

        }

        private void pic50CentCoin_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;
            FiftyCentClickedNumber += 1;
            lbl50Cents.Text = FiftyCentClickedNumber.ToString();
            lblTotalOutPut.Text = total.ToString("c");
        }
    }
}
