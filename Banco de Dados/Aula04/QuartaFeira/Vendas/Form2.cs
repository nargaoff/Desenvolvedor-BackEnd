using Microsoft.EntityFrameworkCore;
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
        public Form2()
        {
            InitializeComponent();
            CarregarDados();
        }

        void CarregarDados()
        {
            try
            {
                VendasContexto contexto = new VendasContexto();
                var listaDeVendas = contexto.Vendas.ToList();
                dataGridView1.DataSource = listaDeVendas;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }





        }


    }
}

