using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }//fim do construtor

        private void Soma_Click(object sender, EventArgs e)
        {
            try
            { 
                double num1 = Convert.ToDouble(textBox1.Text);//coletando numero 1
                double num2 = Convert.ToDouble(textBox2.Text);//coletando os numero 2
                double resultado = model.Somar(num1, num2);//gerando resultado
                Resultado.Text = "" + resultado;//resultado em tela
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão somar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da classe de texto para o primeiro número

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da classe de texto para o segundo número

        private void Subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//coletando numero 1
                double num2 = Convert.ToDouble(textBox2.Text);//coletando os numero 2
                double resultado = model.Subtracao(num1, num2);//gerando resultado
                Resultado.Text = "" + resultado;//resultado em tela 
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão subtrair

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Multiplicacao(num1, num2);
                Resultado.Text = "" + resultado;
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão multiplicar

        private void Divisao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Divisao(num1, num2);
                //tratando validação
                if (resultado == -1)
                {
                    Resultado.Text = "Impossivel dividir por zero!";
                }
                else
                {
                    Resultado.Text = "" + resultado;
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão divisão

        private void raizQuadrada_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//coletando numero 1
                double num2 = Convert.ToDouble(textBox2.Text);//coletando os numero 2
                double resultado = model.raiz(num1);//gerando resultado
                if (resultado == -1)
                {
                    Resultado.Text = "Impossível calcular raiz!";
                }
                else
                {
                    Resultado.Text = "" + resultado;//resultado em tela
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão raiz quadrada

        private void Pontencia_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//coletando numero 1
                double num2 = Convert.ToDouble(textBox2.Text);//coletando os numero 2
                double resultado = model.Potencia(num1, num2);//gerando resultado
                Resultado.Text = "" + resultado;//resultado em tela
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }// fim do botão pontencia

        private void Resultado_Click(object sender, EventArgs e)
        {

        }//fim da label resultado
    }// fim da classe
}//fim do projeto
