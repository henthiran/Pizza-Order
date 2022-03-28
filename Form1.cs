using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textUnitprice.Text = "750";
        }

        private void rdmedium_CheckedChanged(object sender, EventArgs e)
        {
            textUnitprice.Text = "1500";
        }

        private void rdlarge_CheckedChanged(object sender, EventArgs e)
        {
            textUnitprice.Text = "2000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtQuantity.Text);
            double discount = int.Parse(cmdDiscount.Text);
            int unitprice = int.Parse(textUnitprice.Text);

            double totDiscount = (qty * unitprice) * (discount / 100);
            textTD.Text = totDiscount.ToString();

            double totPay = (qty * unitprice) - totDiscount;
            textPay.Text = totPay.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rdlarge.Checked = false;
            rdmedium.Checked = false;
            rdsmall.Checked = false;
            cmdDiscount.Text = "";
            txtQuantity.Clear();
            textUnitprice.Clear();
            textTD.Clear();
            textPay.Clear();
            txtQuantity.Focus();

            
        }
    }
}
