using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleLivros.Model
{
    public class Livro
    {
     
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Editora Editora { get; set; }

        
        public Livro(string titulo, decimal preco, int quantidade, Editora editora)
        {
            Titulo = titulo;
            Preco = preco;
            Quantidade = quantidade;
            Editora = editora;
        }

        public bool Disponivel()
        {
            return Quantidade > 0;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Preço: {Preco:C}, Quantidade: {Quantidade}, Editora: {Editora.Nome}";
        }
    }
}
