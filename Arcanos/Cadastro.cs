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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            string cpf = textBoxCPF.Text.Trim();
            string celular = textBoxContato.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string senha = textBoxSenha.Text.Trim();

            textBoxSenha.PasswordChar = '*';


             if (nome == "" || cpf == "" || celular == "" || email == "" || senha == "")
    {
        MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
        }
    }
}
