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
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.lbReport = new System.Windows.Forms.ListBox();
            this.lblUserCo = new System.Windows.Forms.Label();
            this.gbxMessage = new System.Windows.Forms.GroupBox();
            this.tbxMessageContent = new System.Windows.Forms.TextBox();
            this.btnMessageBan = new System.Windows.Forms.Button();
            this.btnSenderBan = new System.Windows.Forms.Button();
            this.tbxSenderName = new System.Windows.Forms.TextBox();
            this.gbxSender = new System.Windows.Forms.GroupBox();
            this.btnReceiverBan = new System.Windows.Forms.Button();
            this.tbxReceiverName = new System.Windows.Forms.TextBox();
            this.gbxReceiver = new System.Windows.Forms.GroupBox();
            this.tbxMessageId = new System.Windows.Forms.TextBox();
            this.tbxSenderId = new System.Windows.Forms.TextBox();
            this.tbxReceiverId = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gbxMessage.SuspendLayout();
            this.gbxSender.SuspendLayout();
            this.gbxReceiver.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.deconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 29);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // lbReport
            // 
            this.lbReport.FormattingEnabled = true;
            this.lbReport.ItemHeight = 20;
            this.lbReport.Location = new System.Drawing.Point(22, 112);
            this.lbReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbReport.MultiColumn = true;
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(434, 484);
            this.lbReport.TabIndex = 1;
            this.lbReport.SelectedIndexChanged += new System.EventHandler(this.lbUser_SelectedIndexChanged);
            // 
            // lblUserCo
            // 
            this.lblUserCo.AutoSize = true;
            this.lblUserCo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblUserCo.Location = new System.Drawing.Point(18, 58);
            this.lblUserCo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCo.Name = "lblUserCo";
            this.lblUserCo.Size = new System.Drawing.Size(361, 26);
            this.lblUserCo.TabIndex = 2;
            this.lblUserCo.Text = "Vous etes connecter en tant que ...";
            // 
            // gbxMessage
            // 
            this.gbxMessage.Controls.Add(this.tbxMessageId);
            this.gbxMessage.Controls.Add(this.btnMessageBan);
            this.gbxMessage.Controls.Add(this.tbxMessageContent);
            this.gbxMessage.Location = new System.Drawing.Point(463, 112);
            this.gbxMessage.Name = "gbxMessage";
            this.gbxMessage.Size = new System.Drawing.Size(365, 100);
            this.gbxMessage.TabIndex = 4;
            this.gbxMessage.TabStop = false;
            this.gbxMessage.Text = "Message";
            // 
            // tbxMessageContent
            // 
            this.tbxMessageContent.Location = new System.Drawing.Point(9, 59);
            this.tbxMessageContent.Name = "tbxMessageContent";
            this.tbxMessageContent.ReadOnly = true;
            this.tbxMessageContent.Size = new System.Drawing.Size(228, 26);
            this.tbxMessageContent.TabIndex = 0;
            this.tbxMessageContent.Text = "Le contenu";
            // 
            // btnMessageBan
            // 
            this.btnMessageBan.Location = new System.Drawing.Point(258, 25);
            this.btnMessageBan.Name = "btnMessageBan";
            this.btnMessageBan.Size = new System.Drawing.Size(101, 60);
            this.btnMessageBan.TabIndex = 1;
            this.btnMessageBan.Text = "Ban";
            this.btnMessageBan.UseVisualStyleBackColor = true;
            this.btnMessageBan.Click += new System.EventHandler(this.btnMessageBan_Click);
            // 
            // btnSenderBan
            // 
            this.btnSenderBan.Location = new System.Drawing.Point(258, 25);
            this.btnSenderBan.Name = "btnSenderBan";
            this.btnSenderBan.Size = new System.Drawing.Size(101, 60);
            this.btnSenderBan.TabIndex = 1;
            this.btnSenderBan.Text = "Ban";
            this.btnSenderBan.UseVisualStyleBackColor = true;
            this.btnSenderBan.Click += new System.EventHandler(this.btnSenderBan_Click);
            // 
            // tbxSenderName
            // 
            this.tbxSenderName.Location = new System.Drawing.Point(9, 59);
            this.tbxSenderName.Name = "tbxSenderName";
            this.tbxSenderName.ReadOnly = true;
            this.tbxSenderName.Size = new System.Drawing.Size(228, 26);
            this.tbxSenderName.TabIndex = 0;
            this.tbxSenderName.Text = "Le nom";
            // 
            // gbxSender
            // 
            this.gbxSender.Controls.Add(this.tbxSenderId);
            this.gbxSender.Controls.Add(this.btnSenderBan);
            this.gbxSender.Controls.Add(this.tbxSenderName);
            this.gbxSender.Location = new System.Drawing.Point(463, 281);
            this.gbxSender.Name = "gbxSender";
            this.gbxSender.Size = new System.Drawing.Size(365, 100);
            this.gbxSender.TabIndex = 5;
            this.gbxSender.TabStop = false;
            this.gbxSender.Text = "Sender";
            // 
            // btnReceiverBan
            // 
            this.btnReceiverBan.Location = new System.Drawing.Point(258, 25);
            this.btnReceiverBan.Name = "btnReceiverBan";
            this.btnReceiverBan.Size = new System.Drawing.Size(101, 60);
            this.btnReceiverBan.TabIndex = 1;
            this.btnReceiverBan.Text = "Ban";
            this.btnReceiverBan.UseVisualStyleBackColor = true;
            this.btnReceiverBan.Click += new System.EventHandler(this.btnReceiverBan_Click);
            // 
            // tbxReceiverName
            // 
            this.tbxReceiverName.Location = new System.Drawing.Point(9, 59);
            this.tbxReceiverName.Name = "tbxReceiverName";
            this.tbxReceiverName.ReadOnly = true;
            this.tbxReceiverName.Size = new System.Drawing.Size(228, 26);
            this.tbxReceiverName.TabIndex = 0;
            this.tbxReceiverName.Text = "Le nom";
            // 
            // gbxReceiver
            // 
            this.gbxReceiver.Controls.Add(this.tbxReceiverId);
            this.gbxReceiver.Controls.Add(this.btnReceiverBan);
            this.gbxReceiver.Controls.Add(this.tbxReceiverName);
            this.gbxReceiver.Location = new System.Drawing.Point(463, 439);
            this.gbxReceiver.Name = "gbxReceiver";
            this.gbxReceiver.Size = new System.Drawing.Size(365, 100);
            this.gbxReceiver.TabIndex = 5;
            this.gbxReceiver.TabStop = false;
            this.gbxReceiver.Text = "Receiver";
            // 
            // tbxMessageId
            // 
            this.tbxMessageId.Location = new System.Drawing.Point(9, 25);
            this.tbxMessageId.Name = "tbxMessageId";
            this.tbxMessageId.ReadOnly = true;
            this.tbxMessageId.Size = new System.Drawing.Size(228, 26);
            this.tbxMessageId.TabIndex = 2;
            this.tbxMessageId.Text = "L\'id";
            // 
            // tbxSenderId
            // 
            this.tbxSenderId.Location = new System.Drawing.Point(9, 25);
            this.tbxSenderId.Name = "tbxSenderId";
            this.tbxSenderId.ReadOnly = true;
            this.tbxSenderId.Size = new System.Drawing.Size(228, 26);
            this.tbxSenderId.TabIndex = 2;
            this.tbxSenderId.Text = "L\'id";
            // 
            // tbxReceiverId
            // 
            this.tbxReceiverId.Location = new System.Drawing.Point(9, 25);
            this.tbxReceiverId.Name = "tbxReceiverId";
            this.tbxReceiverId.ReadOnly = true;
            this.tbxReceiverId.Size = new System.Drawing.Size(228, 26);
            this.tbxReceiverId.TabIndex = 2;
            this.tbxReceiverId.Text = "L\'id";
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(841, 615);
            this.Controls.Add(this.gbxMessage);
            this.Controls.Add(this.gbxReceiver);
            this.Controls.Add(this.gbxSender);
            this.Controls.Add(this.lblUserCo);
            this.Controls.Add(this.lbReport);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion d\'utilisateur";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxMessage.ResumeLayout(false);
            this.gbxMessage.PerformLayout();
            this.gbxSender.ResumeLayout(false);
            this.gbxSender.PerformLayout();
            this.gbxReceiver.ResumeLayout(false);
            this.gbxReceiver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ListBox lbReport;
        private System.Windows.Forms.Label lblUserCo;
        private System.Windows.Forms.GroupBox gbxMessage;
        private System.Windows.Forms.TextBox tbxMessageId;
        private System.Windows.Forms.Button btnMessageBan;
        private System.Windows.Forms.TextBox tbxMessageContent;
        private System.Windows.Forms.Button btnSenderBan;
        private System.Windows.Forms.TextBox tbxSenderName;
        private System.Windows.Forms.GroupBox gbxSender;
        private System.Windows.Forms.TextBox tbxSenderId;
        private System.Windows.Forms.Button btnReceiverBan;
        private System.Windows.Forms.TextBox tbxReceiverName;
        private System.Windows.Forms.GroupBox gbxReceiver;
        private System.Windows.Forms.TextBox tbxReceiverId;
    }
}
