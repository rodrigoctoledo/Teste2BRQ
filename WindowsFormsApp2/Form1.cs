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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalIdade_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataNas = DateTime.Parse(textBoxData.Text);
                DateTime dataLi = new DateTime(2015, 12, 31);
             

                if (dataNas > dataLi)
                    throw new ArgumentException("Data de nascimento inválida.");

                int idade = DateTime.Now.Year - dataNas.Year;

                if (DateTime.Now < dataNas.AddYears(idade))
                    idade--;

                MessageBox.Show($"Idade: {idade} anos.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira uma data válida.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
