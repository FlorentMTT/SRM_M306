namespace GestionUserSRM
{
    partial class frmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.btnConnexion = new System.Windows.Forms.Button();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnConnexion.Location = new System.Drawing.Point(19, 250);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(245, 38);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbxUser.Location = new System.Drawing.Point(55, 130);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(214, 18);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.Text = "Name User";
            this.tbxUser.Click += new System.EventHandler(this.tbxUser_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(270, 84);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Super Rapide \r\nMessage";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(266, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = global::GestionUserSRM.Properties.Resources.userCyanFoncé;
            this.pbUser.Location = new System.Drawing.Point(23, 127);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(25, 25);
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.panelUser.Location = new System.Drawing.Point(49, 152);
            this.panelUser.Name = "panelUser";
            this.panelUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelUser.Size = new System.Drawing.Size(219, 1);
            this.panelUser.TabIndex = 5;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.panelPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPassword.Location = new System.Drawing.Point(50, 205);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelPassword.Size = new System.Drawing.Size(218, 1);
            this.panelPassword.TabIndex = 8;
            // 
            // pbPassword
            // 
            this.pbPassword.BackgroundImage = global::GestionUserSRM.Properties.Resources.passwordCyanFonce;
            this.pbPassword.Location = new System.Drawing.Point(22, 181);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(25, 25);
            this.pbPassword.TabIndex = 7;
            this.pbPassword.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbxPassword.Location = new System.Drawing.Point(53, 184);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(214, 18);
            this.tbxPassword.TabIndex = 6;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.Click += new System.EventHandler(this.tbxPassword_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(96, 221);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(72, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "ErrorMessage";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(289, 300);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.btnConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.frmConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblError;
    }
}