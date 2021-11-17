using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoletaDoSaber
{
    public partial class Jogo : Form
    {
        #region Perguntas e Roleta
        public static List<Label> listaOpcoesRoleta = new List<Label>();
        public static readonly List<Pegunta> listaPerguntas = new List<Pegunta>()
        {
            new Pegunta{ID = 1, Pergunta = @"De quem é a famosa frase ""penso, logo existo""?",
            RespostaA = "Platão", RespostaB = "Galileu Galilei", RespostaC = "René Descartes", RespostaD = "Sócrates"},

            new Pegunta{ID = 2, Pergunta = "Qual é o menor e maior país do mundo?",
            RespostaA = "Nauru e China", RespostaB = "Vaticano e Russia", RespostaC = "Mônaco e Canadá", RespostaD = "Brasil e Estados Unidos"},

            new Pegunta{ID = 3, Pergunta = "Qual o número mínimo de jogadores numa partida de futebol?",
            RespostaA = "5", RespostaB = "10", RespostaC = "7", RespostaD = "12"},

            new Pegunta{ID = 4, Pergunta = "Quais as duas datas que são comemoradas em novembro?",
            RespostaA = "Dia do médico e dia de São Lucas", RespostaB = "Dia de finados e dia nacional do livro", RespostaC = "Proclamação da República e dia da consciência negra", RespostaD = "Black friday e dia da árvore"},

            new Pegunta{ID = 5, Pergunta = "Quanto tempo a luz do sol demora para chegar a terra?",
            RespostaA = "13 minutos", RespostaB = "12 horas", RespostaC = "1 dia", RespostaD = "8 minutos"},

            new Pegunta{ID = 6, Pergunta = "Qual personagem folclórico costuma a ser agradado pelos caçadores com a oferta de fumo",
            RespostaA = "Caipora", RespostaB = "Saci", RespostaC = "Lobisomem", RespostaD = "Boitatá"},

            new Pegunta{ID = 7, Pergunta = "Em que período da pré história o fogo foi descoberto?",
            RespostaA = "Neolítico", RespostaB = "Paleolítico", RespostaC = "Idade dos Metais", RespostaD = "Período da Pedra"},

            new Pegunta{ID = 8, Pergunta = "Qual a montanha mais alta do Brasil?",
            RespostaA = "Pico da neblina", RespostaB = "Pico Paraná", RespostaC = "Monte Roraima", RespostaD = "Pico maior de Friburgo"},
        };
        #endregion
        public Jogador Jogador = new Jogador();
        public Jogo()
        {
            InitializeComponent();
        }

        public Jogo(Jogador jogador)
        {
            this.Jogador = jogador;
            InitializeComponent();
        }

        int contador = 0;
        int posicao = 0;

        private void Jogo_Load(object sender, EventArgs e)
        {
            lblJogador.Text = Jogador.Nome;
            Jogador.Pontos = 0;

            listaOpcoesRoleta.Add(lblOpcao1);
            listaOpcoesRoleta.Add(lblOpcao2);
            listaOpcoesRoleta.Add(lblOpcao3);
            listaOpcoesRoleta.Add(lblOpcao4);
            listaOpcoesRoleta.Add(lblOpcao5);
            listaOpcoesRoleta.Add(lblOpcao6);
            listaOpcoesRoleta.Add(lblOpcao7);
            listaOpcoesRoleta.Add(lblOpcao8);
            listaOpcoesRoleta.Add(lblOpcao9);
            listaOpcoesRoleta.Add(lblOpcao10);
            listaOpcoesRoleta.Add(lblOpcao11);
            listaOpcoesRoleta.Add(lblOpcao12);

            EmJogo();
        }

        public void EmJogo()
        {
            lblPergunta.MaximumSize = new Size(400, 0);
            lblPergunta.AutoSize = true;
            if (posicao != 0) {
                timer1.Enabled = true;
                timer1.Enabled = false;
            }
            if (posicao <= 7)
            {
                lblPergunta.Text = listaPerguntas[posicao].Pergunta;
                cmdRespostaA.Text = listaPerguntas[posicao].RespostaA;
                cmdRespostaB.Text = listaPerguntas[posicao].RespostaB;
                cmdRespostaC.Text = listaPerguntas[posicao].RespostaC;
                cmdRespostaD.Text = listaPerguntas[posicao].RespostaD;
            }
            else
            {
                Final final = new Final(Jogador);
                final.Show();
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (contador == 0)
            {
                listaOpcoesRoleta[11].ForeColor = Color.Black;
            }

            if (contador != 0)
            {
                listaOpcoesRoleta[contador - 1].ForeColor = Color.Black;
            }
            listaOpcoesRoleta[contador].ForeColor = Color.White;
            contador++;
            if (contador >= 12)
            {
                contador = 0;
            }

        }

        private void cmdConfirma_Click(object sender, EventArgs e)
        {
            //A cada vez que clicar no botão confirma, trocar as propriedades text do botão e da pergunta
            //pela pergunta que estiver na posição do foreach()

            posicao++;
            EmJogo();
        }
    }
}
