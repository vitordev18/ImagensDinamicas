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
        int contVitoria1 = 0;
        int contVitoria2 = 0;

        Random Sorteio = new Random();

        int dado1;
        int dado2;

        public frmJogoDados()
        {
            InitializeComponent();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            contVitoria1 = 0;
            contVitoria2 = 0;
            lblPlacar1.Text = "0";
            lblPlacar2.Text = "0";
            picDado1.Image = null;
            picDado2.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmJogoDados_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair ?",
                                                    "Jogo de Dados CTI",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
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
                lblPlacar2.Text = contVitoria2.ToString();
            }
            else
            {
                MessageBox.Show("Houve um empate nessa rodada!",
                                "Jogo de Dados CTI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private int SorteioDado(PictureBox dado)
        {
            int valorDado = Sorteio.Next(1, 7);
            string arquivoDado = $".\\Imagens\\dado{valorDado}.jpg";

            if (System.IO.File.Exists(arquivoDado))
            {
                dado.Image = Image.FromFile(arquivoDado);
            }
            else
            {
                MessageBox.Show($"Imagem não encontrada: {arquivoDado}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dado.Image = null;
            }
            return valorDado;
        }

        public void SetNomesJogadores(string nome1, string nome2)
        {
            lblJogador1.Text = nome1;
            lblJogador2.Text = nome2;
        }
    }
}