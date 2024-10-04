using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmCardapioCad : Form
    {
        // variável que indica se está criando um novo cardapio
        // bool = true, false
        bool ehNovo = false;
        private FrmCardapio _frmCardapio;

        public FrmCardapioCad(bool acao, FrmCardapio frmCardapio)
        {
            ehNovo = acao;
            _frmCardapio = frmCardapio;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // se o form está em modo de inclusão
            if (ehNovo) {
                // executa o método que realizar o INSERT na tabela
                AdicionarCardapio();
            }
            else
            {   // executa o método que realiza o UPDATE na tabela
                AtualizarCardapio();
            }
            _frmCardapio.ListarCardapios();
            // feca a tela atual (FrmCardapioCad)
            Close();
        }

        private void AtualizarCardapio()
        {
            using (var banco = new AppDbContext())
            {
                var cardapio = banco.Cardápios.
                    FirstOrDefault(f => f.Id == int.Parse(txtId.TextButton));

                cardapio.Titulo = txtTitulo.TextButton;
                cardapio.Descricao = txtDescricao.TextButton;
                cardapio.Preco = decimal.Parse(txtPreco.TextButton);
                cardapio.PossuiPreparo = chkPreparo.Checked;
                banco.SaveChanges();
            }
        }

        private void AdicionarCardapio()
        {
            // usar o banco de dados 
            // cria uma variavel banco que instancia uma conexao com o BD
            using (var banco = new AppDbContext())
            {
                var novoCardapio = new Cardapio()
                {
                    Titulo = txtTitulo.TextButton,
                    Descricao = txtDescricao.TextButton,
                    Preco = decimal.Parse(txtPreco.TextButton),
                    PossuiPreparo = chkPreparo.Checked
                };
                banco.Cardápios.Add(novoCardapio);
                banco.SaveChanges();
            }
        }
    }
}
