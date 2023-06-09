
namespace MediaTek86.Vue
{
    partial class frmGestionPersonnel
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.btnVider = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblAdministration = new System.Windows.Forms.Label();
            this.lblPersonnel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 58);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.Size = new System.Drawing.Size(944, 185);
            this.dgvPersonnel.TabIndex = 0;
            this.dgvPersonnel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnel_CellEnter);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(112, 422);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(151, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(112, 449);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(151, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(112, 476);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(151, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 503);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(151, 20);
            this.txtTel.TabIndex = 4;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(112, 530);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(151, 21);
            this.cmbService.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(636, 415);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(636, 444);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(636, 473);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(614, 520);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(125, 23);
            this.btnAbsence.TabIndex = 9;
            this.btnAbsence.Text = "Gérer les absences  -->";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNom.Location = new System.Drawing.Point(68, 425);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrenom.Location = new System.Drawing.Point(54, 452);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 11;
            this.lblPrenom.Text = "Prenom : ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMail.Location = new System.Drawing.Point(73, 479);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 13);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mai : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTel.Location = new System.Drawing.Point(75, 506);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(31, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Tel : ";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblService.Location = new System.Drawing.Point(63, 533);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 14;
            this.lblService.Text = "Service";
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(138, 557);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 23);
            this.btnVider.TabIndex = 15;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInformation.Location = new System.Drawing.Point(138, 363);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(92, 22);
            this.lblInformation.TabIndex = 16;
            this.lblInformation.Text = "Information";
            // 
            // lblAdministration
            // 
            this.lblAdministration.AutoSize = true;
            this.lblAdministration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdministration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdministration.Location = new System.Drawing.Point(629, 363);
            this.lblAdministration.Name = "lblAdministration";
            this.lblAdministration.Size = new System.Drawing.Size(112, 22);
            this.lblAdministration.TabIndex = 17;
            this.lblAdministration.Text = "Administration";
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonnel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersonnel.Location = new System.Drawing.Point(381, 23);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(208, 22);
            this.lblPersonnel.TabIndex = 18;
            this.lblPersonnel.Text = "Information sur le personnel";
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(968, 626);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.lblAdministration);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "frmGestionPersonnel";
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblAdministration;
        private System.Windows.Forms.Label lblPersonnel;
    }
}