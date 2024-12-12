using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Pharmacy
{
    public partial class FormSQL : Form
    {
        private static FormSQL f;

        public FormSQL()
        {
            InitializeComponent();
        }

        public static FormSQL Fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Сотрудники");
        }

        private void radioButtonPreparations_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT ID_Препарата,
                Название, CAST(Цена AS decimal(16,2)) AS [Текущая цена],
                Количество_на_складе, CAST(Срок_годности AS DateTime) AS
                [Срок_годности], CAST(Дата_производства AS DateTime) AS
                [Дата_производства], CAST(Номер_партии AS integer) AS [Номер партии] FROM Препараты");
        }

        private void radioButtonOrders_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT
                ID_заказа, Сотрудники.ID_сотрудника, Фамилия+' '+Имя+' '+Отчество AS ФИО
                FROM Заказы, Сотрудники WHERE Заказы.ID_сотрудника =
                Сотрудники.ID_сотрудника");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxWorker.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && string.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Sales.Checked)
            {
                sqlSelect = @"SELECT Сотрудники.ID_сотрудника, Фамилия, Имя, Отчество, Заказы.ID_заказа,
                     CAST(Sum(Количество * Цена) AS decimal(16,2)) AS Прибыль
                     FROM Сотрудники, Заказы, Детали_заказов, Препараты
                     WHERE Фамилия LIKE @last_name AND Сотрудники.ID_сотрудника = Заказы.ID_сотрудника AND
                     Заказы.ID_Заказа = Детали_заказов.ID_Заказа AND
                     Детали_заказов.ID_препарата = Препараты.ID_препарата
                     GROUP BY Сотрудники.ID_сотрудника, Фамилия, Имя, Отчество, Заказы.ID_заказа";
            }
            else
            {
                sqlSelect = @"SELECT Сотрудники.ID_сотрудника, Фамилия, Имя, Отчество, 
                    CAST(Sum(Количество * Цена) AS decimal(16,2)) AS Прибыль
                    FROM Сотрудники INNER JOIN Заказы ON Сотрудники.ID_сотрудника = Заказы.ID_сотрудника
                    INNER JOIN Детали_заказов ON Заказы.ID_заказа = Детали_заказов.ID_заказа
                    INNER JOIN Препараты ON Детали_заказов.ID_препарата = Препараты.ID_препарата AND Фамилия LIKE @last_name
                    GROUP BY Сотрудники.ID_сотрудника, Фамилия, Имя, Отчество";
            }
            if (checkBoxMore.Checked)
            {
                sqlSelect += " HAVING Sum(Количество * Цена) > @amount";
            }
            if (checkBoxOrder.Checked)
            {
                sqlSelect += " ORDER BY Sum(Количество * Цена) desc";
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxWorker.Text + "%");
            if (checkBoxMore.Checked)
            {
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value = double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом",
                        "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonCorrelated.Checked)
            {
                sqlSelect = @"SELECT Детали_заказов.ID_заказа, Детали_заказов.ID_препарата,
                    (SELECT Название FROM Препараты WHERE ID_препарата = Детали_заказов.ID_препарата) AS Препарат,
                    CAST(Количество * (SELECT Цена FROM Препараты WHERE ID_препарата = Детали_заказов.ID_препарата) AS decimal(16,2)) AS Стоимость,
                    (SELECT Фамилия+' '+Имя+' '+Отчество FROM Сотрудники
                    WHERE ID_сотрудника IN (SELECT ID_сотрудника FROM Заказы
                    WHERE ID_заказа = Детали_заказов.ID_заказа)) AS Оформил_сотрудник
                    FROM Детали_заказов WHERE ID_заказа = @number";
            }                
            else if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = @"SELECT * FROM Детали_заказов WHERE ID_заказа = @number AND Количество > (SELECT AVG(Количество) FROM Детали_заказов)";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value = int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void InsertDish()
        {
            if (string.IsNullOrEmpty(textBoxId_preparation.Text) ||
                string.IsNullOrEmpty(textBoxId_employee.Text) ||
                string.IsNullOrEmpty(textBoxName_preparation.Text) ||
                string.IsNullOrEmpty(textBoxPrice_preparation.Text) ||
                string.IsNullOrEmpty(textBoxAmount_preparation.Text) ||
                string.IsNullOrEmpty(textBoxLotNumber_preparation.Text) ||
                string.IsNullOrEmpty(textBoxExpirationDate_preparation.Text) ||
                string.IsNullOrEmpty(textBoxManufactureDate_preparation.Text))
            {
                MessageBox.Show("Обязательно введите ID препарата, ID сотрудника, название, цену," +
                    " Количество на складе, номер партии, срок годности и дату производства",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idPreparation;
            if (!int.TryParse(textBoxId_preparation.Text, out idPreparation))
            {
                MessageBox.Show("Некоректное значение ID препарата!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idEmployee;
            if (!int.TryParse(textBoxId_employee.Text, out idEmployee))
            {
                MessageBox.Show("Некоректное значение ID сотрудника!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double price;
            if (!double.TryParse(textBoxPrice_preparation.Text, out price))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int amount;
            if (!int.TryParse(textBoxAmount_preparation.Text, out amount))
            {
                MessageBox.Show("Некоректное значение количества на складе!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int lotNumber;
            if (!int.TryParse(textBoxLotNumber_preparation.Text, out lotNumber))
            {
                MessageBox.Show("Некоректное значение номера партии!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime expirationDate;
            if (!DateTime.TryParse(textBoxExpirationDate_preparation.Text, out expirationDate))
            {
                MessageBox.Show("Некоректное значение срока годности!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime manufactureDate;
            if (!DateTime.TryParse(textBoxManufactureDate_preparation.Text, out manufactureDate))
            {
                MessageBox.Show("Некоректное значение даты производства!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Препараты (ID_препарата, ID_сотрудника, Название,
                Цена, Количество_на_складе, Номер_партии, Срок_годности, Дата_производства, Описание)
                VALUES (@IDPreparation, @IDEmployee, @Name, @Price, @Amount, @LotNumber, @ExpirationDate, @ManufactureDate, @Description)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@IDPreparation", idPreparation);
            command.Parameters.AddWithValue("@IDEmployee", idEmployee);
            command.Parameters.AddWithValue("@Name", textBoxName_preparation.Text);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Amount", amount);
            command.Parameters.AddWithValue("@LotNumber", lotNumber);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@ManufactureDate", manufactureDate);
            command.Parameters.AddWithValue("@Description", textBoxDescription_preparation.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectPreparations_Click(this, EventArgs.Empty);
        }

        void UpdateDish()
        {
            if (string.IsNullOrEmpty(textBoxId_preparation.Text))
            {
                MessageBox.Show("Обязательно укажите ID препарата, для которого будете менять данные",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idPreparation;
            if (!int.TryParse(textBoxId_preparation.Text, out idPreparation))
            {
                MessageBox.Show("Некоректное значение ID препарата!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idEmployee = 0;
            if ((!string.IsNullOrEmpty(textBoxId_employee.Text)) &&
                (!int.TryParse(textBoxId_employee.Text, out idEmployee)))
            {
                MessageBox.Show("Некоректное значение ID сотрудника!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double price = 0;
            if ((!string.IsNullOrEmpty(textBoxPrice_preparation.Text)) &&
                (!double.TryParse(textBoxPrice_preparation.Text, out price)))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int amount = 0;
            if ((!string.IsNullOrEmpty(textBoxAmount_preparation.Text)) &&
                (!int.TryParse(textBoxAmount_preparation.Text, out amount)))
            {
                MessageBox.Show("Некоректное значение количества на складе!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int lotNumber = 0;
            if ((!string.IsNullOrEmpty(textBoxLotNumber_preparation.Text)) &&
                (!int.TryParse(textBoxLotNumber_preparation.Text, out lotNumber)))
            {
                MessageBox.Show("Некоректное значение номера партии!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime expirationDate = new DateTime();
            if ((!string.IsNullOrEmpty(textBoxExpirationDate_preparation.Text)) &&
                (!DateTime.TryParse(textBoxExpirationDate_preparation.Text, out expirationDate)))
            {
                MessageBox.Show("Некоректное значение срока годности!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime manufactureDate = new DateTime();
            if ((!string.IsNullOrEmpty(textBoxManufactureDate_preparation.Text)) &&
                (!DateTime.TryParse(textBoxManufactureDate_preparation.Text, out manufactureDate)))
            {
                MessageBox.Show("Некоректное значение даты производства!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Препараты SET {0} WHERE ID_препарата = @IDpreparation";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!string.IsNullOrEmpty(textBoxId_employee.Text))
                sqlValues += "ID_сотрудника=@IDEmployee,";
            if (!string.IsNullOrEmpty(textBoxName_preparation.Text))
                sqlValues += "Название=@Name,";
            if (!string.IsNullOrEmpty(textBoxPrice_preparation.Text))
                sqlValues += "Цена=@Price,";
            if (!string.IsNullOrEmpty(textBoxAmount_preparation.Text))
                sqlValues += "Количество_на_складе=@Amount,";
            if (!string.IsNullOrEmpty(textBoxLotNumber_preparation.Text))
                sqlValues += "Номер_партии=@LotNumber,";
            if (!string.IsNullOrEmpty(textBoxExpirationDate_preparation.Text))
                sqlValues += "Срок_годности=@ExpirationDate,";
            if (!string.IsNullOrEmpty(textBoxManufactureDate_preparation.Text))
                sqlValues += "Дата_производства=@ManufactureDate,";
            if (!string.IsNullOrEmpty(textBoxDescription_preparation.Text))
                sqlValues += "Описание=@Description,";
            sqlValues = sqlValues.Substring(0, sqlValues.Length - 1);
            command.CommandText = string.Format(sqlUpdate, sqlValues);
            if (!string.IsNullOrEmpty(textBoxId_employee.Text))
                command.Parameters.AddWithValue("@IDEmployee", idEmployee);
            if (!string.IsNullOrEmpty(textBoxName_preparation.Text))
                command.Parameters.AddWithValue("@Name", textBoxName_preparation.Text);
            if (!string.IsNullOrEmpty(textBoxPrice_preparation.Text))
                command.Parameters.AddWithValue("@Price", price);
            if (!string.IsNullOrEmpty(textBoxAmount_preparation.Text))
                command.Parameters.AddWithValue("@Amount", amount);
            if (!string.IsNullOrEmpty(textBoxLotNumber_preparation.Text))
                command.Parameters.AddWithValue("@LotNumber", lotNumber);
            if (!string.IsNullOrEmpty(textBoxExpirationDate_preparation.Text))
                command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            if (!string.IsNullOrEmpty(textBoxManufactureDate_preparation.Text))
                command.Parameters.AddWithValue("@ManufactureDate", manufactureDate);
            if (!string.IsNullOrEmpty(textBoxDescription_preparation.Text))
                command.Parameters.AddWithValue("@Description", textBoxDescription_preparation.Text);
            command.Parameters.AddWithValue("@IDpreparation", idPreparation);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectPreparations_Click(this, EventArgs.Empty);
        }

        void DeleteDish()
        {
            if (string.IsNullOrEmpty(textBoxId_preparation.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда данные которого необходимо удалить",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }
            int id;
            if (!int.TryParse(textBoxId_preparation.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Препараты WHERE ID_препарата = @IDPreparation";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@IDPreparation", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectPreparations_Click(this, EventArgs.Empty);
        }


        private void buttonSelectPreparations_Click(object sender, EventArgs e)
        {
            dataGridViewPreparations.DataSource = FillDataGridView("SELECT * FROM Препараты");
        }

        private void radioButtonDelete_preparation_CheckedChanged(object sender, EventArgs e)
        {
            panelPreparation.Visible = !radioButtonDelete_preparation.Checked;
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_preparation.Checked)
                InsertDish();
            else if (radioButtonUpdate_preparation.Checked)
                UpdateDish();
            else if (radioButtonDelete_preparation.Checked)
                DeleteDish();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
