using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // verificar se o campo nao está vazio
            if (txbProduto.Text.Length == 0)
            {
                MessageBox.Show("o nome do Produto não pode estar vazio!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //mudar a cor de fundo e a cor da letra
                txbProduto.BackColor = Color.Red;
                txbProduto.ForeColor = Color.Black;


            }
            else if (txbProduto.Text.Length < 2)
            {
                MessageBox.Show("O nome do produto precisa ter no minimo duas Letras!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //mudar a cor de fundo e a cor da letra
                txbProduto.BackColor = Color.Red;
                txbProduto.ForeColor = Color.Black;
            }
            else
            {
                // verificar se o item esta na lista
                if (libCompras.Items.Contains(txbProduto.Text))
                {
                    MessageBox.Show($"já existe {txbProduto.Text} na lista!",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // adicionar o item na lista
                    libCompras.Items.Add(txbProduto.Text);

                    // mostrar mensagem de sucesso
                    MessageBox.Show($"{txbProduto.Text} foi adiconado na lista de compras",
                        "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // retornar a cor normal
                    txbProduto.BackColor = Color.White;
                    txbProduto.ForeColor = Color.Black;

                    // limpar o campo
                    txbProduto.Clear();
                }
            }

        }

        private void btnApagartd_Click(object sender, EventArgs e)
        {
            // perguntar se realmente quer apagar a lista
            DialogResult resposta = MessageBox.Show("Tem certeza que desaja apagar tudo?", "ATENÇÃO!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // se optar por "sim", apagar
            if (resposta == DialogResult.Yes)
            {
                libCompras.Items.Clear();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // verificar se o usuario não selecionou nada
            if (libCompras.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item para remover!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // salvar temporariamente o nome em uma variavel antes dela ser removida
                string a = libCompras.SelectedItem.ToString();

                // remover o item selecionado
                libCompras.Items.RemoveAt(libCompras.SelectedIndex);

                MessageBox.Show($"o item {a} foi removido da lista!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

            }
        }

        private void txbProduto_KeyDown(object sender, KeyEventArgs e)
        {
        // precionar adicionar usando a tecla enter
        if(e.KeyCode == Keys.Enter)
                {
btnAdicionar.PerformClick();
            }
        }
    }
}

