using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Appcadastro_fut
{
    public partial class Form1 : Form
    {
        private string arquivo = "figurinhas.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Comum");
            cmbTipo.Items.Add("Especial");

            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dgvFigurinhas.Rows.Clear();

            if (!File.Exists(arquivo))
                return;

            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] dados = linha.Split(';');

                if (dados.Length < 4)
                    continue;

                dgvFigurinhas.Rows.Add(
                    dados[0],
                    dados[1],
                    dados[2],
                    dados[3]
                );
            }
        }

        private void LimparCampos()
        {
         
            txtCodigo.Clear();
            txtSelecao.Clear();
            txtJogador.Clear();

            cmbTipo.SelectedIndex = -1;

            chkPossui.Checked = false;
            chkDesejado.Checked = false;

            caminhoImagem = "";
            picFoto.Image = null;

            txtCodigo.Focus();
        }
        
 

        private void dgvFigurinhas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtCodigo.Text =
                dgvFigurinhas.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtSelecao.Text =
                dgvFigurinhas.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtJogador.Text =
                dgvFigurinhas.Rows[e.RowIndex].Cells[2].Value.ToString();

            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados[0] == txtCodigo.Text)
                {
                    cmbTipo.Text = dados[3];

                    chkPossui.Checked =
                        Convert.ToBoolean(dados[4]);

                    chkDesejado.Checked =
                        Convert.ToBoolean(dados[5]);

                    caminhoImagem = dados[6];

                    if (File.Exists(caminhoImagem))
                        picFoto.ImageLocation = caminhoImagem;

                    break;
                }
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (
        txtCodigo.Text.Trim() == "" ||
        txtSelecao.Text.Trim() == "" ||
        txtJogador.Text.Trim() == "" ||
        cmbTipo.Text == "" ||
        caminhoImagem == ""
       )
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            string linha =
                txtCodigo.Text.Trim() + ";" +
                txtSelecao.Text.Trim() + ";" +
                txtJogador.Text.Trim() + ";" +
                cmbTipo.Text + ";" +
                chkPossui.Checked + ";" +
                chkDesejado.Checked + ";" +
                caminhoImagem;

            File.AppendAllText(
                arquivo,
                linha + Environment.NewLine);

            MessageBox.Show("Figurinha cadastrada com sucesso!");

            LimparCampos();
            CarregarGrid();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(arquivo))
            {
                MessageBox.Show("Arquivo não encontrado.");
                return;
            }

            List<string> linhas =
                File.ReadAllLines(arquivo).ToList();

            bool encontrou = false;

            for (int i = 0; i < linhas.Count; i++)
            {
                string[] dados = linhas[i].Split(';');

                if (dados[0] == txtCodigo.Text.Trim())
                {
                    linhas[i] =
                     txtCodigo.Text.Trim() + ";" +
                     txtSelecao.Text.Trim() + ";" +
                     txtJogador.Text.Trim() + ";" +
                     cmbTipo.Text + ";" +
                     chkPossui.Checked + ";" +
                     chkDesejado.Checked + ";" +
                     caminhoImagem;

                    encontrou = true;
                    break;
                }
            }

            if (!encontrou)
            {
                MessageBox.Show("Figurinha não encontrada.");
                return;
            }

            File.WriteAllLines(arquivo, linhas);

            MessageBox.Show("Figurinha alterada com sucesso!");

            LimparCampos();
            CarregarGrid();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(arquivo))
            {
                MessageBox.Show("Arquivo não encontrado.");
                return;
            }

            List<string> linhas =
                File.ReadAllLines(arquivo).ToList();

            linhas.RemoveAll(x =>
                x.Split(';')[0] == txtCodigo.Text.Trim());

            File.WriteAllLines(arquivo, linhas);

            MessageBox.Show("Figurinha excluída com sucesso!");

            LimparCampos();
            CarregarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter = "Imagens|*.jpg;*.jpeg;*.png";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string pastaFotos = "Fotos";

                if (!Directory.Exists(pastaFotos))
                    Directory.CreateDirectory(pastaFotos);

                string nomeArquivo = Path.GetFileName(abrir.FileName);

                string destino = Path.Combine(pastaFotos, nomeArquivo);

                File.Copy(abrir.FileName, destino, true);

                caminhoImagem = destino;

                picFoto.ImageLocation = caminhoImagem;
            }
        }
        
        
        private string caminhoImagem = "";

        
    }
}