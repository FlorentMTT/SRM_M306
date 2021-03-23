using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lblUserSelected.Text = "Utilisateur selectioné : " + lbUser.SelectedValue.ToString();
            
        }
        private void lbMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbMessage.Show();
            lblMessageSelected.Text = "id message selectioné : " + lbMessages.SelectedIndex.ToString();
            tbxMessageSelectioner.Text = lbMessages.SelectedValue.ToString();
        }

        private void btnBannUser_Click(object sender, EventArgs e)
        {
            db.UpdateUserBanne(1, db.lireUtilisateur(lbUser.SelectedValue.ToString()).id);
            afficheBtnBanned();
        }

        private void btnUpdateMessage_Click(object sender, EventArgs e)
        {
            db.UpdateMessage(tbxMessageSelectioner.Text, lbMessages.SelectedIndex + 1);
            refreshList();
        }

        private void btnDeBannUser_Click(object sender, EventArgs e)
        {
            db.UpdateUserBanne(0, db.lireUtilisateur(lbUser.SelectedValue.ToString()).id);
            afficheBtnBanned();
        }

        public void refreshList()
        {
            lbUser.DataSource = Db.Select()[1];         
        }
        public void afficheBtnBanned()
        {
            if (db.lireUtilisateur(lbUser.SelectedValue.ToString()).active)
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
    }
}
