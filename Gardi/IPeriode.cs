using System.Collections.Generic;
using System.IO;

namespace Gardi
{
    public interface IPeriode
    {
        /// <summary>
        /// Début de la période.
        /// </summary>
        float Debut { get; set; }

        /// <summary>
        /// Fin de la période.
        /// </summary>
        float Fin { get; set; }

        /// <summary>
        /// Durée de la période.
        /// </summary>
        float Duree { get; }

        /// <summary>
        /// Numéro de la période.
        /// </summary>
        int NoPeriode { get; set; }

        /// <summary>
        /// La liste des jours valides de la période.
        /// </summary>
        List<int> ListeJours { get; }

        /// <summary>
        /// Modifie la période.
        /// </summary>
        /// <param name="pDebut">Temps du début de la période.</param>
        /// <param name="pFin">Temps de la fin de la période.</param>
        void ModifierPeriode(float pDebut, float pFin, List<int> pLstJours);

        /// <summary>
        /// Écrit dans un fichier binaire les informations de la période.
        /// </summary>
        /// <param name="pobjBinaryWriter">L'objet qui permet d'écrire dans le fichier binaire.</param>
        void Ecrire(BinaryWriter pobjBinaryWriter);

        /// <summary>
        /// Écrit la période dans un format texte.
        /// </summary>
        /// <returns>Retourne les informations de la période dans un format texte.</returns>
        string ToString();
    }
}
