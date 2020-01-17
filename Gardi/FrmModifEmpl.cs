using System;
using System.Windows.Forms;

namespace Gardi
{
    public partial class FrmModifEmpl : Form
    {
        private readonly IHoraire horaire = FrmGardi.grdHoraire;

        #region Code copié
        // http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
        // The column we are currently using for sorting.
        private ColumnHeader SortingColumn = null;
        #endregion

        public FrmModifEmpl()
        {
            InitializeComponent();
            ActualiserEmpl();
        }

        #region Bouton
        private void BtnAjoutEmpl_Click(object sender, EventArgs e)
        {
            foreach (Employe employe in horaire.ListeEmployes)
            {
                if (employe.ID == txtIDEmpl.Text)
                {
                    MessageBox.Show("Un employe avec cet identifiant existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            horaire.AjouterEmploye(txtNom.Text, txtPrenom.Text, txtIDEmpl.Text);
            ActualiserEmpl();
            ViderTextes();
        }



        private void BtnModifEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                horaire.ModifierEmp(txtNom.Text, txtPrenom.Text, txtIDEmpl.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ActualiserEmpl();
        }

        private void BtnSuppEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                horaire.SupprimerEmploye(txtIDEmpl.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ActualiserEmpl();
            ViderTextes();
        }

        private void BtnGenEmpl_Click(object sender, EventArgs e)
        {
            IEmploye employe = horaire.ChercherEmpID(txtIDEmpl.Text);
            if (employe == null)
            {
                MessageBox.Show("Impossible de trouver l'employé avec cet identifiant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtNom.Text = employe.Nom;
            txtPrenom.Text = employe.Prenom;
        }
        #endregion

        #region TextBox
        private void TxtIDEmpl_TextChanged(object sender, EventArgs e)
        {
            if (txtIDEmpl.Text != "")
            {
                btnGenEmpl.Enabled = true;
                btnSuppEmpl.Enabled = true;
            }
            else
            {
                btnGenEmpl.Enabled = false;
                btnSuppEmpl.Enabled = false;
            }
            VerifierBoutons();
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            VerifierBoutons();
        }

        private void TxtPrenom_TextChanged(object sender, EventArgs e)
        {
            VerifierBoutons();
        }

        private void TxtNom_Enter(object sender, EventArgs e)
        {
            txtNom.Select(0, txtNom.TextLength);
        }

        private void TxtPrenom_Enter(object sender, EventArgs e)
        {
            txtPrenom.Select(0, txtPrenom.TextLength);
        }

        private void TxtIDEmpl_Enter(object sender, EventArgs e)
        {
            txtIDEmpl.Select(0, txtIDEmpl.TextLength);
        }
        #endregion

        #region ListView
        private void LsvEmp_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            #region Code copié
            // http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lsvEmp.Columns[e.Column];

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
            lsvEmp.ListViewItemSorter = new ListViewComparer(e.Column, sort_order);

            // Sort.
            lsvEmp.Sort();
            #endregion
        }

        private void LsvEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Affiche les informations de l'employé sélectioné.
            if (lsvEmp.SelectedIndices.Count <= 0)
                return;

            string ID = lsvEmp.Items[lsvEmp.SelectedIndices[0]].SubItems[0].Text;
            IEmploye employe = horaire.ChercherEmpID(ID);

            txtNom.Text = employe.Nom;
            txtPrenom.Text = employe.Prenom;
            txtIDEmpl.Text = employe.ID;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Vide les TextBoxes du formulaire
        /// </summary>
        private void ViderTextes()
        {
            txtIDEmpl.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
        }

        /// <summary>
        /// Vérifie si on bouton devrait activé.
        /// </summary>
        private void VerifierBoutons()
        {
            if (txtIDEmpl.Text != "" && txtNom.Text != "" && txtPrenom.Text != "")
            {
                btnAjoutEmpl.Enabled = true;
                btnModifEmpl.Enabled = true;
            }
            else
            {
                btnAjoutEmpl.Enabled = false;
                btnModifEmpl.Enabled = false;
            }

        }

        /// <summary>
        /// Affiche la liste des employés dans la ListView.
        /// </summary>
        private void ActualiserEmpl()
        {
            lsvEmp.Items.Clear();
            lsvEmp.BeginUpdate();
            foreach (Employe employe in horaire.ListeEmployes)
            {
                int cpt = 0;
                do
                {
                    ListViewItem infoEmploye = new ListViewItem(employe.ID);
                    infoEmploye.SubItems.Add(employe.Nom);
                    infoEmploye.SubItems.Add(employe.Prenom);
                    if (employe.PeriodesGarde.Count > 1)
                    {
                        infoEmploye.SubItems.Add(employe.PeriodesGarde[cpt].ToString());
                        infoEmploye.SubItems.Add(employe.DatesGarde[cpt].ToString("dd MMM yyyy", new System.Globalization.CultureInfo("fr")));
                    }
                    else
                    {
                        infoEmploye.SubItems.Add("Aucune");
                        infoEmploye.SubItems.Add("Aucune");
                    }
                    lsvEmp.Items.Add(infoEmploye);
                    cpt++;
                }
                while (cpt < employe.PeriodesGarde.Count);
            }
            lsvEmp.EndUpdate();
        }
        #endregion
    }
}
