using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    public class Absence
    {
        /// <summary>
        /// Propriétés
        /// </summary>
        private int IDPERSONNEL;
        private DateTime DATEDEBUT;
        private int IDMOTIF;
        private DateTime DATEFIN;
        private string motif;

        /// <summary>
        /// Getters et setters
        /// </summary>
        public int idPersonnel
        {
            get => IDPERSONNEL;
            set => IDPERSONNEL = value;
        }

        public DateTime dateDebut
        {
            get => DATEDEBUT;
            set => DATEDEBUT = value;
        }

        public int idMotif
        {
            get => IDMOTIF;
            set => IDMOTIF = value;
        }

        public DateTime dateFin
        {
            get => DATEFIN;
            set => DATEFIN = value;
        }

        public string Motif
        {
            get => motif;
            set => motif = value;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="IDPERSONNEL"></param>
        /// <param name="DATEDEBUT"></param>
        /// <param name="DATEFIN"></param>
        /// <param name="IDMOTIF"></param>
        /// <param name="motif"></param>
        public Absence (int IDPERSONNEL, DateTime DATEDEBUT, DateTime DATEFIN, int IDMOTIF, string motif)
        {
            this.IDPERSONNEL = IDPERSONNEL;
            this.DATEDEBUT = DATEDEBUT;
            this.DATEFIN = DATEFIN;
            this.IDMOTIF = IDMOTIF;
            this.motif = motif;
        }
    }
}
