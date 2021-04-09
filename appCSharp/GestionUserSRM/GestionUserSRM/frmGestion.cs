using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionUserSRM
{
    public partial class frmGestion : Form
    {
        // champ
        frmConnexion connexion;
        SQLfunction db;

        // propriété
        public frmConnexion Connexion { get => connexion; set => connexion = value; }
        internal SQLfunction Db { get => db; set => db = value; }

        public frmGestion()
        {
            InitializeComponent();

            Db = new SQLfunction();
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            // Mémorise le bouton qui a fermé la boite de dialogue
            DialogResult retour;
            // créer la fenêtre de dialogue
            frmConnexion dialogue = new frmConnexion();
            // Afficher la 2 ème forme de façon modale 

            retour = dialogue.ShowDialog();

            refreshList();

            // Récupérer la valeur seulement si le dialogue a 
            // valider par l'utilisateur
            if (retour == DialogResult.OK)
            {
                this.lblUserCo.Text = "Vous etes connecter en tant que : " + dialogue.Edition;
            }
            else
            {
                Close();
            }

        }

        private void lbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbOptionUser.Show();
            lblUserSelected.Text = "Utilisateur selectioné : " + lbReport.SelectedValue.ToString();
            
        }        

        private void btnBannUser_Click(object sender, EventArgs e)
        {
            db.UpdateUserBanne(1, db.lireUtilisateur(lbReport.SelectedValue.ToString()).id);
            afficheBtnBanned();
        }

        private void btnDeBannUser_Click(object sender, EventArgs e)
        {
            db.UpdateUserBanne(0, db.lireUtilisateur(lbReport.SelectedValue.ToString()).id);
            afficheBtnBanned();
        }

        public void refreshList()
        {
            lbReport.DataSource = Db.SelectReportedMessages()[1];  
        }
        public void afficheBtnBanned()
        {
            if (db.lireUtilisateur(lbReport.SelectedValue.ToString()).active)
            {
                btnBannUser.Enabled = false;
                btnBannUser.BackColor = Color.FromArgb(30, 61, 89);
                btnDeBannUser.Enabled = true;
                btnDeBannUser.BackColor = Color.FromArgb(7, 123, 138);


            }
            else
            {
                btnBannUser.Enabled = true;
                btnBannUser.BackColor = Color.FromArgb(7, 123, 138);
                btnDeBannUser.Enabled = false;
                btnDeBannUser.BackColor = Color.FromArgb(30, 61, 89);
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshList();
        }
    }
}
