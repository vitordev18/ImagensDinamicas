using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            DialogResult dialogResult = MessageBox.Show("Boas-vindas", "Clique na imagem do jogo que deseja e coloque o nome dos jogaroes",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }

        private void picDados_Click_1(object sender, EventArgs e)
        {
            
        }

        private void picFotos_Click(object sender, EventArgs e)
        {

        }
    }
}
