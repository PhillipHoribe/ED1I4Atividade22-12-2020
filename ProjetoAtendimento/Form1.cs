using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();

        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void buttonListSenhas_Click(object sender, EventArgs e)
        {
            labelSenhas.Items.Clear();
            foreach (Senha s in senhas.filaSenhas) { labelSenhas.Items.Add(s.dadosParciais()); }
        }

        private void buttonAddGuiche_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());

            lblQtdGuiches.Text = guiches.listaGuiches.Count.ToString();
        }

        private void buttonChamar_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            guiches.listaGuiches[index].Chamar(senhas.filaSenhas);
        }

        private void buttonListaAtendimentos_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;

            labelAtendimentos.Items.Clear();
            foreach (Senha s in guiches.listaGuiches[index].atendimentos.ToList()) { labelAtendimentos.Items.Add(s.dadosCompletos()); }
        }
    }
}
