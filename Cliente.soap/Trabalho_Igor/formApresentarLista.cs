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
    public partial class formApresentarLista : Form
    {
        public formApresentarLista()
        {
            InitializeComponent();
        }

        private void btnApresentarLista_Click(object sender, EventArgs e)
        {
            lbItens.Items.Clear();
            var cliente = new CalculadoraService.CalculadoraServiceClient();
            System.Object[] ItemObject = new System.Object[10];
            int[] valores = cliente.gerarValores();
            for (int i = 0; i <= 9; i++)
            {
                ItemObject[i] = valores[i];
            }

            lbItens.Items.AddRange(ItemObject);
        }
    }
}
