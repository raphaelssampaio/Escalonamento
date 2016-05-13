using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processos
{
    public partial class EscalonamentoDeProcessos : Form
    {
        // Criando contador de visibilidade
        public static int contador = 0;
        
        // Criando objetos da classe processos
        static ClasseProcessos p1;
        static ClasseProcessos p2;
        static ClasseProcessos p3;
        static ClasseProcessos p4;

        public EscalonamentoDeProcessos()
        {
            InitializeComponent();

            // Inicializa com o primeiro item do combobox selecionado
            cbxProcessos.SelectedIndex = 0;
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            if (contador==0)
            {
                lbP1.Visible = true;
                tbxP1.Visible = true;
                lbChegadaP1.Visible = true;
                tbxChegadaP1.Visible = true;
                contador++;
                p1 = new ClasseProcessos("P1");    
            }
            else if (contador == 1)
            {
                lbP2.Visible = true;
                tbxP2.Visible = true;
                lbChegadaP2.Visible = true;
                tbxChegadaP2.Visible = true;
                contador++;
                p2 = new ClasseProcessos("P2");
            }
            else if (contador == 2)
            {
                lbP3.Visible = true;
                tbxP3.Visible = true;
                lbChegadaP3.Visible = true;
                tbxChegadaP3.Visible = true;
                contador++;
                p3 = new ClasseProcessos("P3");
            }
            else if (contador == 3)
            {
                lbP4.Visible = true;
                tbxP4.Visible = true;
                lbChegadaP4.Visible = true;
                tbxChegadaP4.Visible = true;
                contador++;
                p4 = new ClasseProcessos("P4");
            }
            else
            {
                MessageBox.Show("Número máximo de processos atingido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                lbP4.Visible = false;
                tbxP4.Visible = false;
                lbChegadaP4.Visible = false;
                tbxChegadaP4.Visible = false;
                contador--;
            } else if(contador == 3)
            {
                lbP3.Visible = false;
                tbxP3.Visible = false;
                lbChegadaP3.Visible = false;
                tbxChegadaP3.Visible = false;
                contador--;
            }
            else if (contador == 2)
            {
                lbP2.Visible = false;
                tbxP2.Visible = false;
                lbChegadaP2.Visible = false;
                tbxChegadaP2.Visible = false;
                contador--;
            }
            else if (contador == 1)
            {
                lbP1.Visible = false;
                tbxP1.Visible = false;
                lbChegadaP1.Visible = false;
                tbxChegadaP1.Visible = false;
                contador--;
            }else
            {
                MessageBox.Show("Nenhum processo a ser excluído!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chkbxQuantum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxQuantum.Checked)
            { 
                tbxQuantum.Enabled = true;
            }
            else
            {
                tbxQuantum.Enabled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
