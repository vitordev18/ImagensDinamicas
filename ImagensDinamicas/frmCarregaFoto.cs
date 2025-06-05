using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmCarregaFoto : Form
    {
        public frmCarregaFoto()
        {
            InitializeComponent();
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            opdFoto.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os arquivos|*.*";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(opdFoto.FileName);
            } else
            {
                picFoto.Image = null;
            }
        }

        public void SetNomesJogadores(string nome1, string nome2)
        {
            textBox1.Text = nome1;
            textBox2.Text = nome2;
        }
    }
}
