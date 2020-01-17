using System.Collections.Generic;

namespace Gardi
{
    public interface IHoraire
    {
        /// <summary>
        /// Liste des employés dans l'horaire.
        /// </summary>
        List<IEmploye> ListeEmployes { get; }

        /// <summary>
        /// Liste des périodes de garde dans l'horaire.
        /// </summary>
        List<IPeriode> ListePeriodes { get; }

        /// <summary>
        /// Nombre de jours de l'horaire.
        /// </summary>
        int NbJours { get; }

        /// <summary>
        /// Ajoute un employé dans l'horaire.
        /// </summary>
        /// <param name="pNom">Nom de l'employé.</param>
        /// <param name="pPrenom">Prénom de l'employé.</param>
        /// <param name="pID">Identifiant de l'employé.</param>
        void AjouterEmploye(string pNom, string pPrenom, string pID);

        /// <summary>
        /// Modifie un employé dans l'horaire.
        /// </summary>
        /// <param name="pNom">Nom de l'employé.</param>
        /// <param name="pPrenom">Prénom de l'employé.</param>
        /// <param name="pID">Identifiant de l'employé.</param>
        void ModifierEmp(string pNom, string pPrenom, string pID);

        /// <summary>
        /// Supprime un employé de l'horaire.
        /// </summary>
        /// <param name="pID">Identifiant de l'employé.</param>
        void SupprimerEmploye(string pID);

        /// <summary>
        /// Ajoute une période de garde à l'horaire.
        /// </summary>
        /// <param name="pDebut">Temps du début de la période.</param>
        /// <param name="pFin">Temps de la fin de la période.</param>
        void AjouterPeriode(float pDebut, float pFin, List<int> pLstJours);

        /// <summary>
        /// Ajoute une période de garde à l'horaire.
        /// </summary>
        /// <param name="pHrDebut">Heure du début de la période.</param>
        /// <param name="pHrFin">Heure de fin de la période.</param>
        /// <param name="pMinDebut">Minute du début de la période.</param>
        /// <param name="pMinFin">Minute de fin la période.</param>
        void AjouterPeriode(float pHrDebut, float pHrFin, float pMinDebut, float pMinFin, List<int> pLstJours);

        /// <summary>
        /// Supprime une période de l'horaire.
        /// </summary>
        /// <param name="pPeriode">Période à supprimer.</param>
        void SupprimerPeriode(int pPeriode);

        /// <summary>
        /// Modifie une période de l'horaire.
        /// </summary>
        /// <param name="pHrDebut">Heure du début de la période.</param>
        /// <param name="pHrFin">Heure de fin de la période.</param>
        /// <param name="pMinDebut">Minute du début de la période.</param>
        /// <param name="pMinFin">Minute de fin la période.</param>
        /// <param name="pNoPeriode">Le numéro de la période.</param>
        void ModifierPeriode(float pHrDebut, float pHrFin, float pMinDebut, float pMinFin, int pNoPeriode, List<int> pLstJours);

        /// <summary>
        /// Cherche un employé grâce à son identifiant.
        /// </summary>
        /// <param name="pID">Identifiant de l'employé.</param>
        /// <returns>Retourne l'employé si trouvé.</returns>
        IEmploye ChercherEmpID(string pID);

        /// <summary>
        /// Cherche un période grâce à son numéro.
        /// </summary>
        /// <param name="pNoPeriode">Le numéro de la période.</param>
        /// <returns>Retourne la période si trouvée.</returns>
        IPeriode ChercherNoPeriode(int pNoPeriode);

        /// <summary>
        /// Génère l'horaire de garde du mois suivant.
        /// </summary>
        void GenererHoraire();

        /// <summary>
        /// Génère un horaire.
        /// </summary>
        /// <param name="pAnnee">Année du début de l'horaire.</param>
        /// <param name="pMois">Mois du début de l'horaire.</param>
        /// <param name="pJours">Jour du début de l'horaire.</param>
        /// <param name="pNbJours">Nombre de jours de l'horaire.</param>
        void GenererHoraire(int pAnnee, int pMois, int pJours, int pNbJours);

        /// <summary>
        /// Charge le fichier contenant les employés et les périodes de l'horaire.
        /// </summary>
        /// <param name="pNomFichier">Fichier à charger.</param>
        void Charger(string pNomFichier);

        /// <summary>
        /// Enregistre les employés et les périodes de l'horaire dans un fichier.
        /// </summary>
        /// <param name="pNomFichier">le nom du fichier où l'enregistrement se fera</param>
        void Enregistrer(string pNomFichier);

        /// <summary>
        /// Exporte l'horaire.
        /// </summary>
        /// <param name="pNomFichier">Nom du fichier à exporter.</param>
        void Exporter(string pNomFichier);
    }
}
