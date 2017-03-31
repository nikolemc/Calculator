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
            if(MyCurrentOperator == "")
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

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation();
        }

    }     
}
 