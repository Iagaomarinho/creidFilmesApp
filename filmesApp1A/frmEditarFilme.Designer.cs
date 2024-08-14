namespace filmesApp1A
{
    partial class frmEditarFilme
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
            numAno = new NumericUpDown();
            label3 = new Label();
            cbxNacionalidade = new ComboBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            SuspendLayout();
            // 
            // numAno
            // 
            numAno.Location = new Point(153, 119);
            numAno.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numAno.Name = "numAno";
            numAno.Size = new Size(120, 23);
            numAno.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 119);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 17;
            label3.Text = "Ano Lançamento:";
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(153, 78);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 23);
            cbxNacionalidade.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(153, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 81);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 14;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 36);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 13;
            label1.Text = "Nome:";
            // 
            // btCriar
            // 
            btCriar.Location = new Point(122, 167);
            btCriar.Name = "btCriar";
            btCriar.Size = new Size(120, 23);
            btCriar.TabIndex = 12;
            btCriar.Text = "Salvar Alterações";
            btCriar.UseVisualStyleBackColor = true;
            btCriar.Click += btCriar_Click;
            // 
            // frmEditarFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 233);
            Controls.Add(numAno);
            Controls.Add(label3);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCriar);
            MaximizeBox = false;
            Name = "frmEditarFilme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Filme";
            Load += frmEditarFilme_Load;
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numAno;
        private Label label3;
        private ComboBox cbxNacionalidade;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Button btCriar;
    }
}