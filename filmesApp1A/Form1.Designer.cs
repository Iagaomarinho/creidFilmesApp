namespace filmesApp1A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            atorBindingSource = new BindingSource(components);
            btFilmes = new Button();
            btAtores = new Button();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // btFilmes
            // 
            btFilmes.Location = new Point(36, 100);
            btFilmes.Name = "btFilmes";
            btFilmes.Size = new Size(145, 23);
            btFilmes.TabIndex = 0;
            btFilmes.Text = "Gerenciar Filmes";
            btFilmes.UseVisualStyleBackColor = true;
            btFilmes.Click += btFilmes_Click;
            // 
            // btAtores
            // 
            btAtores.Location = new Point(36, 53);
            btAtores.Name = "btAtores";
            btAtores.Size = new Size(145, 23);
            btAtores.TabIndex = 1;
            btAtores.Text = "Gerenciar Atores";
            btAtores.UseVisualStyleBackColor = true;
            btAtores.Click += btAtores_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 157);
            Controls.Add(btAtores);
            Controls.Add(btFilmes);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource atorBindingSource;
        private Button btFilmes;
        private Button btAtores;
    }
}
