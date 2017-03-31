using System;
using System.Collections.Generic;
using System.IO;
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
        string memoryPath = "Memory.txt";
        string MyCurrentOperator = "";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)  //CLick on the Add Button 
        {
            PerformOperation();
            MyCurrentOperator = "+";
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation();
            MyCurrentOperator = "-";

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation();
            MyCurrentOperator = "*";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation();
            MyCurrentOperator = "/";

        }

        private void Mod_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation();
            MyCurrentOperator = "%";

        }

        private void ClearAllButton(object sender, RoutedEventArgs e)
        {
            Value1.Text = string.Empty; //Empty the Top Text Box
            Value2.Text = string.Empty; //Empty the Bottom Text Box
            Result.Text = string.Empty; //Empty the Result Text Box
            MyCurrentOperator = "";

        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation();
        }

        private void MemoryAdd_Click(object sender, RoutedEventArgs e)
        {

            using (var writer = new StreamWriter(memoryPath))
            {
                writer.WriteLine(Result.Text);
            }
        }

        private void MemorySubtract_Click(object sender, RoutedEventArgs e)
        {
            using (var writer = new StreamWriter(memoryPath))
            {
                writer.WriteLine(Result.Text);
            }
        }

        private void MemoryRecall_Click(object sender, RoutedEventArgs e)
        {
            using (var reader = new StreamReader(memoryPath))
            {
                Result.Text = reader.ReadLine().ToString();
            }
        }

        private void MemoryClear_Click(object sender, RoutedEventArgs e)
        {
            using (var writer = new StreamWriter(memoryPath))
            {
                writer.WriteLine(string.Empty); //clears the txt file
                Result.Text = string.Empty; //Empty the Result Text Box
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "1";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "1";
                Result.Text = Value2.Text;
            }

        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "2";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "2";
                Result.Text = Value2.Text;
            }


        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {

            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "3";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "3";
                Result.Text = Value2.Text;
            }


        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "4";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "4";
                Result.Text = Value2.Text;
            }



        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "5";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "5";
                Result.Text = Value2.Text;
            }

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "6";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "6";
                Result.Text = Value2.Text;
            }


        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "7";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "7";
                Result.Text = Value2.Text;
            }




        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "8";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "8";
                Result.Text = Value2.Text;
            }



        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "9";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "9";
                Result.Text = Value2.Text;
            }


        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + "0";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + "0";
            }


        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            if (MyCurrentOperator == "")
            {
                Value1.Text = Value1.Text + ".";
                Result.Text = Value1.Text;
            }
            else
            {
                Value2.Text = Value2.Text + ".";
            }

        }

        public void PerformOperation() //this calculates the operation between value 1 and value 2, and then pushes that new value into value 1 containter and result container.
        {
            double output = 0;
            if (MyCurrentOperator == "+")
            {
                output = Convert.ToDouble(Value1.Text) + Convert.ToDouble(Value2.Text);
            }
            if (MyCurrentOperator == "-")
            {
                output = Convert.ToDouble(Value1.Text) - Convert.ToDouble(Value2.Text);
            }
            if (MyCurrentOperator == "*")
            {
                output = Convert.ToDouble(Value1.Text) * Convert.ToDouble(Value2.Text);
            }
            if (MyCurrentOperator == "/")
            {
                output = Convert.ToDouble(Value1.Text) / Convert.ToDouble(Value2.Text);
            }
            if (MyCurrentOperator == "%")
            {
                output = Convert.ToDouble(Value1.Text) % Convert.ToDouble(Value2.Text);
            }
            if (MyCurrentOperator != "")
            {
                Result.Text = output.ToString();  //Take the "output" value from line above and push that value into my Result text box
                Value1.Text = Result.Text;
                Value2.Text = "";
            }
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
        //}

        //void MainWindow_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.NumPad1)
        //    {
        //        Value1.Text = "1";
        //    }
        //}

        private void abuttonispressed(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                //click event is raised here
                Zero_Click(sender, e);
            }
            if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                //click event is raised here
                One_Click(sender, e);
            }
            if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                //click event is raised here
                Two_Click(sender, e);
            }
            if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                //click event is raised here
                Three_Click(sender, e);
            }
            if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                //click event is raised here
                Four_Click(sender, e);
            }
            if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                //click event is raised here
                Five_Click(sender, e);
            }
            if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                //click event is raised here
                Six_Click(sender, e);
            }
            if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                //click event is raised here
                Seven_Click(sender, e);
            }
            if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                //click event is raised here
                Eight_Click(sender, e);
            }
            if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                //click event is raised here
                Nine_Click(sender, e);
            }
            if (e.Key == Key.Add || e.Key == Key.A)
            {
                //click event is raised here
                AddButton_Click(sender, e);
            }
            if (e.Key == Key.Subtract || e.Key == Key.S)
            {
                //click event is raised here
                Subtract_Click(sender, e);
            }
            if (e.Key == Key.Multiply || e.Key == Key.M)
            {
                //click event is raised here
                Multiply_Click(sender, e);
            }
            if (e.Key == Key.Divide || e.Key == Key.D)
            {
                //click event is raised here
                Divide_Click(sender, e);
            }
      

        }
    }
}

 