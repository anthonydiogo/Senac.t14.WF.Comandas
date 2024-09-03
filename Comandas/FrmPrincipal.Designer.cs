namespace Comandas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpxPrincipal = new GroupBox();
            Usuarios = new ReaLTaiizor.Controls.MetroButton();
            btnPedidocozinha = new ReaLTaiizor.Controls.MetroButton();
            btnComanda = new ReaLTaiizor.Controls.MetroButton();
            btnCardapio = new ReaLTaiizor.Controls.MetroButton();
            btnVoltar = new ReaLTaiizor.Controls.AirButton();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.BackColor = Color.White;
            gpxPrincipal.Controls.Add(Usuarios);
            gpxPrincipal.Controls.Add(btnPedidocozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(28, 72);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(741, 263);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // Usuarios
            // 
            Usuarios.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            Usuarios.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            Usuarios.DisabledForeColor = Color.Gray;
            Usuarios.Font = new Font("Microsoft Sans Serif", 10F);
            Usuarios.HoverBorderColor = Color.FromArgb(95, 207, 255);
            Usuarios.HoverColor = Color.FromArgb(95, 207, 255);
            Usuarios.HoverTextColor = Color.White;
            Usuarios.IsDerivedStyle = true;
            Usuarios.Location = new Point(571, 56);
            Usuarios.Name = "Usuarios";
            Usuarios.NormalBorderColor = Color.Black;
            Usuarios.NormalColor = Color.FromArgb(255, 192, 192);
            Usuarios.NormalTextColor = Color.Black;
            Usuarios.PressBorderColor = Color.FromArgb(35, 147, 195);
            Usuarios.PressColor = Color.FromArgb(35, 147, 195);
            Usuarios.PressTextColor = Color.White;
            Usuarios.Size = new Size(145, 127);
            Usuarios.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            Usuarios.StyleManager = null;
            Usuarios.TabIndex = 3;
            Usuarios.Text = "Usuários";
            Usuarios.ThemeAuthor = "Taiizor";
            Usuarios.ThemeName = "MetroLight";
            Usuarios.Click += btnUsuarios_Click;
            // 
            // btnPedidocozinha
            // 
            btnPedidocozinha.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidocozinha.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidocozinha.DisabledForeColor = Color.Gray;
            btnPedidocozinha.Font = new Font("Microsoft Sans Serif", 10F);
            btnPedidocozinha.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnPedidocozinha.HoverColor = Color.FromArgb(95, 207, 255);
            btnPedidocozinha.HoverTextColor = Color.White;
            btnPedidocozinha.IsDerivedStyle = true;
            btnPedidocozinha.Location = new Point(390, 56);
            btnPedidocozinha.Name = "btnPedidocozinha";
            btnPedidocozinha.NormalBorderColor = Color.Black;
            btnPedidocozinha.NormalColor = Color.CornflowerBlue;
            btnPedidocozinha.NormalTextColor = Color.Black;
            btnPedidocozinha.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedidocozinha.PressColor = Color.FromArgb(35, 147, 195);
            btnPedidocozinha.PressTextColor = Color.White;
            btnPedidocozinha.Size = new Size(140, 127);
            btnPedidocozinha.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnPedidocozinha.StyleManager = null;
            btnPedidocozinha.TabIndex = 2;
            btnPedidocozinha.Text = "Pedido cozinha";
            btnPedidocozinha.ThemeAuthor = "Taiizor";
            btnPedidocozinha.ThemeName = "MetroLight";
            btnPedidocozinha.Click += btnPedidocozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledForeColor = Color.Gray;
            btnComanda.Font = new Font("Microsoft Sans Serif", 10F);
            btnComanda.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverTextColor = Color.White;
            btnComanda.IsDerivedStyle = true;
            btnComanda.Location = new Point(203, 56);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.Black;
            btnComanda.NormalColor = Color.YellowGreen;
            btnComanda.NormalTextColor = Color.Black;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(138, 127);
            btnComanda.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnComanda.StyleManager = null;
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.ThemeAuthor = "Taiizor";
            btnComanda.ThemeName = "MetroLight";
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledForeColor = Color.Gray;
            btnCardapio.Font = new Font("Microsoft Sans Serif", 10F);
            btnCardapio.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverTextColor = Color.White;
            btnCardapio.IsDerivedStyle = true;
            btnCardapio.Location = new Point(17, 56);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.Black;
            btnCardapio.NormalColor = Color.PaleGoldenrod;
            btnCardapio.NormalTextColor = Color.Black;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.White;
            btnCardapio.Size = new Size(138, 127);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnVoltar.Font = new Font("Segoe UI", 9F);
            btnVoltar.Image = null;
            btnVoltar.Location = new Point(28, 370);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoRounding = false;
            btnVoltar.Size = new Size(150, 68);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.Transparent = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 3F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.White;
            cyberTextBox1.ColorBackground_Pen = Color.Black;
            cyberTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Font = new Font("Arial", 13F);
            cyberTextBox1.ForeColor = Color.Black;
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(28, 12);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(741, 54);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 2;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cyberTextBox1);
            Controls.Add(btnVoltar);
            Controls.Add(gpxPrincipal);
            Name = "FrmPrincipal";
            Text = "Form1";
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.MetroButton Usuarios;
        private ReaLTaiizor.Controls.MetroButton btnPedidocozinha;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
        private ReaLTaiizor.Controls.AirButton btnVoltar;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
    }
}
