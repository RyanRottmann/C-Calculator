using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double value1 = 0;
        public int selector = 0;// default position no previous numbers
        public double savedValue = 0;
        bool savedBool = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
            value1 = 0;
            selector = 0;
            textBlock1.Text = "";
        }

        private void MPlus_Click(object sender, RoutedEventArgs e)// adds textblock value to saved value
        {
            if(savedBool == false && textBlock.Text != "")
            {
                savedValue = double.Parse(textBlock.Text);
                textBlock1_Copy.Text = savedValue.ToString();
                savedBool = true;
            } else if (savedBool == true && textBlock.Text != "")
            {
                savedValue += double.Parse(textBlock.Text);
                textBlock1_Copy.Text = savedValue.ToString();
            }
        }
        private void MMinus_Click(object sender, RoutedEventArgs e)// subtracts textblock value from saved value
        {
            if (savedBool == true && textBlock.Text != "")
            {
                savedValue -= double.Parse(textBlock.Text);
                textBlock1_Copy.Text = savedValue.ToString();
            }
        }

        private void MRecall_Click(object sender, RoutedEventArgs e)// prints stored value to textblock
        {
            if (savedBool == true && textBlock.Text == "")
            {
                textBlock.Text += savedValue.ToString();
            }
        }

        private void MClear_Click(object sender, RoutedEventArgs e)// clears stored value
        {
            if(savedBool == true)
            {
                savedValue = 0;
                savedBool = false;
                textBlock1_Copy.Text = "";
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "")
            {
                if (selector == 0)// this is first operation preformed
                {
                    value1 = double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 1)// addition is to be performed
                {
                    value1 = value1 + double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 2)// subtraction is to be performed
                {
                    value1 = value1 - double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 3)// multiplication is to be performed
                {
                    value1 = value1 * double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 4)// division is to be performed
                {
                    value1 = value1 / double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }

                selector = 4;
            }
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "")
            {
                if (selector == 0)// this is first operation preformed
                {
                    value1 = double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 1)// addition is to be performed
                {
                    value1 = value1 + double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 2)// subtraction is to be performed
                {
                    value1 = value1 - double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 3)// multiplication is to be performed
                {
                    value1 = value1 * double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 4)// division is to be performed
                {
                    value1 = value1 / double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                selector = 3;
            }
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "")
            {
                if (selector == 0)// this is first operation preformed
                {
                    value1 = double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 1)// addition is to be performed
                {
                    value1 = value1 + double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 2)// subtraction is to be performed
                {
                    value1 = value1 - double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 3)// multiplication is to be performed
                {
                    value1 = value1 * double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 4)// division is to be performed
                {
                    value1 = value1 / double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                selector = 2;
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "")
            {
                if (selector == 0)// this is first operation preformed
                {
                    value1 = double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 1)// addition is to be performed
                {
                    value1 = value1 + double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 2)// subtraction is to be performed
                {
                    value1 = value1 - double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 3)// multiplication is to be performed
                {
                    value1 = value1 * double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                else if (selector == 4)// division is to be performed
                {
                    value1 = value1 / double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = "";
                }
                selector = 1;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text != "")
            {
                if (selector == 0)// this is first operation preformed
                {
                    value1 = double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = value1.ToString();
                }
                else if (selector == 1)// addition is to be performed
                {
                    value1 = value1 + double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = value1.ToString();
                }
                else if (selector == 2)// subtraction is to be performed
                {
                    value1 = value1 - double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = value1.ToString();
                }
                else if (selector == 3)// multiplication is to be performed
                {
                    value1 = value1 * double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = value1.ToString();
                }
                else if (selector == 4)// division is to be performed
                {
                    value1 = value1 / double.Parse(textBlock.Text);
                    textBlock1.Text = value1.ToString();
                    textBlock.Text = value1.ToString();
                }
                selector = 0;
            }
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 0;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {

            textBlock.Text = textBlock.Text + 2;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 3;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 4;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 5;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 6;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 7;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 8;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 9;
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + ".";
        }
    }
}
/*
if (currentValue == 0)
{
currentValue = double.Parse(nowValue.ToString());
}
else
{
currentValueString = currentValue.ToString();
currentValueStringArray = currentValueString.ToCharArray();

for(int i=0; i<currentValueStringArray.Length; i++)
{
Console.WriteLine(currentValueStringArray[i]);

}

}
textBlock.Text = nowValue.ToString();


        private void Plus_Click(object sender, RoutedEventArgs e)
        {

            pastValue += double.Parse(textBlock.Text);
            textBlock.Text = "";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            pastValue = pastValue + double.Parse(textBlock.Text);
            textBlock.Text = pastValue.ToString();
            pastValue = 0;
        }

*/
