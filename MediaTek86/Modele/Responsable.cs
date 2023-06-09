using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    public class Responsable
    {
        /// <summary>
        /// Propriétés
        /// </summary> 
        private string login;
        private string pwd;

        /// <summary>
        /// Getters
        /// </summary>
        public string Login
        {
            get => login;
        }

        public string Pwd
        {
            get => pwd;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

    }
}
