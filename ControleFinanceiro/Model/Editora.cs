using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleLivros.Model
{
    public class Editora
    {
        
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Livro> Livros { get; set; }

       
        public Editora(string nome, string email)
        {
            Nome = nome;
            Email = email;
            Livros = new List<Livro>();
           
        }

        public void Consultar()
        {
            Console.WriteLine($"Livros disponíveis da editora {Nome}:");
            foreach (var livro in Livros)
            {
                if (livro.Disponivel())
                {
                    Console.WriteLine($"- {livro.Titulo} (Preço: {livro.Preco:C}, Quantidade: {livro.Quantidade})");
                }
            }
        }

        public override string ToString()
        {
            return $"Editora: {Nome}, Email: {Email}, Total de Livros: {Livros.Count}";
        }

        
    }

}
