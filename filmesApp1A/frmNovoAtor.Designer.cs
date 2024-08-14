namespace filmesApp1A
{
    partial class frmNovoAtor
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
            btCriar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            cbxNacionalidade = new ComboBox();
            SuspendLayout();
            // 
            // btCriar
            // 
            btCriar.Location = new Point(159, 138);
            btCriar.Name = "btCriar";
            btCriar.Size = new Size(71, 23);
            btCriar.TabIndex = 0;
            btCriar.Text = "Criar";
            btCriar.UseVisualStyleBackColor = true;
            btCriar.Click += btCriar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 47);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 92);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Nacionalidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(149, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
            txtNome.TabIndex = 3;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(149, 89);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(121, 23);
            cbxNacionalidade.TabIndex = 4;
            // 
            // frmNovoAtor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 186);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCriar);
            MaximizeBox = false;
            Name = "frmNovoAtor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Ator";
            Load += frmNovoAtor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCriar;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private ComboBox cbxNacionalidade;
    }
}