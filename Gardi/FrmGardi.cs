using System;
using System.Windows.Forms;

namespace Gardi
{
    public partial class FrmGardi : Form
    {
        // La variable qui contient les données des employés et des périodes.
        public static IHoraire grdHoraire = new Horaire();

        #region Code copié
        // Utilisé pour le tri de la listView
        // http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
        // The column we are currently using for sorting.
        private ColumnHeader SortingColumn = null;
        #endregion

        public FrmGardi()
        {
            InitializeComponent();
            btnGenHor.Text = "Générer " + DateTime.Now.AddMonths(1).ToString("MMMM yyyy", new System.Globalization.CultureInfo("fr"));
            btnGenHor.Select();
        }

        #region Bouton
        private void BtnModifEmpl_Click(object sender, EventArgs e)
        {
            OuvrirFormEmp();
        }

        private void BtnModifPer_Click(object sender, EventArgs e)
        {
            OuvrirFormPer();
        }

        private void BtnGenHor_Click(object sender, EventArgs e)
        {
            try
            {
                grdHoraire.GenererHoraire();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ActualiserEmpl();
        }

        private void BtnPlusHor_Click(object sender, EventArgs e)
        {
            Form objFrmPlusGen = new FrmPlusGen();

            var form = objFrmPlusGen.ShowDialog();
            if (form == DialogResult.Cancel)
            {
                ActualiserEmpl();
            }
        }

        private void btnViderEmpl_Click(object sender, EventArgs e)
        {
            grdHoraire.ListeEmployes.Clear();
            ActualiserEmpl();
        }

        private void btnViderPer_Click(object sender, EventArgs e)
        {
            grdHoraire.ListePeriodes.Clear();
            ActualiserPer();
        }
        #endregion

        #region Icône
        // Icônes de icons8.com
        private void IcnEnr_MouseEnter(object sender, EventArgs e)
        {
            icnEnr.Image = Properties.Resources.save_icon_color;
        }

        private void IcnEnr_MouseLeave(object sender, EventArgs e)
        {
            icnEnr.Image = Properties.Resources.save_icon;
        }

        private void IcnExp_MouseEnter(object sender, EventArgs e)
        {
            icnExp.Image = Properties.Resources.export_icon_color;
        }

        private void IcnExp_MouseLeave(object sender, EventArgs e)
        {
            icnExp.Image = Properties.Resources.export_icon;
        }

        private void icnOvr_MouseEnter(object sender, EventArgs e)
        {
            icnOvr.Image = Properties.Resources.open_icon_color;
        }

        private void icnOvr_MouseLeave(object sender, EventArgs e)
        {
            icnOvr.Image = Properties.Resources.open_icon;
        }

        private void IcnEnr_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }

        private void IcnExp_Click(object sender, EventArgs e)
        {
            Exporter();
        }

        private void icnOvr_Click(object sender, EventArgs e)
        {
            Ouvrir();
        }
        #endregion

        #region Menu
        private void EnregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }

        private void ExporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporter();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ouvrir();
        }
        private void mnuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous souhaitez être informé des mises à jour de Gardi? \n" +
                "Des questions ou des commentaires? \n\n" +
                "Envoyez un message à aurelende@protonmail.com \n\n\n\n" +
                "\t\t\t Aurele Nde Tcheh, octobre 2019", "Informations", MessageBoxButtons.OK);
        }

        #endregion

        #region ListView
        private void LsvEmp_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            #region Code copié
            // Permet de filtrer la listeView
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

        private void LsvEmp_DoubleClick(object sender, EventArgs e)
        {
            OuvrirFormEmp();
        }

        private void LsvPer_DoubleClick(object sender, EventArgs e)
        {
            OuvrirFormPer();
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Ouvre le formulaire des employés et affiche les modifications dans le formulaire principal.
        /// </summary>
        private void OuvrirFormEmp()
        {
            Form objFrmModifEmpl = new FrmModifEmpl();

            var form = objFrmModifEmpl.ShowDialog();
            if (form == DialogResult.Cancel)
                ActualiserEmpl();
        }

        /// <summary>
        /// Ouvre le formulaire des périodes et affiche les modifications dans le formulaire principal.
        /// </summary>
        private void OuvrirFormPer()
        {
            Form objFrmModifPer = new FrmModifPer();

            var form = objFrmModifPer.ShowDialog();
            if (form == DialogResult.Cancel)
                ActualiserPer();
        }

        /// <summary>
        /// Actualise la ListView des employés.
        /// </summary>
        private void ActualiserEmpl()
        {
            lsvEmp.Items.Clear();
            lsvEmp.BeginUpdate();
            foreach (Employe employe in grdHoraire.ListeEmployes)
            {
                int cpt = 0;
                do
                {
                    ListViewItem infoEmploye = new ListViewItem(employe.ID);
                    infoEmploye.SubItems.Add(employe.Nom);
                    infoEmploye.SubItems.Add(employe.Prenom);
                    if (employe.PeriodesGarde.Count > 0)
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

            // Gère le texte des labels sur les statistiques.
            lblNbEmpl.Text = grdHoraire.ListeEmployes.Count.ToString();
            if (grdHoraire.ListeEmployes.Count == 0)
                lblEmplEnr.Text = "Employé enregistré";
            else
                lblEmplEnr.Text = "Employés enregistrés";

            int nbPerGrdGen = 0;
            foreach (Employe employe in grdHoraire.ListeEmployes)
                nbPerGrdGen += employe.PeriodesGarde.Count;

            lblNbPerGrd.Text = nbPerGrdGen.ToString();
            if (nbPerGrdGen == 0)
                lblPerGrd.Text = "Période de garde générée";
            else
                lblPerGrd.Text = "Périodes de garde générées";
        }

        /// <summary>
        /// Actualise la ListView des périodes.
        /// </summary>
        private void ActualiserPer()
        {
            lsvPer.Items.Clear();
            lsvPer.BeginUpdate();
            foreach (Periode periode in grdHoraire.ListePeriodes)
            {
                ListViewItem infoPeriode = new ListViewItem(periode.NoPeriode.ToString());
                infoPeriode.SubItems.Add(periode.Debut.ToString());
                infoPeriode.SubItems.Add(periode.Fin.ToString());
                infoPeriode.SubItems.Add(periode.Duree.ToString());

                lsvPer.Items.Add(infoPeriode);
            }
            lsvPer.EndUpdate();

            // Gère le texte des labels sur les statistiques.
            lblNbPer.Text = grdHoraire.ListePeriodes.Count.ToString();
            if (grdHoraire.ListePeriodes.Count == 0)
                lblPerEnr.Text = "Période enregistrée";
            else
                lblPerEnr.Text = "Périodes enregistrées";
        }

        /// <summary>
        /// Ouvre le fichier contenant les informations sur les employés et les périodes.
        /// </summary>
        public void Ouvrir()
        {
            OpenFileDialog fichier = new OpenFileDialog();
            fichier.Filter = "Fichiers GRD|*.grd";
            if (fichier.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    grdHoraire.Charger(fichier.FileName);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("L'application vient d'être initialisé. Appuyé sur OK pour continuer.", "Gardi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ActualiserEmpl();
                ActualiserPer();
            }
        }


        /// <summary>
        /// Enregistre le fichier contenant les informations sur les employés et les périodes.
        /// </summary>
        public void Enregistrer()
        {
            SaveFileDialog fichier = new SaveFileDialog();
            fichier.Filter = "Fichiers GRD|*.grd";
            fichier.FileName = "*.grd";
            if (fichier.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    grdHoraire.Enregistrer(fichier.FileName);
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        /// <summary>
        /// Exporte le fichier avec les péridoes de garde sous format csv.
        /// </summary>
        public void Exporter()
        {
            SaveFileDialog fichier = new SaveFileDialog();
            fichier.Filter = "Fichiers CSV (séparateur: virgule)|*.csv";
            fichier.FileName = "*.csv";

            if (fichier.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    grdHoraire.Exporter(fichier.FileName);

                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("L'application ne dispose pas des autorisations nécessaires pour exporter le fichier à cet endroit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #endregion
    }
}
