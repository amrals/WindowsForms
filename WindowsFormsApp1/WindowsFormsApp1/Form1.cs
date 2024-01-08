using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            // check if is number
            string input = textBox1.Text;
            try
            {
                if (int.TryParse(input, out int number))
                {
                    if (number % 2 == 0)
                    {
                        lbl_Value.Text = $"{number} é Par";
                    }
                    else
                    {
                        lbl_Value.Text = $"{number} é Ímpar";
                    }
                }
                else
                {
                    lbl_Value.Text = "Por favor, insira um número válido.";
                }
            }
            catch (Exception ex)
            {
                lbl_Value.Text = $"Erro: {ex.Message}";
            }
        }
    }
}
