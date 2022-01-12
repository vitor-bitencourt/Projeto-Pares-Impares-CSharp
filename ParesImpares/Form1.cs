using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParesImpares
{
 

    public partial class Form1 : Form
    {
        double num, somag, somap, somai, qtdg, qtdp, qtdi;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_qtdg.Clear();
            txt_qtdi.Clear();
            txt_qtdp.Clear();
            txt_somag.Clear();
            txt_somai.Clear();
            txt_somap.Clear();
           
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            
            
            //Exibe os resultados das somas

            txt_somap.Text = Convert.ToString(somap);
            txt_somai.Text = Convert.ToString(somai);


            //Exibe a quantidade dos números

            txt_qtdp.Text = Convert.ToString(qtdp);
            txt_qtdi.Text = Convert.ToString(qtdi);


            //Exibe a quantidade geral

            qtdg = qtdp + qtdi;
            txt_qtdg.Text = Convert.ToString(qtdg);
            

            //Exibe a soma geral

            somag = somap + somai;
            txt_somag.Text = Convert.ToString(somag);

            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            num = double.Parse(txt_num.Text);
            
            if (num % 2 == 0)
            {
                //Soma os pares existentes com os novos
                somap = somap + num;
                //Conta a quantidade de pares
                qtdp++;  
            }
            else
            {
                //Soma os ímpares exixtentes com os novos
                somai = somai + num;
                //Conta a quantidade de pares
                qtdi++;
            }

            txt_num.Clear();
             
        }

    }
}
