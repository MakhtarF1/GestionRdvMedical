namespace AppGroupe2
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.btnPatient = new Guna.UI2.WinForms.Guna2Button();
            this.Pn_left = new Guna.UI2.WinForms.Guna2Panel();
<<<<<<< HEAD
            this.btnParametre = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlanification = new Guna.UI2.WinForms.Guna2Button();
            this.btnActions = new Guna.UI2.WinForms.Guna2Button();
            this.btnUtilisateur = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitter = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeDeconnecter = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRv = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedecin = new Guna.UI2.WinForms.Guna2Button();
=======
            this.btnMedecin = new Guna.UI2.WinForms.Guna2Button();
            this.btnRv = new Guna.UI2.WinForms.Guna2Button();
            this.lblActions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblParametrel = new System.Windows.Forms.Label();
            this.btnSeDeconnecter = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitter = new Guna.UI2.WinForms.Guna2Button();
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pn_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.Animated = true;
            this.btnPatient.AutoRoundedCorners = true;
            this.btnPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatient.FillColor = System.Drawing.Color.White;
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatient.ImageSize = new System.Drawing.Size(40, 40);
<<<<<<< HEAD
            this.btnPatient.Location = new System.Drawing.Point(23, 486);
=======
            this.btnPatient.Location = new System.Drawing.Point(17, 214);
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(243, 45);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patient";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // Pn_left
            // 
<<<<<<< HEAD
            this.Pn_left.Controls.Add(this.btnParametre);
            this.Pn_left.Controls.Add(this.btnPlanification);
            this.Pn_left.Controls.Add(this.btnActions);
            this.Pn_left.Controls.Add(this.btnUtilisateur);
            this.Pn_left.Controls.Add(this.btnQuitter);
            this.Pn_left.Controls.Add(this.btnSeDeconnecter);
            this.Pn_left.Controls.Add(this.pictureBox1);
=======
            this.Pn_left.Controls.Add(this.btnQuitter);
            this.Pn_left.Controls.Add(this.btnSeDeconnecter);
            this.Pn_left.Controls.Add(this.lblParametrel);
            this.Pn_left.Controls.Add(this.pictureBox1);
            this.Pn_left.Controls.Add(this.lblActions);
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            this.Pn_left.Controls.Add(this.btnRv);
            this.Pn_left.Controls.Add(this.btnMedecin);
            this.Pn_left.Controls.Add(this.btnPatient);
            this.Pn_left.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pn_left.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pn_left.Location = new System.Drawing.Point(0, 1);
            this.Pn_left.Margin = new System.Windows.Forms.Padding(4);
            this.Pn_left.Name = "Pn_left";
<<<<<<< HEAD
            this.Pn_left.Size = new System.Drawing.Size(289, 683);
            this.Pn_left.TabIndex = 3;
            this.Pn_left.Paint += new System.Windows.Forms.PaintEventHandler(this.Pn_left_Paint);
            // 
            // btnParametre
            // 
            this.btnParametre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParametre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParametre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParametre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParametre.FillColor = System.Drawing.Color.White;
            this.btnParametre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametre.ForeColor = System.Drawing.Color.Black;
            this.btnParametre.Location = new System.Drawing.Point(0, 537);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(208, 45);
            this.btnParametre.TabIndex = 13;
            this.btnParametre.Text = "Paramétres";
            // 
            // btnPlanification
            // 
            this.btnPlanification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlanification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlanification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlanification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlanification.FillColor = System.Drawing.Color.White;
            this.btnPlanification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanification.ForeColor = System.Drawing.Color.Black;
            this.btnPlanification.Location = new System.Drawing.Point(10, 290);
            this.btnPlanification.Name = "btnPlanification";
            this.btnPlanification.Size = new System.Drawing.Size(208, 45);
            this.btnPlanification.TabIndex = 12;
            this.btnPlanification.Text = "Planification";
            // 
            // btnActions
            // 
            this.btnActions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActions.FillColor = System.Drawing.Color.White;
            this.btnActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActions.ForeColor = System.Drawing.Color.Black;
            this.btnActions.Location = new System.Drawing.Point(22, 160);
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(141, 45);
            this.btnActions.TabIndex = 11;
            this.btnActions.Text = "Actions";
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.Animated = true;
            this.btnUtilisateur.AutoRoundedCorners = true;
            this.btnUtilisateur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUtilisateur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUtilisateur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUtilisateur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUtilisateur.FillColor = System.Drawing.Color.White;
            this.btnUtilisateur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateur.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("btnUtilisateur.Image")));
            this.btnUtilisateur.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUtilisateur.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUtilisateur.Location = new System.Drawing.Point(17, 226);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(243, 45);
            this.btnUtilisateur.TabIndex = 10;
            this.btnUtilisateur.Text = "Utilisateur";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Animated = true;
            this.btnQuitter.AutoRoundedCorners = true;
            this.btnQuitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuitter.FillColor = System.Drawing.Color.White;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnQuitter.ImageSize = new System.Drawing.Size(40, 40);
            this.btnQuitter.Location = new System.Drawing.Point(23, 627);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(243, 45);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.Animated = true;
            this.btnSeDeconnecter.AutoRoundedCorners = true;
            this.btnSeDeconnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeDeconnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeDeconnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeDeconnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeDeconnecter.FillColor = System.Drawing.Color.White;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDeconnecter.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSeDeconnecter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeDeconnecter.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSeDeconnecter.Location = new System.Drawing.Point(23, 577);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(243, 45);
            this.btnSeDeconnecter.TabIndex = 6;
            this.btnSeDeconnecter.Text = "&Se Deconnecter";
            this.btnSeDeconnecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRv
            // 
            this.btnRv.Animated = true;
            this.btnRv.AutoRoundedCorners = true;
            this.btnRv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRv.FillColor = System.Drawing.Color.White;
            this.btnRv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRv.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnRv.Image = ((System.Drawing.Image)(resources.GetObject("btnRv.Image")));
            this.btnRv.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRv.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRv.Location = new System.Drawing.Point(25, 417);
            this.btnRv.Name = "btnRv";
            this.btnRv.Size = new System.Drawing.Size(243, 45);
            this.btnRv.TabIndex = 2;
            this.btnRv.Text = "Rendez-vous";
            // 
=======
            this.Pn_left.Size = new System.Drawing.Size(289, 607);
            this.Pn_left.TabIndex = 3;
            this.Pn_left.Paint += new System.Windows.Forms.PaintEventHandler(this.Pn_left_Paint);
            // 
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            // btnMedecin
            // 
            this.btnMedecin.Animated = true;
            this.btnMedecin.AutoRoundedCorners = true;
            this.btnMedecin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedecin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedecin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedecin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedecin.FillColor = System.Drawing.Color.White;
            this.btnMedecin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedecin.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnMedecin.Image = ((System.Drawing.Image)(resources.GetObject("btnMedecin.Image")));
            this.btnMedecin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedecin.ImageSize = new System.Drawing.Size(40, 40);
<<<<<<< HEAD
            this.btnMedecin.Location = new System.Drawing.Point(17, 352);
=======
            this.btnMedecin.Location = new System.Drawing.Point(17, 296);
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            this.btnMedecin.Name = "btnMedecin";
            this.btnMedecin.Size = new System.Drawing.Size(243, 45);
            this.btnMedecin.TabIndex = 1;
            this.btnMedecin.Text = "Medecin";
            this.btnMedecin.Click += new System.EventHandler(this.btnMedecin_Click);
            // 
<<<<<<< HEAD
=======
            // btnRv
            // 
            this.btnRv.Animated = true;
            this.btnRv.AutoRoundedCorners = true;
            this.btnRv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRv.FillColor = System.Drawing.Color.White;
            this.btnRv.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRv.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnRv.Image = ((System.Drawing.Image)(resources.GetObject("btnRv.Image")));
            this.btnRv.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRv.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRv.Location = new System.Drawing.Point(23, 382);
            this.btnRv.Name = "btnRv";
            this.btnRv.Size = new System.Drawing.Size(243, 45);
            this.btnRv.TabIndex = 2;
            this.btnRv.Text = "Rendez-vous";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(19, 168);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(59, 20);
            this.lblActions.TabIndex = 3;
            this.lblActions.Text = "Actions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblParametrel
            // 
            this.lblParametrel.AutoSize = true;
            this.lblParametrel.Location = new System.Drawing.Point(19, 462);
            this.lblParametrel.Name = "lblParametrel";
            this.lblParametrel.Size = new System.Drawing.Size(86, 20);
            this.lblParametrel.TabIndex = 5;
            this.lblParametrel.Text = "Paramétres";
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.Animated = true;
            this.btnSeDeconnecter.AutoRoundedCorners = true;
            this.btnSeDeconnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeDeconnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeDeconnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeDeconnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeDeconnecter.FillColor = System.Drawing.Color.White;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDeconnecter.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSeDeconnecter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeDeconnecter.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSeDeconnecter.Location = new System.Drawing.Point(23, 489);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(243, 45);
            this.btnSeDeconnecter.TabIndex = 6;
            this.btnSeDeconnecter.Text = "&Se Deconnecter";
            this.btnSeDeconnecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Animated = true;
            this.btnQuitter.AutoRoundedCorners = true;
            this.btnQuitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuitter.FillColor = System.Drawing.Color.White;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnQuitter.ImageSize = new System.Drawing.Size(40, 40);
            this.btnQuitter.Location = new System.Drawing.Point(23, 539);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(243, 45);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 0);
            this.pictureBox2.Name = "pictureBox2";
<<<<<<< HEAD
            this.pictureBox2.Size = new System.Drawing.Size(496, 684);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 684);
=======
            this.pictureBox2.Size = new System.Drawing.Size(496, 601);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 601);
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Pn_left);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4);
=======
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            this.Name = "frmMDI";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.Pn_left.ResumeLayout(false);
<<<<<<< HEAD
=======
            this.Pn_left.PerformLayout();
>>>>>>> 8f904f457910be6f53a33265328af12516297100
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPatient;
        private Guna.UI2.WinForms.Guna2Panel Pn_left;
        private Guna.UI2.WinForms.Guna2Button btnMedecin;
        private System.Windows.Forms.PictureBox pictureBox1;
<<<<<<< HEAD
        private Guna.UI2.WinForms.Guna2Button btnRv;
        private Guna.UI2.WinForms.Guna2Button btnQuitter;
        private Guna.UI2.WinForms.Guna2Button btnSeDeconnecter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnUtilisateur;
        private Guna.UI2.WinForms.Guna2Button btnParametre;
        private Guna.UI2.WinForms.Guna2Button btnPlanification;
        private Guna.UI2.WinForms.Guna2Button btnActions;
=======
        private System.Windows.Forms.Label lblActions;
        private Guna.UI2.WinForms.Guna2Button btnRv;
        private Guna.UI2.WinForms.Guna2Button btnQuitter;
        private Guna.UI2.WinForms.Guna2Button btnSeDeconnecter;
        private System.Windows.Forms.Label lblParametrel;
        private System.Windows.Forms.PictureBox pictureBox2;
>>>>>>> 8f904f457910be6f53a33265328af12516297100
    }
}