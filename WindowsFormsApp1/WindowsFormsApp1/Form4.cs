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
    public partial class Form4 : Form
    {
        private List<int> numbers = new List<int> { -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 };

        public Form4()
        {
            InitializeComponent();
            lbl_Numbers.Text = string.Join(", ", numbers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var convertedList = numbers.Select(n => n >= 0 ? "POSITIVO" : "NEGATIVO").ToList();
            lbl_Result.Text = string.Join(", ", convertedList);
        }
    }
}
