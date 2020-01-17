using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gardi
{
    public class Horaire : IHoraire
    {
        #region Champs et propriétés
        private int m_nbJours;
        private List<IEmploye> m_lstEmploye;
        private List<IPeriode> m_lstPerGarde;

        public List<IEmploye> ListeEmployes
        {
            get { return m_lstEmploye; }
        }

        public List<IPeriode> ListePeriodes
        {
            get { return m_lstPerGarde; }
        }

        public int NbJours
        {
            get { return m_nbJours; }
        }
        #endregion

        #region Constructeur
        public Horaire()
        {
            m_lstEmploye = new List<IEmploye>();
            m_lstPerGarde = new List<IPeriode>();
        }
        #endregion

        #region Ajouter/Supprimer/Modifier
        public void AjouterEmploye(string pNom, string pPrenom, string pID)
        {
            m_lstEmploye.Add(new Employe(pNom, pPrenom, pID));
        }

        public void SupprimerEmploye(string pID)
        {
            IEmploye employe = ChercherEmpID(pID);
            if (employe == null)
                throw new ArgumentNullException("Impossible de trouver l'employé avec cet identifiant");

            m_lstEmploye.Remove(employe);
        }

        public void ModifierEmp(string pNom, string pPrenom, string pID)
        {
            IEmploye employe = ChercherEmpID(pID);
            if (employe == null)
                throw new ArgumentNullException("Impossible de trouver l'employé avec cet identifiant");

            employe.Nom = pNom;
            employe.Prenom = pPrenom;
        }

        public void AjouterPeriode(float pDebut, float pFin, List<int> pLstJours)
        {
            m_lstPerGarde.Add(new Periode(pDebut, pFin, m_lstPerGarde.Count + 1, pLstJours));
        }

        public void AjouterPeriode(float pHrDebut, float pHrFin, float pMinDebut, float pMinFin, List<int> pLstJours)
        {
            m_lstPerGarde.Add(new Periode(pHrDebut, pHrFin, pMinDebut, pMinFin, m_lstPerGarde.Count + 1, pLstJours));
        }

        public void SupprimerPeriode(int pPeriode)
        {
            IPeriode periode = ChercherNoPeriode(pPeriode);

            if (periode == null)
                throw new ArgumentNullException("Impossible de trouver la période de garde avec ce numéro");

            m_lstPerGarde.Remove(periode);
            for (int i = 0; i < m_lstPerGarde.Count; i++)
                m_lstPerGarde[i].NoPeriode = i + 1;
        }

        public void ModifierPeriode(float pHrDebut, float pHrFin, float pMinDebut, float pMinFin, int pNoPeriode, List<int> pLstJours)
        {
            IPeriode periode = ChercherNoPeriode(pNoPeriode);

            if (periode == null)
                throw new ArgumentNullException("Impossible de trouver la période de garde avec ce numéro");

            periode = new Periode(pHrDebut, pHrFin, pMinDebut, pMinFin, pNoPeriode, pLstJours);
            m_lstPerGarde.Insert(pNoPeriode - 1, periode);
            m_lstPerGarde.RemoveAt(pNoPeriode);
        }
        #endregion

        #region Chercher
        public IEmploye ChercherEmpID(string pID)
        {
            foreach (IEmploye employe in m_lstEmploye)
                if (employe.ID == pID)
                    return employe;
            return null;
        }

        public IPeriode ChercherNoPeriode(int pPeriode)
        {
            foreach (IPeriode heure in m_lstPerGarde)
                if (heure.NoPeriode == pPeriode)
                    return heure;
            return null;
        }
        #endregion

        #region Generer l'horaire
        public void GenererHoraire()
        {
            if (m_lstEmploye.Count < 2 || m_lstPerGarde.Count < 1)
                throw new ArgumentException("Il faut au moins deux employé et une période pour générer les périodes de garde.");

            DateTime prochPer = DateTime.Now.AddMonths(1);
            int moisPerGrd = prochPer.Month;
            int anneePerGrd = prochPer.Year;

            // Réinitialise les périodes de garde des employés.
            foreach (Employe employe in m_lstEmploye)
                employe.ViderPeriodeGarde();

            Random objRandom = new Random();

            // Le tableau contenant la liste des employés qui ont une période attribuée.
            int[] lstEmployeAttr = new int[m_lstEmploye.Count];

            InitialiserTableau(lstEmployeAttr, lstEmployeAttr.Length);

            // La date et le nombre de jour de la période. Soit le premier jour du mois suivant.
            DateTime dateHoraire = new DateTime(anneePerGrd, moisPerGrd, 1);
            m_nbJours = DateTime.DaysInMonth(dateHoraire.Year, dateHoraire.Month);
            int cptEmpl = 0;
            int dernierEmpl = -1;

            // Initialise les périodes selon le nombre de jours.
            for (int jour = 0; jour < m_nbJours; jour++)
            {
                // Trouve la valeur de la journée de la semaine sachant que lundi = 0.
                int jourDate = (int)dateHoraire.DayOfWeek;
                if (jourDate <= 0)
                    jourDate = 6;
                else
                    jourDate--;

                // Compte le nombre de périodes valides pour la journée de la semaine.
                List<int> lstPerValide = new List<int>();
                foreach (Periode periode in m_lstPerGarde)
                    if (periode.ListeJours.Contains(jourDate))
                        lstPerValide.Add(periode.NoPeriode - 1);


                if (lstPerValide.Count != 0)
                {
                    int[] lstPeriodeAttr = new int[lstPerValide.Count];

                    // Les periodes se reinitialise chaque jours
                    int cptPeriode = 0;
                    InitialiserTableau(lstPeriodeAttr, lstPeriodeAttr.Length);
                    while (cptPeriode != lstPerValide.Count)
                    {
                        // La période de garde est sélectionné par ordre de no de période.
                        int noPeriode;
                        int i = 0;
                        do
                            noPeriode = m_lstPerGarde[i++].NoPeriode - 1;
                        while (lstPeriodeAttr.Contains(noPeriode) || !lstPerValide.Contains(noPeriode));

                        // Aleatoirise l'employe
                        int empl;
                        do
                            empl = objRandom.Next(0, m_lstEmploye.Count);
                        while (lstEmployeAttr.Contains(empl) || empl == dernierEmpl);

                        // Ajoute les informations de la période à l'employé.
                        m_lstEmploye[empl].AjouterDateGarde(dateHoraire);
                        m_lstEmploye[empl].AjouterPeriodeGarde(m_lstPerGarde[noPeriode]);

                        lstEmployeAttr[cptEmpl++] = empl;           // Enregistre l'employe avec un horaire
                        lstPeriodeAttr[cptPeriode++] = noPeriode;     // Enregistre l'horaire utilise

                        // S'assure que le dernier employé à avoir eu une période ne tombe pas la période suivante.
                        // Fonctionne, car les périodes sont générés de manière linéaire plutôt qu'aléatoire.

                        dernierEmpl = empl;
                        // S'assure que tous les employes ont eu une heure avant de recommencer
                        if (cptEmpl == m_lstEmploye.Count)
                        {
                            InitialiserTableau(lstEmployeAttr, lstEmployeAttr.Length);
                            cptEmpl = 0;
                        }
                    }
                }
                // Passe à la journée suivante.
                dateHoraire = dateHoraire.AddDays(1);
            }
        }

        public void GenererHoraire(int pAnnee, int pMois, int pJours, int pNbJours)
        {
            if (m_lstEmploye.Count < 2 || m_lstPerGarde.Count < 1)
                throw new ArgumentException("Il faut au moins un employé et une période pour générer les périodes de garde.");

            foreach (Employe employe in m_lstEmploye)
                employe.ViderPeriodeGarde();

            Random objRandom = new Random();

            int[] lstEmployeAttr = new int[m_lstEmploye.Count];

            InitialiserTableau(lstEmployeAttr, lstEmployeAttr.Length);

            DateTime dateHoraire = new DateTime(pAnnee, pMois, pJours);
            m_nbJours = pNbJours;
            int cptEmpl = 0;
            int dernierEmpl = -1;

            for (int jour = 0; jour < m_nbJours; jour++)
            {
                int jourDate = (int)dateHoraire.DayOfWeek;
                if (jourDate <= 0)
                    jourDate = 6;
                else
                    jourDate--;

                List<int> lstPerValide = new List<int>();
                foreach (Periode periode in m_lstPerGarde)
                    if (periode.ListeJours.Contains(jourDate))
                        lstPerValide.Add(periode.NoPeriode - 1);

                if (lstPerValide.Count != 0)
                {
                    int[] lstPeriodeAttr = new int[lstPerValide.Count];

                    // Les periodes se reinitialise chaque jours
                    int cptPeriode = 0;
                    InitialiserTableau(lstPeriodeAttr, lstPeriodeAttr.Length);
                    while (cptPeriode != lstPerValide.Count)
                    {
                        // Aleatoirise la periode de garde

                        int noPeriode;
                        int i = 0;
                        do
                            noPeriode = m_lstPerGarde[i++].NoPeriode - 1;
                        while (lstPeriodeAttr.Contains(noPeriode) || !lstPerValide.Contains(noPeriode));

                        // Aleatoirise l'employe
                        int empl;
                        do
                            empl = objRandom.Next(0, m_lstEmploye.Count);
                        while (lstEmployeAttr.Contains(empl) || empl == dernierEmpl);

                        m_lstEmploye[empl].AjouterDateGarde(dateHoraire);
                        m_lstEmploye[empl].AjouterPeriodeGarde(m_lstPerGarde[noPeriode]);

                        lstEmployeAttr[cptEmpl++] = empl;           // Enregistre l'employe avec un horaire
                        lstPeriodeAttr[cptPeriode++] = noPeriode;     // Enregistre l'horaire utilise

                        // S'assure que le dernier employé à avoir eu une période ne tombe pas la période suivante.
                        // Fonctionne, car les périodes sont générés de manière linéaire plutôt qu'aléatoire.

                        dernierEmpl = empl;
                        // S'assure que tous les employes ont eu une heure avant de recommencer
                        if (cptEmpl == m_lstEmploye.Count)
                        {
                            InitialiserTableau(lstEmployeAttr, lstEmployeAttr.Length);
                            cptEmpl = 0;
                        }
                    }
                }
                dateHoraire = dateHoraire.AddDays(1);
            }
        }

        public void InitialiserTableau(int[] pTableau, int pTabLength)
        {
            for (int i = 0; i < pTabLength; i++)
                pTableau[i] = -1;
        }
        #endregion

        #region Fichier
        public void Charger(string pNomFichier)
        {
            if (!File.Exists(pNomFichier))
                throw new ArgumentNullException("Le fichier à charger est introuvable.");

            m_lstEmploye.Clear();
            m_lstPerGarde.Clear();

            FileStream objFileStream = new FileStream(pNomFichier, FileMode.Open);
            BinaryReader objFileToRead = new BinaryReader(objFileStream);

            int nbrPeriodes = objFileToRead.ReadInt32();
            for (int cpt = 0; cpt < nbrPeriodes; cpt++)
            {
                float debutP = objFileToRead.ReadSingle();
                float finP = objFileToRead.ReadSingle();
                int noP = objFileToRead.ReadInt32();

                int jourSem = objFileToRead.ReadInt32();
                List<int> lstJourSem = new List<int>();
                for (int i = 0; i < jourSem; i++)
                    lstJourSem.Add(objFileToRead.ReadInt32());

                m_lstPerGarde.Add(new Periode(debutP, finP, noP, lstJourSem));
            }

            int nbrEmployes = objFileToRead.ReadInt32();
            for (int cpt = 0; cpt < nbrEmployes; cpt++)
            {
                string nomE = objFileToRead.ReadString();
                string prenomE = objFileToRead.ReadString();
                string idE = objFileToRead.ReadString();

                m_lstEmploye.Add(new Employe(nomE, prenomE, idE));
            }
            objFileToRead.Close();
        }

        public void Enregistrer(string pNomFichier)
        {
            FileStream objFileStream = new FileStream(pNomFichier, FileMode.Create);
            BinaryWriter objFileToWrite = new BinaryWriter(objFileStream);

            objFileToWrite.Write(m_lstPerGarde.Count);

            foreach (Periode periode in m_lstPerGarde)
                periode.Ecrire(objFileToWrite);

            objFileToWrite.Write(m_lstEmploye.Count);
            foreach (Employe employe in m_lstEmploye)
                employe.Ecrire(objFileToWrite);

            objFileToWrite.Close();
        }

        public void Exporter(string pNomFichier)
        {
            StreamWriter objFichier = new StreamWriter(pNomFichier, false, System.Text.Encoding.UTF32);

            objFichier.WriteLine("\"sep=,\"");
            objFichier.WriteLine("ID, Nom, Prénom, Période de garde, Date de garde");
            foreach (Employe employe in m_lstEmploye)
            {
                int cpt = 0;
                do
                {
                    if (employe.PeriodesGarde.Count > 0)
                        objFichier.WriteLine(employe.ID + "," + employe.Nom + "," + employe.Prenom + "," +
                            employe.PeriodesGarde[cpt].ToString() + "," + employe.DatesGarde[cpt].ToString("dd MMM yyyy", new System.Globalization.CultureInfo("fr")));
                    else
                        objFichier.WriteLine(employe.ID + "," + employe.Nom + "," + employe.Prenom + ",Aucune,Aucune");
                    cpt++;
                }
                while (cpt < employe.PeriodesGarde.Count);
            }
            objFichier.Close();
        }

        #endregion
    }
}
