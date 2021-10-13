using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driveButton_Click(object sender, EventArgs e)
        {
            /// Create an if statement to check age and display a 
            /// message stating "You can drive now" if age is 16. 
            /// If not 16 then display, "You are not 16".

            int age = 16;

            if (age > 16)
            {
                driveOutput.Text = " You are NOT old enough to drive.";
            }
            else
            {
                driveOutput.Text = " You are old enough to drive.";
            }

        }

        private void ageButton_Click(object sender, EventArgs e)
        {
            /// Create a variable to hold a person's age. Then use 
            /// that variable to determine if the person is old 
            /// enough to vote. Display an appropriate message based
            /// on whether they can or can't vote            

            int age = Convert.ToInt16(ageInput.Text);

            if(age < 18)
            {
                voteOutput.Text = "You can't vote.";
            }
            else
            {
                voteOutput.Text = "You can vote.";
            }
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines how many overtime 
            /// hours an employee has worked. Any hours over 40 is 
            /// considered overtime. Make sure that your output matches
            /// the sample output below exactly.
            ///
            /// Sample Output for 15 hours:
            /// You worked 15 hours
            /// 
            /// Sample output for 45 hours:
            /// You worked 40 hours plus 5 hours overtime

            int totalHours = Convert.ToInt32(hoursInput.Text);
           
            if(totalHours > 40)
            {
                int overTime = totalHours - 40;
                workOutput.Text = $"You worked 40 hours plus {overTime} hrs overtime.";
            }
            else
            {
                workOutput.Text = $"You worked {totalHours} hours";
            }

        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines the max value 
            /// between 2 values inputted by the user. The output 
            /// should match the following:
            /// 
            /// Sample output for inputs 34, 12
            /// The max value is: 34
            /// 
            /// Sample output for inputs 22, 77
            /// The max value is: 77
            
            int number1 = Convert.ToInt32(num1Input.Text);
            int number2 = Convert.ToInt32(num2Input.Text);

            if(number1 > number2)
            {
                maxOutput.Text = $" The max value is: {number1}";
            }
            else
            {
                maxOutput.Text = $" The max value is: {number2}";
            }
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines if an entered year
            /// is a leap year. The output should match the following:
            /// 
            /// Sample output for inputs 2002
            /// 2002 is not a leap year
            /// 
            /// Sample output for inputs 2016
            /// 2016 is a leap year
           
            int year = Convert.ToInt32(yearInput.Text);

            //mod operation with % symbol
            //== (double equals) means the same as = (single equal symbol) in math. left side = right side
            // basically: if the year is divisible by 4 with a remainder of exactly 0, run this. else, run the other part.
            if (year % 4 == 0)
            {
                yearOutput.Text = $"{year} is a leap year";
            }
            else
            {
                yearOutput.Text = $"{year} is not a leap year";
            }

        }

        private void ageInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
