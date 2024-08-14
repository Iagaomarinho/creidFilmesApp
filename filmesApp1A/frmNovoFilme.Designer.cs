namespace filmesApp1A
{
    partial class frmNovoFilme
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
            cbxNacionalidade = new ComboBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btCriar = new Button();
            label3 = new Label();
            numAno = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            SuspendLayout();
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(120, 75);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 23);
            cbxNacionalidade.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 7;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // btCriar
            // 
            btCriar.Location = new Point(120, 157);
            btCriar.Name = "btCriar";
            btCriar.Size = new Size(71, 23);
            btCriar.TabIndex = 5;
            btCriar.Text = "Criar";
            btCriar.UseVisualStyleBackColor = true;
            btCriar.Click += btCriar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 116);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 10;
            label3.Text = "Ano Lançamento:";
            // 
            // numAno
            // 
            numAno.Location = new Point(120, 116);
            numAno.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numAno.Name = "numAno";
            numAno.Size = new Size(120, 23);
            numAno.TabIndex = 11;
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 232);
            Controls.Add(numAno);
            Controls.Add(label3);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCriar);
            MaximizeBox = false;
            Name = "frmNovoFilme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNovoFilme";
            Load += frmNovoFilme_Load;
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxNacionalidade;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Button btCriar;
        private Label label3;
        private NumericUpDown numAno;
    }
}