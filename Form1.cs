using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        //acrescentar valor bool(falso)
        double valor = 0;
        string operacao = "";
        bool operacao_pressionada = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            //modificar operador de instrução 
            // && ou || para (or)
            if ((resultado.Text == "0") ||(operacao_pressionada))
            {
                resultado.Clear();
            }
            Button b = (Button)sender;
            resultado.Text = resultado.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        private void operador_click(object sender, EventArgs e)
        {
            //chamar butao de cima
            Button b = (Button)sender;
            operacao = b.Text;
            valor = Double.Parse(resultado.Text);
            operacao_pressionada = true;
            equacao.Text = valor + " " + operacao;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equacao.Text = "";
            switch (operacao)
            {
                
                case "+":
                    resultado.Text = (valor + Double.Parse(resultado.Text)).ToString(); break;
                case "-":
                    resultado.Text = (valor - Double.Parse(resultado.Text)).ToString(); break;
                case "*":
                    resultado.Text = (valor * Double.Parse(resultado.Text)).ToString(); break;
                case "/":
                    resultado.Text = (valor / Double.Parse(resultado.Text)).ToString(); break;
                default:
                    break;
            }//fechar switch
            //colocar operação falsa de novo
            operacao_pressionada = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            valor = 0;
        }
    }
}
