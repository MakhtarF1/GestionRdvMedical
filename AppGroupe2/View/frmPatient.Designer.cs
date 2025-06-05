namespace AppGroupe2.View
{
    partial class frmPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.txtREmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRv = new Guna.UI2.WinForms.Guna2Button();
            this.btnRechercher = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDateNaissance = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTaille = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPoids = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGroupeSanguin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.lblGroupeSanguin = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.dgPatient = new System.Windows.Forms.DataGridView();
            this.btnChoisir = new Guna.UI2.WinForms.Guna2Button();
            this.pnBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbQuitter = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gbRecherche.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.pnBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRecherche
            // 
            this.gbRecherche.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbRecherche.Controls.Add(this.txtREmail);
            this.gbRecherche.Controls.Add(this.txtRTel);
            this.gbRecherche.Controls.Add(this.btnRv);
            this.gbRecherche.Controls.Add(this.btnRechercher);
            this.gbRecherche.Controls.Add(this.label2);
            this.gbRecherche.Controls.Add(this.label1);
            this.gbRecherche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbRecherche.Location = new System.Drawing.Point(549, 35);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(821, 99);
            this.gbRecherche.TabIndex = 18;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Recherche";
            // 
            // txtREmail
            // 
            this.txtREmail.Animated = true;
            this.txtREmail.BackColor = System.Drawing.Color.White;
            this.txtREmail.BorderColor = System.Drawing.Color.White;
            this.txtREmail.BorderRadius = 30;
            this.txtREmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtREmail.DefaultText = "";
            this.txtREmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtREmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtREmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtREmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtREmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtREmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtREmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtREmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtREmail.IconLeft")));
            this.txtREmail.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtREmail.Location = new System.Drawing.Point(255, 52);
            this.txtREmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.PlaceholderText = "";
            this.txtREmail.SelectedText = "";
            this.txtREmail.Size = new System.Drawing.Size(212, 29);
            this.txtREmail.TabIndex = 47;
            // 
            // txtRTel
            // 
            this.txtRTel.Animated = true;
            this.txtRTel.BackColor = System.Drawing.Color.White;
            this.txtRTel.BorderColor = System.Drawing.Color.White;
            this.txtRTel.BorderRadius = 30;
            this.txtRTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRTel.DefaultText = "";
            this.txtRTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRTel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtRTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRTel.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtRTel.IconLeft")));
            this.txtRTel.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtRTel.Location = new System.Drawing.Point(10, 52);
            this.txtRTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRTel.Name = "txtRTel";
            this.txtRTel.PlaceholderText = "";
            this.txtRTel.SelectedText = "";
            this.txtRTel.Size = new System.Drawing.Size(208, 29);
            this.txtRTel.TabIndex = 45;
            this.txtRTel.TextChanged += new System.EventHandler(this.txtRTel_TextChanged);
            // 
            // btnRv
            // 
            this.btnRv.BorderRadius = 8;
            this.btnRv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRv.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRv.ForeColor = System.Drawing.Color.Black;
            this.btnRv.Location = new System.Drawing.Point(688, 21);
            this.btnRv.Name = "btnRv";
            this.btnRv.Size = new System.Drawing.Size(115, 30);
            this.btnRv.TabIndex = 46;
            this.btnRv.Text = "Rendez-vous";
            this.btnRv.Click += new System.EventHandler(this.btnRv_Click_1);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BorderRadius = 8;
            this.btnRechercher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechercher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRechercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRechercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRechercher.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRechercher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.Black;
            this.btnRechercher.Location = new System.Drawing.Point(538, 21);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(115, 30);
            this.btnRechercher.TabIndex = 45;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Telephone";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnSupprimer);
            this.guna2Panel1.Controls.Add(this.btnAjouter);
            this.guna2Panel1.Controls.Add(this.btnModifier);
            this.guna2Panel1.Controls.Add(this.dtpDateNaissance);
            this.guna2Panel1.Controls.Add(this.txtTaille);
            this.guna2Panel1.Controls.Add(this.txtPoids);
            this.guna2Panel1.Controls.Add(this.txtGroupeSanguin);
            this.guna2Panel1.Controls.Add(this.txtTelephone);
            this.guna2Panel1.Controls.Add(this.txtEmail);
            this.guna2Panel1.Controls.Add(this.txtAdresse);
            this.guna2Panel1.Controls.Add(this.txtNomPrenom);
            this.guna2Panel1.Controls.Add(this.lblDateNaissance);
            this.guna2Panel1.Controls.Add(this.lblTaille);
            this.guna2Panel1.Controls.Add(this.lblPoids);
            this.guna2Panel1.Controls.Add(this.lblGroupeSanguin);
            this.guna2Panel1.Controls.Add(this.lblTelephone);
            this.guna2Panel1.Controls.Add(this.lblEmail);
            this.guna2Panel1.Controls.Add(this.lblAdresse);
            this.guna2Panel1.Controls.Add(this.lblNomPrenom);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 24;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Blue;
            this.guna2Panel1.Size = new System.Drawing.Size(411, 488);
            this.guna2Panel1.TabIndex = 19;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
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
            this.btnSupprimer.Location = new System.Drawing.Point(262, 448);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(115, 30);
            this.btnSupprimer.TabIndex = 43;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
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
            this.btnAjouter.Location = new System.Drawing.Point(20, 448);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 30);
            this.btnAjouter.TabIndex = 41;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.BorderRadius = 8;
            this.btnModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifier.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnModifier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(141, 448);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 30);
            this.btnModifier.TabIndex = 42;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.BorderRadius = 8;
            this.dtpDateNaissance.Checked = true;
            this.dtpDateNaissance.FillColor = System.Drawing.Color.White;
            this.dtpDateNaissance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.dtpDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateNaissance.Location = new System.Drawing.Point(13, 391);
            this.dtpDateNaissance.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateNaissance.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(322, 36);
            this.dtpDateNaissance.TabIndex = 40;
            this.dtpDateNaissance.Value = new System.DateTime(2025, 2, 26, 15, 13, 18, 446);
            // 
            // txtTaille
            // 
            this.txtTaille.Animated = true;
            this.txtTaille.BackColor = System.Drawing.Color.Transparent;
            this.txtTaille.BorderRadius = 8;
            this.txtTaille.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaille.DefaultText = "";
            this.txtTaille.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaille.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaille.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaille.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaille.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtTaille.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaille.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTaille.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaille.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTaille.IconLeft")));
            this.txtTaille.Location = new System.Drawing.Point(13, 342);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.PlaceholderText = "";
            this.txtTaille.SelectedText = "";
            this.txtTaille.Size = new System.Drawing.Size(322, 29);
            this.txtTaille.TabIndex = 39;
            // 
            // txtPoids
            // 
            this.txtPoids.Animated = true;
            this.txtPoids.BackColor = System.Drawing.Color.Transparent;
            this.txtPoids.BorderRadius = 8;
            this.txtPoids.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoids.DefaultText = "";
            this.txtPoids.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPoids.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPoids.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoids.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoids.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtPoids.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoids.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPoids.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoids.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPoids.IconLeft")));
            this.txtPoids.Location = new System.Drawing.Point(13, 291);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.PlaceholderText = "";
            this.txtPoids.SelectedText = "";
            this.txtPoids.Size = new System.Drawing.Size(322, 29);
            this.txtPoids.TabIndex = 38;
            // 
            // txtGroupeSanguin
            // 
            this.txtGroupeSanguin.Animated = true;
            this.txtGroupeSanguin.BackColor = System.Drawing.Color.Transparent;
            this.txtGroupeSanguin.BorderRadius = 8;
            this.txtGroupeSanguin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupeSanguin.DefaultText = "";
            this.txtGroupeSanguin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroupeSanguin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroupeSanguin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupeSanguin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupeSanguin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtGroupeSanguin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupeSanguin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtGroupeSanguin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupeSanguin.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtGroupeSanguin.IconLeft")));
            this.txtGroupeSanguin.Location = new System.Drawing.Point(13, 239);
            this.txtGroupeSanguin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGroupeSanguin.Name = "txtGroupeSanguin";
            this.txtGroupeSanguin.PlaceholderText = "";
            this.txtGroupeSanguin.SelectedText = "";
            this.txtGroupeSanguin.Size = new System.Drawing.Size(322, 29);
            this.txtGroupeSanguin.TabIndex = 37;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Animated = true;
            this.txtTelephone.BackColor = System.Drawing.Color.Transparent;
            this.txtTelephone.BorderRadius = 8;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.DefaultText = "";
            this.txtTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTelephone.IconLeft")));
            this.txtTelephone.Location = new System.Drawing.Point(13, 187);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PlaceholderText = "";
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.Size = new System.Drawing.Size(322, 29);
            this.txtTelephone.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtEmail.IconLeft")));
            this.txtEmail.Location = new System.Drawing.Point(13, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(322, 29);
            this.txtEmail.TabIndex = 35;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Animated = true;
            this.txtAdresse.BackColor = System.Drawing.Color.Transparent;
            this.txtAdresse.BorderRadius = 8;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.DefaultText = "";
            this.txtAdresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtAdresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtAdresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtAdresse.IconLeft")));
            this.txtAdresse.Location = new System.Drawing.Point(13, 84);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PlaceholderText = "";
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.Size = new System.Drawing.Size(322, 29);
            this.txtAdresse.TabIndex = 34;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Animated = true;
            this.txtNomPrenom.BackColor = System.Drawing.Color.Transparent;
            this.txtNomPrenom.BorderRadius = 8;
            this.txtNomPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomPrenom.DefaultText = "";
            this.txtNomPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomPrenom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNomPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPrenom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNomPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomPrenom.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNomPrenom.IconLeft")));
            this.txtNomPrenom.Location = new System.Drawing.Point(13, 32);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.PlaceholderText = "";
            this.txtNomPrenom.SelectedText = "";
            this.txtNomPrenom.Size = new System.Drawing.Size(322, 29);
            this.txtNomPrenom.TabIndex = 33;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(12, 372);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(140, 16);
            this.lblDateNaissance.TabIndex = 26;
            this.lblDateNaissance.Text = "Date de Naissance";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(8, 322);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(47, 16);
            this.lblTaille.TabIndex = 32;
            this.lblTaille.Text = "Taille";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(8, 271);
            this.lblPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(47, 16);
            this.lblPoids.TabIndex = 30;
            this.lblPoids.Text = "Poids";
            // 
            // lblGroupeSanguin
            // 
            this.lblGroupeSanguin.AutoSize = true;
            this.lblGroupeSanguin.Location = new System.Drawing.Point(17, 219);
            this.lblGroupeSanguin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupeSanguin.Name = "lblGroupeSanguin";
            this.lblGroupeSanguin.Size = new System.Drawing.Size(118, 16);
            this.lblGroupeSanguin.TabIndex = 27;
            this.lblGroupeSanguin.Text = "Groupe Sanguin";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(17, 167);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(82, 16);
            this.lblTelephone.TabIndex = 24;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 115);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(8, 64);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(65, 16);
            this.lblAdresse.TabIndex = 17;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(17, 12);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(95, 16);
            this.lblNomPrenom.TabIndex = 14;
            this.lblNomPrenom.Text = "Nom prenom";
            // 
            // dgPatient
            // 
            this.dgPatient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgPatient.Location = new System.Drawing.Point(430, 141);
            this.dgPatient.Margin = new System.Windows.Forms.Padding(4);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.Size = new System.Drawing.Size(927, 409);
            this.dgPatient.TabIndex = 17;
            // 
            // btnChoisir
            // 
            this.btnChoisir.BorderRadius = 8;
            this.btnChoisir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoisir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoisir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoisir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoisir.FillColor = System.Drawing.Color.Crimson;
            this.btnChoisir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoisir.ForeColor = System.Drawing.Color.White;
            this.btnChoisir.Location = new System.Drawing.Point(417, 35);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(115, 30);
            this.btnChoisir.TabIndex = 44;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click_1);
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnBar.Controls.Add(this.guna2ControlBox2);
            this.pnBar.Controls.Add(this.cbQuitter);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.Location = new System.Drawing.Point(0, 0);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(1370, 34);
            this.pnBar.TabIndex = 45;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1273, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(35, 28);
            this.guna2ControlBox2.TabIndex = 9;
            // 
            // cbQuitter
            // 
            this.cbQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuitter.FillColor = System.Drawing.Color.White;
            this.cbQuitter.IconColor = System.Drawing.Color.Red;
            this.cbQuitter.Location = new System.Drawing.Point(1322, 3);
            this.cbQuitter.Name = "cbQuitter";
            this.cbQuitter.Size = new System.Drawing.Size(35, 28);
            this.cbQuitter.TabIndex = 8;
            this.cbQuitter.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 553);
            this.ControlBox = false;
            this.Controls.Add(this.pnBar);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.dgPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.pnBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label lblGroupeSanguin;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNomPrenom;
        private Guna.UI2.WinForms.Guna2TextBox txtNomPrenom;
        private System.Windows.Forms.DataGridView dgPatient;
        private Guna.UI2.WinForms.Guna2TextBox txtAdresse;
        private Guna.UI2.WinForms.Guna2TextBox txtPoids;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupeSanguin;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephone;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateNaissance;
        private Guna.UI2.WinForms.Guna2TextBox txtTaille;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
        private Guna.UI2.WinForms.Guna2Button btnModifier;
        private Guna.UI2.WinForms.Guna2Button btnChoisir;
        private Guna.UI2.WinForms.Guna2Button btnRv;
        private Guna.UI2.WinForms.Guna2Button btnRechercher;
        private Guna.UI2.WinForms.Guna2TextBox txtREmail;
        private Guna.UI2.WinForms.Guna2TextBox txtRTel;
        private Guna.UI2.WinForms.Guna2Panel pnBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox cbQuitter;
    }
}