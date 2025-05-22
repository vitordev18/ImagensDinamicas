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
    public partial class frmJogoDados : Form
    {

        int contVitoria1 = 0, contVitoria2 = 0;

        Random Sorteio = new Random();

        int dado1, dado2;
        
        public frmJogoDados()
        {
            InitializeComponent();
        }

        private void btnJogar(object sender, EventArgs e)
        {
            dado1 = SorteioDado(picDado1);
            dado2 = SorteioDado(picDado2);
        }

        private int SorteioDado (PictureBox dado)
        {
            int valorDado = Sorteio.Next(1, 7);
            String arquivoDado = @"\imagens\dado" + valorDado.ToString() + ".png";
            dado.Image = Image.FromFile(arquivoDado);
            return valorDado;
        }
    }
}
