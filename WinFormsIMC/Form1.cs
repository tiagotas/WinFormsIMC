using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double imc = peso / (altura * altura);

            lbl_resultado.Text = "Seu IMC é " + imc.ToString();
        }
    }
}
