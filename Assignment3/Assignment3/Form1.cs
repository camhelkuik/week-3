using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Miles Per Gallon by Cameron Helkuik";
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHotKeyNotice.Text = "Press the Alt key to display the \"Hot-keys\"";
            txtMiles.Text = "0.00";
            txtGallons.Text = "0.00";
            lblMPG.Text = "0.00";
            txtMiles.Focus();
            txtMiles.SelectAll();
            txtGallons.SelectAll();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double inputMiles = Convert.ToDouble(txtMiles.Text);
            double inputGallons = Convert.ToDouble(txtGallons.Text);
            double mpg = inputMiles / inputGallons;

            lblMPG.Text = mpg.ToString("F2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMiles.Text = "0.0";
            txtGallons.Text = "0.0";
            lblMPG.Text = "0.0";
            txtMiles.Focus();
            txtMiles.SelectAll();
            txtGallons.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
