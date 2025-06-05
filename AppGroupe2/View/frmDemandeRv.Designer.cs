namespace AppGroupe2.View
{
    partial class frmDemandeRv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemandeRv));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCreneau = new System.Windows.Forms.Label();
            this.dgCreneau = new System.Windows.Forms.DataGridView();
            this.dgMedecin = new System.Windows.Forms.DataGridView();
            this.lblListeMedecin = new System.Windows.Forms.Label();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgListeAgenda = new System.Windows.Forms.DataGridView();
            this.lblListeAgendaMedecin = new System.Windows.Forms.Label();
            this.btnVoirCreneau = new System.Windows.Forms.Button();
            this.pnBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbQuitter = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtNomPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSpecialite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSoin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCout = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPayement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRefPayement = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumeroRecu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCreneau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListeAgenda)).BeginInit();
            this.pnBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Mode Payement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Soins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Numero Recu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "Specialite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Cout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Reference Payement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Nom prenom";
            // 
            // lblCreneau
            // 
            this.lblCreneau.AutoSize = true;
            this.lblCreneau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreneau.Location = new System.Drawing.Point(9, 40);
            this.lblCreneau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreneau.Name = "lblCreneau";
            this.lblCreneau.Size = new System.Drawing.Size(65, 16);
            this.lblCreneau.TabIndex = 94;
            this.lblCreneau.Text = "Creneau";
            // 
            // dgCreneau
            // 
            this.dgCreneau.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgCreneau.Location = new System.Drawing.Point(8, 65);
            this.dgCreneau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgCreneau.Name = "dgCreneau";
            this.dgCreneau.Size = new System.Drawing.Size(225, 474);
            this.dgCreneau.TabIndex = 93;
            // 
            // dgMedecin
            // 
            this.dgMedecin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgMedecin.Location = new System.Drawing.Point(556, 86);
            this.dgMedecin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.Size = new System.Drawing.Size(538, 144);
            this.dgMedecin.TabIndex = 109;
            this.dgMedecin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedecin_CellContentClick);
            // 
            // lblListeMedecin
            // 
            this.lblListeMedecin.AutoSize = true;
            this.lblListeMedecin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeMedecin.Location = new System.Drawing.Point(553, 68);
            this.lblListeMedecin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListeMedecin.Name = "lblListeMedecin";
            this.lblListeMedecin.Size = new System.Drawing.Size(124, 17);
            this.lblListeMedecin.TabIndex = 110;
            this.lblListeMedecin.Text = "Liste des Medecins";
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectionner.Location = new System.Drawing.Point(987, 50);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(95, 34);
            this.btnSelectionner.TabIndex = 111;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // dgListeAgenda
            // 
            this.dgListeAgenda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListeAgenda.Location = new System.Drawing.Point(556, 332);
            this.dgListeAgenda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgListeAgenda.Name = "dgListeAgenda";
            this.dgListeAgenda.Size = new System.Drawing.Size(538, 144);
            this.dgListeAgenda.TabIndex = 112;
            // 
            // lblListeAgendaMedecin
            // 
            this.lblListeAgendaMedecin.AutoSize = true;
            this.lblListeAgendaMedecin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeAgendaMedecin.Location = new System.Drawing.Point(553, 314);
            this.lblListeAgendaMedecin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblListeAgendaMedecin.Name = "lblListeAgendaMedecin";
            this.lblListeAgendaMedecin.Size = new System.Drawing.Size(111, 17);
            this.lblListeAgendaMedecin.TabIndex = 113;
            this.lblListeAgendaMedecin.Text = "Agenda Medecin";
            // 
            // btnVoirCreneau
            // 
            this.btnVoirCreneau.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoirCreneau.Location = new System.Drawing.Point(987, 293);
            this.btnVoirCreneau.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnVoirCreneau.Name = "btnVoirCreneau";
            this.btnVoirCreneau.Size = new System.Drawing.Size(95, 34);
            this.btnVoirCreneau.TabIndex = 114;
            this.btnVoirCreneau.Text = "Voir Creneau";
            this.btnVoirCreneau.UseVisualStyleBackColor = false;
            this.btnVoirCreneau.Click += new System.EventHandler(this.btnVoirCreneau_Click);
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnBar.Controls.Add(this.guna2ControlBox2);
            this.pnBar.Controls.Add(this.cbQuitter);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.Location = new System.Drawing.Point(0, 0);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(1155, 34);
            this.pnBar.TabIndex = 115;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1058, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(35, 28);
            this.guna2ControlBox2.TabIndex = 9;
            // 
            // cbQuitter
            // 
            this.cbQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuitter.FillColor = System.Drawing.Color.White;
            this.cbQuitter.IconColor = System.Drawing.Color.Red;
            this.cbQuitter.Location = new System.Drawing.Point(1107, 3);
            this.cbQuitter.Name = "cbQuitter";
            this.cbQuitter.Size = new System.Drawing.Size(35, 28);
            this.cbQuitter.TabIndex = 8;
            this.cbQuitter.Click += new System.EventHandler(this.cbQuitter_Click);
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Animated = true;
            this.txtNomPrenom.BackColor = System.Drawing.Color.White;
            this.txtNomPrenom.BorderRadius = 8;
            this.txtNomPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomPrenom.DefaultText = "";
            this.txtNomPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPrenom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNomPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPrenom.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNomPrenom.IconLeft")));
            this.txtNomPrenom.Location = new System.Drawing.Point(243, 91);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.PlaceholderText = "";
            this.txtNomPrenom.SelectedText = "";
            this.txtNomPrenom.Size = new System.Drawing.Size(305, 29);
            this.txtNomPrenom.TabIndex = 116;
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.BackColor = System.Drawing.Color.Transparent;
            this.cbSpecialite.BorderRadius = 8;
            this.cbSpecialite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSpecialite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialite.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSpecialite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSpecialite.ItemHeight = 30;
            this.cbSpecialite.Location = new System.Drawing.Point(242, 150);
            this.cbSpecialite.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(305, 36);
            this.cbSpecialite.TabIndex = 117;
            // 
            // cbSoin
            // 
            this.cbSoin.BackColor = System.Drawing.Color.Transparent;
            this.cbSoin.BorderRadius = 8;
            this.cbSoin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSoin.ItemHeight = 30;
            this.cbSoin.Location = new System.Drawing.Point(242, 210);
            this.cbSoin.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoin.Name = "cbSoin";
            this.cbSoin.Size = new System.Drawing.Size(305, 36);
            this.cbSoin.TabIndex = 118;
            // 
            // txtCout
            // 
            this.txtCout.Animated = true;
            this.txtCout.BackColor = System.Drawing.Color.White;
            this.txtCout.BorderRadius = 8;
            this.txtCout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCout.DefaultText = "";
            this.txtCout.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCout.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCout.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCout.Location = new System.Drawing.Point(242, 279);
            this.txtCout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCout.Name = "txtCout";
            this.txtCout.PlaceholderText = "";
            this.txtCout.SelectedText = "";
            this.txtCout.Size = new System.Drawing.Size(305, 29);
            this.txtCout.TabIndex = 119;
            // 
            // cbPayement
            // 
            this.cbPayement.BackColor = System.Drawing.Color.Transparent;
            this.cbPayement.BorderRadius = 8;
            this.cbPayement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPayement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPayement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPayement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPayement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPayement.ItemHeight = 30;
            this.cbPayement.Location = new System.Drawing.Point(243, 338);
            this.cbPayement.Margin = new System.Windows.Forms.Padding(4);
            this.cbPayement.Name = "cbPayement";
            this.cbPayement.Size = new System.Drawing.Size(305, 36);
            this.cbPayement.TabIndex = 120;
            // 
            // txtRefPayement
            // 
            this.txtRefPayement.Animated = true;
            this.txtRefPayement.BackColor = System.Drawing.Color.White;
            this.txtRefPayement.BorderRadius = 8;
            this.txtRefPayement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRefPayement.DefaultText = "";
            this.txtRefPayement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRefPayement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRefPayement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefPayement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefPayement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefPayement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtRefPayement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefPayement.Location = new System.Drawing.Point(244, 410);
            this.txtRefPayement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRefPayement.Name = "txtRefPayement";
            this.txtRefPayement.PlaceholderText = "";
            this.txtRefPayement.SelectedText = "";
            this.txtRefPayement.Size = new System.Drawing.Size(305, 29);
            this.txtRefPayement.TabIndex = 121;
            // 
            // txtNumeroRecu
            // 
            this.txtNumeroRecu.Animated = true;
            this.txtNumeroRecu.BackColor = System.Drawing.Color.White;
            this.txtNumeroRecu.BorderRadius = 8;
            this.txtNumeroRecu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroRecu.DefaultText = "";
            this.txtNumeroRecu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroRecu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroRecu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroRecu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroRecu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroRecu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNumeroRecu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroRecu.Location = new System.Drawing.Point(244, 469);
            this.txtNumeroRecu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroRecu.Name = "txtNumeroRecu";
            this.txtNumeroRecu.PlaceholderText = "";
            this.txtNumeroRecu.SelectedText = "";
            this.txtNumeroRecu.Size = new System.Drawing.Size(305, 29);
            this.txtNumeroRecu.TabIndex = 122;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BorderRadius = 8;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(244, 518);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 30);
            this.btnAjouter.TabIndex = 123;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BorderRadius = 8;
            this.btnSupprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupprimer.FillColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(421, 518);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(115, 30);
            this.btnSupprimer.TabIndex = 124;
            this.btnSupprimer.Text = "Supprimer";
            // 
            // frmDemandeRv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 627);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumeroRecu);
            this.Controls.Add(this.txtRefPayement);
            this.Controls.Add(this.cbPayement);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.cbSoin);
            this.Controls.Add(this.cbSpecialite);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.pnBar);
            this.Controls.Add(this.btnVoirCreneau);
            this.Controls.Add(this.lblListeAgendaMedecin);
            this.Controls.Add(this.dgListeAgenda);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.lblListeMedecin);
            this.Controls.Add(this.dgMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCreneau);
            this.Controls.Add(this.dgCreneau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDemandeRv";
            this.Text = "Demande de Rendez-vous";
            this.Load += new System.EventHandler(this.frmDemandeRv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCreneau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListeAgenda)).EndInit();
            this.pnBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCreneau;
        private System.Windows.Forms.DataGridView dgCreneau;
        private System.Windows.Forms.DataGridView dgMedecin;
        private System.Windows.Forms.Label lblListeMedecin;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgListeAgenda;
        private System.Windows.Forms.Label lblListeAgendaMedecin;
        private System.Windows.Forms.Button btnVoirCreneau;
        private Guna.UI2.WinForms.Guna2Panel pnBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox cbQuitter;
        private Guna.UI2.WinForms.Guna2TextBox txtNomPrenom;
        private Guna.UI2.WinForms.Guna2ComboBox cbSpecialite;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoin;
        private Guna.UI2.WinForms.Guna2TextBox txtCout;
        private Guna.UI2.WinForms.Guna2ComboBox cbPayement;
        private Guna.UI2.WinForms.Guna2TextBox txtRefPayement;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroRecu;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
    }
}