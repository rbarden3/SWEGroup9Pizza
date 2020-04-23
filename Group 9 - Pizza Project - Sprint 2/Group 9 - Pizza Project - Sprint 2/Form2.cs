<<<<<<< HEAD
﻿using System;
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
        int checkCounter = 0;
        /// <summary>
        /// I added these variables in case anyone wanted to have a receipt
        /// </summary>
        double total = 0;
        String size = "";
        String crust = "";
        String sauce = "";
        String cheese = "";
        String toppings = "";
        String drink = "";
        String drinkSize = "";

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
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                cheese = "Mozzarella";
            }
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

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkCounter >= 4)
            {
                checkBox1.CheckedChanged -= checkBox1_CheckedChanged;
                checkBox1.Checked = false;
                checkBox1.CheckedChanged += checkBox1_CheckedChanged;
                return;
            }

            if (checkBox1.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkCounter >= 4)
            {
                checkBox2.CheckedChanged -= checkBox2_CheckedChanged;
                checkBox2.Checked = false;
                checkBox2.CheckedChanged += checkBox2_CheckedChanged;
                return;
            }
            if (checkBox2.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void splitContainer13_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true && checkCounter >= 4)
            {
                checkBox4.CheckedChanged -= checkBox4_CheckedChanged;
                checkBox4.Checked = false;
                checkBox4.CheckedChanged += checkBox4_CheckedChanged;
                return;
            }
            if (checkBox4.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true && checkCounter >= 4)
            {
                checkBox5.CheckedChanged -= checkBox5_CheckedChanged;
                checkBox5.Checked = false;
                checkBox5.CheckedChanged += checkBox5_CheckedChanged;
                return;
            }

            if (checkBox5.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                total += 4;
                size = "Small";
            }
            else
                total -= 4;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                total += 5;
                size = "Medium";
            }
            else
                total -= 5;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                total += 6;
                size = "Large";
            }
            else
                total -= 6;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                total += 7;
                size = "Extra-Large";
            }
            else
                total -= 7;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                crust = "Brooklyn Style";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                crust = "Hand Tossed";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                crust = "Thin Crust";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                crust = "Deep Dish";
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                cheese = "Cheddar";
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                cheese = "Swiss";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                cheese = "Provalone";
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                sauce = "Tomato Sauce";
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                sauce = "BBQ Sauce";
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                sauce = "White Sauce";
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                sauce = "Pesto";
            }
        }

        private void splitContainer14_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBeef_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeef.Checked == true && checkCounter >= 4)
            {
                chkBeef.CheckedChanged -= chkBeef_CheckedChanged;
                chkBeef.Checked = false;
                chkBeef.CheckedChanged += chkBeef_CheckedChanged;
                return;
            }

            if (chkBeef.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHam.Checked == true && checkCounter >= 4)
            {
                chkHam.CheckedChanged -= chkHam_CheckedChanged;
                chkHam.Checked = false;
                chkHam.CheckedChanged += chkHam_CheckedChanged;
                return;
            }

            if (chkHam.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnions.Checked == true && checkCounter >= 4)
            {
                chkOnions.CheckedChanged -= chkOnions_CheckedChanged;
                chkOnions.Checked = false;
                chkOnions.CheckedChanged += chkOnions_CheckedChanged;
                return;
            }

            if (chkOnions.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked == true && checkCounter >= 4)
            {
                chkOlives.CheckedChanged -= chkOlives_CheckedChanged;
                chkOlives.Checked = false;
                chkOlives.CheckedChanged += chkOlives_CheckedChanged;
                return;
            }

            if (chkOlives.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void chkJalapenos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJalapenos.Checked == true && checkCounter >= 4)
            {
                chkJalapenos.CheckedChanged -= chkJalapenos_CheckedChanged;
                chkJalapenos.Checked = false;
                chkJalapenos.CheckedChanged += chkJalapenos_CheckedChanged;
                return;
            }
            if (chkJalapenos.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked == true && checkCounter >= 4)
            {
                chkTomatoes.CheckedChanged -= chkTomatoes_CheckedChanged;
                chkTomatoes.Checked = false;
                chkTomatoes.CheckedChanged += chkTomatoes_CheckedChanged;
                return;
            }

            if (chkTomatoes.Checked)
            {
                total += 2;
                checkCounter++;
            }
            else
            {
                total -= 2;
                checkCounter--;
            }
            label1.Text = "$" + total.ToString();
        }

        private void radioButton20_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drink = "None";
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drink = "Coke";
                total += 2;
            }
            else
                total -= 2;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drink = "Diet Coke";
                total += 2;
            }
            else
                total -= 2;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drink = "Sprite";
                total += 2;
            }
            else
                total -= 2;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drink = "Tea";
                total += 2;
            }
            else
                total -= 2;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drink = "Water";
                total += 1;
            }
            else
                total -= 1;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drinkSize = "Small";
            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drinkSize = "Medium";
                total += .25;
            }
            else
                total -= .25;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drinkSize = "Large";
                total += .50;
            }
            else
                total -= .50;
            label1.Text = "$" + total.ToString();
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                drinkSize = "Extra Large";
                total += .75;
            }
            else
                total -= .75;
            label1.Text = "$" + total.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
=======
﻿using System;
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CartForm cf = new CartForm();
            cf.ShowDialog();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> 1a2c6262fcbafb878f2a51b7f53a6ed7fb535176
