using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleLivros.Model;


namespace ControleLivros
{
    public partial class frmLivro : Form
    {
        private List<Editora> editoras;
        public frmLivro()
        {
            InitializeComponent();
            editoras = new List<Editora>();


        }

            private void btnAdicionarEditora_Click(object sender, EventArgs e)
            {
                string nome = txtNomeEditora.Text;
                string email = txtEmailEditora.Text;

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Preencha todos os campos da editora!");
                    return;
                }

                Editora editora = new Editora(nome, email);
                editoras.Add(editora);
                cmbEditora.Items.Add(editora.Nome);

                

                MessageBox.Show("Editora adicionada com sucesso!");
                txtNomeEditora.Clear();
                txtEmailEditora.Clear();
            }

            private void btnAdicionarLivro_Click(object sender, EventArgs e)
            {
                if (cmbEditora.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma editora!");
                    return;
                }

                string titulo = txtTituloLivro.Text;
                decimal preco;
                int quantidade;

                if (string.IsNullOrWhiteSpace(titulo) ||
                    !decimal.TryParse(txtPrecoLivro.Text, out preco) ||
                    !int.TryParse(txtQuantidadeLivro.Text, out quantidade))
                {
                    MessageBox.Show("Preencha corretamente os dados do livro!");
                    return;
                }

                string nomeEditora = cmbEditora.SelectedItem.ToString();
                Editora editora = editoras.Find(e => e.Nome == nomeEditora);

                Livro livro = new Livro(titulo, preco, quantidade, editora);
                editora.Livros.Add(livro);

                AtualizarListaLivros();
                MessageBox.Show("Livro adicionado com sucesso!");
                txtTituloLivro.Clear();
                txtPrecoLivro.Clear();
                txtQuantidadeLivro.Clear();
            }

            private void btnConsultarLivros_Click(object sender, EventArgs e)
            {

                dgvLivros.Rows.Clear();
                foreach (var editora in editoras)
                {
                    foreach (var livro in editora.Livros)
                    {
                        dgvLivros.Rows.Add(livro.Titulo, livro.Preco, livro.Quantidade, editora.Nome);
                    }
                }
            MessageBox.Show("Livro baixado com sucesso!", "Baixar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

            private void AtualizarListaLivros()
            {
                dgvLivros.Rows.Clear();
                foreach (var editora in editoras)
                {
                    foreach (var livro in editora.Livros)
                    {
                        dgvLivros.Rows.Add(livro.Titulo, livro.Preco, livro.Quantidade, editora.Nome);
                    }
                }
            }
        }
    }

