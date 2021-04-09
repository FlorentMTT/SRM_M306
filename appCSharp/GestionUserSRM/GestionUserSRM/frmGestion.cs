using System;
using System.Collections.Generic;
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

        public List<Report> reportsList;


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
            string selectedItem = lbReport.SelectedItem.ToString();
            int selectedID = Convert.ToInt32(selectedItem.Split(new string[] { " : " }, StringSplitOptions.None)[0]);
            Report selectedReport = reportsList.Find(item => item.ReportID == selectedID);

            gbxMessage.Show();
            gbxSender.Show();
            gbxReceiver.Show();

            tbxMessageId.Text = selectedReport.MessageID.ToString();
            tbxMessageContent.Text = selectedReport.MessageContent;

            tbxSenderId.Text = selectedReport.SenderID.ToString();
            tbxSenderName.Text = selectedReport.SenderName;

            tbxReceiverId.Text = selectedReport.ReceiverID.ToString();
            tbxReceiverName.Text = selectedReport.ReceiverName;
        }

        public void refreshList()
        {
            reportsList = db.lireReports();
            lbReport.Items.Clear();
            foreach (Report report in reportsList)
            {
                lbReport.Items.Add(report);
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void btnMessageBan_Click(object sender, EventArgs e)
        {
            db.UpdateMessageBan(1, Convert.ToInt32(tbxMessageId.Text));
        }

        private void btnSenderBan_Click(object sender, EventArgs e)
        {
            db.UpdateUserBan(1, Convert.ToInt32(tbxSenderId.Text));
        }

        private void btnReceiverBan_Click(object sender, EventArgs e)
        {
            db.UpdateGroupBan(1, Convert.ToInt32(tbxReceiverId.Text));
        }
    }
}
