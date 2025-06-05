namespace AppGroupe2.View
{
    partial class frmMedecin
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
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNumeroOrdre = new System.Windows.Forms.TextBox();
            this.lblNumeroOrdre = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.dgMedecin = new System.Windows.Forms.DataGridView();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.cbSpecialite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChoisir.Location = new System.Drawing.Point(386, 31);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(96, 34);
            this.btnChoisir.TabIndex = 30;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Location = new System.Drawing.Point(243, 490);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 34);
            this.btnSupprimer.TabIndex = 33;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(143, 490);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 34);
            this.btnModifier.TabIndex = 32;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Location = new System.Drawing.Point(35, 490);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(96, 34);
            this.btnAjouter.TabIndex = 29;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNumeroOrdre
            // 
            this.txtNumeroOrdre.Location = new System.Drawing.Point(36, 418);
            this.txtNumeroOrdre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumeroOrdre.Name = "txtNumeroOrdre";
            this.txtNumeroOrdre.Size = new System.Drawing.Size(302, 22);
            this.txtNumeroOrdre.TabIndex = 27;
            // 
            // lblNumeroOrdre
            // 
            this.lblNumeroOrdre.AutoSize = true;
            this.lblNumeroOrdre.Location = new System.Drawing.Point(36, 394);
            this.lblNumeroOrdre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroOrdre.Name = "lblNumeroOrdre";
            this.lblNumeroOrdre.Size = new System.Drawing.Size(104, 16);
            this.lblNumeroOrdre.TabIndex = 35;
            this.lblNumeroOrdre.Text = "Numero Ordre";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(36, 331);
            this.lblSpecialite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(77, 16);
            this.lblSpecialite.TabIndex = 34;
            this.lblSpecialite.Text = "Specialite";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(36, 292);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(302, 22);
            this.txtIdentifiant.TabIndex = 25;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(36, 267);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(74, 16);
            this.lblIdentifiant.TabIndex = 31;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(36, 228);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(302, 22);
            this.txtTelephone.TabIndex = 23;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(36, 203);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(82, 16);
            this.lblTelephone.TabIndex = 28;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(36, 164);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 22);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 139);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(36, 100);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(302, 22);
            this.txtAdresse.TabIndex = 20;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(36, 76);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(65, 16);
            this.lblAdresse.TabIndex = 21;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(36, 37);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(302, 22);
            this.txtNomPrenom.TabIndex = 18;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(36, 12);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(95, 16);
            this.lblNomPrenom.TabIndex = 19;
            this.lblNomPrenom.Text = "Nom prenom";
            // 
            // dgMedecin
            // 
            this.dgMedecin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgMedecin.Location = new System.Drawing.Point(386, 75);
            this.dgMedecin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.Size = new System.Drawing.Size(538, 474);
            this.dgMedecin.TabIndex = 36;
            this.dgMedecin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedecin_CellContentClick);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgenda.Location = new System.Drawing.Point(494, 31);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(96, 34);
            this.btnAgenda.TabIndex = 37;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.FormattingEnabled = true;
            this.cbSpecialite.Location = new System.Drawing.Point(39, 351);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(299, 24);
            this.cbSpecialite.TabIndex = 38;
            this.cbSpecialite.SelectedIndexChanged += new System.EventHandler(this.cbSpecialite_SelectedIndexChanged);
            // 
            // frmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(936, 553);
            this.ControlBox = false;
            this.Controls.Add(this.cbSpecialite);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumeroOrdre);
            this.Controls.Add(this.lblNumeroOrdre);
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.dgMedecin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMedecin";
            this.Text = "Medecin";
            this.Load += new System.EventHandler(this.frmMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNumeroOrdre;
        private System.Windows.Forms.Label lblNumeroOrdre;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.DataGridView dgMedecin;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.ComboBox cbSpecialite;
    }
}