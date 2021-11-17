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
    public partial class Cadastro : Form
    {
        public Jogador jogador = new Jogador();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void cmdJogar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo(jogador);
            jogo.Show();
        }

        private void cmdMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("É obrigatório um nome para o jogador!");
            }
            else
            {
                cmdJogar.Enabled = true;
                jogador.Nome = txtNome.Text;
            }
        }
    }
}
