using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gardi
{
    public partial class FrmModifPer : Form
    {
        private readonly IHoraire horaire = FrmGardi.grdHoraire;

        #region Code copié 
        // http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
        // The column we are currently using for sorting.
        private ColumnHeader SortingColumn = null;
        #endregion

        public FrmModifPer()
        {
            InitializeComponent();
            ActualiserPer();
        }

        #region Bouton
        private void BtnAjoutEPer_Click(object sender, EventArgs e)
        {
            List<int> lstJours = VerifierJoursCheck();

            Periode periodeTest = new Periode(float.Parse(txtDebHr.Text), float.Parse(txtFinHr.Text), float.Parse(txtDebMn.Text), float.Parse(txtFinMn.Text), -1, lstJours);
            foreach (Periode periode in horaire.ListePeriodes)
            {
                if (periode.Debut == periodeTest.Debut && periode.Fin == periodeTest.Fin)
                {
                    MessageBox.Show("Une période de garde avec les mêmes paramèters existe déjà.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            try
            {
                horaire.AjouterPeriode(float.Parse(txtDebHr.Text), float.Parse(txtFinHr.Text), float.Parse(txtDebMn.Text), float.Parse(txtFinMn.Text), lstJours);
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrez des chiffres entiers", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ActualiserPer();
            ViderTextes();
        }

        private void BtnModifPer_Click(object sender, EventArgs e)
        {
            List<int> lstJours = VerifierJoursCheck();

            try
            {
                horaire.ModifierPeriode(float.Parse(txtDebHr.Text), float.Parse(txtFinHr.Text), float.Parse(txtDebMn.Text),
                    float.Parse(txtFinMn.Text), int.Parse(txtPer.Text), lstJours);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ActualiserPer();
        }

        private void BtnSuppPer_Click(object sender, EventArgs e)
        {
            try
            {
                horaire.SupprimerPeriode(int.Parse(txtPer.Text));
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Impossible d'effectuer l'action", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualiserPer();
            ViderTextes();
        }

        private void BtnGenPer_Click(object sender, EventArgs e)
        {
            try
            {
                genererPeriode(int.Parse(txtPer.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Impossible d'effectuer l'action", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TextBox
        // Cette section permet de faire pour qu'il n'y ait que des nombres dans le TextBox.

        private void TxtDebHr_TextChanged(object sender, EventArgs e)
        {
            txtDebHr.Text = ValiderTexte(txtDebHr.Text, true);
            txtDebHr.Select(txtDebHr.TextLength, 0);
            VerifierBoutons();
        }

        private void TxtFinHr_TextChanged(object sender, EventArgs e)
        {
            txtFinHr.Text = ValiderTexte(txtFinHr.Text, true);
            txtFinHr.Select(txtFinHr.TextLength, 0);
            VerifierBoutons();
        }

        private void TxtDebMn_TextChanged(object sender, EventArgs e)
        {
            txtDebMn.Text = ValiderTexte(txtDebMn.Text, false);
            txtDebMn.Select(txtDebMn.TextLength, 0);
            VerifierBoutons();
        }

        private void TxtFinMn_TextChanged(object sender, EventArgs e)
        {
            txtFinMn.Text = ValiderTexte(txtFinMn.Text, false);
            txtFinMn.Select(txtFinMn.TextLength, 0);
            VerifierBoutons();
        }

        private void TxtDebHr_Enter(object sender, EventArgs e)
        {
            if (txtDebHr.Text == "heure")
                txtDebHr.Text = "";
            txtDebHr.Select(0, txtDebHr.TextLength);
        }

        private void TxtFinHr_Enter(object sender, EventArgs e)
        {
            if (txtFinHr.Text == "heure")
                txtFinHr.Text = "";
            txtFinHr.Select(0, txtFinHr.TextLength);
        }

        private void TxtDebMn_Enter(object sender, EventArgs e)
        {
            if (txtDebMn.Text == "minute")
                txtDebMn.Text = "";
            txtDebMn.Select(0, txtDebMn.TextLength);
        }

        private void TxtFinMn_Enter(object sender, EventArgs e)
        {
            if (txtFinMn.Text == "minute")
                txtFinMn.Text = "";
            txtFinMn.Select(0, txtFinMn.TextLength);
        }

        private void TxtDebHr_Leave(object sender, EventArgs e)
        {
            if (txtDebHr.Text == "")
                txtDebHr.Text = "heure";
        }

        private void TxtFinHr_Leave(object sender, EventArgs e)
        {
            if (txtFinHr.Text == "")
                txtFinHr.Text = "heure";
        }

        private void TxtDebMn_Leave(object sender, EventArgs e)
        {
            if (txtDebMn.Text == "")
                txtDebMn.Text = "minute";
        }

        private void TxtFinMn_Leave(object sender, EventArgs e)
        {
            if (txtFinMn.Text == "")
                txtFinMn.Text = "minute";
        }

        private void TxtPer_TextChanged(object sender, EventArgs e)
        {
            if (txtPer.Text == "")
            {
                btnGenPer.Enabled = false;
                btnSuppPer.Enabled = false;
                btnModifPer.Enabled = false;
            }
            else
            {
                btnGenPer.Enabled = true;
                btnSuppPer.Enabled = true;
                btnModifPer.Enabled = true;
            }
        }

        private void TxtPer_Enter(object sender, EventArgs e)
        {
            txtPer.Select(0, txtPer.TextLength);
        }
        #endregion

        #region ListeView
        private void LsvPer_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            #region Code copié
            // http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lsvPer.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }

            // Create a comparer.
            lsvPer.ListViewItemSorter = new ListViewComparer(e.Column, sort_order);

            // Sort.
            lsvPer.Sort();
            #endregion
        }

        private void LsvPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPer.SelectedIndices.Count <= 0)
                return;

            int noPeriode = int.Parse(lsvPer.Items[lsvPer.SelectedIndices[0]].SubItems[0].Text);
            genererPeriode(noPeriode);

        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Vide les TextBoxes du formulaire
        /// </summary>
        private void ViderTextes()
        {
            txtDebHr.Clear();
            txtFinHr.Clear();
            txtDebMn.Clear();
            txtFinMn.Clear();
            txtPer.Clear();
        }

        /// <summary>
        ///  Vérifie si on bouton devrait être activé.
        /// </summary>
        public void VerifierBoutons()
        {
            if (txtDebHr.Text != "heure" && txtFinHr.Text != "heure" && txtDebMn.Text != "minute" && txtFinMn.Text != "minute" &&
                txtDebHr.Text != "" && txtFinHr.Text != "" && txtDebMn.Text != "" && txtFinMn.Text != "")
            {
                btnAjoutEPer.Enabled = true;
                if (txtPer.Text != "")
                    btnModifPer.Enabled = true;
            }
            else
            {
                btnAjoutEPer.Enabled = false;
                btnModifPer.Enabled = false;
            }


        }

        /// <summary>
        /// Vérifie les jours cochés.
        /// </summary>
        /// <returns>Retourne la liste de jours cochés.</returns>
        public List<int> VerifierJoursCheck()
        {
            List<int> lstJours = new List<int>();
            for (int i = 0; i < clbJours.Items.Count; i++)
                if (clbJours.GetItemChecked(i))
                    lstJours.Add(i);

            return lstJours;
        }

        /// <summary>
        /// Génère la période de garde et ses informations.
        /// </summary>
        /// <param name="pNoPeriode">Le numéro de la période de garde.</param>
        public void genererPeriode(int pNoPeriode)
        {
            IPeriode periode = horaire.ChercherNoPeriode(pNoPeriode);
            if (periode == null)
            {
                MessageBox.Show("Impossible de trouver la période de garde avec ce numéro", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtDebHr.Text = Math.Truncate(periode.Debut).ToString();
            txtFinHr.Text = Math.Truncate(periode.Fin).ToString();
            txtDebMn.Text = Math.Round((periode.Debut - Math.Truncate(periode.Debut)) * 60).ToString();
            txtFinMn.Text = Math.Round((periode.Fin - Math.Truncate(periode.Fin)) * 60).ToString();

            List<int> lstJour = periode.ListeJours;
            for (int i = 0; i < clbJours.Items.Count; i++)
            {
                clbJours.SetItemChecked(i, false);
            }
            for (int i = 0; i < lstJour.Count; i++)
                clbJours.SetItemChecked(lstJour[i], true);

            txtPer.Text = periode.NoPeriode.ToString();
        }

        /// <summary>
        /// Affiche la période de garde dans la ListView.
        /// </summary>
        private void ActualiserPer()
        {
            lsvPer.Items.Clear();
            lsvPer.BeginUpdate();
            foreach (Periode periode in horaire.ListePeriodes)
            {
                ListViewItem infoPeriode = new ListViewItem(periode.NoPeriode.ToString());
                infoPeriode.SubItems.Add(periode.Debut.ToString());
                infoPeriode.SubItems.Add(periode.Fin.ToString());
                infoPeriode.SubItems.Add(periode.Duree.ToString());

                lsvPer.Items.Add(infoPeriode);
            }
            lsvPer.EndUpdate();
        }

        /// <summary>
        /// Vérifie si la valeur entré dans le TextBox est valide.
        /// </summary>
        /// <param name="text">Valeur du TextBox.</param>
        /// <param name="EstHeure">Si la valeur est un heure, c'est vrai, si c'est une minute, c'est faux.</param>
        /// <returns></returns>
        private string ValiderTexte(string text, bool EstHeure)
        {
            if (text == "heure" || text == "minute")
                return text;

            if (text.Length > 2)
                text = text.Remove(2);

            for (int i = 0; i < text.Length; i++)
                if (!char.IsNumber(text[i]))
                    text = text.Remove(i, 1);

            if (text.Length > 0)
                if (EstHeure && int.Parse(text) >= 24)
                    text = "23";
                else if (int.Parse(text) >= 60)
                    text = "59";

            return text;
        }
        #endregion

    }
}
