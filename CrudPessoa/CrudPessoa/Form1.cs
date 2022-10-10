using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // declara lista
        List<Pessoa> listaPessoa = new List<Pessoa>();

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMae_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listaPessoa.Count; i++)
            {
                if(txtBoxNome.Text == listaPessoa[i].nome)
                {
                    txtboxIdade.Text = listaPessoa[i].idade;
                    txtboxMae.Text = listaPessoa[i].mae;
                }
                else
                {
                    MessageBox.Show("Nao tem");
                }
            }
        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaPessoa.Count; i++)
            {
                if (txtBoxNome.Text == listaPessoa[i].nome)
                {
                    listaPessoa.RemoveAt(i);
                }
            }
            limpar();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa NovaPessoa = new Pessoa();

            NovaPessoa.nome = txtBoxNome.Text;
            NovaPessoa.idade = txtboxIdade.Text;
            NovaPessoa.mae = txtboxMae.Text;

            listaPessoa.Add(NovaPessoa);
            limpar();

        }

        private void limpar()
        {
            txtBoxNome.Text = null;
            txtboxIdade.Text = null;
            txtboxMae.Text = null;
        }
    }
}
