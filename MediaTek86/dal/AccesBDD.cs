using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.bddmanager;
using MediaTek86.Modele;

namespace MediaTek86.dal
{
    public class AccesBDD
    {
        /// <summary>
        /// chaine pour la connexion a la BDD
        /// </summary>
        private static string connectionString = "Server=localhost;Database=mediatek86;User Id=Benjamin;Password=Benjamin2023";


        /// <summary>
        /// Controle de l'authentification 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "SELECT * FROM responsable WHERE login=@login AND pwd=SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);

            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);
            if(curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }

        /// <summary>
        /// recupere les memebres
        /// </summary>
        /// <returns></returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "SELECT p.IDPERSONNEL as IDPERSONNEL, p.IDSERVICE AS IDSERVICE, p.NOM AS NOM, p.PRENOM AS PRENOM, p.TEL AS TEL, p.MAIL AS MAIL, s.NOM AS service ";
            req += "FROM personnel p JOIN service s USING (IDSERVICE)";
            req += "ORDER BY NOM, PRENOM;";
            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {


                Personnel personnel = new Personnel((int)curseur.Field("IDPERSONNEL"),
                                                    (int)curseur.Field("IDSERVICE"),
                                                    (string)curseur.Field("NOM"),
                                                    (string)curseur.Field("PRENOM"),
                                                    (string)curseur.Field("TEL"),
                                                    (string)curseur.Field("MAIL"),
                                                    (string)curseur.Field("service"));
                lesPersonnels.Add(personnel);

            }
            curseur.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// recupere les services a partire de la bdd
        /// </summary>
        /// <returns></returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "SELECT * FROM service ORDER BY NOM;";
            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Service service = new Service((int)curseur.Field("IDSERVICE"),
                                              (string)curseur.Field("NOM"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// recupère les absences a partire de la bdd
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        public static List<Absence> GetlesAbsences(Personnel personnel)
        {
            List<Absence> lesabsences = new List<Absence>();
            string req = "SELECT p.IDPERSONNEL AS IDPERSONNEL, a.DATEDEBUT AS DATEDEBUT, a.DATEFIN AS DATEFIN , a.IDMOTIF AS IDMOTIF, m.LIBELLE AS 'motif' ";
            req += "FROM absence a JOIN motif m USING (IDMOTIF) JOIN personnel p ON p.IDPERSONNEL = a.IDPERSONNEL ";
            req += "WHERE p.IDPERSONNEL = @IDPERSONNEL ";
            req += "ORDER BY DATEDEBUT DESC;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.idPersonnel);
            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);
            while (curseur.Read())
            {
                Absence absence = new Absence((int)curseur.Field("IDPERSONNEL"),
                                              (DateTime)curseur.Field("DATEDEBUT"),
                                              (DateTime)curseur.Field("DATEFIN"),
                                              (int)curseur.Field("IDMOTIF"),
                                              (string)curseur.Field("motif"));
                lesabsences.Add(absence);

            }
            curseur.Close();
            return lesabsences;
        }

        /// <summary>
        /// Recupere les motifs a partire de la bdd
        /// </summary>
        /// <returns></returns>
        public static List<Motif> GetMotifs()
        {
            List<Motif> motifs = new List<Motif>();
            string req = "SELECT * FROM motif ORDER BY LIBELLE;";
            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("IDMOTIF"),
                                        (string)curseur.Field("LIBELLE"));
                motifs.Add(motif);
            }
            curseur.Close();
            return motifs;
        }

        /// <summary>
        /// Ajouter un membre
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddunPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(IDSERVICE,NOM, PRENOM, TEL, MAIL) ";
            req += "VALUES ( @IDSERVICE, @NOM, @PRENOM, @TEL, @MAIL)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDSERVICE", personnel.idService);
            parameters.Add("@NOM", personnel.Nom);
            parameters.Add("@PRENOM", personnel.Prenom);
            parameters.Add("@TEL", personnel.Tel);
            parameters.Add("@MAIL", personnel.Mail);
            BddManager connection = BddManager.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprimer un membre 
        /// </summary>
        /// <param name="personnel"></param>
        public static void DelunPersonnel(Personnel personnel)
        {
            string req = "DELETE FROM personnel WHERE IDPERSONNEL = @IDPERSONNEL;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.idPersonnel);
            BddManager connection = BddManager.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Mise a jour (modification) du profile d'un membre du personnel 
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdateunPersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET NOM = @NOM, PRENOM = @PRENOM , TEL = @TEL, MAIL = @MAIL,IDSERVICE = @IDSERVICE ";
            req += "WHERE IDPERSONNEL = @IDPERSONNEL";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.idPersonnel);
            parameters.Add("@NOM", personnel.Nom);
            parameters.Add("@PRENOM", personnel.Prenom);
            parameters.Add("@TEL", personnel.Tel);
            parameters.Add("@MAIL", personnel.Mail);
            parameters.Add("@IDSERVICE", personnel.idService);
            BddManager connection = BddManager.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);

        }

        /// <summary>
        /// Ajouter une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public static void Adduneabsence(Absence absence, Personnel personnel)
        {
            string req = "INSERT INTO absence(IDPERSONNEL,DATEDEBUT, DATEFIN,IDMOTIF)  ";
            req += "VALUES( @IDPERSONNEL, @DATEDEBUT, @DATEFIN, @IDMOTIF)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.idPersonnel);
            parameters.Add("@DATEDEBUT", absence.dateDebut);
            parameters.Add("@DATEFIN", absence.dateFin);
            parameters.Add("@IDMOTIF", absence.idMotif);

            BddManager connection = BddManager.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprimer une absence 
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public static void Deluneabsence(Absence absence, Personnel personnel)
        {
            string req = "DELETE FROM absence WHERE IDPERSONNEL = @IDPERSONNEL AND DATEDEBUT = @DATEDEBUT;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.idPersonnel);
            parameters.Add("@DATEDEBUT", absence.dateFin);

            BddManager connection = BddManager.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Mise jour (modification) d'une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public static void Updateuneabsence(Absence absence, Personnel personnel)
        {

            string req = "UPDATE absence SET IDPERSONNEL = @IDPERSONNEL, DATEDEBUT = @DATEDEBUT, IDMOTIF = @IDMOTIF, DATEFIN = @DATEFIN ";
            req += "WHERE DATEDEBUT = @DATEDEBUT AND IDPERSONNEL= @IDPERSONNEL";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDMOTIF", absence.idMotif);
            parameters.Add("@IDPERSONNEL", personnel.idPersonnel);
            parameters.Add("@DATEDEBUT", absence.dateDebut);
            parameters.Add("@DATEFIN", absence.dateFin);
            BddManager connection = BddManager.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);

        }



    }
}
