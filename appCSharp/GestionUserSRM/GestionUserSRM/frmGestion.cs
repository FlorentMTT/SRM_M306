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
           
            Connexion = new frmConnexion();
            Db = new SQLfunction();
            connexion.Show();
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            this.Hide();
            // Rempli la liste de users
            lbUser.DataSource = Db.Select()[1];
            // Rempli la liste de groupes
            // lbGroupe.DataSource = Db.SelectGroupe()[1];
        }

        private void lbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbOptionUser.Show();
        }
    }
}
