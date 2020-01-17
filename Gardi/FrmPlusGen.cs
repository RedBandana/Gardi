using System;
using System.Windows.Forms;

namespace Gardi
{
    public partial class FrmPlusGen : Form
    {
        private readonly IHoraire horaire = FrmGardi.grdHoraire;

        public FrmPlusGen()
        {
            InitializeComponent();
        }

        private void BtnGenHor_Click(object sender, EventArgs e)
        {
            DateTime dateD = dtpDateDebut.Value.Date;
            try
            {
                horaire.GenererHoraire(dateD.Year, dateD.Month, dateD.Day, (int)numNbJours.Value);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Close();
        }
    }
}
