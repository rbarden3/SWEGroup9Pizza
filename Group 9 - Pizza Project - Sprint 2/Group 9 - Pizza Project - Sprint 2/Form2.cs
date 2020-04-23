using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_9___Pizza_Project___Sprint_2
{
    public partial class Form2 : Form
    {
        
        CartForm cf = new CartForm();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string order = "Options: ";
            string toppings = "\n -- Toppings: ";
            Panel[] arr = {panel2, panel3, panel4, panel5, panel6, panel7  };
            foreach (Panel p in arr)
            {
                foreach (RadioButton r in p.Controls)
                {
                    if (r.Checked)
                    {
                        order += r.Text;
                        order += ", ";
                    }
                        
                }
            }

            // Determine if there are any items checked.  
            if (MeatToppingsBox.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results. 
                for (int x = 0; x < MeatToppingsBox.CheckedItems.Count; x++)
                {
                    toppings += MeatToppingsBox.CheckedItems[x].ToString();
                    toppings += ", ";
                }
            }

            // Determine if there are any items checked.  
            if (VeggieToppingsBox.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                for (int x = 0; x < VeggieToppingsBox.CheckedItems.Count; x++)
                {
                    toppings += VeggieToppingsBox.CheckedItems[x].ToString();
                    toppings += ", ";
                }
            }

            order += toppings;
            cf.listBox1.Items.Add(order);
            cf.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CartForm cf = new CartForm();
            cf.ShowDialog();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
