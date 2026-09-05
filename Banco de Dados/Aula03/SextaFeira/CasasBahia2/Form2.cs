using CasasBahia2.Classes.Contextos;
using CasasBahia2.Classes.Entidades;

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

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Tab 1 - Botão para cadastrar item
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
        //Tab 2 - Botão para pesquisar item
        private void button2_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            var produto = contexto.Produtos.FirstOrDefault(p => p.CodigoDoProduto == int.Parse(textBox4.Text));
            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado!");

            }
            else
            {
                MessageBox.Show("Produto encontrado!" 
                    $"\nNome: {produto.NomeDoProduto}\nQuantidade: {produto.QuantidadeDeProduto}\nValor: {produto.ValorDoProduto:c}");
                
            }
            textBox4.Text = "";
        }


        //Tab 3 - Botão para editar/pesquisar item
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}
