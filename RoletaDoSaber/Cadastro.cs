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
        Form1 formularioInicio = new Form1();

        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(Form1 inicio)
        {
            formularioInicio = inicio;
            InitializeComponent();
        }

        private void cmdJogar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo(jogador);
            jogo.Show();
            Close();
        }

        private void cmdMenu_Click(object sender, EventArgs e)
        {
            Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("É obrigatório um nome para o jogador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmdJogar.Enabled = true;
                jogador.Nome = txtNome.Text;
                MessageBox.Show($"{jogador.Nome} foi registrado!", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
