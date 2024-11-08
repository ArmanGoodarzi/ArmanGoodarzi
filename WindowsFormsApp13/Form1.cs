using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car
                {
                    Brand = textBox1.Text,
                    Speed = int.Parse(textBox2.Text)
                };

                label1.Text = car.GetCarInfo();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for speed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class Car
    {
        private string brand;
        private int speed;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0 && value <= 290)
                {
                    speed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Speed must be between 0 and 290.");
                }
            }
        }
        public string GetCarInfo()
        {
            return $"Brand: {Brand}, Speed: {Speed} km/h";
        }
    }
}

