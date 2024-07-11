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
    public partial class FrmUsuarios : Form
    {
        private bool ehNovo;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
                CriarUsuario();
            else
                AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                var usuario = banco
                    .Usuarios
                    .Where( e => e.Id == 1)
                    .FirstOrDefault();

                usuario.Nome = "Pedro";
                usuario.Email = "pedro@gmail.com";

                banco.SaveChanges();
            }
        }

        private void CriarUsuario()
        {
            // acessar o banco
            using (var banco = new AppDbContext())
            {
                // criar novo usuario
                var novoUsuario = new Usuario();
                // atribuimos as propriedades do usuario
                novoUsuario.Nome = "Anthony";
                novoUsuario.Email = "anthony@gmail.com";
                novoUsuario.Senha = "1234";
                // salvar as alterações(INSERT INTO usuario)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso.");
            }

                
        }
    }
}
