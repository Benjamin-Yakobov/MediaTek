using MediaTek86.Controleur;
using System;
using System.Windows.Forms;

namespace MediaTek86.Vue
{
    public partial class frmConnexion : Form
    {
        private Controle controle;

        /// <summary>
        /// Ouverture de la fenêtre de connexion
        /// </summary>
        /// <param name="controle"></param>
        public frmConnexion(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            chkMotDePasse.Checked = true;
        }

        /// <summary>
        /// Se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!txtIdentifiant.Text.Equals("") && !txtMotDePasse.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txtIdentifiant.Text, txtMotDePasse.Text))
                {
                    MessageBox.Show("Authentification incorrecte, veuillez réessayer ", "Erreur");
                    txtMotDePasse.Text = "";
                    txtIdentifiant.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur");
            }
        }

        /// <summary>
        /// Cacher ou pas le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMotDePasse.Checked)
            {
                txtMotDePasse.UseSystemPasswordChar = true;
            }
            else
            {
                txtMotDePasse.UseSystemPasswordChar = false;
            }
        }



    }
}
