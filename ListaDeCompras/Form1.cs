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
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question );

                if(rst == DialogResult.Yes)
                {    
                    //Remove os items da lista 
                    libListaCompras.Items.RemoveAt(libListaCompras.SelectedIndex);
                }
                else {libListaCompras.SelectedIndex = -1;}

            }
       

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa todos os items
            txbCadastrarItem.Clear();
            libListaCompras.Items.Clear();
        }













        private void libListaCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
