using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoletaDoSaber
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }
        public Jogador Jogador = new Jogador();
        public Final(Jogador jogador)
        {
            this.Jogador = jogador;
            InitializeComponent();
        }
        private void Final_Load(object sender, EventArgs e)
        {
            lblNome.Text = "Nome: " + Jogador.Nome;
            lblPontos.Text = "Pontos: " + Jogador.Pontos;
        }

        //private void cmdJoogarNovamente_Click(object sender, EventArgs e)
        //{
        //    Jogo jogo = new Jogo(Jogador);
        //    jogo.Show();
        //    Close();
        //}

        private void cmdsair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
