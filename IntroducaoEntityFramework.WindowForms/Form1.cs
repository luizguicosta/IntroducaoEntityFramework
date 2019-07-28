using IntroducaoEntityFramework.Data;
using IntroducaoEntityFramework.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoEntityFramework.WindowForms
{
    public partial class Form1 : Form
    {
        private readonly ProductDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new ProductDbContext();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            var loja = new Loja()
            {
                Nome = tbNomeLoja.Text,
                Descricao = rtbDescricaoLoja.Text
            };

            var produto = new Produto()
            {
                Nome = tbNomeProduto.Text,
                Descricao = rtbDescricaoProduto.Text,
                Valor = Convert.ToDecimal(tbValorProduto.Text),
                Loja = loja
            };

            _context.Lojas.Add(loja);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbNomeLoja.Text = string.Empty;
            rtbDescricaoLoja.Text = string.Empty;
            tbNomeProduto.Text = string.Empty;
            rtbDescricaoProduto.Text = string.Empty;
            tbValorProduto.Text = string.Empty;
        }

        private void TbValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (tbValorProduto.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BtnCadastroProdutoNomeLoja_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(tbNomeLoja.Text))
            {
                MessageBox.Show("Informe o nome da loja", "Informação");
                flag = false;
            }

            var loja = _context.Lojas.FirstOrDefault(x => x.Nome.Equals(tbNomeLoja.Text));
            if (loja == null && flag)
                MessageBox.Show("Loja não esta cadastrada");

            if (loja != null)
            {
                var produto = new Produto()
                {
                    Nome = tbNomeProduto.Text,
                    Descricao = rtbDescricaoProduto.Text,
                    Valor = Convert.ToDecimal(tbValorProduto.Text),
                    Loja = loja
                };
                _context.Produtos.Add(produto);
                _context.SaveChanges();
            }
        }

        private void BtnPesquisarLojaProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomeProduto.Text))
            {
                var produto = _context.Produtos.FirstOrDefault(p => p.Nome == tbNomeProduto.Text);
                var loja = produto != null ? _context.Lojas.Find(produto.LojaID) : null;
                if(loja != null)
                {
                    tbNomeLoja.Text = loja.Nome;
                    rtbDescricaoLoja.Text = loja.Descricao;
                }
            }
            else
            {
                MessageBox.Show("Infrome o nome da loga", "Informação");
            }
        }
    }
}
