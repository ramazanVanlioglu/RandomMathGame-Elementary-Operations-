using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMathGame
{
    public partial class GamePage : Form
    {
        Random random = new Random();
        string personalSign;

        private int correct = 0;
        private int mistakes = 0;


        public string[] signs = { "+", "-", "x", "/" };

        double num1; double num2;

        double result;
        public GamePage()
        {
            InitializeComponent();
        }

        public string playAnotherRound() // Button comparement will be the next step. //->01.04.23, 18.58 
        {

            int i = random.Next(0, signs.Length);
            num1 = random.Next(0, 101);
            num2 = random.Next(0, 101);
            label_num1.Text = num1.ToString();
            label_num2.Text = num2.ToString();
            switch (i)
            {
                case 0:
                    label_sign.Text = "?";
                    result = (num1 + num2);
                    label_result.Text = result.ToString();

                    break;
                case 1:
                    label_sign.Text = "?";
                    result = (num1 - num2);
                    label_result.Text = result.ToString();

                    break;

                case 2:
                    label_sign.Text = "?";
                    result = (num1 * num2);
                    label_result.Text = result.ToString();

                    break;
                case 3:
                    label_sign.Text = "?";
                    result = (num1 / num2);
                    label_result.Text = result.ToString();

                    break;

            }
            return label_sign.Text;

        }

        // Random numbers added.
        // We've created a method to redefine the numbers we have(num1,num2) as playAnotherRound().
        // Now we need to state the result and see if the answer is correct with the computer's one. 01.04.23, 02.05


        private void GamePage_Load(object sender, EventArgs e)
        {
            int i = random.Next(0, signs.Length);
            num1 = random.Next(0, 101);
            num2 = random.Next(0, 101);
            label_num1.Text = num1.ToString();
            label_num2.Text = num2.ToString();


            switch (i)
            {
                case 0:
                    label_sign.Text = "?";
                    result = (num1 + num2);
                    label_result.Text = result.ToString();


                    break;
                case 1:
                    label_sign.Text = "?";
                    result = (num1 - num2);
                    label_result.Text = result.ToString();

                    break;

                case 2:
                    label_sign.Text = "?";
                    result = (num1 * num2);
                    label_result.Text = result.ToString();

                    break;
                case 3:
                    label_sign.Text = "?";
                    result = (num1 / num2);
                    label_result.Text = result.ToString();
                    break;

            }

        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            personalSign = "+";
            string sign = playAnotherRound();
            if (personalSign == sign)
            {
                correct++;
                label_correct.Text = "Corrects: " + correct;
            }
            else
            {
                mistakes++;
                label_mistakes.Text = "Mistakes: " + mistakes;
            }
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            personalSign = "-";
            string sign = playAnotherRound();
            if (personalSign == sign)
            {
                correct++;
                label_correct.Text = "Corrects: " + correct;
            }
            else
            {
                mistakes++;
                label_mistakes.Text = "Mistakes: " + mistakes;
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            personalSign = "x";
            string sign = playAnotherRound();
            if (personalSign == sign)
            {
                correct++;
                label_correct.Text = "Corrects: " + correct;
            }
            else
            {
                mistakes++;
                label_mistakes.Text = "Mistakes: " + mistakes;
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            personalSign = "/";
            string sign = playAnotherRound();
            if (personalSign == sign)
            {
                correct++;
                label_correct.Text = "Corrects: " + correct;
            }
            else
            {
                mistakes++;
                label_mistakes.Text = "Mistakes: " + mistakes;
            }
        }


    }
}
