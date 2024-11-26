using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleProduto.Model
{
    public class Revista : Produto
    {
        public string Frequencia { get; set; }

        public Revista(string titulo, decimal preco, string frequencia) : base(titulo, preco)
        {
            Frequencia = frequencia;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Revista: {Titulo}, Frequência: {Frequencia}, Preço: {Preco:C}");
        }

        public override void VerificarDisponibilidade()
        {
            Console.WriteLine($"Revista {Titulo} está disponível para venda.");
        }
    }
}

