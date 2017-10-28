using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelRes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;

            n = Convert.ToInt32(tBnumber.Text);
            int lastDigit = n % 10;
            int lastTwoDigits = n % 100;
            string result = string.Empty;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
                result = "коров";

            else if (lastDigit == 1)
                result = "корова";
            else if (lastDigit >= 2 && lastDigit <= 4)
                result = "коровы";
            else if (lastDigit == 0 || lastDigit >= 5 && lastDigit <= 9)
                result = "коров";

            labelRes.Text = Convert.ToInt32(n) + " " + result;
        }
   }
}
