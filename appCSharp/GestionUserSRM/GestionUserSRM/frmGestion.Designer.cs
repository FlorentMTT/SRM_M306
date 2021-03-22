namespace GestionUserSRM
{
    partial class frmGestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUser = new System.Windows.Forms.ListBox();
            this.lblUserCo = new System.Windows.Forms.Label();
            this.gbOptionUser = new System.Windows.Forms.GroupBox();
            this.lblUserSelected = new System.Windows.Forms.Label();
            this.btnDeBannUser = new System.Windows.Forms.Button();
            this.btnAvertissementUser = new System.Windows.Forms.Button();
            this.btnBannUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbOptionUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // lbUser
            // 
            this.lbUser.FormattingEnabled = true;
            this.lbUser.Location = new System.Drawing.Point(15, 73);
            this.lbUser.MultiColumn = true;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(197, 316);
            this.lbUser.TabIndex = 2;
            this.lbUser.SelectedIndexChanged += new System.EventHandler(this.lbUser_SelectedIndexChanged);
            // 
            // lblUserCo
            // 
            this.lblUserCo.AutoSize = true;
            this.lblUserCo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblUserCo.Location = new System.Drawing.Point(12, 38);
            this.lblUserCo.Name = "lblUserCo";
            this.lblUserCo.Size = new System.Drawing.Size(233, 17);
            this.lblUserCo.TabIndex = 1;
            this.lblUserCo.Text = "Vous etes connecter en tant que ...";
            // 
            // gbOptionUser
            // 
            this.gbOptionUser.Controls.Add(this.lblUserSelected);
            this.gbOptionUser.Controls.Add(this.btnDeBannUser);
            this.gbOptionUser.Controls.Add(this.btnAvertissementUser);
            this.gbOptionUser.Controls.Add(this.btnBannUser);
            this.gbOptionUser.Controls.Add(this.btnDeleteUser);
            this.gbOptionUser.Location = new System.Drawing.Point(218, 73);
            this.gbOptionUser.Name = "gbOptionUser";
            this.gbOptionUser.Size = new System.Drawing.Size(213, 121);
            this.gbOptionUser.TabIndex = 3;
            this.gbOptionUser.TabStop = false;
            this.gbOptionUser.Text = "Option d\'utilisateur";
            this.gbOptionUser.Visible = false;
            // 
            // lblUserSelected
            // 
            this.lblUserSelected.AutoSize = true;
            this.lblUserSelected.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblUserSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.lblUserSelected.Location = new System.Drawing.Point(6, 96);
            this.lblUserSelected.Name = "lblUserSelected";
            this.lblUserSelected.Size = new System.Drawing.Size(149, 17);
            this.lblUserSelected.TabIndex = 6;
            this.lblUserSelected.Text = "Utilisateur Selectioner";
            // 
            // btnDeBannUser
            // 
            this.btnDeBannUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnDeBannUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeBannUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeBannUser.ForeColor = System.Drawing.Color.White;
            this.btnDeBannUser.Location = new System.Drawing.Point(126, 56);
            this.btnDeBannUser.Name = "btnDeBannUser";
            this.btnDeBannUser.Size = new System.Drawing.Size(81, 31);
            this.btnDeBannUser.TabIndex = 3;
            this.btnDeBannUser.Text = "DéBannir";
            this.btnDeBannUser.UseVisualStyleBackColor = false;
            this.btnDeBannUser.Click += new System.EventHandler(this.btnDeBannUser_Click);
            // 
            // btnAvertissementUser
            // 
            this.btnAvertissementUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnAvertissementUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvertissementUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvertissementUser.ForeColor = System.Drawing.Color.White;
            this.btnAvertissementUser.Location = new System.Drawing.Point(6, 56);
            this.btnAvertissementUser.Name = "btnAvertissementUser";
            this.btnAvertissementUser.Size = new System.Drawing.Size(114, 31);
            this.btnAvertissementUser.TabIndex = 2;
            this.btnAvertissementUser.Text = "Avertissment";
            this.btnAvertissementUser.UseVisualStyleBackColor = false;
            // 
            // btnBannUser
            // 
            this.btnBannUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnBannUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBannUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannUser.ForeColor = System.Drawing.Color.White;
            this.btnBannUser.Location = new System.Drawing.Point(105, 19);
            this.btnBannUser.Name = "btnBannUser";
            this.btnBannUser.Size = new System.Drawing.Size(93, 31);
            this.btnBannUser.TabIndex = 1;
            this.btnBannUser.Text = "Bannir";
            this.btnBannUser.UseVisualStyleBackColor = false;
            this.btnBannUser.Click += new System.EventHandler(this.btnBannUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(6, 19);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(93, 31);
            this.btnDeleteUser.TabIndex = 0;
            this.btnDeleteUser.Text = "Suprimer";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(446, 400);
            this.Controls.Add(this.gbOptionUser);
            this.Controls.Add(this.lblUserCo);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion d\'utilisateur";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbOptionUser.ResumeLayout(false);
            this.gbOptionUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ListBox lbUser;
        private System.Windows.Forms.Label lblUserCo;
        private System.Windows.Forms.GroupBox gbOptionUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnDeBannUser;
        private System.Windows.Forms.Button btnAvertissementUser;
        private System.Windows.Forms.Button btnBannUser;
        private System.Windows.Forms.Label lblUserSelected;
    }
}

