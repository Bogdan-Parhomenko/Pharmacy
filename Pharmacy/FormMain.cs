using Pharmacy.Properties;
using System;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {        
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = 
                MessageBox.Show("Вы хотите закрыть программу?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    != DialogResult.Yes;
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Пархоменко Богдан Борисович, 572-2, 2024", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void toolStripMenuItemCustomers_Click(object sender, EventArgs e)
        {
            FormCustomersList.Fc.ShowForm();
        }

        private void toolStripMenuItemEmployees_Click(object sender, EventArgs e)
        {
            FormEmployeesList.Fe.ShowForm();
        }

        private void toolStripMenuItemRecipes_Click(object sender, EventArgs e)
        {
            FormRecipesList.Fr.ShowForm();
        }

        private void toolStripMenuItemPreparations_Click(object sender, EventArgs e)
        {
            FormPreparationsList.Fp.ShowForm();
        }

        private void toolStripMenuItemOrders_Click(object sender, EventArgs e)
        {
            FormOrdersList.Fo.ShowForm();
        }

        private void toolStripMenuItemQuery_Click(object sender, EventArgs e)
        {
            FormSQL.Fs.ShowForm();
        }
    }
}
