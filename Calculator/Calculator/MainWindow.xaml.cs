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

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)  //CLick on the Add Button 
        {
            int output = Int32.Parse(Value1.Text) + Int32.Parse(Value2.Text);  //Add the value from Text box 1 and add with Text Box 2 

            Result.Text = output.ToString();  //Take the "output" value from line above and push that value into my Result text box
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(Value1.Text) - Int32.Parse(Value2.Text);  //Subtract the value from Text box 1 and add with Text Box 2 

            Result.Text = output.ToString();  //Take the "output" value from line above and push that value into my Result text box

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(Value1.Text) * Int32.Parse(Value2.Text);  //Multiply the value from Text box 1 and add with Text Box 2 

            Result.Text = output.ToString();  //Take the "output" value from line above and push that value into my Result text box
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(Value1.Text) / Int32.Parse(Value2.Text);  //Divide the value from Text box 1 and add with Text Box 2 

            Result.Text = output.ToString();  //Take the "output" value from line above and push that value into my Result text box
        }

        private void Mod_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(Value1.Text) % Int32.Parse(Value2.Text);  //Mod the value from Text box 1 and add with Text Box 2 

            Result.Text = output.ToString();  //Take the "output" value from line above and push that value into my Result text box

        }

        private void ClearAllButton(object sender, RoutedEventArgs e)
        {
            Value1.Text = string.Empty; //Empty the Top Text Box
            Value2.Text = string.Empty; //Empty the Bottom Text Box
            Result.Text = string.Empty; //Empty the Result Text Box

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }     
}
 