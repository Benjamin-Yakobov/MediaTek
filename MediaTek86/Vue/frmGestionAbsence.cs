using MediaTek86.Controleur;
using MediaTek86.Modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.Vue
{
    public partial class frmGestionAbsence : Form
    {
        private Controle controle;
        private Personnel personnel;

        BindingSource bsAbsence = new BindingSource();
        BindingSource bsmotifs = new BindingSource();

        public frmGestionAbsence(Controle controle, Personnel personnel)
        {
            InitializeComponent();
            this.controle = controle;
            this.personnel = personnel;
            Init();

        }

        private void Init()
        {
            Remplirdgvabsences();
            RemplirCmbmotifs();
        }

        /// <summary>
        /// Affichage des abseces
        /// </summary>
        public void Remplirdgvabsences()
        {
            List<Absence> lesabsences = controle.GetlesAbsences(personnel);
            bsAbsence.DataSource = lesabsences;
            dgvAbsence.DataSource = bsAbsence;
            dgvAbsence.Columns["IDPERSONNEL"].Visible = false;
            dgvAbsence.Columns["IDMOTIF"].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affichage des motifs
        /// </summary>
        public void RemplirCmbmotifs()
        {
            List<Motif> motifs = controle.GetMotifs();
            bsmotifs.DataSource = motifs;
            cmbMotif.DataSource = bsmotifs;
        }







        private void frmGestionAbsence_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Modifier une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                if (!dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cmbMotif.SelectedIndex != -1)
                {

                    Absence absence = (Absence)bsAbsence.List[bsAbsence.Position];
                    Motif motif = (Motif)bsmotifs.List[bsmotifs.Position];
                    absence = new Absence(personnel.idPersonnel, absence.dateDebut, dtpFin.Value.Date, motif.idMotif, motif.Libelle);

                    if (MessageBox.Show("Vous êtes sur le point de modifier une absence", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        controle.Updateuneabsence(absence, personnel);
                        Remplirdgvabsences();
                    }
                }

                else
                {
                    MessageBox.Show("Veuillez sélectionner une absence.", "Attention");
                }
            }
        }


        /// <summary>
        /// Ajouter une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cmbMotif.SelectedIndex != -1)
            {

                Motif motif = (Motif)bsmotifs.List[bsmotifs.Position];
                Absence absence = new Absence(personnel.idPersonnel, dtpDebut.Value, dtpFin.Value, motif.idMotif, motif.Libelle);
                controle.Adduneabsence(absence, personnel);
                Remplirdgvabsences();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur");
            }
        }

        /// <summary>
        /// Supprimer une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bsAbsence.List[bsAbsence.Position];
                if (MessageBox.Show("Vous êtes sur le point de supprimer une absence", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    controle.Deluneabsence(absence, personnel);
                    Remplirdgvabsences();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence", "Erreur");
            }
        }

        /// <summary>
        /// Retour ver la page de géstion du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            controle.backpersonnel();

        }

        /// <summary>
        /// Réinitialisation des champs 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVider_Click(object sender, EventArgs e)
        {
            vider();
        }

        /// <summary>
        /// la procédure de réinitialisation
        /// </summary>
        private void vider()
        {

            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
        }

        private void dgvAbsence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// permet de d'afficher dans les champs les informations de la ligne séléctionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void dgvAbsence_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*
            DataGridViewRow row = dgvAbsence.CurrentRow;
            cmbMotif.Text = row.Cells["Motif"].Value.ToString();

            DateTime.TryParse(row.Cells["dateDebut"].Value.ToString(), out DateTime dateDebut);
            dtpDebut.Value = dateDebut;

            DateTime.TryParse(row.Cells["dateFin"].Value.ToString(), out DateTime dateFin);
            dtpFin.Value = dateFin;
            */

        }

    }
}
