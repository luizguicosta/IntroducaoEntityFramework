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
            MessageBox.Show("Cadastro efetudado com sucesso!", "Sucesso");
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
                MessageBox.Show("Informe o nome da loja", "Alerta");
                flag = false;
            }

            var loja = _context.Lojas.FirstOrDefault(x => x.Nome.Equals(tbNomeLoja.Text));
            if (loja == null && flag)
                MessageBox.Show("Loja não esta cadastrada", "Alerta");

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
                MessageBox.Show("Informe o nome da loja", "Alerta");
            }
        }

        private void BtnPesquisaPorNome_Click(object sender, EventArgs e)
        {
            var loja = _context.Lojas.FirstOrDefault(l => l.Nome.Equals(tbNomeLoja.Text) || l.Nome.Contains(tbNomeLoja.Text));
            if(loja != null)
            {
                tbNomeLoja.Text = loja.Nome;
                rtbDescricaoLoja.Text = loja.Descricao;
            }
            else
            {
                MessageBox.Show("Loja não cadastrada", "Alerta");
                LimparCampos();
            }
        }

        private void BtnAumentarPreco_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomeLoja.Text))
            {
                var loja = _context.Lojas.FirstOrDefault(l => l.Nome.Equals(tbNomeLoja.Text));
                if(loja != null && loja.Produtos.Count > 0)
                {
                    loja.Produtos.ForEach(p => p.Valor += p.Valor * 0.10m);
                    _context.SaveChanges();
                    MessageBox.Show("Aumento Realizado com sucesso", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Loja não cadastrada", "Alerta");
                }
            }
            else
            {
                MessageBox.Show("Informe o nome da Loja", "Alerta");
            }
            LimparCampos();
        }

        private void BtnPesquisarProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomeProduto.Text))
            {
                var produto = _context.Produtos.FirstOrDefault(p => p.Nome.Equals(tbNomeProduto.Text));
                if(produto != null)
                {
                    tbNomeProduto.Text = produto.Nome;
                    rtbDescricaoProduto.Text = produto.Descricao;
                    tbValorProduto.Text = produto.Valor.ToString();
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado", "Alerta");
                }
            }
            else
            {
                MessageBox.Show("Informe o nome do produto", "Alerta");
            }
        }

        private void BtnRemoveLoja_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomeLoja.Text))
            {
                var loja = _context.Lojas.FirstOrDefault(l => l.Nome.Equals(tbNomeLoja.Text));
                if(loja != null)
                {
                    try
                    {
                        _context.Lojas.Remove(loja);
                        _context.SaveChanges();
                        MessageBox.Show("Loja removida com sucesso", "Sucesso");
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Não foi possível remover a loja :{ex.Message}", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Loja não cadastrada", "Alerta");
                }
            }
            else
            {
                MessageBox.Show("Informe o nome da loja que deseja remover", "Alerta");
            }
        }

        private void BtnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomeProduto.Text))
            {
                var produto = _context.Produtos.FirstOrDefault(l => l.Nome.Equals(tbNomeProduto.Text));
                if (produto != null)
                {
                    try
                    {
                        _context.Produtos.Remove(produto);
                        _context.SaveChanges();
                        MessageBox.Show("Produto removido com sucesso", "Sucesso");
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Não foi possível remover a Produto :{ex.Message}", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado", "Alerta");
                }
            }
            else
            {
                MessageBox.Show("Informe o nome do Produto que deseja remover", "Alerta");
            }
        }
    }
}
