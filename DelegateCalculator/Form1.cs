using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetResult Result = new GetResult(Solution.getTotal1);
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            MessageBox.Show(Result(num1, num2).ToString());
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            GetResult Result = new GetResult(Solution.getTotal2);
            int num3 = int.Parse(txtNum1.Text);
            int num4 = int.Parse(txtNum2.Text);
            MessageBox.Show(Result(num3, num4).ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetResult Result = new GetResult(Solution.getTotal3);
            int num5 = int.Parse(txtNum1.Text);
            int num6 = int.Parse(txtNum2.Text);
            MessageBox.Show(Result(num5, num6).ToString());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            GetResult Result = new GetResult(Solution.getTotal4);
            int num7 = int.Parse(txtNum1.Text);
            int num8 = int.Parse(txtNum2.Text);
            MessageBox.Show(Result(num7, num8).ToString());
        }
    }
}
