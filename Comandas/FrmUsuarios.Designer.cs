namespace Comandas
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVoltar = new ReaLTaiizor.Controls.AirButton();
            btnNovo = new ReaLTaiizor.Controls.AirButton();
            btnSalvar = new ReaLTaiizor.Controls.AirButton();
            btnExcluir = new ReaLTaiizor.Controls.AirButton();
            btnCancelar = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnVoltar.Font = new Font("Segoe UI", 9F);
            btnVoltar.Image = null;
            btnVoltar.Location = new Point(30, 357);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoRounding = false;
            btnVoltar.Size = new Size(150, 68);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.Transparent = false;
            // 
            // btnNovo
            // 
            btnNovo.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnNovo.Font = new Font("Segoe UI", 9F);
            btnNovo.Image = null;
            btnNovo.Location = new Point(30, 105);
            btnNovo.Name = "btnNovo";
            btnNovo.NoRounding = false;
            btnNovo.Size = new Size(150, 68);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.Transparent = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.Image = null;
            btnSalvar.Location = new Point(222, 105);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoRounding = false;
            btnSalvar.Size = new Size(150, 68);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.Transparent = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.Image = null;
            btnExcluir.Location = new Point(413, 105);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoRounding = false;
            btnExcluir.Size = new Size(150, 68);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.Transparent = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.Image = null;
            btnCancelar.Location = new Point(603, 105);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoRounding = false;
            btnCancelar.Size = new Size(150, 68);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Transparent = false;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnVoltar);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton btnVoltar;
        private ReaLTaiizor.Controls.AirButton btnNovo;
        private ReaLTaiizor.Controls.AirButton btnSalvar;
        private ReaLTaiizor.Controls.AirButton btnExcluir;
        private ReaLTaiizor.Controls.AirButton btnCancelar;
    }
}