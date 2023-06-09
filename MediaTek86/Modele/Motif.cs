using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    public class Motif
    {
        /// <summary>
        /// Propriétés
        /// </summary>
        private int IDMOTIF;
        private string LIBELLE;

        /// <summary>
        /// Getters et setters 
        /// </summary>
        public int idMotif
        {
            get => IDMOTIF;
            set => IDMOTIF = value;
        }

        public string Libelle
        {
            get => LIBELLE;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="IDMOTIF"></param>
        /// <param name="LIBELLE"></param>
        public Motif(int IDMOTIF, string LIBELLE)
        {
            this.IDMOTIF = IDMOTIF;
            this.LIBELLE = LIBELLE;
        }

        /// <summary>
        /// Affichage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Libelle;
        }


    }
}
