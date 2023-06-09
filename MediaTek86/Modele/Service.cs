using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    public class Service
    {
        /// <summary>
        /// Propriétés
        /// </summary>
        private int IDSERVICE;
        private string NOM;

        /// <summary>
        /// Getters et setters
        /// </summary>
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


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="IDSERVICE"></param>
        /// <param name="NOM"></param>
        public Service(int IDSERVICE, string NOM)
        {
            this.IDSERVICE = IDSERVICE;
            this.NOM = NOM;
        }

        /// <summary>
        /// Affichage
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }

}
