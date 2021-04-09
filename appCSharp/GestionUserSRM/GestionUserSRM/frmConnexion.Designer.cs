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
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.btnConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(28, 385);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(368, 58);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbxUser.Location = new System.Drawing.Point(82, 200);
            this.tbxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(321, 26);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.TabStop = false;
            this.tbxUser.Text = "Name User";
            this.tbxUser.Click += new System.EventHandler(this.tbxUser_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(18, 14);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(397, 128);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Super Rapide \r\nMessage";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.White;
            this.pbUser.BackgroundImage = global::GestionUserSRM.Properties.Resources.userCyanFoncé;
            this.pbUser.Location = new System.Drawing.Point(34, 195);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(38, 38);
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.panelUser.Location = new System.Drawing.Point(74, 234);
            this.panelUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUser.Name = "panelUser";
            this.panelUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelUser.Size = new System.Drawing.Size(328, 2);
            this.panelUser.TabIndex = 2;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.panelPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPassword.Location = new System.Drawing.Point(75, 315);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelPassword.Size = new System.Drawing.Size(327, 2);
            this.panelPassword.TabIndex = 4;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.White;
            this.pbPassword.BackgroundImage = global::GestionUserSRM.Properties.Resources.passwordCyanFonce;
            this.pbPassword.Location = new System.Drawing.Point(33, 278);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(38, 38);
            this.pbPassword.TabIndex = 7;
            this.pbPassword.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbxPassword.Location = new System.Drawing.Point(80, 283);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(321, 26);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.TabStop = false;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.Click += new System.EventHandler(this.tbxPassword_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(144, 340);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(109, 20);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "ErrorMessage";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(434, 462);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.btnConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblError;
    }
}