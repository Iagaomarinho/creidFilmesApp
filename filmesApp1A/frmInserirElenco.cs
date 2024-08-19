using filmesApp1A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp1A
{
    public partial class frmInserirElenco : Form
    {
        Filme filme;
        public frmInserirElenco(Filme filme)
        {
            InitializeComponent();
            this.filme = filme;
        }
        Contexto db;
        private void frmInserirElenco_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            List<Ator> atores = this.db.Ator.ToList();
            //cbxAtor.DataSource = atores; --> nao funciona aparece: Castle.Proxies.AtorProxy
            //solução chatgpt
            //|||||||||||||||
            //vvvvvvvvvvvvvvv
            cbxAtor.DataSource = db.Ator.Select(a => new { a.Id, a.Nome }).ToList();
            cbxAtor.DisplayMember = "Nome";
            cbxAtor.ValueMember = "Id";
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbxAtor.SelectedIndex > -1)
            {
                int atorId = (int)cbxAtor.SelectedValue; // Obtém o ID selecionado

                // Carrega o objeto Ator do banco usando o ID
                var ator = db.Ator.Local.FirstOrDefault(a => a.Id == atorId);
                if (ator == null)
                {
                    // Carrega do banco apenas se não estiver sendo rastreado
                    ator = db.Ator.Find(atorId);
                }

                filme.Atores.Add(ator);
                this.db.Filme.Update(filme);
                this.db.SaveChanges();
            }
        }

        private void cbxAtor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
