
namespace MediaTek86.Vue
{
    partial class frmGestionAbsence
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
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblAdministration = new System.Windows.Forms.Label();
            this.btnVider = new System.Windows.Forms.Button();
            this.lblAbsence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(12, 60);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.Size = new System.Drawing.Size(944, 185);
            this.dgvAbsence.TabIndex = 0;
            this.dgvAbsence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsence_CellContentClick);
            this.dgvAbsence.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsence_CellEnter);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(134, 396);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 3;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(134, 423);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // cmbMotif
            // 
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(133, 449);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(201, 21);
            this.cmbMotif.TabIndex = 5;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDebut.Location = new System.Drawing.Point(82, 403);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(45, 13);
            this.lblDebut.TabIndex = 8;
            this.lblDebut.Text = "Debut : ";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFin.Location = new System.Drawing.Point(98, 429);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(30, 13);
            this.lblFin.TabIndex = 9;
            this.lblFin.Text = "Fin : ";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMotif.Location = new System.Drawing.Point(88, 452);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(39, 13);
            this.lblMotif.TabIndex = 10;
            this.lblMotif.Text = "Motif : ";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(723, 393);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(723, 422);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(723, 451);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(52, 570);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "<--  Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInformation.Location = new System.Drawing.Point(196, 342);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(92, 22);
            this.lblInformation.TabIndex = 15;
            this.lblInformation.Text = "Information";
            // 
            // lblAdministration
            // 
            this.lblAdministration.AutoSize = true;
            this.lblAdministration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdministration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdministration.Location = new System.Drawing.Point(706, 342);
            this.lblAdministration.Name = "lblAdministration";
            this.lblAdministration.Size = new System.Drawing.Size(112, 22);
            this.lblAdministration.TabIndex = 16;
            this.lblAdministration.Text = "Administration";
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(179, 476);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(103, 23);
            this.btnVider.TabIndex = 17;
            this.btnVider.Text = "Reinitialiser";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // lblAbsence
            // 
            this.lblAbsence.AutoSize = true;
            this.lblAbsence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAbsence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbsence.Location = new System.Drawing.Point(424, 21);
            this.lblAbsence.Name = "lblAbsence";
            this.lblAbsence.Size = new System.Drawing.Size(110, 22);
            this.lblAbsence.TabIndex = 18;
            this.lblAbsence.Text = "Les absences";
            // 
            // frmGestionAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(968, 626);
            this.Controls.Add(this.lblAbsence);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.lblAdministration);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.cmbMotif);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dgvAbsence);
            this.Name = "frmGestionAbsence";
            this.Text = "Gestion des absences";
            this.Load += new System.EventHandler(this.frmGestionAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblAdministration;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Label lblAbsence;
    }
}