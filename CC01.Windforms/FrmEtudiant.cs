using System;
using CC01.BO;
using CC01.BLL;
using CC01.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.Windforms
{
    public partial class FrmEtudiant : Form
    {
        public FrmEtudiant()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.ImageLocation = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadData(IEnumerable<Etudiant> etudiants)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
            lbllignes.Text = $"{dataGridView1.RowCount} lignes";
        }

        private void FrmEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
          
        }
    }
}
