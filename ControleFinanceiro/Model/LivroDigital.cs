using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleLivros.Model
{
    public class LivroDigital : Livro
    {
      
        public decimal TamanhoArquivo { get; private set; }
        public string LinkDownload { get; private set; }

       
        public LivroDigital(string titulo, decimal preco, int quantidade, Editora editora, decimal tamanhoArquivo, string linkDownload)
            : base(titulo, preco, quantidade, editora)
        {
            if (tamanhoArquivo <= 0)
                throw new ArgumentException("O tamanho do arquivo deve ser maior que zero.");
            if (string.IsNullOrWhiteSpace(linkDownload))
                throw new ArgumentException("O link de download não pode ser vazio.");

            TamanhoArquivo = tamanhoArquivo;
            LinkDownload = linkDownload;
        }

        
        public void Baixar()
        {
            if (Disponivel())
            {
                Console.WriteLine($"Baixando o livro digital {Titulo} da editora {Editora.Nome}...");
               
            }
            else
            {
                Console.WriteLine($"O livro {Titulo} não está disponível para download.");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Tamanho do Arquivo: {TamanhoArquivo} MB, URL de Download: {LinkDownload}";
        }
    }
}
