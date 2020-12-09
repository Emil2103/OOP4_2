using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4_2
{
    public partial class Form1 : Form
    {
        //public int a = 35;
        //public int b = 78;
        Model model;
        public Form1()
        {
            InitializeComponent();
           // textBox_Num1.Text = a.ToString();
           // numericUpDown_Num1.Value = a;
           // label_Num1.Text = a.ToString();
           // textBox_Num2.Text = b.ToString();
           // numericUpDown_Num2.Value = b;
           // label_Num2.Text = b.ToString();
            model = new Model();
            
            model.observers += new System.EventHandler(this.UpdateFromModel);
            model.observers.Invoke(model, null);
        }

        

        private void textBox_Num1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox_Num2.Text = model.chekString(textBox_Num2.Text);
                model.setValue1(Int32.Parse(textBox_Num1.Text), Int32.Parse(textBox_Num2.Text));
            }

               /* if (e.KeyCode == Keys.Enter)
                {
                    if (textBox_Num2.Text == "" || Int32.Parse(textBox_Num1.Text) < Int32.Parse(textBox_Num2.Text))
                    {
                        numericUpDown_Num1.Value = Int32.Parse(textBox_Num1.Text);
                        label_Num1.Text = textBox_Num1.Text;
                    }
                    else
                        MessageBox.Show("Введите значение меньше чем справа");
                }*/
        }

        private void numericUpDown_Num1_ValueChanged(object sender, EventArgs e)
        {
            model.setValue1(Decimal.ToInt32(numericUpDown_Num1.Value), Decimal.ToInt32(numericUpDown_Num2.Value));

            /*if (numericUpDown_Num2.Value == 0 || numericUpDown_Num1.Value < numericUpDown_Num2.Value)
            {
                textBox_Num1.Text = numericUpDown_Num1.Value.ToString();
                label_Num1.Text = numericUpDown_Num1.Value.ToString();
            }
            else
                MessageBox.Show("Введите значение меньше чем справа");*/
        }

        private void textBox_Num2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_Num1.Text = model.chekString(textBox_Num1.Text);
                model.setValue2(Int32.Parse(textBox_Num1.Text), Int32.Parse(textBox_Num2.Text));
            }

            /*if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Num1.Text == "" || Int32.Parse(textBox_Num2.Text) > Int32.Parse(textBox_Num1.Text))
                {
                    numericUpDown_Num2.Value = Int32.Parse(textBox_Num2.Text);
                    label_Num2.Text = textBox_Num2.Text;
                }
                else
                    MessageBox.Show("Введите значение больше чем слева");
            }*/
        }

        private void numericUpDown_Num2_ValueChanged(object sender, EventArgs e)
        {
            model.setValue2(Decimal.ToInt32(numericUpDown_Num1.Value), Decimal.ToInt32(numericUpDown_Num2.Value));

            /* if (numericUpDown_Num1.Value == 0 || numericUpDown_Num2.Value > numericUpDown_Num1.Value)
             {
                 textBox_Num2.Text = numericUpDown_Num2.Value.ToString();
                 label_Num2.Text = numericUpDown_Num2.Value.ToString();
             }
             else
                 MessageBox.Show("Введите значение больше чем слева");*/
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBox_Num1.Text = model.getValue1().ToString();
            numericUpDown_Num1.Value = model.getValue1();
            label_Num1.Text = model.getValue1().ToString();

            textBox_Num2.Text = model.getValue2().ToString();
            numericUpDown_Num2.Value = model.getValue2();
            label_Num2.Text = model.getValue2().ToString();
        }
    }

    public class Model
    {

        public int value1 = 35;
        public int value2 = 78;
        public System.EventHandler observers;
            
        public void setValue1(int value1, int value2)
        {
            if (value2 > value1 || value2 == 0)
                this.value1 = value1;
            else
                MessageBox.Show("Введите число меньше чем справа");
            observers.Invoke(this, null);
        }
        
        public void setValue2(int value1, int value2)
        {
            if (value2 > value1 || value1 == 0)
            {
                    this.value2 = value2;
            }
            else
                MessageBox.Show("Введите число больше чем слева");
            observers.Invoke(this, null);
        }

        public string chekString(string value)
        {
            if (value == "")
                value = "0";
            return value;
        }

        public int getValue1()
        {
            return value1;
        }

        public int getValue2()
        {
            return value2;
        }
    }
}
