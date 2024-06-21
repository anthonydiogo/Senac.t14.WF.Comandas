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
        // metódo (visibilidade=privite, retorno
        private void CriarBancoDeDados()
        {
            // criar uma variável do tipo AppDbContext
            // usar a variável e acessar o contexto
            // executar a migracação  
            using (var banco = new AppDbContext())
            {
                // executa a migração(CREATE TABLE Usuarios)
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
