using Pharmacy.PharmacyDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormRecipesList : Form
    {
        private static FormRecipesList f;

        public FormRecipesList()
        {
            InitializeComponent();
        }

        private void рецептыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            рецептыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        private void FormRecipesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.pharmacyDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Рецепты". При необходимости она может быть перемещена или удалена.
            рецептыTableAdapter.Fill(pharmacyDataSet.Рецепты);
            pharmacyDataSet.Рецепты.Columns["Дата_оформления"].DefaultValue = DateTime.Now;
        }

        public static FormRecipesList Fr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRecipesList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)рецептыBindingSource.Current)["ID_покупателя"].ToString() != "")
            {
                id = (int)((DataRowView)рецептыBindingSource.Current)["ID_покупателя"];
            }
            id = FormCustomersList.Fc.ShowSelectForm(id);
            if (id >= 0)
            {
                ((DataRowView)рецептыBindingSource.Current)["ID_покупателя"] = id;
                рецептыBindingSource.EndEdit();
                покупателиTableAdapter.Fill(pharmacyDataSet.Покупатели);
            }
        }
    }
}
