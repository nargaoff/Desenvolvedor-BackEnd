using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendas.Classes.Contextos;

namespace Vendas
{
    public partial class Form2 : Form
    {
        //Campos
        VendasContexto vendasContexto = new VendasContexto();




        //Construtor
        public Form2()
        {
            InitializeComponent();


        }

        //Metodos
        void CarregarDados(string filtro = "")
        {

            var listaDeVendas = vendasContexto.Vendas.ToList();
            dataGridView1.DataSource = listaDeVendas;
            switch (filtro)
            {
                case "Id":
                    dataGridView1.DataSource = listaDeVendas.Where(v => v.Id == int.Parse(textBox1.Text)).ToList();
                    break;
                case "DataCompra":
                    //Pesquisar pela data de compra
                    dataGridView1.DataSource = listaDeVendas.Where(v => v.DataCompra.ToString().Contains(textBox1.Text)).ToList();
                    break;
                case "Tipo":
                    //Pesquisar pelo tipo
                    dataGridView1.DataSource = listaDeVendas.Where(v => v.Tipo.Contains(textBox1.Text)).ToList();
                    break;
                case "Marca":
                    //Pesquisar pela marca
                    dataGridView1.DataSource = listaDeVendas.Where(v => v.Marca.Contains(textBox1.Text)).ToList();
                    break;
                default:
                    dataGridView1.DataSource = listaDeVendas;
                    break;
            }

        }

        //Eventos

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.IsNullOrEmpty())
            {
                CarregarDados();
            }
            else if (radioButton1.Checked)
            {
                CarregarDados("Id");
            }
            else if (radioButton2.Checked)
            {
                CarregarDados("DataCompra");
            }
            else if (radioButton3.Checked)
            {
                CarregarDados("Tipo");
            }
            else if (radioButton4.Checked)
            {
                CarregarDados("Marca");
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var listaDeVenda = vendasContexto.Vendas.ToList();
            var linhaselecionada = dataGridView1.SelectedRows[0];

            Consulta.SelectedTab = tabPage2;
            textBox2.Text = linhaselecionada.Cells["Id"].Value.ToString();
            textBox3.Text = linhaselecionada.Cells["DataCompra"].Value.ToString();
            textBox4.Text = linhaselecionada.Cells["Tipo"].Value.ToString();
            textBox5.Text = linhaselecionada.Cells["Marca"].Value.ToString();
            textBox6.Text = linhaselecionada.Cells["Faturamento"].Value.ToString();
            textBox7.Text = linhaselecionada.Cells["Lucro"].Value.ToString();
            Consulta.SelectedTab = tabPage2;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var chave = Keys.Enter;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
        }
    }
}

