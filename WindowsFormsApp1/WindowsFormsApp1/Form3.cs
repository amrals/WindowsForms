using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                double kelvin = celsius + 273.15;

                lbl_Result_F.Text = $"Fahrenheit: {fahrenheit}";
                lbl_Result_K.Text = $"Kelvin: {kelvin}";
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}
