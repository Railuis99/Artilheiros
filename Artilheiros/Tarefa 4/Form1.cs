using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_4
{
    public partial class Form1 : Form
    {
        string[] jogador = new string[3];
        int[] gols = new int[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jogador[0] = "Messi";
            jogador[1] = "Ronaldo";
            jogador[2] = "Maradona";

            txtPes.Text = jogador[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cont = 0;

            for (int x = 0; x < gols.Length; x++)
                gols[x] = 0;

            for (int x = 0; x < jogador.Length; x++)
            {
                if (x == 0)
                {
                    txtJog1.Text = jogador[x];
                    txtGols1.Text = gols[x].ToString();
                }
                else if(x == 1)
                {
                    txtJog2.Text = jogador[x];
                    txtGols2.Text = gols[x].ToString();
                }
                else
                {
                    txtJog3.Text = jogador[x];
                    txtGols3.Text = gols[x].ToString();
                }
                cont++;
            }

            txtNumJogGol.Text = 0.ToString();
            txtNumJog.Text = cont.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;

            gols[0] = gols[0] + 1;
            txtGols1.Text = gols[0].ToString();

            for(int x = 0; x < gols.Length; x++)
            {
                if (gols[x] > 0)
                    cont++;
            }

            txtNumJogGol.Text = cont.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0; 

            gols[0] = gols[0] - 1;
            txtGols1.Text = gols[0].ToString();

            for (int x = 0; x < gols.Length; x++)
            {
                if (gols[x] > 0)
                    cont++;
            }

            txtNumJogGol.Text = cont.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cont = 0;

            gols[1] = gols[1] + 1;
            txtGols2.Text = gols[1].ToString();

            for (int x = 0; x < gols.Length; x++)
            {
                if (gols[x] > 0)
                    cont++;
            }

            txtNumJogGol.Text = cont.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cont = 0;

            gols[1] = gols[1] - 1;
            txtGols2.Text = gols[1].ToString();

            for (int x = 0; x < gols.Length; x++)
            {
                if (gols[x] > 0)
                    cont++;
            }

            txtNumJogGol.Text = cont.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cont = 0;

            gols[2] = gols[2] + 1;
            txtGols3.Text = gols[2].ToString();

            for (int x = 0; x < gols.Length; x++)
            {
                if (gols[x] > 0)
                    cont++;
            }

            txtNumJogGol.Text = cont.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cont = 0;

            gols[2] = gols[2] - 1;
            txtGols3.Text = gols[2].ToString();

            for (int x = 0; x < gols.Length; x++)
            {
                if (gols[x] > 0)
                    cont++;
            }

            txtNumJogGol.Text = cont.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int pos = (int)selJog.Value;

            if (pos != 0)
                txtPes.Text = jogador[pos - 1].ToString();
            else
                txtPes.Text = "";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            int jogArr = Convert.ToInt16(txtJogArr.Text) - 1;
            int jogLis = Convert.ToInt16(txtJogLis.Text) - 1;
            string jog = jogador[jogArr];

            listJog.SelectedIndex = jogLis;
            jogador[jogArr] = listJog.SelectedItem.ToString();
            gols[jogArr] = 0;

            listJog.Items.Insert(jogLis, jog);
            listJog.Items.RemoveAt(jogLis + 1);


            for (int x = 0; x < jogador.Length; x++)
            {
                if (x == 0)
                {
                    txtJog1.Text = jogador[x];
                    txtGols1.Text = gols[x].ToString();
                }
                else if (x == 1)
                {
                    txtJog2.Text = jogador[x];
                    txtGols2.Text = gols[x].ToString();
                }
                else
                {
                    txtJog3.Text = jogador[x];
                    txtGols3.Text = gols[x].ToString();
                }
            }
        }
    }
}
