using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace Banco.Classes.Models.Entidades
{
    public class ContaBancaria
    {
        /// <summary>
        /// Cria o numero da conta bancario no database.
        /// </summary>
        [Key]
        public int NumeroConta { get; set; }

        /// <summary>
        /// Cria o titular da conta bancaria.
        /// </summary>
        [Required]
        public string  TitularConta { get; set; }
        
        /// <summary>
        /// Saldo da conta, esse valor pode ficar negativo ou zero
        /// </summary>
        [Required]
        public decimal Saldo { get; set; }

        public ContaBancaria(string titularConta, decimal saldo)
        {
            TitularConta = titularConta;
            Saldo = saldo;
        }
    }
}
