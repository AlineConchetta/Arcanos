using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUsuario.Text.Equals("Aline") && textSenha.Text.Equals("123"))
                {
                    // Seguir login para área restrita do app.
                }
                else
                {
                    MessageBox.Show("Usuário e senha incorretos",
                        "Acesso negado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
        }
    }
}
