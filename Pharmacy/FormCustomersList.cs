using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormCustomersList : Form
    {
        private static FormCustomersList f;

        private int idCurrent = -1;

        public FormCustomersList()
        {
            InitializeComponent();
        }

        private void покупателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            покупателиBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        private void FormCustomersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            покупателиTableAdapter.Fill(pharmacyDataSet.Покупатели);
            pharmacyDataSet.Покупатели.Columns["Дата_рождения"].DefaultValue = DateTime.Now;
        }

        private void покупателиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            покупателиBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        public static FormCustomersList Fc
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormCustomersList();
                return f;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            покупателиBindingSource.Position = 0;
            Show();
            Activate();
        }

        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
            {
                return (int)((DataRowView)покупателиBindingSource.Current)["ID_покупателя"];
            }
            else
            {
                return -1;
            }
        }

        private void FormCustomersList_Shown(object sender, EventArgs e)
        {
            покупателиBindingSource.Position = покупателиBindingSource.Find("ID_покупателя", idCurrent);
        }

        string GetSelectedFieldName()
        {
            return покупателиDataGridView.Columns[покупателиDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = покупателиBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
            {
                покупателиBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                покупателиBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        покупателиBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                    }
                }
            }
            else
            {
                покупателиBindingSource.Filter = "";
            }
            if (покупателиBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                покупателиBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
