
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Purpose: Develop a calculator to practice using visual studio.
/// Input: /
/// Output: /
/// Author: Benjamin Hao, Lancelei Herradura
/// Date: January 22, 2017
/// Updated by: Benjamin Hao, Lancelei Herradura
/// Date: January 23, 2017
/// </summary>
namespace Lab2
{
    public partial class Form1 : Form
    {
        float result = 0; // Result value
        float tmp = 0; // Temporary result
        float i; // buffer, making input to next bit.
        int num = 0; // Opreation times
        int opt = 0; // This int determines if we need further culculation.
        string operation = ""; // Get operator value
        private bool nonNumberEntered = false; //// Boolean flag used to determine when a character other than a number is entered.
        bool awake = false; // Determine the calculator is on or off


        public Form1()
        {
            InitializeComponent();

            // Disable buttons before turning calculator on
            turn_OffCalculator();
        }

        /// <summary>
        /// Purpose: To get numbers.
        /// Input: sender
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Benjamin Hao, Lancelei Herradura
        /// Date: January 23, 2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // Request for a a new calculation
            if (awake == false || button.Text == "C")
            {
                DisplayBox.Clear();
                result = 0;
                opt = 0;
                num = 0;
                awake = true;
            }

            DisplayBox.Focus(); // focusing displaybox
            DisplayBox.SelectionStart = DisplayBox.Text.Length; // setting cursor at the end of text
            if (button.Text == "CE" || button.Text == "C")
            {
                DisplayBox.Clear();
                tmp = 0;
            }
            else // display tmp value
            {
                i = float.Parse(button.Text.ToString());
                tmp = tmp * 10 + i;
                DisplayBox.Text = tmp.ToString();
                DisplayBox.SelectionStart = DisplayBox.Text.Length; // setting cursor at the end of text

            }

        }

        /// <summary>
        /// Purpose: To calculate.
        /// Input: void
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Benjamin Hao, Lancelei Herradura
        /// Date: January 23, 2017
        /// </summary>
        private void calculate()
        {
            if (num == 0) //determine if there is an operation; return 0 if none.
            {
                result = 0;
                tmp = 0;
                DisplayBox.Text = result.ToString();
                DisplayBox.SelectionStart = DisplayBox.Text.Length; // setting cursor at the end of text
                return;
            }
            // Determine result with the chosen operation
            switch (opt)
            {
                case 1:
                    result += tmp;
                    break;
                case 2:
                    result -= tmp;
                    break;
                case 3:
                    result *= tmp;
                    break;
                case 4:
                    try // Division by zero exception
                    {
                        result /= tmp;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Division by zero exception");

                    }
                    break;
                default:
                    return;
            }
            DisplayBox.Text = result.ToString();// Display the result.
            DisplayBox.SelectionStart = DisplayBox.Text.Length; // setting cursor at the end of text
            opt = 0; //clear operation.
            tmp = 0; // clear tmp value.
        }

        /// <summary>
        /// Purpose: To apply operator and determine if there are futher operations.
        /// Input: sender
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Benjamin Hao
        /// Date: January 23, 2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOperator_Click(object sender, EventArgs e)
        {
            if ((string)sender == "+" || (string)sender == "-"|| (string)sender == "*"|| (string)sender == "/")
            {// if input by keyboard
                operation = (string)sender;
            } else
            {//if input by button
                Button button = (Button)sender;
                operation = button.Text;
            }
                
            switch (operation)
            {
                case "+":
                    if (opt != 0 && opt != 1)
                    {
                        calculate();
                    }
                    opt = 1;
                    if (num != 0) // check the operation times
                    {
                        if (tmp != 0)
                            result = result + tmp;
                    }
                    else
                        result = tmp;
                    num++;
                    tmp = 0;
                    DisplayBox.Text = result.ToString();
                    break;
                case "-":
                    if (opt != 0 && opt != 2)
                    {
                        calculate();
                    }
                    opt = 2;
                    if (num != 0) // check the operation times
                    {
                        if (tmp != 0)
                            result = result - tmp;
                    }
                    else
                        result = tmp;
                    num++;
                    tmp = 0;
                    DisplayBox.Text = result.ToString();
                    break;
                case "*":
                    if (opt != 0 && opt != 3)
                    {
                        calculate();
                    }
                    opt = 3;
                    if (num != 0) // check the operation times
                    {
                        if (tmp != 0)
                            result = result * tmp;
                    }
                    else
                        result = tmp;
                    num++;
                    tmp = 0;
                    DisplayBox.Text = result.ToString();
                    break;
                case "/":
                    if (opt != 0 && opt != 4)
                    {
                        calculate();
                    }
                    opt = 4;
                    if (num != 0) // check the operation times
                    {
                        if (tmp != 0)
                            try //Division by zero exception
                            {
                                result = result / tmp;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Division by zero exception");

                            }
                        
                    }
                    else
                        result = tmp;
                    num++;
                    tmp = 0;
                    DisplayBox.Text = result.ToString();
                    break;
            }
            DisplayBox.SelectionStart = DisplayBox.Text.Length; // setting cursor at the end of text
        }

        /// <summary>
        /// Purpose: To calculate the sesult.
        /// Input: sender
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Benjamin Hao, Lancelei Herradura
        /// Date: January 23, 2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calculate();
        }


        /// <summary>
        /// Purpose: KeyPress and KeyDown functions that allow user input by using keyboard.
        /// Input: sender
        /// Output: void
        /// Author: Microsoft
        /// Date: June 21, 2011
        /// Updated by: Benjamin Hao
        /// Date: January 23, 2017
        /// Based on: https://msdn.microsoft.com/en-us/library/system.windows.forms.control.keypress(v=vs.110).aspx
        /// </summary>
        /// Handle the KeyDown event to determine the type of character entered into the control.
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

                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        //This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void DisplayBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (awake == false)
            {
                DisplayBox.Clear();
                result = 0;
                awake = true;
            }
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Determine what calculator function will be executed
                // Implement and execute the equals button
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    calculate();
                    DisplayBox.Clear();
                    DisplayBox.Text += result.ToString();

                }
                // Implement and execute technical functions of calculator
                else if (e.KeyChar == 'h' || e.KeyChar == 'j' || e.KeyChar == 'k' || e.KeyChar == 'l')
                {
                    switch (e.KeyChar)
                    {
                        case 'h': // on button
                            turn_OnCalculator();
                            awake = false;
                            break;
                        case 'j': // off button
                            turn_OffCalculator();
                            break;
                        case 'k': // C Function
                            DisplayBox.Clear();
                            result = 0;
                            opt = 0;
                            num = 0;
                            break;
                        case 'l': // CE Function
                            DisplayBox.Clear();
                            tmp = 0;
                            break;
                    }
                }
                // Implement and execute operator and calculate the result
                else
                {
                    switch (e.KeyChar)
                    {
                        case '+':
                            tmp = float.Parse(DisplayBox.Text.ToString());
                            buttonOperator_Click("+",e);
                            DisplayBox.SelectAll();
                            break;
                        case '-':
                            tmp = float.Parse(DisplayBox.Text.ToString());
                            buttonOperator_Click("-", e);
                            DisplayBox.SelectAll();
                            break;
                        case '*':
                            tmp = float.Parse(DisplayBox.Text.ToString());
                            DisplayBox.SelectAll();
                            buttonOperator_Click("*", e);
                            break;
                        case '/':
                            tmp = float.Parse(DisplayBox.Text.ToString());
                            buttonOperator_Click("/", e);
                            DisplayBox.SelectAll();
                            break;
                        case '=':
                            tmp = float.Parse(DisplayBox.Text.ToString());
                            calculate();
                            DisplayBox.SelectionStart = DisplayBox.Text.Length; // setting cursor at the end of text
                            break;
                    }

                    // Stop the character from being entered into the control since it is non-numerical.
                    e.Handled = true;
                    }
                }
        }

        /// <summary>
        /// Purpose: Turns on the calculator using on button and enabling the buttons
        /// for use.
        /// Input: object sender, EventArgs e
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Lancelei Herradura
        /// Date: January 23, 2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOn_Click(object sender, EventArgs e)
        {
            turn_OnCalculator();
        }

        /// <summary>
        /// Purpose: Turns off the calculator using button the off button and
        /// disabling the buttons for use.
        /// Input: object sender, EventArgs
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Lancelei Herradura
        /// Date: January 23, 2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOff_Click(object sender, EventArgs e)
        {
            turn_OffCalculator();
        }

        /// <summary>
        /// Purpose: Enables the buttons of the calculator while disabling the on button.
        /// Input: void
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Lancelei Herradura
        /// Date: January 23, 2017
        /// </summary>
        private void turn_OnCalculator()
        {
            panel2.Visible = true;

            List<Control> list = new List<Control>();

            // Retrieve all controls and put into list
            GetAllControl(this, list);

            // Enable all buttons, but disable the ButtonOn
            foreach (Control control in list)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (control != ButtonOn)
                    {
                        control.Enabled = true;
                    }
                    else
                    {
                        control.Enabled = false;
                    }

                }
            }

        }

        /// <summary>
        /// Purpose: Disables all buttons, but the on button, to prevent the 
        /// user from inputing any values onto the calculator.
        /// Input: void
        /// Output: void
        /// Author: Benjamin Hao, Lancelei Herradura
        /// Date: January 22, 2017
        /// Updated by: Lancelei Herradura
        /// Date: January 23, 2017
        /// </summary>
        private void turn_OffCalculator()
        {
            panel2.Visible = false;
            DisplayBox.Text = "";
            List<Control> list = new List<Control>();

            // Retrieve all controls and put into the lsit
            GetAllControl(this, list);

            // Disable all buttons, but the ButtonOn
            foreach (Control control in list)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (control != ButtonOn)
                        control.Enabled = false;
                    else
                        control.Enabled = true;
                }
            }

        }

        /// <summary>
        /// Purpose: Gets all controls of the form and puts it in the list specified by user.
        /// Input: Control c, List<Control> list
        /// Output: void
        /// Author: Hashi
        /// Date: June 21, 2011
        /// Updated by: Lancelei Herradura
        /// Date: January 23, 2017
        /// Based on: http://stackoverflow.com/questions/6421292/how-can-i-get-the-button-controls-in-windows-form-panel
        /// </summary>
        /// <param name="c"></param>
        /// <param name="list"></param>
        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(control, list);
            }
        }
    }
}