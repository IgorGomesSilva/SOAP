using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoDudu
{
    public partial class formUserSenha : Form
    {
        public formUserSenha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var cliente = new CalculadoraService.CalculadoraServiceClient();

            if (cliente.validarUsuarioSenha(txtUser.Text,txtSenha.Text)) {
                new formApresentarLista().Show();

            }
        }
    }
}
