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
            // Tipo da figurinha
            cmbTipo.Items.Add("Comum");
            cmbTipo.Items.Add("Especial");

            // Lista de seleções da Copa do Mundo 2026
            string[] selecoes = {
                "Alemanha", "Argentina", "Bélgica", "Brasil", "Canadá",
                "Croácia", "Equador", "Espanha", "EUA", "França",
                "Inglaterra", "Itália", "Japão", "México", "Holanda",
                "Portugal", "Uruguai", "Marrocos"
                // adicione as demais conforme necessário
            };

            foreach (string s in selecoes)
                cmbSelecao.Items.Add(s);

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

                if (dados.Length < 7)
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
            cmbSelecao.SelectedIndex = -1;
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

            // Ignora a linha "nova linha" (vazia) ou células sem valor
            if (dgvFigurinhas.Rows[e.RowIndex].Cells[0].Value == null)
                return;

            txtCodigo.Text =
                dgvFigurinhas.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.RowIndex < 0)
                return;

            txtCodigo.Text =
                dgvFigurinhas.Rows[e.RowIndex].Cells[0].Value.ToString();

            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                // Proteção: ignora linhas com formato inválido
                if (dados.Length < 7)
                    continue;

                if (dados[0] == txtCodigo.Text)
                {
                    cmbSelecao.Text = dados[1];
                    txtJogador.Text = dados[2];
                    cmbTipo.Text = dados[3];

                    chkPossui.Checked = Convert.ToBoolean(dados[4]);
                    chkDesejado.Checked = Convert.ToBoolean(dados[5]);

                    caminhoImagem = dados[6];

                    if (File.Exists(caminhoImagem))
                        picFoto.ImageLocation = caminhoImagem;
                    else
                        picFoto.Image = null;

                    break;
                }
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (!CamposValidos())
                return;

            if (!JogadorValido())
                return;

            if (!CamposValidos())
                return;

            // Verifica se o código já existe (evita duplicidade)
            if (File.Exists(arquivo))
            {
                var linhas = File.ReadAllLines(arquivo);
                if (linhas.Any(l => l.Split(';')[0] == txtCodigo.Text.Trim()))
                {
                    MessageBox.Show("Já existe uma figurinha cadastrada com esse código.");
                    return;
                }
            }

            string linha = MontarLinha();

            File.AppendAllText(arquivo, linha + Environment.NewLine);

            MessageBox.Show("Figurinha cadastrada com sucesso!");

            LimparCampos();
            CarregarGrid();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (!CamposValidos())
                return;

            if (!JogadorValido())
                return;

            if (!CamposValidos())
                return;

            if (!File.Exists(arquivo))
            {
                MessageBox.Show("Arquivo não encontrado.");
                return;
            }

            List<string> linhas = File.ReadAllLines(arquivo).ToList();

            bool encontrou = false;

            for (int i = 0; i < linhas.Count; i++)
            {
                string[] dados = linhas[i].Split(';');

                if (dados[0] == txtCodigo.Text.Trim())
                {
                    linhas[i] = MontarLinha();
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

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione uma figurinha para excluir.");
                return;
            }

            var confirmacao = MessageBox.Show(
                "Tem certeza que deseja excluir esta figurinha?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao != DialogResult.Yes)
                return;

            List<string> linhas = File.ReadAllLines(arquivo).ToList();

            linhas.RemoveAll(x => x.Split(';')[0] == txtCodigo.Text.Trim());

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
                string pastaFotos = Path.Combine(Application.StartupPath, "Fotos");

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

        // Verifica se todos os campos obrigatórios foram preenchidos
        private bool CamposValidos()
        {
            if (
                txtCodigo.Text.Trim() == "" ||
                cmbSelecao.Text.Trim() == "" ||
                txtJogador.Text.Trim() == "" ||
                cmbTipo.Text == "" ||
                caminhoImagem == ""
            )
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return false;
            }

            return true;
        }

        // Monta a linha no formato:
        // Codigo;Selecao;Jogador;Tipo;Possui;Desejado;CaminhoImagem
        private string MontarLinha()
        {
            return
                txtCodigo.Text.Trim() + ";" +
                cmbSelecao.Text.Trim() + ";" +
                txtJogador.Text.Trim() + ";" +
                cmbTipo.Text + ";" +
                chkPossui.Checked + ";" +
                chkDesejado.Checked + ";" +
                caminhoImagem;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Verifica se o jogador já está cadastrado em outra seleção
        private bool JogadorValido()
        {
            if (!File.Exists(arquivo))
                return true;

            string jogador = txtJogador.Text.Trim();
            string selecao = cmbSelecao.Text.Trim();
            string codigoAtual = txtCodigo.Text.Trim();

            var linhas = File.ReadAllLines(arquivo);

            foreach (var linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados.Length < 7)
                    continue;

                // Ignora a própria figurinha (importante na hora de Alterar)
                if (dados[0] == codigoAtual)
                    continue;

                // Mesmo nome de jogador, mas seleção diferente = inválido
                if (dados[2].Equals(jogador, StringComparison.OrdinalIgnoreCase)
                    && dados[1] != selecao)
                {
                    MessageBox.Show(
                        $"O jogador \"{jogador}\" já está cadastrado na seleção \"{dados[1]}\". " +
                        "Um jogador não pode pertencer a duas seleções diferentes.");
                    return false;
                }
            }

            return true;
        }
    }
}