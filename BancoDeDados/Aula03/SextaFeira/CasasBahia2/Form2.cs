using CasasBahia2.Classes.Contextos;
using CasasBahia2.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CasasBahia2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }





        //tab 1 - botão para pesquisar item
        private void button1_Click(object sender, EventArgs e)
        {
           ProdutosContexto contexto = new ProdutosContexto();
            string cadastroNomeProduto = textBox1.Text;
            int quantidadeDeProduto = int.Parse(textBox2.Text);
            decimal valorDoProduto = decimal.Parse(textBox3.Text);

            Produtos produtos = new Produtos(cadastroNomeProduto, quantidadeDeProduto, valorDoProduto);

            contexto.Produtos.Add(produtos);
            contexto.SaveChanges();
            MessageBox.Show("Cadastro realizado com sucesso!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //tab 2 - botão para pesquisar item
        private void button2_Click(object sender, EventArgs e)
        {
            ProdutosContexto contextos = new ProdutosContexto();
            var produto = contextos.Produtos.FirstOrDefault(p => p.CodigoDoProduto == int.Parse( textBox4.Text));
            if(produto == null)
            {
                MessageBox.Show("Produto não cadastrado!");
            }
            else
            {
               MessageBox.Show(" ===Produto encontrado ===\n" +
                   $"Nome do produto: {produto.NomeDoProduto}\n" +
                   $"Quantidade em estoque: {produto.QuantidadeDeProduto}\n" +
                   $"Preço do produto: {produto.ValorDoProduto:c}");
            }

            textBox4.Text = "";
        }
        //tab 3 - botão para editar/pesquisar item
        private void button3_Click(object sender, EventArgs e)
        {

        }

    }

}
