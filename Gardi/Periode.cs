using System;
using System.Collections.Generic;
using System.IO;
namespace Gardi
{
    public class Periode : IPeriode
    {
        #region Champs et propriétés
        private float m_debut;
        private float m_fin;
        private float m_duree;
        private int m_periode;
        private List<int> m_lstJour;

        public float Debut
        {
            get { return m_debut; }
            set
            {
                if (value < 0 || value >= 24)
                    throw new ArgumentOutOfRangeException("L'heure entrée n'est pas compris entre 0 et 24");
                m_debut = value;
            }
        }

        public float Fin
        {
            get { return m_fin; }
            set
            {
                if (value < 0 || value >= 24)
                    throw new ArgumentOutOfRangeException("L'heure entrée n'est pas compris entre 0 et 24");
                m_fin = value;
            }
        }

        public float Duree
        {
            get { return m_duree; }
        }

        public int NoPeriode
        {
            get { return m_periode; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("La période doit être une valeur positive");
                m_periode = value;
            }
        }

        public List<int> ListeJours
        {
            get { return m_lstJour; }
        }
        #endregion

        #region Constructeur
        public Periode(float pDebut, float pFin, int pPeriode, List<int> pLstJours)
        {
            if (m_debut < 0 || m_debut >= 24 || m_fin < 0 || m_fin >= 24)
                throw new ArgumentOutOfRangeException("L'heure entrée n'est pas entre 0 et 23.99");

            m_debut = pDebut;
            m_fin = pFin;

            if (m_debut > m_fin)
                m_duree = 24 - m_debut + m_fin;
            else
                m_duree = m_fin - m_debut;

            m_periode = pPeriode;
            m_lstJour = pLstJours;
        }

        public Periode(float pHrDebut, float pHrFin, float pMinDebut, float pMinFin, int pPeriode, List<int> pLstJours)
        {
            if (pHrDebut < 0 || pHrDebut >= 24 || pHrFin < 0 || pHrFin >= 24 || pMinDebut < 0 || pMinDebut >= 60 || pMinFin < 0 || pMinFin >= 60)
                throw new ArgumentOutOfRangeException("Les valeurs entrées ne sont pas valides");

            m_debut = pHrDebut + pMinDebut / 60;
            m_fin = pHrFin + pMinFin / 60;

            if (m_debut > m_fin)
                m_duree = 24 - m_debut + m_fin;
            else
                m_duree = m_fin - m_debut;

            m_periode = pPeriode;
            m_lstJour = pLstJours;
        }
        #endregion

        #region Méthodes
        public void ModifierPeriode(float pDebut, float pFin, List<int> pLstJours)
        {
            if (m_debut < 0 || m_debut >= 24 || m_fin < 0 || m_fin >= 24)
                throw new ArgumentOutOfRangeException("L'heure entrée n'est pas entre 0 et 23.99");

            if (m_debut > m_fin)
                m_duree = 24 - m_debut + m_fin;

            m_debut = pDebut;
            m_fin = pFin;
            m_lstJour = pLstJours;
        }

        public void AjouterJour(int pJour)
        {
            m_lstJour.Add(pJour);
        }

        public void ModifierLstJours(List<int> pLstJours)
        {
            m_lstJour = pLstJours;
        }

        public void Ecrire(BinaryWriter pobjBinaryWriter)
        {
            pobjBinaryWriter.Write(m_debut);
            pobjBinaryWriter.Write(m_fin);
            pobjBinaryWriter.Write(m_periode);

            pobjBinaryWriter.Write(m_lstJour.Count);
            for (int i = 0; i < m_lstJour.Count; i++)
                pobjBinaryWriter.Write(m_lstJour[i]);
        }

        public override string ToString()
        {
            string debutH = Math.Truncate(m_debut).ToString("00");
            string debutM = Math.Round((m_debut - Math.Truncate(m_debut)) * 60).ToString("00");
            string finH = Math.Truncate(m_fin).ToString("00");
            string finM = Math.Round((m_fin - Math.Truncate(m_fin)) * 60).ToString("00");

            return debutH + ":" + debutM + " - " + finH + ":" + finM;
        }
        #endregion
    }
}
