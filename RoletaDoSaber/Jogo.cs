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
        public static List<Label> listaOpcoesRoleta = new List<Label>();

        public Jogo()
        {
            InitializeComponent();
        }

        int contador = 0;

        private void Jogo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;

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

            //for (int i = 0; i < 12; i++)
            //{
            //    if (contador != 0)
            //    {
            //        listaOpcoesRoleta[contador - 1].ForeColor = Color.Black;
            //    }
            //    listaOpcoesRoleta[contador].ForeColor = Color.White;
            //    contador++;
            //    if (contador >= 12)
            //    {
            //        contador = 0;
            //    }
            //    Thread.Sleep(150);
            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(contador == 0)
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
            //Fazer Classe Pergunta com as propriedades Pergunta, Resposta A, B, C, D
            //Fazer lista estática para guardar todas as perguntas
            //A cada vez que clicar no botão confirma, trocar as propriedades text do botão e da pergunta
            //pela pergunta que estiver na posição do foreach()
        }
    }
}
