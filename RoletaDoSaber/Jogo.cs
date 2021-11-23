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
            new Pegunta{Pontos = 3, ID = 1, Pergunta = "O que são animais herbívoros?",
            RespostaA = "Os que se alimentam de carnes", RespostaB = "Animais mamíferos", RespostaC = "Os que se alimentam de plantas", RespostaD = "Todas estão corretas"},

            new Pegunta{Pontos = 4, ID = 2, Pergunta = "Quais animais estão no topo da cadeia alimentar?",
            RespostaA = "Herbívoros", RespostaB = "Carnívoros", RespostaC = "Mamíferos", RespostaD = "Repiteis"},

            new Pegunta{Pontos = 5, ID = 3, Pergunta = "O que são animais mamíferos?",
            RespostaA = "Todos que tem pelos", RespostaB = "Todos que vivem na água", RespostaC = "Os que apresentam glândulas mamárias", RespostaD = "Os que são os maiores da floresta"},

            new Pegunta{Pontos = 6, ID = 4, Pergunta = "O processo em que as plantas utilizam a luz como fonte de energia é chamado?",
            RespostaA = "Elas se transforma em polem", RespostaB = "Chamamos de processo solido", RespostaC = "Fotossíntese", RespostaD = "Produção de flores"},

            new Pegunta{Pontos = 7, ID = 5, Pergunta = "Quais são os três estados físicos da água?",
            RespostaA = "Gasoso e liquido", RespostaB = "Solido e liquido", RespostaC = "Todas estão correstas", RespostaD = "Sólido, liquido e gasoso"},

            new Pegunta{Pontos = 8, ID = 6, Pergunta = "Quais são as quatro fases da lua?",
            RespostaA = "Cheia, minguante, nova, e crescente.", RespostaB = "minguante e nova", RespostaC = "crescente, cheia e nova", RespostaD = "nova e cheia, minguante"},

            new Pegunta{Pontos = 9, ID = 7, Pergunta = "Quais são as quatro estações do ano?",
            RespostaA = "lua cheia, verão e outono", RespostaB = "primavera, verão, outono e inverno", RespostaC = "outono, verão e inverno", RespostaD = "primavera e inverno"},

            new Pegunta{Pontos = 10, ID = 8, Pergunta = "Espermatozoide é a célula reprodutiva?",
            RespostaA = "masculina, existente apenas seres humanos", RespostaB = "feminina, existente em todos seres vivos", RespostaC = "Feminina, existe apenas seres humanos ", RespostaD = "Todas as espécies"},
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
        Random tempo = new Random();

        //Vetor que guarda o valor pra ser multiplicado nos pontos, posicionados na ordem da roleta
        private readonly int[] multiplicaPontosRoleta = { 15, 8, 10, 5, 10, 25, 10, 30, 10, 25, 2, 40 };

        //Variavel que guarda última posição que a roleta parou
        private int ultimoNumeroRoleta = 0;

        private int c = 0;
        int numeroDeParadaAleatorio = 0;
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
            timer2.Interval = tempo.Next(70, 250);
            timer1.Enabled = true;
            timer2.Enabled = true;
            numeroDeParadaAleatorio = tempo.Next(12, 20);
            c = 0;
            lblPergunta.MaximumSize = new Size(400, 0);
            lblJogador.Text = Jogador.Nome;
            Jogador.Pontos = 0;

            #region Insere opções na Lista
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
            #endregion

            EmJogo();
        }

        public void EmJogo()
        {
            cmdRespostaA.Enabled = false;
            cmdRespostaB.Enabled = false;
            cmdRespostaC.Enabled = false;
            cmdRespostaD.Enabled = false;
            cmdConfirma.Enabled = false;
            button1.Enabled = false;

            if (posicao != 0)
            {
                cmdRespostaA.Enabled = false;
                cmdRespostaB.Enabled = false;
                cmdRespostaC.Enabled = false;
                cmdRespostaD.Enabled = false;
                cmdConfirma.Enabled = false;
                button1.Enabled = false;

                timer2.Enabled = true;
                timer1.Enabled = true;
                cmdGirar.Enabled = false;
                numeroDeParadaAleatorio = tempo.Next(12, 20);
                c = 0;
            }
            if (posicao <= 7)
            {
                lblPergunta.Text = listaPerguntas[posicao].Pergunta;
                lblPontos.Text = "Vale: " + listaPerguntas[posicao].Pontos.ToString();
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
            ultimoNumeroRoleta = contador;
            contador++;
            if (contador >= 12)
            {
                contador = 0;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (c == numeroDeParadaAleatorio)
            {
                timer1.Enabled = false;

                cmdRespostaA.Enabled = true;
                cmdRespostaB.Enabled = true;
                cmdRespostaC.Enabled = true;
                cmdRespostaD.Enabled = true;
                cmdConfirma.Enabled = true;
                button1.Enabled = true;
            }
            c++;
        }

        private void cmdConfirma_Click(object sender, EventArgs e)
        {
            #region CorBotao
            cmdRespostaA.BackColor = Color.DarkRed;
            cmdRespostaA.ForeColor = Color.White;
            cmdRespostaB.BackColor = Color.DarkRed;
            cmdRespostaB.ForeColor = Color.White;
            cmdRespostaC.BackColor = Color.DarkRed;
            cmdRespostaC.ForeColor = Color.White;
            cmdRespostaD.BackColor = Color.DarkRed;
            cmdRespostaD.ForeColor = Color.White;
            #endregion

            cmdGirar.Enabled = true;
            numeroDeParadaAleatorio = 0;
            c = 0;

            if (resposta == 0)
            {
                MessageBox.Show("Escolha uma resposta!");
            }
            else
            {
                var pontosPergunta = listaPerguntas.Where(c => c.ID == posicao + 1).FirstOrDefault().Pontos;
                var bonusMultiplicador = multiplicaPontosRoleta[ultimoNumeroRoleta];
                switch (resposta)
                {
                    case 1:
                        var pegaRespostaA = listaRespostas.Where(c => c.IDPergunta == posicao + 1).FirstOrDefault();
                        if (pegaRespostaA.LetraResposta == resposta)
                        {
                            Jogador.Pontos += (pontosPergunta * bonusMultiplicador);
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao + 1}");
                        }
                        else
                        {
                            MessageBox.Show($"Resposta Incorreta, a resposta correta era a {eLetraResposta.GetNomeTela(pegaRespostaA.LetraResposta)}");
                        }
                        break;
                    case 2:
                        var pegaRespostaB = listaRespostas.Where(c => c.IDPergunta == posicao + 1).FirstOrDefault();
                        if (pegaRespostaB.LetraResposta == resposta)
                        {
                            Jogador.Pontos += (pontosPergunta * bonusMultiplicador);
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao + 1}");
                        }
                        else
                        {
                            MessageBox.Show($"Resposta Incorreta, a resposta correta era a {eLetraResposta.GetNomeTela(pegaRespostaB.LetraResposta)}");
                        }
                        break;
                    case 3:
                        var pegaRespostaC = listaRespostas.Where(c => c.IDPergunta == posicao + 1).FirstOrDefault();
                        if (pegaRespostaC.LetraResposta == resposta)
                        {
                            Jogador.Pontos += (pontosPergunta * bonusMultiplicador);
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao + 1}");
                        }
                        else
                        {
                            MessageBox.Show($"Resposta Incorreta, a resposta correta era a {eLetraResposta.GetNomeTela(pegaRespostaC.LetraResposta)}");
                        }
                        break;
                    case 4:
                        var pegaRespostaD = listaRespostas.Where(c => c.IDPergunta == posicao + 1).FirstOrDefault();
                        if (pegaRespostaD.LetraResposta == resposta)
                        {
                            Jogador.Pontos += (pontosPergunta * bonusMultiplicador);
                            MessageBox.Show($"Parabéns, você acertou a pergunta {posicao + 1}");
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
            cmdRespostaA.BackColor = Color.Yellow;
            cmdRespostaA.ForeColor = Color.Black;
            cmdRespostaB.Enabled = false;
            cmdRespostaC.Enabled = false;
            cmdRespostaD.Enabled = false;
        }

        private void cmdRespostaB_Click(object sender, EventArgs e)
        {
            resposta = 2;
            cmdRespostaB.BackColor = Color.Yellow;
            cmdRespostaB.ForeColor = Color.Black;
            cmdRespostaA.Enabled = false;
            cmdRespostaC.Enabled = false;
            cmdRespostaD.Enabled = false;
        }

        private void cmdRespostaC_Click(object sender, EventArgs e)
        {
            resposta = 3;
            cmdRespostaC.BackColor = Color.Yellow;
            cmdRespostaC.ForeColor = Color.Black;
            cmdRespostaA.Enabled = false;
            cmdRespostaB.Enabled = false;
            cmdRespostaD.Enabled = false;
        }

        private void cmdRespostaD_Click(object sender, EventArgs e)
        {
            resposta = 4;
            cmdRespostaD.BackColor = Color.Yellow;
            cmdRespostaD.ForeColor = Color.Black;
            cmdRespostaA.Enabled = false;
            cmdRespostaB.Enabled = false;
            cmdRespostaC.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region CorBotao
            cmdRespostaA.BackColor = Color.DarkRed;
            cmdRespostaA.ForeColor = Color.White;
            cmdRespostaB.BackColor = Color.DarkRed;
            cmdRespostaB.ForeColor = Color.White;
            cmdRespostaC.BackColor = Color.DarkRed;
            cmdRespostaC.ForeColor = Color.White;
            cmdRespostaD.BackColor = Color.DarkRed;
            cmdRespostaD.ForeColor = Color.White;
            #endregion
            cmdRespostaA.Enabled = true;
            cmdRespostaB.Enabled = true;
            cmdRespostaC.Enabled = true;
            cmdRespostaD.Enabled = true;
            resposta = 0;
        }


        private void cmdGirar_Click(object sender, EventArgs e)
        {

            //timer2.Enabled = true;
            //timer1.Enabled = true;
            //cmdGirar.Enabled = false;
            //k = tempo.Next(12, 20);
            //c = 0;

        }
    }
}
