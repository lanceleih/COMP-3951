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
        // Heyyyy you.
        public Form1()
        {
            InitializeComponent();
        }

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

        private int summation(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum = sum + i * 1;
            }
            return sum;
        }
        
    }
}
