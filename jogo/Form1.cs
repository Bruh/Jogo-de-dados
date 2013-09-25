using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace jogo
{


    public partial class Form1 : Form
    {
        int valorImagem;

        public Form1()
        {
            InitializeComponent();
            sortear();
        }

        public void sortear(){

            Random aleatorio = new Random();
            valorImagem = aleatorio.Next(1, 10);
            pictureBoxWillian.Image = Image.FromFile(@"C:\Users\Willian\Desktop\jogo\jogo\imagem\" + Convert.ToString(valorImagem) + ".png");

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            txtnum.Text = "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnum.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtnum.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnum.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtnum.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtnum.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtnum.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtnum.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtnum.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(valorImagem) == txtnum.Text)
            {
                certo C = new certo();
                C.Show();
                this.Hide();

            }
            else
            {
                Errado E = new Errado();
                E.Show();
                this.Hide();

            }
            sortear();
            

           }

        private void button11_Click(object sender, EventArgs e)
        {

            Application.Exit();
           
        }

        }

    }
