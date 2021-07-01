using ConsumingDesktopApp.MyServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumingDesktopApp
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // tao proxy
            MyMathServiceSoapClient proxy = new MyMathServiceSoapClient();
            String result = proxy.HelloWorld();

            MessageBox.Show(result, "Service Response");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtX.TextLength < 1 || txtY.TextLength < 1)
            {
                MessageBox.Show("Input Parameter");
            }
            else
            {
                double x = Double.Parse(txtX.Text);
                double y = Double.Parse(txtY.Text);

                MyMathServiceSoapClient proxy = new MyMathServiceSoapClient();
                double result = proxy.Div(x, y);

                MessageBox.Show(result.ToString(), "Service Response");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            {
                if (txtX.TextLength < 1 || txtY.TextLength < 1)
                {
                    MessageBox.Show("Input Parameter");
                }
                else
                {
                    double x = Double.Parse(txtX.Text);
                    double y = Double.Parse(txtY.Text);

                    MyMathServiceSoapClient proxy = new MyMathServiceSoapClient();
                    double result = proxy.Mul(x, y);

                    MessageBox.Show(result.ToString(), "Service Response");
                }
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            {
                if (txtX.TextLength < 1 || txtY.TextLength < 1)
                {
                    MessageBox.Show("Input Parameter");
                }
                else
                {
                    double x = Double.Parse(txtX.Text);
                    double y = Double.Parse(txtY.Text);

                    MyMathServiceSoapClient proxy = new MyMathServiceSoapClient();
                    double result = proxy.Sub(x, y);

                    MessageBox.Show(result.ToString(), "Service Response");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                if (txtX.TextLength < 1 || txtY.TextLength < 1)
                {
                    MessageBox.Show("Input Parameter");
                }
                else
                {
                    double x = Double.Parse(txtX.Text);
                    double y = Double.Parse(txtY.Text);

                    MyMathServiceSoapClient proxy = new MyMathServiceSoapClient();
                    double result = proxy.Add(x, y);

                    MessageBox.Show(result.ToString(), "Service Response");
                }
            }
        }
    }
}
