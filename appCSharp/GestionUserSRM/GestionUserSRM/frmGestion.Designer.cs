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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDebannGroupe = new System.Windows.Forms.Button();
            this.btnAvertissementGroupe = new System.Windows.Forms.Button();
            this.lblGroupeSelected = new System.Windows.Forms.Label();
            this.btnBannGroupe = new System.Windows.Forms.Button();
            this.btnDeleteGroupe = new System.Windows.Forms.Button();
            this.lbGroupe = new System.Windows.Forms.ListBox();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.btnDebannMessage = new System.Windows.Forms.Button();
            this.btnUpdateMessage = new System.Windows.Forms.Button();
            this.lblMessageSelected = new System.Windows.Forms.Label();
            this.btnBannMessage = new System.Windows.Forms.Button();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.tbxMessageSelectioner = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gbOptionUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 24);
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
            this.lbUser.TabIndex = 1;
            this.lbUser.SelectedIndexChanged += new System.EventHandler(this.lbUser_SelectedIndexChanged);
            // 
            // lblUserCo
            // 
            this.lblUserCo.AutoSize = true;
            this.lblUserCo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblUserCo.Location = new System.Drawing.Point(12, 38);
            this.lblUserCo.Name = "lblUserCo";
            this.lblUserCo.Size = new System.Drawing.Size(233, 17);
            this.lblUserCo.TabIndex = 2;
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
            this.btnDeBannUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnDeBannUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeBannUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeBannUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
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
            this.btnAvertissementUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnAvertissementUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvertissementUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvertissementUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnAvertissementUser.Location = new System.Drawing.Point(6, 56);
            this.btnAvertissementUser.Name = "btnAvertissementUser";
            this.btnAvertissementUser.Size = new System.Drawing.Size(114, 31);
            this.btnAvertissementUser.TabIndex = 2;
            this.btnAvertissementUser.Text = "Avertissment";
            this.btnAvertissementUser.UseVisualStyleBackColor = false;
            // 
            // btnBannUser
            // 
            this.btnBannUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnBannUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBannUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
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
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnDeleteUser.Location = new System.Drawing.Point(6, 19);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(93, 31);
            this.btnDeleteUser.TabIndex = 0;
            this.btnDeleteUser.Text = "Suprimer";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDebannGroupe);
            this.groupBox1.Controls.Add(this.btnAvertissementGroupe);
            this.groupBox1.Controls.Add(this.lblGroupeSelected);
            this.groupBox1.Controls.Add(this.btnBannGroupe);
            this.groupBox1.Controls.Add(this.btnDeleteGroupe);
            this.groupBox1.Location = new System.Drawing.Point(648, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option de groupe";
            this.groupBox1.Visible = false;
            // 
            // btnDebannGroupe
            // 
            this.btnDebannGroupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnDebannGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebannGroupe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebannGroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnDebannGroupe.Location = new System.Drawing.Point(126, 56);
            this.btnDebannGroupe.Name = "btnDebannGroupe";
            this.btnDebannGroupe.Size = new System.Drawing.Size(81, 31);
            this.btnDebannGroupe.TabIndex = 3;
            this.btnDebannGroupe.Text = "DéBannir";
            this.btnDebannGroupe.UseVisualStyleBackColor = false;
            // 
            // btnAvertissementGroupe
            // 
            this.btnAvertissementGroupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnAvertissementGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvertissementGroupe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvertissementGroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnAvertissementGroupe.Location = new System.Drawing.Point(6, 56);
            this.btnAvertissementGroupe.Name = "btnAvertissementGroupe";
            this.btnAvertissementGroupe.Size = new System.Drawing.Size(114, 31);
            this.btnAvertissementGroupe.TabIndex = 2;
            this.btnAvertissementGroupe.Text = "Avertissment";
            this.btnAvertissementGroupe.UseVisualStyleBackColor = false;
            // 
            // lblGroupeSelected
            // 
            this.lblGroupeSelected.AutoSize = true;
            this.lblGroupeSelected.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblGroupeSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.lblGroupeSelected.Location = new System.Drawing.Point(3, 96);
            this.lblGroupeSelected.Name = "lblGroupeSelected";
            this.lblGroupeSelected.Size = new System.Drawing.Size(126, 17);
            this.lblGroupeSelected.TabIndex = 4;
            this.lblGroupeSelected.Text = "groupeSelectioner";
            // 
            // btnBannGroupe
            // 
            this.btnBannGroupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnBannGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBannGroupe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannGroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnBannGroupe.Location = new System.Drawing.Point(105, 19);
            this.btnBannGroupe.Name = "btnBannGroupe";
            this.btnBannGroupe.Size = new System.Drawing.Size(93, 31);
            this.btnBannGroupe.TabIndex = 1;
            this.btnBannGroupe.Text = "Bannir";
            this.btnBannGroupe.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGroupe
            // 
            this.btnDeleteGroupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnDeleteGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroupe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnDeleteGroupe.Location = new System.Drawing.Point(6, 19);
            this.btnDeleteGroupe.Name = "btnDeleteGroupe";
            this.btnDeleteGroupe.Size = new System.Drawing.Size(93, 31);
            this.btnDeleteGroupe.TabIndex = 0;
            this.btnDeleteGroupe.Text = "Suprimer";
            this.btnDeleteGroupe.UseVisualStyleBackColor = false;
            // 
            // lbGroupe
            // 
            this.lbGroupe.FormattingEnabled = true;
            this.lbGroupe.Location = new System.Drawing.Point(446, 73);
            this.lbGroupe.Name = "lbGroupe";
            this.lbGroupe.Size = new System.Drawing.Size(197, 316);
            this.lbGroupe.TabIndex = 6;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.btnDebannMessage);
            this.gbMessage.Controls.Add(this.btnUpdateMessage);
            this.gbMessage.Controls.Add(this.lblMessageSelected);
            this.gbMessage.Controls.Add(this.btnBannMessage);
            this.gbMessage.Controls.Add(this.btnDeleteMessage);
            this.gbMessage.Location = new System.Drawing.Point(1069, 73);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(213, 121);
            this.gbMessage.TabIndex = 7;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Option de message";
            this.gbMessage.Visible = false;
            // 
            // btnDebannMessage
            // 
            this.btnDebannMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnDebannMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebannMessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebannMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnDebannMessage.Location = new System.Drawing.Point(126, 56);
            this.btnDebannMessage.Name = "btnDebannMessage";
            this.btnDebannMessage.Size = new System.Drawing.Size(81, 31);
            this.btnDebannMessage.TabIndex = 3;
            this.btnDebannMessage.Text = "DéBannir";
            this.btnDebannMessage.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMessage
            // 
            this.btnUpdateMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnUpdateMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnUpdateMessage.Location = new System.Drawing.Point(6, 56);
            this.btnUpdateMessage.Name = "btnUpdateMessage";
            this.btnUpdateMessage.Size = new System.Drawing.Size(114, 31);
            this.btnUpdateMessage.TabIndex = 2;
            this.btnUpdateMessage.Text = "Update";
            this.btnUpdateMessage.UseVisualStyleBackColor = false;
            this.btnUpdateMessage.Click += new System.EventHandler(this.btnUpdateMessage_Click);
            // 
            // lblMessageSelected
            // 
            this.lblMessageSelected.AutoSize = true;
            this.lblMessageSelected.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblMessageSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.lblMessageSelected.Location = new System.Drawing.Point(3, 96);
            this.lblMessageSelected.Name = "lblMessageSelected";
            this.lblMessageSelected.Size = new System.Drawing.Size(159, 17);
            this.lblMessageSelected.TabIndex = 4;
            this.lblMessageSelected.Text = "Id message selectioner";
            // 
            // btnBannMessage
            // 
            this.btnBannMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnBannMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBannMessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnBannMessage.Location = new System.Drawing.Point(105, 19);
            this.btnBannMessage.Name = "btnBannMessage";
            this.btnBannMessage.Size = new System.Drawing.Size(93, 31);
            this.btnBannMessage.TabIndex = 1;
            this.btnBannMessage.Text = "Bannir";
            this.btnBannMessage.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.btnDeleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.btnDeleteMessage.Location = new System.Drawing.Point(6, 19);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(93, 31);
            this.btnDeleteMessage.TabIndex = 0;
            this.btnDeleteMessage.Text = "Suprimer";
            this.btnDeleteMessage.UseVisualStyleBackColor = false;
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(867, 73);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(197, 316);
            this.lbMessages.TabIndex = 8;
            this.lbMessages.SelectedIndexChanged += new System.EventHandler(this.lbMessages_SelectedIndexChanged);
            // 
            // tbxMessageSelectioner
            // 
            this.tbxMessageSelectioner.Location = new System.Drawing.Point(1070, 200);
            this.tbxMessageSelectioner.Multiline = true;
            this.tbxMessageSelectioner.Name = "tbxMessageSelectioner";
            this.tbxMessageSelectioner.Size = new System.Drawing.Size(212, 188);
            this.tbxMessageSelectioner.TabIndex = 9;
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1302, 400);
            this.Controls.Add(this.tbxMessageSelectioner);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbGroupe);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDebannGroupe;
        private System.Windows.Forms.Button btnAvertissementGroupe;
        private System.Windows.Forms.Label lblGroupeSelected;
        private System.Windows.Forms.Button btnBannGroupe;
        private System.Windows.Forms.Button btnDeleteGroupe;
        private System.Windows.Forms.ListBox lbGroupe;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.Button btnDebannMessage;
        private System.Windows.Forms.Button btnUpdateMessage;
        private System.Windows.Forms.Label lblMessageSelected;
        private System.Windows.Forms.Button btnBannMessage;
        private System.Windows.Forms.Button btnDeleteMessage;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.TextBox tbxMessageSelectioner;
    }
}

