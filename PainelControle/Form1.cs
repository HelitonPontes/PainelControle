using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainelControle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PainelControle PC = new PainelControle();



        private void btnLigarDesligar_Click(object sender, EventArgs e)
        {

            PC.MLigarDesligar();


            if (PC.Ligar == true)
            {
                txtLigarDesligar.Text = PC.Liga;


            }
            if (PC.Desligar == true)
            {
                txtLigarDesligar.Text = PC.Desliga;

            }
            if (PC.Desligar == true && PC.DesligarAlarme == true)

            {
                txtLigarDesligar.Text = PC.Desliga;
                txtLigarDesligarAlarme.Text = PC.DesligaAlarme;

            }


        }

        private void btnLDAlarme_Click(object sender, EventArgs e)
        {

            PC.MLigarDesligarAlarme();


            if (PC.LigarAlarme == true)
            {
                txtLigarDesligarAlarme.Text = PC.Liga;


            }
            if (PC.DesligarAlarme == true)
            {
                txtLigarDesligarAlarme.Text = PC.Desliga;

            }
            
        }

        private void btnDisiparo_Click(object sender, EventArgs e)
        {
            
            txtSirene.Clear();
            if ( PC.LigarAlarme == false)
            {
                MessageBox.Show("Alarme Desligado");
          

            }else
            {
                txtSirene.Text = "Acionado a Policia";
            }
        }

        private void btnIluminaçãpo_Click(object sender, EventArgs e)
        {
            PC.MIlminação();

            if ( PC.LigarIluminação == false)
            {
                MessageBox.Show("Deseja Desligar Iluminação");

                txtIluminação.Text = PC.DesligaIluminação;
            }else
            {
                MessageBox.Show("Deseja Ligar Iluminação");
                txtIluminação.Text = PC.LigaIluminação;
            }
        }
    }
}

