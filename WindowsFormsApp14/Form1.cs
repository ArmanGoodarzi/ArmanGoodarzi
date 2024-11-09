using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        private Car car;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = textBox1.Text;
                int speed = int.Parse(textBox2.Text);

                car = new Car(brand,speed);

                label1.Text = "Car Details: " + car.GetDetails();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for speed or brand.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Car
    {
        private string brand;
        private int speed;

        public Car(string b,int s)
        {
            brand = b;
            speed = s;
            MessageBox.Show($"Car created: Brand = {brand} , Speed = {speed}");
        }

        ~Car()
        {
            MessageBox.Show($"Car destroyed: Brand =  { brand} , Speed = {speed}" );
        }

        public string GetDetails()
        {
            return $"Brand: {brand}, Speed: {speed}";
        }
    }
}
