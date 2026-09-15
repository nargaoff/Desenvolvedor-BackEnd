using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Classes.Entidades
{
    internal class Pratos
    {

        //propriedades
        public int Id { get; set; }
        public string Nome_do_prato { get; set; }
        public decimal Preco { get; set; }
        public string Foto_do_prato { get; set; }

        //Construtor
        public Pratos(string nome_do_prato, decimal preco, string foto_do_prato)
        {
            Nome_do_prato = nome_do_prato;
            Preco = preco;
            Foto_do_prato = foto_do_prato;
        }
    }
}
