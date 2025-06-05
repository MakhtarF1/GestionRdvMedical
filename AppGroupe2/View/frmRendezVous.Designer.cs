namespace AppGroupe2.View
{
    partial class frmRendezVous
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgRendezVous = new System.Windows.Forms.DataGridView();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(1065, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 34);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgRendezVous
            // 
            this.dgRendezVous.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRendezVous.Location = new System.Drawing.Point(16, 62);
            this.dgRendezVous.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dgRendezVous.Name = "dgRendezVous";
            this.dgRendezVous.Size = new System.Drawing.Size(915, 449);
            this.dgRendezVous.TabIndex = 76;
            this.dgRendezVous.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRendezVous_CellContentClick);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(27, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(184, 27);
            this.lblNom.TabIndex = 77;
            this.lblNom.Text = "Mes Rendez-vous";
            // 
            // frmRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1174, 553);
            this.ControlBox = false;
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dgRendezVous);
            this.Controls.Add(this.btnClose);
            this.Name = "frmRendezVous";
            this.Text = "RendezVous";
            this.Load += new System.EventHandler(this.frmRendezVous_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgRendezVous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgRendezVous;
        private System.Windows.Forms.Label lblNom;
    }
}