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
    public partial class frmJogoDados : Form
    {

        int contVitoria1 = 0, contVitoria2 = 0;

        Random Sorteio = new Random();

        int dado1, dado2;
        
        public frmJogoDados()
        {
            InitializeComponent();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmJogoDados_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Deseja realmente sair ?",
                                     "Jogo de Dados CTI",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void btnJogar(object sender, EventArgs e)
        {
            dado1 = SorteioDado(picDado1);
            dado2 = SorteioDado(picDado2);
            if (dado1 > dado2)
            {
                contVitoria1 += 1;
                lblPlacar1.Text = contVitoria1.ToString();
            } 
            else if (dado1 < dado2)
            {
                contVitoria2 += 1;
                lblPlacar2.Text = contVitoria1.ToString();
            }
            else
            {
                MessageBox.Show("Houve um empate nessa rodada!",
                                "Jogo de Dados CTI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private int SorteioDado (PictureBox dado)
        {
            int valorDado = Sorteio.Next(1, 7);
            String arquivoDado = ".\\Imagens\\dado" + valorDado.ToString() + ".jpg";
            dado.Image = Image.FromFile(arquivoDado);
            return valorDado;
        }
    }
}
