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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsuario.Text.Equals("Aline") && textBoxSenha.Text.Equals("123"))
                {
                    // Seguir login para área restrita do app.
                }
                else
                {
                    MessageBox.Show("ERRO - 401",
                        "Desculpe. Usuário ou senha incorretos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
        }
    }
}
