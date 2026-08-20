namespace Pedido.Classes.Entidades
{
    //Objeto que pode existir de forma independente
    internal class Funcionario
    {
        //Primeiro Membro - Campos
        private string nome;


        //Segundo Membro - Propriedades

        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Terceiro Membro - Construtor
        public Funcionario(string nome)
        {
            Nome = nome;
        }
        


    }
}
