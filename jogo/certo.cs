using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace jogo
{
    public partial class certo : Form
    {
        public certo()
        {
            InitializeComponent();

            SoundPlayer tocarSom = new SoundPlayer(@"C:\Users\Willian\Desktop\jogo\jogo\imagem\cuco.wav");
            tocarSom.Play();


        }

        private void certo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 jogo = new Form1();
            jogo.Show();
        }

    }
}
