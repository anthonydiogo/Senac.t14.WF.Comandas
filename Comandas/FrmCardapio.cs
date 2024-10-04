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
    public partial class FrmCardapio : Form
    {
        public int ID { get; set; }
        public string? TITULO { get; set; }
        public bool POSSUI_PREPARO { get; set; }
        public string? DESCRICAO { get; set; }
        public decimal PRECO { get; set; }
        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        public void ListarCardapios()
        {
            using (var banco = new AppDbContext())
            {
                var cardapios = banco.Cardápios.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var ehNovo = true;
            new FrmCardapioCad(ehNovo).ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo).ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //exibe uma mensagme de confirmação para o usuário
            var result = MessageBox.Show("Confirma a exclusão do item {TITULO} ?", "Excluir Cardápio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // se o usuário clicou em não
            if (result == DialogResult.No)
            {
                // para o método
                return;
            }
            // chamar o método excluir
            if(ExcluirCardapio(ID)) 
            {
                // atualiza a tabela
                ListarCardapios();
                // exibe a mensagem de sucesso
                MessageBox.Show($"Cardápio '{TITULO}' excluído com sucesso!");
                // desabilita o botão de excluir
                btnExcluir.Enabled = false;
            }
        }

        private bool ExcluirCardapio(int iD)
        {
            // conectar no banco
            using (var banco = new AppDbContext())
            {
                // buscar o cardápio através do id
                // SELECT * FROM Cardapios WHERE id = @iD
                var card = banco.Cardápios.First(c => c.Id == iD);
                // avisar o banco da exclusão
                banco.Cardápios.Remove(card);
                // confirmar para o banco a ação
                banco.SaveChanges();
            }
            return true;
        }
    }
}
