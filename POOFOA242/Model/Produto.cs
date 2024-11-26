using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleProduto.Model
{
    public abstract class Produto : IDisponibilidade
    {
        public string Titulo { get; set; }
        public decimal Preco { get; set; }

        protected Produto(string titulo, decimal preco)
        {
            Titulo = titulo;
            Preco = preco;
        }

        public abstract void ExibirDetalhes();

        public virtual void VerificarDisponibilidade()
        {
            Console.WriteLine($"Verificando disponibilidade do produto: {Titulo}");
        }
    }
}
