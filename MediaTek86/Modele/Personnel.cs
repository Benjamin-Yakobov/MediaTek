using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    public class Personnel
    {
        /// <summary>
        /// Propriétés
        /// </summary>
        private int IDPERSONNEL;
        private int IDSERVICE;
        private string NOM;
        private string PRENOM;
        private string TEL;
        private string MAIL;
        private string service;

        /// <summary>
        /// Getters et setters
        /// </summary>
        public int idPersonnel
        {
            get => IDPERSONNEL;
            set => IDPERSONNEL = value;
        }

        public int idService
        {
            get => IDSERVICE;
            set => IDSERVICE = value;
        }

        public string Nom
        {
            get => NOM;
            set => NOM = value;
        }

        public string Prenom
        {
            get => PRENOM;
            set => PRENOM = value;
        }

        public string Tel
        {
            get => TEL;
            set => TEL = value;
        }

        public string Mail
        {
            get => MAIL;
            set => MAIL = value;
        }

        public string Service
        {
            get => service;
            set => service = value;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="IDPERSONNEL"></param>
        /// <param name="IDSERVICE"></param>
        /// <param name="NOM"></param>
        /// <param name="PRENOM"></param>
        /// <param name="TEL"></param>
        /// <param name="MAIL"></param>
        /// <param name="service"></param>
        public Personnel(int IDPERSONNEL, int IDSERVICE, string NOM, string PRENOM, string TEL, string MAIL, string service)
        {
            this.IDPERSONNEL = IDPERSONNEL;
            this.IDSERVICE = IDSERVICE;
            this.NOM = NOM;
            this.PRENOM = PRENOM;
            this.TEL = TEL;
            this.MAIL = MAIL;
            this.service = service;
        }

        
    }
}
