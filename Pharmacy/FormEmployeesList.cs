using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormEmployeesList : Form
    {
        private static FormEmployeesList f;

        public FormEmployeesList()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            сотрудникиBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        private void FormEmployeesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            сотрудникиTableAdapter.Fill(pharmacyDataSet.Сотрудники);
        }

        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            string fileImage = "";
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фотоPictureBox.Image = new
                Bitmap(openFileDialogPhoto.FileName);
            }
            else fileImage = "";
        }
        
        public static FormEmployeesList Fe
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormEmployeesList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
