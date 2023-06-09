using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.dal;
using MediaTek86.Modele;
using MediaTek86.Vue;

namespace MediaTek86.Controleur
{
    public class Controle
    {
        private frmConnexion FrmConnexion;
        /// <summary>
        /// Vue de la frmpersonnel
        /// </summary>
        private frmGestionPersonnel FrmGestionPersonnel;
        /// <summary>
        /// Vue de la frmbsence
        /// </summary>
        private frmGestionAbsence FrmGestionAbsence;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            FrmConnexion = new frmConnexion(this);
            FrmConnexion.ShowDialog();

        }

        /// <summary>
        /// Controle l'authentification afin d'ouvrir la page de gestion du personnel
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(string login, string pwd)
        {
            if (AccesBDD.ControleAuthentification(login, pwd))
            {
                FrmConnexion.Hide();
                FrmGestionPersonnel = new frmGestionPersonnel(this);
                FrmGestionPersonnel.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Personnel> GetLesPersonnels()
        {
            return AccesBDD.GetLesPersonnels();
        }

        public List<Service> GetLesServices()
        {
            return AccesBDD.GetLesServices();
        }

        public void AddunPersonnel(Personnel personnel)
        {
            AccesBDD.AddunPersonnel(personnel);
        }

        public void DelunPersonnel(Personnel personnel)
        {
            AccesBDD.DelunPersonnel(personnel);
        }

        public void UpdateunPersonnel(Personnel personnel)
        {
            AccesBDD.UpdateunPersonnel(personnel);
        }

        public void AfficherlesAbsences(Personnel personnel)
        {

            FrmGestionPersonnel.Hide();
            FrmGestionAbsence = new frmGestionAbsence(this, personnel);
            FrmGestionAbsence.ShowDialog();

        }

        public List<Absence> GetlesAbsences(Personnel personnel)
        {
            return AccesBDD.GetlesAbsences(personnel);
        }

        public List<Motif> GetMotifs()
        {
            return AccesBDD.GetMotifs();
        }

        public void Adduneabsence(Absence absence, Personnel personnel)
        {
            AccesBDD.Adduneabsence(absence, personnel);
        }

        public void Deluneabsence(Absence absence, Personnel personnel)
        {
            AccesBDD.Deluneabsence(absence, personnel);
        }

        public void Updateuneabsence(Absence absence, Personnel personnel)
        {
            AccesBDD.Updateuneabsence(absence, personnel);
        }

        public void backpersonnel()

        {
            FrmGestionAbsence.Close();
            FrmGestionPersonnel.Show();
        }


    }
}
