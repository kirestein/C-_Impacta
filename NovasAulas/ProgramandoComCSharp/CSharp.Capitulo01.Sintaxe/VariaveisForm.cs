using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Capitulo01.Sintaxe
{
    public partial class VariaveisForm : Form
    {
        public VariaveisForm()
        {
            InitializeComponent();
        }

        //private void toolStripTextBox1_Click(object sender, EventArgs e)
        //{
        //    int x = 42;
        //    DateTime dataNascimento = new DateTime(1984, 09, 15);
        //    decimal n1 = 31234m;

        //    listBox1.Items.Add($"A soma de 35 mais 12 é igual a {35 + 12}.");
        //    listBox1.Items.Add($"A multiplicação de 35 por 12 é igual a {35 * 12}.");
        //    listBox1.Items.Add($"A subtração de 35 menos 12 é igual a {35 - 12}.");
        //    listBox1.Items.Add($"A divisão de 35 por 12 é igual a {35 / 12}");
        //    listBox1.Items.Add($"O resto da divisão de 35 pr 12 é {35 % 12}.");
        //}

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {



            int n1 = 12;
            int n2 = 25;
            var resultado = n1 + n2;

            listBox1.Items.Add($"O resultado de {n1} + {n2} é igual a {resultado}");

            listBox1.Items.Add(new String('-', 50));

        }

        private void subtracaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int n1 = 12;
            int n2 = 25;
            var resultado = n1 - n2;

            listBox1.Items.Add($"O resultado de {n1} - {n2} é igual a {resultado}");

        }

        private void multiplicacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int n1 = 12;
            int n2 = 25;
            var resultado = n1 * n2;

            listBox1.Items.Add($"O resultado de {n1} vezes {n2} é igual a {resultado}");

        }

        private void divisaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int n1 = 25;
            double n2 = 12;
            var resultado = n1 / n2;

            listBox1.Items.Add($"O resultado de {n1} dividido {n2} é igual a {resultado}");

        }

        private void restoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int n1 = 25;
            int n2 = 12;
            var resultado = n1 % n2;

            listBox1.Items.Add($"O resto da divisão de {n1} por {n2} é igual a {resultado}");

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
