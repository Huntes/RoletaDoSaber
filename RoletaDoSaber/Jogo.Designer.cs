
namespace RoletaDoSaber
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.cmdRespostaA = new System.Windows.Forms.Button();
            this.cmdRespostaB = new System.Windows.Forms.Button();
            this.cmdRespostaC = new System.Windows.Forms.Button();
            this.cmdRespostaD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RoletaDoSaber.Properties.Resources.Roleta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(71, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.Color.White;
            this.lblPergunta.Location = new System.Drawing.Point(558, 38);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(140, 33);
            this.lblPergunta.TabIndex = 1;
            this.lblPergunta.Text = "Pergunta";
            // 
            // cmdRespostaA
            // 
            this.cmdRespostaA.BackColor = System.Drawing.Color.DarkRed;
            this.cmdRespostaA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRespostaA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRespostaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRespostaA.ForeColor = System.Drawing.Color.White;
            this.cmdRespostaA.Location = new System.Drawing.Point(512, 185);
            this.cmdRespostaA.Name = "cmdRespostaA";
            this.cmdRespostaA.Size = new System.Drawing.Size(232, 46);
            this.cmdRespostaA.TabIndex = 2;
            this.cmdRespostaA.Text = "A) Resposta";
            this.cmdRespostaA.UseVisualStyleBackColor = false;
            // 
            // cmdRespostaB
            // 
            this.cmdRespostaB.BackColor = System.Drawing.Color.DarkRed;
            this.cmdRespostaB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRespostaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRespostaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRespostaB.ForeColor = System.Drawing.Color.White;
            this.cmdRespostaB.Location = new System.Drawing.Point(512, 251);
            this.cmdRespostaB.Name = "cmdRespostaB";
            this.cmdRespostaB.Size = new System.Drawing.Size(232, 46);
            this.cmdRespostaB.TabIndex = 3;
            this.cmdRespostaB.Text = "B) Resposta";
            this.cmdRespostaB.UseVisualStyleBackColor = false;
            // 
            // cmdRespostaC
            // 
            this.cmdRespostaC.BackColor = System.Drawing.Color.DarkRed;
            this.cmdRespostaC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRespostaC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRespostaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRespostaC.ForeColor = System.Drawing.Color.White;
            this.cmdRespostaC.Location = new System.Drawing.Point(512, 315);
            this.cmdRespostaC.Name = "cmdRespostaC";
            this.cmdRespostaC.Size = new System.Drawing.Size(232, 46);
            this.cmdRespostaC.TabIndex = 4;
            this.cmdRespostaC.Text = "C) Resposta";
            this.cmdRespostaC.UseVisualStyleBackColor = false;
            // 
            // cmdRespostaD
            // 
            this.cmdRespostaD.BackColor = System.Drawing.Color.DarkRed;
            this.cmdRespostaD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRespostaD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRespostaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRespostaD.ForeColor = System.Drawing.Color.White;
            this.cmdRespostaD.Location = new System.Drawing.Point(512, 378);
            this.cmdRespostaD.Name = "cmdRespostaD";
            this.cmdRespostaD.Size = new System.Drawing.Size(232, 46);
            this.cmdRespostaD.TabIndex = 5;
            this.cmdRespostaD.Text = "D) Resposta";
            this.cmdRespostaD.UseVisualStyleBackColor = false;
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RoletaDoSaber.Properties.Resources.backjogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdRespostaD);
            this.Controls.Add(this.cmdRespostaC);
            this.Controls.Add(this.cmdRespostaB);
            this.Controls.Add(this.cmdRespostaA);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Jogo";
            this.Text = "Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button cmdRespostaA;
        private System.Windows.Forms.Button cmdRespostaB;
        private System.Windows.Forms.Button cmdRespostaC;
        private System.Windows.Forms.Button cmdRespostaD;
    }
}