using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txbCadastrarItem.Text == "")
            {
                //Exibe uma menssagem de erro caso o campo esteja vazio
                MessageBox.Show("O campo não pode estar vazio, por favor preencher o campo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {   //Adiciona o item a lista 
                libListaCompras.Items.Add(txbCadastrarItem.Text);
                txbCadastrarItem.Clear();
            }

        }

        private void libListaCompras_DoubleClick(object sender, EventArgs e)
        {
            if (libListaCompras.SelectedIndex != -1)

            {   //Exibe um icone de menssagem perguntando se deseja excluir
                DialogResult rst = MessageBox.Show("Tem certeza que deseja excluir o item", "Excluir",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rst == DialogResult.Yes)
                {
                    //Remove os items da lista 
                    libListaCompras.Items.RemoveAt(libListaCompras.SelectedIndex);
                }
                else { libListaCompras.SelectedIndex = -1; }

            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa todos os items
            txbCadastrarItem.Clear();
            libListaCompras.Items.Clear();
        }



        private void txbCadastrarItem_KeyDown(object sender, KeyEventArgs e)
        {
            //Verifica se a tecla enter foi pressionada
            if (e.KeyCode == Keys.Enter)
            {
                //Simula o clique da tecla enter no botão adicionar
                btnAdicionar.PerformClick();

            }

         }

 private void txbCadastrarItem_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verifica se o caractere é um número
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede de colocar caracter
            }



        }




       

       
    }
}
