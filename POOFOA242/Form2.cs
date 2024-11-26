using ControleProduto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleProduto
{
    public partial class Form2 : Form
    {
        private Produto produto;
        public Form2()
        {

            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            string titulo = txtTitulo.Text;
            decimal preco = decimal.Parse(txtPreco.Text);

           
            string frequencia = txtFrequencia.Text;

           
            Produto revista = new Revista(titulo, preco, frequencia);

            
            revista.ExibirDetalhes();

           
            revista.VerificarDisponibilidade();

          
            MessageBox.Show("Produto comprado com sucesso!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitulo.Clear();
            txtPreco.Clear();
            txtFrequencia.Clear();
        }

        private void btnVerificarDisponibilidade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Revista disponível para compra.", "Disponibilidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
