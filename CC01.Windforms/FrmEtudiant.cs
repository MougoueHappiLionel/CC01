using System;
using CC01.BO;
using CC01.BLL;
using CC01.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CC01.Windforms
{
    public partial class FrmEtudiant : Form
    {
        private EtudiantBLO etudiantBLO;
        public FrmEtudiant()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
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
            txbrecherche.Text = $"{dataGridView1.RowCount} lignes";
            dataGridView1.ClearSelection();
        }

        private void FrmEtudiant_Load(object sender, EventArgs e)
        {
            loadData(etudiantBLO.GetAllEtudiant());
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                Etudiant etudiant = new Etudiant
                (
                txtnom.Text,
                txtprenom.Text,
                txtid.Text,
                int.Parse(txtcontact.Text),
                txtemail.Text
                );
                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                etudiantBLO.CreateProduct(etudiant);

                MessageBox.Show
                    (
                    "L'étudiant a été ajouté",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                txtnom.Clear();
                txtprenom.Clear();
                txtid.Clear();
                txtcontact.Clear();
                txtemail.Clear();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
                   (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );

            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter("app.log", true))
                {
                    sw.WriteLine(ex.ToString());
                }
                    MessageBox.Show
                       (
                        "Une erreur a encore  été detectée !",
                       "Erreur",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );

            }
        }
    }
}
