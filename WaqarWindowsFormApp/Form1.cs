using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaqarWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // my Events

        private void btn1_Click(object sender, EventArgs e)
        {
            SetTBResult("1");
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            SetTBResult("2");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SetTBResult("3");

        }



        private void btn4_Click(object sender, EventArgs e)
        {
            SetTBResult("4");

        }



        private void btn5_Click(object sender, EventArgs e)
        {
            SetTBResult("5");

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SetTBResult("6");

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SetTBResult("7");

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SetTBResult("8");

        }

        private void btn9_Click(object sender, EventArgs e)
        {

            SetTBResult("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            SetTBResult("0");
        }






        // my Functions


        public void SetTBResult(string text)
        {
            tbResult.Text += text;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetTBResult(" + ");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetTBResult(" - ");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            SetTBResult(" * ");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            SetTBResult(" / ");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string Expression = tbResult.Text;

            var NewEx = Expression.Split(' ');


            int Num1 = int.Parse(NewEx[0]);
            char op = Convert.ToChar(NewEx[1]);
            int Num2 = int.Parse(NewEx[2]);


            tbResult.Text = Arithmatic(Num1, Num2, op);



        }


        public string Arithmatic(int n1 ,int n2,char op)
        {
            double res = 0;

            switch (op)
            {

                case '+':

                    res = n1 + n2;
                    break;


                case '*':

                    res = n1 * n2;
                    break;



                case '-':

                    res = n1 - n2;
                    break;


                case '/':

                    res = n1 / n2;
                    break;


            }


            return res.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var text = tbResult.Text;

            var len = text.Length;

            text.LastIndexOf(' ');
            tbResult.Text = text;

        }
    }
}
