using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoletaDoSaber
{
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Matrix m = new Matrix();

            //// Rotacionar o quanto quiser

            //m.Rotate(10);

            //// Atribui-la ao objeto Graphics que vai fazer o desenho, no caso aqui
            //// estou usando o próprio form.

            //e.Graphics.Transform = m;

            //// E então desenhar a imagem...

            //e.Graphics.DrawImage(new Bitmap("c:\\Roleta.jpg"), 0, 0);

            //// Depois, volte tudo ao normal, sem a rotação que foi aplicada acima

            //e.Graphics.ResetTransform();
        }
    }
}
