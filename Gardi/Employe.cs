using System;
using System.Collections.Generic;
using System.IO;

namespace Gardi
{
    public class Employe : IEmploye
    {
        #region Champs et propriétés
        private string m_nom;
        private string m_prenom;
        private string m_id;
        private List<IPeriode> m_lstPerGarde;
        private List<DateTime> m_lstDatGrd;

        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }

        public string Prenom
        {
            get { return m_prenom; }
            set { m_prenom = value; }
        }

        public string ID
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public List<IPeriode> PeriodesGarde
        {
            get { return m_lstPerGarde; }
        }

        public List<DateTime> DatesGarde
        {
            get { return m_lstDatGrd; }
        }
        #endregion

        #region Constructeur
        public Employe(string pNom, string pPrenom, string pID)
        {
            m_nom = pNom;
            m_prenom = pPrenom;
            m_id = pID;
            m_lstPerGarde = new List<IPeriode>();
            m_lstDatGrd = new List<DateTime>();
        }
        #endregion

        #region Méthodes
        public void AjouterPeriodeGarde(IPeriode pPeriode)
        {
            m_lstPerGarde.Add(pPeriode);
        }

        public void AjouterDateGarde(DateTime pDateGarde)
        {
            m_lstDatGrd.Add(pDateGarde);
        }

        public void ViderPeriodeGarde()
        {
            m_lstPerGarde.Clear();
            m_lstDatGrd.Clear();
        }

        public void Ecrire(BinaryWriter pobjBinaryWriter)
        {
            pobjBinaryWriter.Write(m_nom);
            pobjBinaryWriter.Write(m_prenom);
            pobjBinaryWriter.Write(m_id);
        }

        public override string ToString()
        {
            return m_id + ": " + m_nom + " " + m_prenom;
        }
        #endregion
    }
}
