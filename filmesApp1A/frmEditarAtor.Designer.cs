﻿namespace filmesApp1A
{
    partial class frmEditarAtor
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btSalvar = new Button();
            txtNome = new TextBox();
            cbxNacionalidade = new ComboBox();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 173);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Filmes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Nacionalidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 54);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(210, 137);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 3;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(243, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 4;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(243, 93);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 23);
            cbxNacionalidade.TabIndex = 5;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(54, 191);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(451, 132);
            dgvFilmes.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // anoLancamentoDataGridViewTextBoxColumn
            // 
            anoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.HeaderText = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.Name = "anoLancamentoDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // frmEditarAtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 335);
            Controls.Add(dgvFilmes);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(btSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmEditarAtor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Ator";
            Load += frmEditarAtor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btSalvar;
        private TextBox txtNome;
        private ComboBox cbxNacionalidade;
        private DataGridView dgvFilmes;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
    }
}