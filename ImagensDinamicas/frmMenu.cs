﻿using System;
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
            MessageBox.Show(
                "Clique na imagem do jogo que deseja e coloque o nome dos jogadores",
                "Boas-vindas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void picDados_Click_1(object sender, EventArgs e)
        {
            frmJogoDados frmJogo = new frmJogoDados();
            frmJogo.SetNomesJogadores(txtJog1.Text, txtJog2.Text);
            this.Hide();
            frmJogo.ShowDialog();
            this.Show();
        }

        private void picFotos_Click(object sender, EventArgs e)
        {
            frmCarregaFoto frmFotos = new frmCarregaFoto();
            frmFotos.SetNomesJogadores(txtJog1.Text, txtJog2.Text);
            this.Hide();
            frmFotos.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
