using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the input from the TextBox
            string userInput = textBox1.Text;

            // Add the input to the ListBox
            listBox1.Items.Add(userInput);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBox1.SelectedIndex != -1)
            {
                // Remove the selected item
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBox1.SelectedIndex != -1)
            {
                // Get the index of the selected item
                int selectedIndex = listBox1.SelectedIndex;

                // Get the new value from the user input (assuming you have a TextBox for user input)
                string newValue = textBox1.Text;

                // Update the item in the ListBox
                listBox1.Items[selectedIndex] = newValue;
            }
            else
            {
                MessageBox.Show("Please select an item to change.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear all items from the ListBox
            listBox1.Items.Clear();
        }
    }
}
