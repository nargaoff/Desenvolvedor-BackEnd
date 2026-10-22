using System.Net.Http.Json;
using WinFormsApp1.Classes.DTO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Campo
        private readonly HttpClient http = new()
        {
            BaseAddress = new Uri("http://localhost:5035/")
        };
        //Rotas de requisição
        string rota1 = @"a0pi/Contas";



        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        //Método para carregar os dados no datagrid
        private async Task CarregarDados()
        {
            try
            {
                var contas = await http.GetFromJsonAsync<List<ContaBancariaDTO>>("api/Contas");
                dataGridView1.DataSource = contas;
                dataGridView2.DataSource = contas;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao carregar dados da API, erro -> {e.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = radioButton1.Checked;
            textBox2.Visible = radioButton1.Checked;
        }

        private async void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string titular = textBox1.Text;
            decimal saldo = decimal.Parse(textBox2.Text);

            ContaBancariaDTO conta = new ContaBancariaDTO(titular, saldo);

            var resposta = await http.PostAsJsonAsync($"{rota1}", conta);

            if (resposta.IsSuccessStatusCode)
            {
                MessageBox.Show("Conta criada com sucesso!");
            }
            else
            {
                MessageBox.Show($"Erro ao adicionar a conta: {resposta.StatusCode}");
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CarregarDados();
        }

        private async Task button2_Click(object sender, EventArgs e)
        {
            try
            {
                string titular = textBox1.Text;
                decimal saldo;

                if (textBox2.Text.IsWhiteSpace() | textBox2.Text == null)
                {
                    saldo = 0;
                }
                else
                {
                    saldo = decimal.Parse(textBox2.Text);
                }


                ContaBancariaDTO conta = new ContaBancariaDTO(titular, saldo);

                var resposta = await http.PostAsJsonAsync($"{rota1}", conta);

                if (resposta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Conta criada com sucesso!");
                }
                else
                {
                    MessageBox.Show($"Erro ao adicionar a conta: {resposta.StatusCode}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar conta -> Erro:" + ex.Message);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await CarregarDados();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = dataGridView2.SelectedRows[0];
                DataGridViewRow linhaselecionada = linha;
                var mensagem = MessageBox.Show("Tem certeza que deseja excluir a conta selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (mensagem)
                {
                    decimal numero = Convert.ToDecimal(linhaselecionada.Cells["NumeroConta"].Value);
                    await http.DeleteAsync($"{rota1}/{numero}");
                }
                await CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir conta -> Erro:" + ex.Message);
            }
        }
    }

}
