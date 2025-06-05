namespace AppGroupe2.View
{
    partial class frmAgenda
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
            this.txtCreneau = new System.Windows.Forms.TextBox();
            this.lblCreneau = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.lblHeureFin = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dgAgenda = new System.Windows.Forms.DataGridView();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.txtDateAgenda = new System.Windows.Forms.DateTimePicker();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblIdMedecin = new System.Windows.Forms.Label();
            this.btnRendezVous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChoisir.Location = new System.Drawing.Point(438, 27);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(112, 34);
            this.btnChoisir.TabIndex = 69;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Location = new System.Drawing.Point(272, 393);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 34);
            this.btnSupprimer.TabIndex = 72;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(155, 393);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 34);
            this.btnModifier.TabIndex = 71;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Location = new System.Drawing.Point(29, 393);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 34);
            this.btnAjouter.TabIndex = 68;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtCreneau
            // 
            this.txtCreneau.Location = new System.Drawing.Point(29, 350);
            this.txtCreneau.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtCreneau.Name = "txtCreneau";
            this.txtCreneau.Size = new System.Drawing.Size(352, 20);
            this.txtCreneau.TabIndex = 65;
            // 
            // lblCreneau
            // 
            this.lblCreneau.AutoSize = true;
            this.lblCreneau.Location = new System.Drawing.Point(29, 327);
            this.lblCreneau.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCreneau.Name = "lblCreneau";
            this.lblCreneau.Size = new System.Drawing.Size(54, 13);
            this.lblCreneau.TabIndex = 73;
            this.lblCreneau.Text = "Creneau";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(29, 288);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(352, 20);
            this.txtLieu.TabIndex = 64;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(29, 263);
            this.lblLieu.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(31, 13);
            this.lblLieu.TabIndex = 70;
            this.lblLieu.Text = "Lieu";
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Location = new System.Drawing.Point(29, 224);
            this.txtHeureFin.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(352, 20);
            this.txtHeureFin.TabIndex = 62;
            // 
            // lblHeureFin
            // 
            this.lblHeureFin.AutoSize = true;
            this.lblHeureFin.Location = new System.Drawing.Point(29, 199);
            this.lblHeureFin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHeureFin.Name = "lblHeureFin";
            this.lblHeureFin.Size = new System.Drawing.Size(62, 13);
            this.lblHeureFin.TabIndex = 67;
            this.lblHeureFin.Text = "Heure Fin";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(29, 160);
            this.txtHeureDebut.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(352, 20);
            this.txtHeureDebut.TabIndex = 61;
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.Location = new System.Drawing.Point(29, 135);
            this.lblHeureDebut.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(79, 13);
            this.lblHeureDebut.TabIndex = 63;
            this.lblHeureDebut.Text = "Heure Debut";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(29, 72);
            this.lblDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 13);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "Date";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(29, 33);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(352, 20);
            this.txtTitre.TabIndex = 57;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(29, 8);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(33, 13);
            this.lblTitre.TabIndex = 58;
            this.lblTitre.Text = "Titre";
            // 
            // dgAgenda
            // 
            this.dgAgenda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgAgenda.Location = new System.Drawing.Point(438, 71);
            this.dgAgenda.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dgAgenda.Name = "dgAgenda";
            this.dgAgenda.Size = new System.Drawing.Size(628, 474);
            this.dgAgenda.TabIndex = 75;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(29, 451);
            this.lblMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(0, 13);
            this.lblMedecin.TabIndex = 76;
            // 
            // txtDateAgenda
            // 
            this.txtDateAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateAgenda.Location = new System.Drawing.Point(29, 101);
            this.txtDateAgenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDateAgenda.Name = "txtDateAgenda";
            this.txtDateAgenda.Size = new System.Drawing.Size(353, 20);
            this.txtDateAgenda.TabIndex = 77;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFermer.Location = new System.Drawing.Point(974, 8);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(112, 34);
            this.btnFermer.TabIndex = 78;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblIdMedecin
            // 
            this.lblIdMedecin.AutoSize = true;
            this.lblIdMedecin.Location = new System.Drawing.Point(29, 511);
            this.lblIdMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMedecin.Name = "lblIdMedecin";
            this.lblIdMedecin.Size = new System.Drawing.Size(0, 13);
            this.lblIdMedecin.TabIndex = 79;
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRendezVous.Location = new System.Drawing.Point(589, 27);
            this.btnRendezVous.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(161, 34);
            this.btnRendezVous.TabIndex = 80;
            this.btnRendezVous.Text = "Mes Rendez-Vous";
            this.btnRendezVous.UseVisualStyleBackColor = false;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1092, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnRendezVous);
            this.Controls.Add(this.lblIdMedecin);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.txtDateAgenda);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtCreneau);
            this.Controls.Add(this.lblCreneau);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.txtHeureFin);
            this.Controls.Add(this.lblHeureFin);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.lblHeureDebut);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dgAgenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtCreneau;
        private System.Windows.Forms.Label lblCreneau;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Label lblHeureFin;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgAgenda;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.DateTimePicker txtDateAgenda;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblIdMedecin;
        private System.Windows.Forms.Button btnRendezVous;
    }
}