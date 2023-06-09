
namespace MediaTek86.Vue
{
    partial class frmConnexion
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
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.chkMotDePasse = new System.Windows.Forms.CheckBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(303, 178);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(225, 20);
            this.txtIdentifiant.TabIndex = 0;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(303, 205);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(225, 20);
            this.txtMotDePasse.TabIndex = 1;
            // 
            // chkMotDePasse
            // 
            this.chkMotDePasse.AutoSize = true;
            this.chkMotDePasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkMotDePasse.Location = new System.Drawing.Point(340, 231);
            this.chkMotDePasse.Name = "chkMotDePasse";
            this.chkMotDePasse.Size = new System.Drawing.Size(139, 17);
            this.chkMotDePasse.TabIndex = 2;
            this.chkMotDePasse.Text = "Afficher le mot de passe";
            this.chkMotDePasse.UseVisualStyleBackColor = true;
            this.chkMotDePasse.CheckedChanged += new System.EventHandler(this.chkMotDePasse_CheckedChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(376, 254);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblConnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConnexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConnexion.Location = new System.Drawing.Point(372, 125);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(86, 22);
            this.lblConnexion.TabIndex = 4;
            this.lblConnexion.Text = "Connexion";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConnexion);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.chkMotDePasse);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Name = "frmConnexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.CheckBox chkMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblConnexion;
    }
}