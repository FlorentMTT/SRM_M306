using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GestionUserSRM
{
    public partial class frmConnexion : Form
    {

        // Champs
        #region Champs
        SQLfunction _db;
        string _user;
        string _password;
        string _errorMsg;
        bool _closefrm;


        #endregion

        // Porpriétés
        #region Propriétés
        internal SQLfunction Db { get => _db; set => _db = value; }

        public string User { get => _user; set => _user = value; }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }


        // Getter et Setter pour accéder au contenu
        // du textbox depuis l'extérieur
        public string Edition
        {
            get { return tbxUser.Text; }
            set { tbxUser.Text = value; }

        }

        public string ErrorMsg { get => _errorMsg; set => _errorMsg = value; }
        public bool Closefrm { get => _closefrm; set => _closefrm = value; }

        #endregion

        // Constructeurs
        #region Constructeurs
        public frmConnexion()
    {
            Db = new SQLfunction();
            User = "";
            Password = "";
            ErrorMsg = "";

            InitializeComponent();
        }

        #endregion

        // Méthodes
        #region Méthodes
        private void frmConnexion_Load(object sender, EventArgs e)
        {
            refreshInputText();
        }


        private void tbxUser_Click(object sender, EventArgs e)
        {
            tbxUser.Clear();

            pbUser.BackgroundImage = Properties.Resources.userViolet;
            panelUser.BackColor = Color.FromArgb(92, 60, 146);
            tbxUser.ForeColor = Color.FromArgb(92, 60, 146);

            pbPassword.BackgroundImage = Properties.Resources.passwordCyanFonce;
            panelPassword.BackColor = Color.Black;
            tbxPassword.ForeColor = Color.Black;
        }

        private void tbxPassword_Click(object sender, EventArgs e)
        {
            tbxPassword.Clear();
            tbxPassword.PasswordChar = '*';

            pbPassword.BackgroundImage = Properties.Resources.passwordViolet;
            panelPassword.BackColor = Color.FromArgb(92, 60, 146);
            tbxPassword.ForeColor = Color.FromArgb(92, 60, 146);

            pbUser.BackgroundImage = Properties.Resources.userCyanFoncé;
            panelUser.BackColor = Color.Black;
            tbxUser.ForeColor = Color.Black;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            User = tbxUser.Text;
            Password = tbxPassword.Text;
            ValidateEntre();
        }


        public void refreshInputText()
        {
            tbxUser.Text = User;
            tbxPassword.Text = "";
            lblError.Text = ErrorMsg;
        }

        // Encyrpte une chaine de caractères avec sha256
        public static String HashWithSHA256(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public void ValidateEntre()
        {
            if (Db.Select()[1].Contains(User) && Password == Db.lireUtilisateur(User).password)
            {
                //if (Db.lireUtilisateur(tbxUser.Text).idRole == 1)
                //{
                //    //  lblError.Text = "successful connection";
                //    this.DialogResult = DialogResult.OK;
                //}
                //else {
                //    lblError.Text = "Vous n'etes pas admin !";

                //}

                this.DialogResult = DialogResult.OK;
             
            }
            else
            {
                ErrorMsg = "password or username incorect";
                refreshInputText();
            }
        }



        #endregion
    }
}
