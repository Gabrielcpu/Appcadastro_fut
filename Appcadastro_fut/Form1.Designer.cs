namespace Appcadastro_fut
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chkPossui = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvFigurinhas = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPossui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnSelecionarFoto = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.chkDesejado = new System.Windows.Forms.CheckBox();
            this.cmbSelecao = new System.Windows.Forms.ComboBox();
            this.txtJogador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigurinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(44, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // chkPossui
            // 
            this.chkPossui.AutoSize = true;
            this.chkPossui.Location = new System.Drawing.Point(44, 206);
            this.chkPossui.Name = "chkPossui";
            this.chkPossui.Size = new System.Drawing.Size(139, 20);
            this.chkPossui.TabIndex = 3;
            this.chkPossui.Text = "Possuo a figurinha";
            this.chkPossui.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "codigo da figurinha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "selecao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "jogador";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(303, 24);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(303, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(303, 93);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(303, 125);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(303, 155);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvFigurinhas
            // 
            this.dgvFigurinhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFigurinhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colSelecao,
            this.colJogador,
            this.colPossui});
            this.dgvFigurinhas.Location = new System.Drawing.Point(486, 15);
            this.dgvFigurinhas.Name = "dgvFigurinhas";
            this.dgvFigurinhas.RowHeadersWidth = 51;
            this.dgvFigurinhas.RowTemplate.Height = 24;
            this.dgvFigurinhas.Size = new System.Drawing.Size(578, 159);
            this.dgvFigurinhas.TabIndex = 12;
            this.dgvFigurinhas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFigurinhas_CellClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 125;
            // 
            // colSelecao
            // 
            this.colSelecao.HeaderText = "Seleção";
            this.colSelecao.MinimumWidth = 6;
            this.colSelecao.Name = "colSelecao";
            this.colSelecao.Width = 125;
            // 
            // colJogador
            // 
            this.colJogador.HeaderText = "Jogador";
            this.colJogador.MinimumWidth = 6;
            this.colJogador.Name = "colJogador";
            this.colJogador.Width = 125;
            // 
            // colPossui
            // 
            this.colPossui.HeaderText = "Possui";
            this.colPossui.MinimumWidth = 6;
            this.colPossui.Name = "colPossui";
            this.colPossui.Width = 125;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(486, 206);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(578, 212);
            this.picFoto.TabIndex = 13;
            this.picFoto.TabStop = false;
            // 
            // btnSelecionarFoto
            // 
            this.btnSelecionarFoto.Location = new System.Drawing.Point(303, 351);
            this.btnSelecionarFoto.Name = "btnSelecionarFoto";
            this.btnSelecionarFoto.Size = new System.Drawing.Size(143, 35);
            this.btnSelecionarFoto.TabIndex = 14;
            this.btnSelecionarFoto.Text = "Selecionar Foto";
            this.btnSelecionarFoto.UseVisualStyleBackColor = true;
            this.btnSelecionarFoto.Click += new System.EventHandler(this.btnSelecionarFoto_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Comum",
            "Especial"});
            this.cmbTipo.Location = new System.Drawing.Point(303, 184);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 15;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // chkDesejado
            // 
            this.chkDesejado.AutoSize = true;
            this.chkDesejado.Location = new System.Drawing.Point(44, 245);
            this.chkDesejado.Name = "chkDesejado";
            this.chkDesejado.Size = new System.Drawing.Size(89, 20);
            this.chkDesejado.TabIndex = 16;
            this.chkDesejado.Text = "Desejado";
            this.chkDesejado.UseVisualStyleBackColor = true;
            // 
            // cmbSelecao
            // 
            this.cmbSelecao.FormattingEnabled = true;
            this.cmbSelecao.Items.AddRange(new object[] {
            " Alemanha",
            "Argentina",
            "Bélgica",
            "Brasil",
            "Canadá",
            "Croácia",
            "Equador ",
            "Espanha",
            "EUA ",
            "França",
            "Inglaterra",
            "Itália",
            "Japão",
            "México ",
            "Holanda",
            "Portugal",
            "Uruguai ",
            "Marrocos"});
            this.cmbSelecao.Location = new System.Drawing.Point(44, 93);
            this.cmbSelecao.Name = "cmbSelecao";
            this.cmbSelecao.Size = new System.Drawing.Size(100, 24);
            this.cmbSelecao.TabIndex = 17;
            // 
            // txtJogador
            // 
            this.txtJogador.Location = new System.Drawing.Point(44, 156);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(100, 22);
            this.txtJogador.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.txtJogador);
            this.Controls.Add(this.cmbSelecao);
            this.Controls.Add(this.chkDesejado);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnSelecionarFoto);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.dgvFigurinhas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPossui);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigurinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox chkPossui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvFigurinhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPossui;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnSelecionarFoto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.CheckBox chkDesejado;
        private System.Windows.Forms.ComboBox cmbSelecao;
        private System.Windows.Forms.TextBox txtJogador;
    }
}

