using MediaTek86.Controleur;
using MediaTek86.Modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MediaTek86.Vue
{
    public partial class frmGestionPersonnel : Form
    {
        private Controle controle;

        BindingSource BsPersonnels = new BindingSource();
        BindingSource BsServices = new BindingSource();

        public frmGestionPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        public void Init()
        {
            Remplirdgvpersonnels();
            RemplirCmbServices();
        }

        /// <summary>
        /// Affichage du personnel
        /// </summary>
        public void Remplirdgvpersonnels()
        {
            List<Personnel> lespersonnels = controle.GetLesPersonnels();
            BsPersonnels.DataSource = lespersonnels;
            dgvPersonnel.DataSource = BsPersonnels;
            dgvPersonnel.Columns["IDPERSONNEL"].Visible = false;
            dgvPersonnel.Columns["IDSERVICE"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affichage des services
        /// </summary>
        public void RemplirCmbServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            BsServices.DataSource = lesServices;
            cmbService.DataSource = BsServices;
            if (cmbService.Items.Count > 0)
            {
                cmbService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Ajouter un memebre du personnel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cmbService.SelectedIndex != -1)
            {
                int IDPERSONNEL = 0;
                Service service = (Service)BsServices.List[BsServices.Position];
                Personnel personnel = new Personnel(IDPERSONNEL, service.idService, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Nom);
                controle.AddunPersonnel(personnel);
                Remplirdgvpersonnels();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur");
            }
        }

        /// <summary>
        /// Modifier un les informations d'un memebre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {

                if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && cmbService.SelectedIndex != -1)
                {


                    Personnel personnel = (Personnel)BsPersonnels.List[BsPersonnels.Position];
                    Service service = (Service)BsServices.List[BsServices.Position];
                    personnel = new Personnel(personnel.idPersonnel, service.idService, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Nom);


                    if (MessageBox.Show("Vous êtes sur le point de modifier un membre du personnel", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        controle.UpdateunPersonnel(personnel);
                        Remplirdgvpersonnels();


                    }
                }

            }

            else
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel", "Erreur");
            }
        }

        /// <summary>
        /// Supprimer un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {

                Personnel personnel = (Personnel)BsPersonnels.List[BsPersonnels.Position];
                if (MessageBox.Show("Vous êtes sur le point de supprimer un membre du personnel", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    controle.DelunPersonnel(personnel);
                    Remplirdgvpersonnels();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un membre", "Erreur");
            }
        }

        /// <summary>
        /// Aller sur la fenêtre des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsence_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)BsPersonnels.List[BsPersonnels.Position];
                controle.AfficherlesAbsences(personnel);

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel.", "Erreur");
            }
        }

        /// <summary>
        /// Vider les chmaps
        /// </summary>
        private void Vider()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            cmbService.SelectedIndex = -1;
            dgvPersonnel.ClearSelection();
            txtNom.Focus();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            Vider();
        }

        /// <summary>
        /// Replis dans les champs les information du membre séléctionné 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPersonnel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPersonnel.CurrentRow;
            txtNom.Text = row.Cells["Nom"].Value.ToString();
            txtPrenom.Text = row.Cells["Prenom"].Value.ToString();
            txtTel.Text = row.Cells["Tel"].Value.ToString();
            txtMail.Text = row.Cells["Mail"].Value.ToString();
            cmbService.Text = row.Cells["Service"].Value.ToString();
        }
    }
}
