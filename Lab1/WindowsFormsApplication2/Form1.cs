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
    /// <summary>
    /// Class that creates a Windows Form with all the necessary
    /// components to create a simple UI to calculate the Fibonacci
    /// Sequence or the summation of a number.
    /// </summary>
    public partial class MathFunctions : Form
    {
        /// <summary>
        /// Constructor to create a MathFunction.
        /// </summary>
        public MathFunctions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks which radiobutton is chosen and opens a message box
        /// showing the result based on the number inside the textbox
        /// and the radiobutton chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcButton_Click(object sender, EventArgs e)
        {
            int answer = 0;

            if(fibButton.Checked)
            {
                MessageBox.Show(fibSeq(Convert.ToInt32(number.Text)));
            }
            if(sumButton.Checked)
            {
                answer = summation(Convert.ToInt16(number.Text));
                MessageBox.Show(answer.ToString());
            }
        }

        /// <summary>
        /// Performs the Fibonacci sequence. 
        /// Returns a string showing the Fibonacci sequence up to
        /// whatever number is chosen.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private String fibSeq(int num)
        {
            String ans = "";
            int[] sequence = new int[num + 1];

            sequence[0] = 0;
            sequence[1] = 1;
            
            for (int i = 2; i <= num; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
                ans += sequence[i].ToString();
                if(i < num)
                {
                    ans += ", ";
                }
                
            }

            return ans;
        }

        /// <summary>
        /// Performs a summation of numbers up to the number chosen.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int summation(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        
    }
}
