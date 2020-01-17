using System;
using System.Collections.Generic;
using System.IO;

namespace Gardi
{
    public interface IEmploye
    {
        /// <summary>
        /// Le nom de l'employé.
        /// </summary>
        string Nom { get; set; }

        /// <summary>
        /// Le prénom de l'employé.
        /// </summary>
        string Prenom { get; set; }

        /// <summary>
        /// L'identifiant de l'employé.
        /// </summary>
        string ID { get; set; }

        /// <summary>
        /// Les périodes de garde de l'employé.
        /// </summary>
        List<IPeriode> PeriodesGarde { get; }

        /// <summary>
        /// Les dates de garde de l'employé.
        /// </summary>
        List<DateTime> DatesGarde { get; }

        /// <summary>
        /// Ajoute une période de garde à l'employé.
        /// </summary>
        /// <param name="pPeriode">La période à ajouter,</param>
        void AjouterPeriodeGarde(IPeriode pPeriode);

        /// <summary>
        /// Ajoute une date de garde à l'employé.
        /// </summary>
        /// <param name="pDateGarde">La date à ajouter.</param>
        void AjouterDateGarde(DateTime pDateGarde);

        /// <summary>
        /// Vide les périodes et les dates de garde de l'employé.
        /// </summary>
        void ViderPeriodeGarde();

        /// <summary>
        /// Écrit les informations pertinantes de l'employé (nom, prénom, id) dans un fichier binaire.
        /// </summary>
        /// <param name="pobjBinaryWriter">L'objet qui permet d'écrire dans le fichier binaire.</param>
        void Ecrire(BinaryWriter pobjBinaryWriter);

        /// <summary>
        /// Écrit les informations pertinantes de l'employé (nom, prénom, id) en format texte.
        /// </summary>
        /// <returns>Retourne les informations de l'employé dans un format texte.</returns>
        string ToString();
    }
}
