namespace Appcadastro_fut
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.chkFiltroObtido = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFiltroDesejado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObtido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDesejado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colVisualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSelecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da figurinha";
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.Location = new System.Drawing.Point(45, 54);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(204, 22);
            this.txtFiltroNome.TabIndex = 1;
            // 
            // chkFiltroObtido
            // 
            this.chkFiltroObtido.AutoSize = true;
            this.chkFiltroObtido.Location = new System.Drawing.Point(293, 56);
            this.chkFiltroObtido.Name = "chkFiltroObtido";
            this.chkFiltroObtido.Size = new System.Drawing.Size(66, 20);
            this.chkFiltroObtido.TabIndex = 2;
            this.chkFiltroObtido.Text = "obtive\r\n";
            this.chkFiltroObtido.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "apenas obtidas ";
            // 
            // chkFiltroDesejado
            // 
            this.chkFiltroDesejado.AutoSize = true;
            this.chkFiltroDesejado.Location = new System.Drawing.Point(465, 56);
            this.chkFiltroDesejado.Name = "chkFiltroDesejado";
            this.chkFiltroDesejado.Size = new System.Drawing.Size(94, 20);
            this.chkFiltroDesejado.TabIndex = 4;
            this.chkFiltroDesejado.Text = "desejadas";
            this.chkFiltroDesejado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "apenas desejadas";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(666, 53);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "filtro";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colObtido,
            this.colDesejado,
            this.colVisualizar,
            this.colSelecao,
            this.colJogador});
            this.dgvLista.Location = new System.Drawing.Point(12, 100);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(725, 306);
            this.dgvLista.TabIndex = 13;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 125;
            // 
            // colObtido
            // 
            this.colObtido.HeaderText = "Obtido";
            this.colObtido.MinimumWidth = 6;
            this.colObtido.Name = "colObtido";
            this.colObtido.Width = 125;
            // 
            // colDesejado
            // 
            this.colDesejado.HeaderText = " Desejado";
            this.colDesejado.MinimumWidth = 6;
            this.colDesejado.Name = "colDesejado";
            this.colDesejado.Width = 125;
            // 
            // colVisualizar
            // 
            this.colVisualizar.HeaderText = "Estilo da carta";
            this.colVisualizar.MinimumWidth = 6;
            this.colVisualizar.Name = "colVisualizar";
            this.colVisualizar.Width = 125;
            // 
            // colSelecao
            // 
            this.colSelecao.HeaderText = "figurinha obtida recentimente";
            this.colSelecao.MinimumWidth = 6;
            this.colSelecao.Name = "colSelecao";
            this.colSelecao.Width = 125;
            // 
            // colJogador
            // 
            this.colJogador.HeaderText = "figurinha desejada";
            this.colJogador.MinimumWidth = 6;
            this.colJogador.Name = "colJogador";
            this.colJogador.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFiltroDesejado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkFiltroObtido);
            this.Controls.Add(this.txtFiltroNome);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.CheckBox chkFiltroObtido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFiltroDesejado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewButtonColumn colObtido;
        private System.Windows.Forms.DataGridViewButtonColumn colDesejado;
        private System.Windows.Forms.DataGridViewButtonColumn colVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJogador;
    }
}