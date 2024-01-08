using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dtp_BirthDate.Value;
            DateTime currentDate = DateTime.Now;

            try
            {
                if (birthDate.Year > 2015)
                {
                    lbl_Result.Text = "Data inválida. Ano deve ser até 2015.";
                }
                else
                {
                    int age = currentDate.Year - birthDate.Year;

                    // Se ainda não fez aniversário este ano, diminui um ano da idade
                    if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                    {
                        age--;
                    }

                    lbl_Result.Text = $"Idade: {age} ANOS";
                }
            }
            catch (Exception ex)
            {
                lbl_Result.Text = $"Erro: {ex.Message}";
            }
        }
    }
}
