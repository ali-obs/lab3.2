using System;
using System.Windows.Forms;

namespace lab3._2
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

        private int SumDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        private int CountEvenDigits(int number)
        {
            int count = 0;
            number = Math.Abs(number);
            if (number == 0) return 1;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }

        private void btnSumDigits_Click(object sender, EventArgs e)
        {
            string inputText = GetTextBoxText();

            if (!int.TryParse(inputText, out int number))
            {
                SetResultText("Please enter a valid integer.");
                return;
            }

            if (number < 0)
            {
                SetResultText("Please enter a non-negative integer.");
                return;
            }

            int result = SumDigits(number);
            SetResultText(result.ToString());
        }

        private void btnCountEven_Click(object sender, EventArgs e)
        {
            string inputText = GetTextBoxText();

            if (!int.TryParse(inputText, out int number))
            {
                SetResultText("Please enter a valid integer.");
                return;
            }

            if (number < 0)
            {
                SetResultText("Please enter a non-negative integer.");
                return;
            }

            int result = CountEvenDigits(number);
            SetResultText(result.ToString());
        }

        private string GetTextBoxText()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                    return txt.Text;
            }
            return string.Empty;
        }

        private void SetResultText(string text)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.Text = text;
                    return;
                }
            }
            MessageBox.Show(text);
        }
    }
}