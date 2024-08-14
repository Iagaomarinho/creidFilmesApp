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
    public partial class frmGerenciarElenco : Form
    {
        Filme filme;
        public frmGerenciarElenco(Filme filme)
        {
            InitializeComponent();
            this.filme = filme;
        }
        Contexto db;
        private void frmGerenciarElenco_Load(object sender, EventArgs e)
        {
            lblFilme.Text = filme.Nome;
            Recarregar();
        }
        public void Recarregar()
        {
            dgvElenco.DataSource = filme.Atores;
        }
        private void btInserir_Click(object sender, EventArgs e)
        {
            /*DialogResult r = MessageBox.Show
                (db.Ator.ToString(), "", MessageBoxButtons.OKCancel);
            filme.Atores.Add(ator);
            db.Filme.Update(filme);
            db.SaveChanges();*/
        }

        private void dgvElenco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btExcluir.Enabled = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
