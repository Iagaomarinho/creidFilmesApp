﻿namespace filmesApp1A
{
    partial class frmInserirElenco
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
            cbxAtor = new ComboBox();
            atorBindingSource2 = new BindingSource(components);
            atorBindingSource = new BindingSource(components);
            label1 = new Label();
            btAdd = new Button();
            atorBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)atorBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // cbxAtor
            // 
            cbxAtor.FormattingEnabled = true;
            cbxAtor.Location = new Point(105, 62);
            cbxAtor.Name = "cbxAtor";
            cbxAtor.Size = new Size(121, 23);
            cbxAtor.TabIndex = 0;
            cbxAtor.SelectedIndexChanged += cbxAtor_SelectedIndexChanged;
            // 
            // atorBindingSource2
            // 
            atorBindingSource2.DataSource = typeof(Models.Ator);
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 65);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Atores:";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(105, 105);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 2;
            btAdd.Text = "Adicionar";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // atorBindingSource1
            // 
            atorBindingSource1.DataSource = typeof(Models.Ator);
            // 
            // frmInserirElenco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 194);
            Controls.Add(btAdd);
            Controls.Add(label1);
            Controls.Add(cbxAtor);
            MaximizeBox = false;
            Name = "frmInserirElenco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInserirElenco";
            Load += frmInserirElenco_Load;
            ((System.ComponentModel.ISupportInitialize)atorBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxAtor;
        private BindingSource atorBindingSource;
        private Label label1;
        private Button btAdd;
        private BindingSource atorBindingSource1;
        private BindingSource atorBindingSource2;
    }
}