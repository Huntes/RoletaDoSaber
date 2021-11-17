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
        #region Perguntas/Respostas e Roleta
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
        public static readonly List<Resposta> listaRespostas = new List<Resposta>()
        {
            new Resposta{IDPergunta = 1, LetraResposta = (int)eResposta.LetraC },
            new Resposta{IDPergunta = 2, LetraResposta = (int)eResposta.LetraB },
            new Resposta{IDPergunta = 3, LetraResposta = (int)eResposta.LetraC },
            new Resposta{IDPergunta = 4, LetraResposta = (int)eResposta.LetraC },
            new Resposta{IDPergunta = 5, LetraResposta = (int)eResposta.LetraD },
            new Resposta{IDPergunta = 6, LetraResposta = (int)eResposta.LetraA },
            new Resposta{IDPergunta = 7, LetraResposta = (int)eResposta.LetraB },
            new Resposta{IDPergunta = 8, LetraResposta = (int)eResposta.LetraA },
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
        int resposta = 0;

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
            cmdRespostaA.Enabled = true;
            cmdRespostaB.Enabled = true;
            cmdRespostaC.Enabled = true;
            cmdRespostaD.Enabled = true;

            if (posicao != 0)
            {
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

            if (resposta == 0)
            {
                MessageBox.Show("Escolha uma resposta!");
            }
            else
            {
                switch (resposta)
                {
                    case 1:
                        var pegaRespostaA = listaRespostas.Where(c => c.IDPergunta == posicao+1).FirstOrDefault();
                        if (pegaRespostaA.LetraResposta == resposta)
                        {
                            Jogador.Pontos += 10;
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao +1}");
                        }
                        else
                        {
                            MessageBox.Show($"Resposta Incorreta, a resposta correta era a {eLetraResposta.GetNomeTela(pegaRespostaA.LetraResposta)}");
                        }
                        break;
                    case 2:
                        var pegaRespostaB = listaRespostas.Where(c => c.IDPergunta == posicao+1).FirstOrDefault();
                        if (pegaRespostaB.LetraResposta == resposta)
                        {
                            Jogador.Pontos += 10;
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao +1}");
                        }
                        else
                        {
                            MessageBox.Show($"Resposta Incorreta, a resposta correta era a {eLetraResposta.GetNomeTela(pegaRespostaB.LetraResposta)}");
                        }
                        break;
                    case 3:
                        var pegaRespostaC = listaRespostas.Where(c => c.IDPergunta == posicao+1).FirstOrDefault();
                        if (pegaRespostaC.LetraResposta == resposta)
                        {
                            Jogador.Pontos += 10;
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao +1}");
                        }
                        else
                        {
                            MessageBox.Show($"Resposta Incorreta, a resposta correta era a {eLetraResposta.GetNomeTela(pegaRespostaC.LetraResposta)}");
                        }
                        break;
                    case 4:
                        var pegaRespostaD = listaRespostas.Where(c => c.IDPergunta == posicao+1).FirstOrDefault();
                        if (pegaRespostaD.LetraResposta == resposta)
                        {
                            Jogador.Pontos += 10;
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao +1}");
                        }
                        else
                        {
                            MessageBox.Show($"Resposta Incorreta, a resposta correta era a {eLetraResposta.GetNomeTela(pegaRespostaD.LetraResposta)}");
                        }
                        break;
                }

                posicao++;
                EmJogo();
            }

        }

        private void cmdRespostaA_Click(object sender, EventArgs e)
        {
            resposta = 1;
            cmdRespostaB.Enabled = false;
            cmdRespostaC.Enabled = false;
            cmdRespostaD.Enabled = false;
        }

        private void cmdRespostaB_Click(object sender, EventArgs e)
        {
            resposta = 2;
            cmdRespostaA.Enabled = false;
            cmdRespostaC.Enabled = false;
            cmdRespostaD.Enabled = false;
        }

        private void cmdRespostaC_Click(object sender, EventArgs e)
        {
            resposta = 3;
            cmdRespostaA.Enabled = false;
            cmdRespostaB.Enabled = false;
            cmdRespostaD.Enabled = false;
        }

        private void cmdRespostaD_Click(object sender, EventArgs e)
        {
            resposta = 4;
            cmdRespostaA.Enabled = false;
            cmdRespostaB.Enabled = false;
            cmdRespostaC.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdRespostaA.Enabled = true;
            cmdRespostaB.Enabled = true;
            cmdRespostaC.Enabled = true;
            cmdRespostaD.Enabled = true;
            resposta = 0;
        }
    }
}
