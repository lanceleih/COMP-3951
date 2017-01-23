
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        int result = 0;
        int oldResult = 0;
        String operation = "";
        bool calculated = false;
        bool awake = false;
         
        public Form1()
        {
            InitializeComponent();

            // Disable buttons before turning calculator on
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            buttonAdd.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            ButtonC.Enabled = false;
            ButtonOff.Enabled = false;
            buttonEquals.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            ButtonCE.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // Request for a a new calculation
            if (awake == false || calculated || button.Text == "C")
            {
                DisplayBox.Clear();
                result = 0;
                calculated = false;
                awake = true;
            }

            DisplayBox.Focus();
            if(button.Text == "CE" || button.Text == "C")
            {
                DisplayBox.Clear();
            } else
            {
                DisplayBox.Text += button.Text;
            }
            
        }

        public void functions_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Int32.Parse(DisplayBox.Text);
            DisplayBox.Clear();
            if(calculated == true)
            {
                calculated = false;
            }
            
        }

        public void calculate(int val)
        {
            // Determine result with the chosen operation
            switch (operation)
            {
                case "+":
                    result += val;
                    break;
                case "-":
                    result -= val;
                    break;
                case "*":
                    result *= val;
                    break;
                case "/":
                    result /= val;
                    break;
            }
        }

        
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            // Calculate the value based on the operation and operand
            calculate(Int32.Parse(DisplayBox.Text));
            DisplayBox.Clear();
            DisplayBox.Text += result.ToString();
            calculated = true;
            
        }

       
        /// <summary>
        /// Can only input numbers.
        /// Copyied form website, need to change.
        /// </summary>
        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void DisplayBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                    switch(e.KeyCode)
                    {
                        case Keys.Add:
                            operation = "+";
                            DisplayBox.Clear();
                            break;
                        case Keys.Subtract:
                            operation = "-";
                            DisplayBox.Clear();
                            break;
                        case Keys.Multiply:
                            operation = "*";
                            DisplayBox.Clear();
                            break;
                        case Keys.Divide:
                            operation = "/";
                            DisplayBox.Clear();
                            break;
                        case Keys.Enter:
                            calculate(Int32.Parse(DisplayBox.Text));
                            DisplayBox.Clear();
                            DisplayBox.Text = result.ToString();
                            break;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void DisplayBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void ButtonOn_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            buttonAdd.Enabled = true;
            button13.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            ButtonC.Enabled = true;
            ButtonOff.Enabled = true;
            buttonEquals.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            ButtonCE.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            DisplayBox.Focus();
        }

        private void ButtonOff_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            buttonAdd.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            ButtonC.Enabled = false;
            ButtonOff.Enabled = false;
            buttonEquals.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            ButtonCE.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ADD}");
        }


    }
}