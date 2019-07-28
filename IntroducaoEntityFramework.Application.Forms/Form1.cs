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

namespace IntroducaoEntityFramework.Forms
{
    public partial class Form1 : Form
    {
        private readonly ProductDbContext _context; 
        public Form1()
        {
            InitializeComponent();
            _context = new ProductDbContext();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Nome = "Minha nova loja",
            };

            Produto produto = new Produto()
            {
                Nome = "Prduto da minha nova loja",
                Valor = 20m,
                Loja = loja,
                Descricao = "Este é um produto de teste que pertence a minha nova loja"
            };

            _context.Lojas.Add(loja);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
    }
}
