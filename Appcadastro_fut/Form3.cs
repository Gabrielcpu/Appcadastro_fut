using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Appcadastro_fut
{
    public partial class Form3 : Form
    {
        private string arquivo = "figurinhas.txt";
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {

             dgvLista.Rows.Clear();

            if (!File.Exists(arquivo))
                return;

            string nome = txtFiltroNome.Text.ToLower();

            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                bool exibir = true;

                if (!string.IsNullOrWhiteSpace(nome))
                {
                    if (!dados[2].ToLower().Contains(nome))
                        exibir = false;
                }

                if (chkFiltroObtido.Checked)
                {
                    if (dados[4] != "True")
                        exibir = false;
                }

                if (chkFiltroDesejado.Checked)
                {
                    if (dados[5] != "True")
                        exibir = false;
                }

                if (exibir)
                {
                    dgvLista.Rows.Add(
                        dados[0],
                        dados[1],
                        dados[2],
                        dados[3],
                        dados[4],
                        dados[5],
                        "✔",
                        "❤",
                        "👁",
                        "🗑"
                    );
                }
            }
        }

        private void CarregarGrid()
        {
            dgvLista.Rows.Clear();

            if (!File.Exists(arquivo))
                return;

            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados.Length < 7)
                    continue;

                dgvLista.Rows.Add(
                    dados[0],
                    dados[1],
                    dados[2],
                    dados[3],
                    dados[4],
                    dados[5],
                    "✔",
                    "❤",
                    "👁",
                    "🗑"
                );
            }
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();

            if (!File.Exists(arquivo))
                return;

            string nome = txtFiltroNome.Text.ToLower();

            string[] linhas = File.ReadAllLines(arquivo);

           
            foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(';');
  
                bool exibir = true;

                if (!string.IsNullOrWhiteSpace(nome))
                {
                    if (!dados[2].ToLower().Contains(nome))
                        exibir = false;
                }

                if (chkFiltroObtido.Checked)
                {
                    if (dados[4] != "True")
                        exibir = false;
                }

                if (chkFiltroDesejado.Checked)
                {
                    if (dados[5] != "True")
                        exibir = false;
                }

                if (exibir)
                {
                    dgvLista.Rows.Add(
                        dados[0],
                        dados[1],
                        dados[2],
                        dados[3],
                        dados[4],
                        dados[5],
                        "✔",
                        "❤",
                        "👁",
                        "🗑"
                    );
                }
            }
        }
    }
}
