using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormOrdersList : Form
    {
        private static FormOrdersList f;

        public FormOrdersList()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                заказыBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(pharmacyDataSet);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormOrdersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Препараты". При необходимости она может быть перемещена или удалена.
            препаратыTableAdapter.Fill(pharmacyDataSet.Препараты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Детали_заказов". При необходимости она может быть перемещена или удалена.
            детали_заказовTableAdapter.Fill(pharmacyDataSet.Детали_заказов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            заказыTableAdapter.Fill(pharmacyDataSet.Заказы);
            pharmacyDataSet.Заказы.Columns["Дата_заказа"].DefaultValue = DateTime.Now;
        }

        private void детали_заказовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            детали_заказовBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        public static FormOrdersList Fo
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOrdersList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return детали_заказовDataGridView.Columns[детали_заказовDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }
        
        private void детали_заказовDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(GetSelectedFieldName(), "О_препарате", false) != 0 || детали_заказовDataGridView.CurrentCell.Value == DBNull.Value)
            {
                return;
            }
            int idPreparationCurrent;
            int.TryParse(((DataRowView)детали_заказовBindingSource.Current)["ID_препарата"].ToString(), out idPreparationCurrent);
            int idPreparation = FormPreparationsList.Fp.ShowSelectForm(idPreparationCurrent);
            ((DataRowView)детали_заказовBindingSource.Current)["ID_препарата"] = idPreparation;
            детали_заказовBindingSource.EndEdit();
            детали_заказовTableAdapter.Update(pharmacyDataSet);
            препаратыTableAdapter.Fill(pharmacyDataSet.Препараты);
        }
    }
}