using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormPreparationsList : Form
    {
        private static FormPreparationsList f;

        private int idCurrent = -1;

        public FormPreparationsList()
        {
            InitializeComponent();
        }

        private void препаратыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            препаратыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        private void FormPreperationsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Препараты". При необходимости она может быть перемещена или удалена.
            препаратыTableAdapter.Fill(pharmacyDataSet.Препараты);
            pharmacyDataSet.Препараты.Columns["Срок_годности"].DefaultValue = DateTime.Now;
            pharmacyDataSet.Препараты.Columns["Дата_производства"].DefaultValue = DateTime.Now;
        }

        public static FormPreparationsList Fp
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormPreparationsList();
                return f;
            }
        }

        public void ShowForm()
        {
            препаратыBindingSource.Position = 0;
            Show();
            Activate();
        }

        public int ShowSelectForm(int idPreparation)
        {
            idCurrent = idPreparation;
            ShowDialog();
            return (int)((DataRowView)препаратыBindingSource.Current)["ID_препарата"];
        }

        private void FormPreparationsList_Shown(object sender, EventArgs e)
        {
            препаратыBindingSource.Position = препаратыBindingSource.Find("ID_препарата", idCurrent);
        }
    }
}
