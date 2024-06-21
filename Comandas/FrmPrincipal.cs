using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        // met�do (visibilidade=privite, retorno
        private void CriarBancoDeDados()
        {
            // criar uma vari�vel do tipo AppDbContext
            // usar a vari�vel e acessar o contexto
            // executar a migraca��o  
            using (var banco = new AppDbContext())
            {
                // executa a migra��o(CREATE TABLE Usuarios)
                banco.Database.Migrate();
            }
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedidocozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }
    }
}
