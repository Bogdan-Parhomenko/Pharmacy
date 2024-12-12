namespace Pharmacy
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonPreparations = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Sales = new System.Windows.Forms.RadioButton();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridViewPreparations = new System.Windows.Forms.DataGridView();
            this.buttonSelectPreparations = new System.Windows.Forms.Button();
            this.panelPreparation = new System.Windows.Forms.Panel();
            this.textBoxDescription_preparation = new System.Windows.Forms.TextBox();
            this.labelDescription_preparation = new System.Windows.Forms.Label();
            this.textBoxManufactureDate_preparation = new System.Windows.Forms.TextBox();
            this.labelManufactureDate_preparation = new System.Windows.Forms.Label();
            this.textBoxExpirationDate_preparation = new System.Windows.Forms.TextBox();
            this.labelExpirationDate_preparation = new System.Windows.Forms.Label();
            this.textBoxLotNumber_preparation = new System.Windows.Forms.TextBox();
            this.labelLotNumber_preparation = new System.Windows.Forms.Label();
            this.textBoxAmount_preparation = new System.Windows.Forms.TextBox();
            this.labelAmount_preparation = new System.Windows.Forms.Label();
            this.textBoxPrice_preparation = new System.Windows.Forms.TextBox();
            this.labelPrice_preparation = new System.Windows.Forms.Label();
            this.textBoxName_preparation = new System.Windows.Forms.TextBox();
            this.labelName_preparation = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxId_preparation = new System.Windows.Forms.TextBox();
            this.labelId_preparation = new System.Windows.Forms.Label();
            this.radioButtonDelete_preparation = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_preparation = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_preparation = new System.Windows.Forms.RadioButton();
            this.textBoxId_employee = new System.Windows.Forms.TextBox();
            this.labelId_employee = new System.Windows.Forms.Label();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreparations)).BeginInit();
            this.panelPreparation.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 424);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 58);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 363);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonOrders);
            this.groupBoxSelect.Controls.Add(this.radioButtonPreparations);
            this.groupBoxSelect.Controls.Add(this.radioButtonWorkers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 55);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonOrders
            // 
            this.radioButtonOrders.AutoSize = true;
            this.radioButtonOrders.Location = new System.Drawing.Point(184, 19);
            this.radioButtonOrders.Name = "radioButtonOrders";
            this.radioButtonOrders.Size = new System.Drawing.Size(64, 17);
            this.radioButtonOrders.TabIndex = 2;
            this.radioButtonOrders.TabStop = true;
            this.radioButtonOrders.Text = "Заказы";
            this.radioButtonOrders.UseVisualStyleBackColor = true;
            this.radioButtonOrders.CheckedChanged += new System.EventHandler(this.radioButtonOrders_CheckedChanged);
            // 
            // radioButtonPreparations
            // 
            this.radioButtonPreparations.AutoSize = true;
            this.radioButtonPreparations.Location = new System.Drawing.Point(96, 19);
            this.radioButtonPreparations.Name = "radioButtonPreparations";
            this.radioButtonPreparations.Size = new System.Drawing.Size(82, 17);
            this.radioButtonPreparations.TabIndex = 1;
            this.radioButtonPreparations.TabStop = true;
            this.radioButtonPreparations.Text = "Препараты";
            this.radioButtonPreparations.UseVisualStyleBackColor = true;
            this.radioButtonPreparations.CheckedChanged += new System.EventHandler(this.radioButtonPreparations_CheckedChanged);
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.Location = new System.Drawing.Point(6, 19);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(84, 17);
            this.radioButtonWorkers.TabIndex = 0;
            this.radioButtonWorkers.TabStop = true;
            this.radioButtonWorkers.Text = "Сотрудники";
            this.radioButtonWorkers.UseVisualStyleBackColor = true;
            this.radioButtonWorkers.CheckedChanged += new System.EventHandler(this.radioButtonWorkers_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 156);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 265);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxWorker);
            this.groupBoxFSelect.Controls.Add(this.labelWorker);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 153);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Прибыль сотрудников";
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(439, 109);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(144, 23);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Прибыль сотрудников";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(6, 113);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(252, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию прибыли";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(162, 62);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(100, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(6, 64);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(150, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать прибыль более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Sales);
            this.groupBoxDet.Location = new System.Drawing.Point(439, 20);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(223, 83);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли сотрудников";
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(6, 42);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDet_NO.TabIndex = 1;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Нет детализации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Sales
            // 
            this.radioButtonDet_Sales.AutoSize = true;
            this.radioButtonDet_Sales.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDet_Sales.Name = "radioButtonDet_Sales";
            this.radioButtonDet_Sales.Size = new System.Drawing.Size(202, 17);
            this.radioButtonDet_Sales.TabIndex = 0;
            this.radioButtonDet_Sales.TabStop = true;
            this.radioButtonDet_Sales.Text = "Прибыль сотрудника по продажам";
            this.radioButtonDet_Sales.UseVisualStyleBackColor = true;
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(162, 22);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(100, 20);
            this.textBoxWorker.TabIndex = 1;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(6, 25);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(117, 13);
            this.labelWorker.TabIndex = 0;
            this.labelWorker.Text = "Фамилия сотрудника";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 142);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 279);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 139);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(268, 54);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(149, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(100, 56);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(149, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(6, 59);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(80, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер заказа";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(187, 28);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 28);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewPreparations);
            this.tabPageDML.Controls.Add(this.buttonSelectPreparations);
            this.tabPageDML.Controls.Add(this.panelPreparation);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 424);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPreparations
            // 
            this.dataGridViewPreparations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreparations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPreparations.Location = new System.Drawing.Point(3, 294);
            this.dataGridViewPreparations.Name = "dataGridViewPreparations";
            this.dataGridViewPreparations.Size = new System.Drawing.Size(786, 127);
            this.dataGridViewPreparations.TabIndex = 15;
            // 
            // buttonSelectPreparations
            // 
            this.buttonSelectPreparations.Location = new System.Drawing.Point(6, 265);
            this.buttonSelectPreparations.Name = "buttonSelectPreparations";
            this.buttonSelectPreparations.Size = new System.Drawing.Size(167, 23);
            this.buttonSelectPreparations.TabIndex = 14;
            this.buttonSelectPreparations.Text = "Показать список препаратов";
            this.buttonSelectPreparations.UseVisualStyleBackColor = true;
            this.buttonSelectPreparations.Click += new System.EventHandler(this.buttonSelectPreparations_Click);
            // 
            // panelPreparation
            // 
            this.panelPreparation.Controls.Add(this.textBoxId_employee);
            this.panelPreparation.Controls.Add(this.labelId_employee);
            this.panelPreparation.Controls.Add(this.textBoxDescription_preparation);
            this.panelPreparation.Controls.Add(this.labelDescription_preparation);
            this.panelPreparation.Controls.Add(this.textBoxManufactureDate_preparation);
            this.panelPreparation.Controls.Add(this.labelManufactureDate_preparation);
            this.panelPreparation.Controls.Add(this.textBoxExpirationDate_preparation);
            this.panelPreparation.Controls.Add(this.labelExpirationDate_preparation);
            this.panelPreparation.Controls.Add(this.textBoxLotNumber_preparation);
            this.panelPreparation.Controls.Add(this.labelLotNumber_preparation);
            this.panelPreparation.Controls.Add(this.textBoxAmount_preparation);
            this.panelPreparation.Controls.Add(this.labelAmount_preparation);
            this.panelPreparation.Controls.Add(this.textBoxPrice_preparation);
            this.panelPreparation.Controls.Add(this.labelPrice_preparation);
            this.panelPreparation.Controls.Add(this.textBoxName_preparation);
            this.panelPreparation.Controls.Add(this.labelName_preparation);
            this.panelPreparation.Location = new System.Drawing.Point(6, 92);
            this.panelPreparation.Name = "panelPreparation";
            this.panelPreparation.Size = new System.Drawing.Size(783, 167);
            this.panelPreparation.TabIndex = 1;
            // 
            // textBoxDescription_preparation
            // 
            this.textBoxDescription_preparation.Location = new System.Drawing.Point(387, 6);
            this.textBoxDescription_preparation.Multiline = true;
            this.textBoxDescription_preparation.Name = "textBoxDescription_preparation";
            this.textBoxDescription_preparation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription_preparation.Size = new System.Drawing.Size(219, 105);
            this.textBoxDescription_preparation.TabIndex = 13;
            // 
            // labelDescription_preparation
            // 
            this.labelDescription_preparation.AutoSize = true;
            this.labelDescription_preparation.Location = new System.Drawing.Point(324, 9);
            this.labelDescription_preparation.Name = "labelDescription_preparation";
            this.labelDescription_preparation.Size = new System.Drawing.Size(57, 13);
            this.labelDescription_preparation.TabIndex = 12;
            this.labelDescription_preparation.Text = "Описание";
            // 
            // textBoxManufactureDate_preparation
            // 
            this.textBoxManufactureDate_preparation.Location = new System.Drawing.Point(149, 136);
            this.textBoxManufactureDate_preparation.Name = "textBoxManufactureDate_preparation";
            this.textBoxManufactureDate_preparation.Size = new System.Drawing.Size(100, 20);
            this.textBoxManufactureDate_preparation.TabIndex = 11;
            // 
            // labelManufactureDate_preparation
            // 
            this.labelManufactureDate_preparation.AutoSize = true;
            this.labelManufactureDate_preparation.Location = new System.Drawing.Point(5, 139);
            this.labelManufactureDate_preparation.Name = "labelManufactureDate_preparation";
            this.labelManufactureDate_preparation.Size = new System.Drawing.Size(107, 13);
            this.labelManufactureDate_preparation.TabIndex = 10;
            this.labelManufactureDate_preparation.Text = "Дата производства";
            // 
            // textBoxExpirationDate_preparation
            // 
            this.textBoxExpirationDate_preparation.Location = new System.Drawing.Point(149, 110);
            this.textBoxExpirationDate_preparation.Name = "textBoxExpirationDate_preparation";
            this.textBoxExpirationDate_preparation.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpirationDate_preparation.TabIndex = 9;
            // 
            // labelExpirationDate_preparation
            // 
            this.labelExpirationDate_preparation.AutoSize = true;
            this.labelExpirationDate_preparation.Location = new System.Drawing.Point(5, 113);
            this.labelExpirationDate_preparation.Name = "labelExpirationDate_preparation";
            this.labelExpirationDate_preparation.Size = new System.Drawing.Size(81, 13);
            this.labelExpirationDate_preparation.TabIndex = 8;
            this.labelExpirationDate_preparation.Text = "Срок годности";
            // 
            // textBoxLotNumber_preparation
            // 
            this.textBoxLotNumber_preparation.Location = new System.Drawing.Point(149, 84);
            this.textBoxLotNumber_preparation.Name = "textBoxLotNumber_preparation";
            this.textBoxLotNumber_preparation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLotNumber_preparation.TabIndex = 7;
            // 
            // labelLotNumber_preparation
            // 
            this.labelLotNumber_preparation.AutoSize = true;
            this.labelLotNumber_preparation.Location = new System.Drawing.Point(5, 87);
            this.labelLotNumber_preparation.Name = "labelLotNumber_preparation";
            this.labelLotNumber_preparation.Size = new System.Drawing.Size(79, 13);
            this.labelLotNumber_preparation.TabIndex = 6;
            this.labelLotNumber_preparation.Text = "Номер партии";
            // 
            // textBoxAmount_preparation
            // 
            this.textBoxAmount_preparation.Location = new System.Drawing.Point(149, 58);
            this.textBoxAmount_preparation.Name = "textBoxAmount_preparation";
            this.textBoxAmount_preparation.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount_preparation.TabIndex = 5;
            // 
            // labelAmount_preparation
            // 
            this.labelAmount_preparation.AutoSize = true;
            this.labelAmount_preparation.Location = new System.Drawing.Point(5, 61);
            this.labelAmount_preparation.Name = "labelAmount_preparation";
            this.labelAmount_preparation.Size = new System.Drawing.Size(120, 13);
            this.labelAmount_preparation.TabIndex = 4;
            this.labelAmount_preparation.Text = "Количество на складе";
            // 
            // textBoxPrice_preparation
            // 
            this.textBoxPrice_preparation.Location = new System.Drawing.Point(149, 32);
            this.textBoxPrice_preparation.Name = "textBoxPrice_preparation";
            this.textBoxPrice_preparation.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice_preparation.TabIndex = 3;
            // 
            // labelPrice_preparation
            // 
            this.labelPrice_preparation.AutoSize = true;
            this.labelPrice_preparation.Location = new System.Drawing.Point(5, 35);
            this.labelPrice_preparation.Name = "labelPrice_preparation";
            this.labelPrice_preparation.Size = new System.Drawing.Size(89, 13);
            this.labelPrice_preparation.TabIndex = 2;
            this.labelPrice_preparation.Text = "Цена препарата";
            // 
            // textBoxName_preparation
            // 
            this.textBoxName_preparation.Location = new System.Drawing.Point(149, 6);
            this.textBoxName_preparation.Name = "textBoxName_preparation";
            this.textBoxName_preparation.Size = new System.Drawing.Size(100, 20);
            this.textBoxName_preparation.TabIndex = 1;
            // 
            // labelName_preparation
            // 
            this.labelName_preparation.AutoSize = true;
            this.labelName_preparation.Location = new System.Drawing.Point(5, 9);
            this.labelName_preparation.Name = "labelName_preparation";
            this.labelName_preparation.Size = new System.Drawing.Size(113, 13);
            this.labelName_preparation.TabIndex = 0;
            this.labelName_preparation.Text = "Название препарата";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_preparation);
            this.groupBoxDML.Controls.Add(this.labelId_preparation);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_preparation);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_preparation);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_preparation);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 83);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(200, 44);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(121, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxId_preparation
            // 
            this.textBoxId_preparation.Location = new System.Drawing.Point(89, 46);
            this.textBoxId_preparation.Name = "textBoxId_preparation";
            this.textBoxId_preparation.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_preparation.TabIndex = 4;
            // 
            // labelId_preparation
            // 
            this.labelId_preparation.AutoSize = true;
            this.labelId_preparation.Location = new System.Drawing.Point(6, 49);
            this.labelId_preparation.Name = "labelId_preparation";
            this.labelId_preparation.Size = new System.Drawing.Size(74, 13);
            this.labelId_preparation.TabIndex = 3;
            this.labelId_preparation.Text = "ID препарата";
            // 
            // radioButtonDelete_preparation
            // 
            this.radioButtonDelete_preparation.AutoSize = true;
            this.radioButtonDelete_preparation.Location = new System.Drawing.Point(492, 19);
            this.radioButtonDelete_preparation.Name = "radioButtonDelete_preparation";
            this.radioButtonDelete_preparation.Size = new System.Drawing.Size(278, 17);
            this.radioButtonDelete_preparation.TabIndex = 2;
            this.radioButtonDelete_preparation.TabStop = true;
            this.radioButtonDelete_preparation.Text = "Удалить данные по препарату с заданным кодом";
            this.radioButtonDelete_preparation.UseVisualStyleBackColor = true;
            this.radioButtonDelete_preparation.CheckedChanged += new System.EventHandler(this.radioButtonDelete_preparation_CheckedChanged);
            // 
            // radioButtonUpdate_preparation
            // 
            this.radioButtonUpdate_preparation.AutoSize = true;
            this.radioButtonUpdate_preparation.Location = new System.Drawing.Point(200, 19);
            this.radioButtonUpdate_preparation.Name = "radioButtonUpdate_preparation";
            this.radioButtonUpdate_preparation.Size = new System.Drawing.Size(286, 17);
            this.radioButtonUpdate_preparation.TabIndex = 1;
            this.radioButtonUpdate_preparation.TabStop = true;
            this.radioButtonUpdate_preparation.Text = "Изменить данные по препарату с заданным кодом";
            this.radioButtonUpdate_preparation.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_preparation
            // 
            this.radioButtonInsert_preparation.AutoSize = true;
            this.radioButtonInsert_preparation.Location = new System.Drawing.Point(8, 19);
            this.radioButtonInsert_preparation.Name = "radioButtonInsert_preparation";
            this.radioButtonInsert_preparation.Size = new System.Drawing.Size(186, 17);
            this.radioButtonInsert_preparation.TabIndex = 0;
            this.radioButtonInsert_preparation.TabStop = true;
            this.radioButtonInsert_preparation.Text = "Добавить данные по препарату";
            this.radioButtonInsert_preparation.UseVisualStyleBackColor = true;
            // 
            // textBoxId_employee
            // 
            this.textBoxId_employee.Location = new System.Drawing.Point(408, 117);
            this.textBoxId_employee.Name = "textBoxId_employee";
            this.textBoxId_employee.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_employee.TabIndex = 7;
            // 
            // labelId_employee
            // 
            this.labelId_employee.AutoSize = true;
            this.labelId_employee.Location = new System.Drawing.Point(325, 120);
            this.labelId_employee.Name = "labelId_employee";
            this.labelId_employee.Size = new System.Drawing.Size(79, 13);
            this.labelId_employee.TabIndex = 6;
            this.labelId_employee.Text = "ID сотрудника";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreparations)).EndInit();
            this.panelPreparation.ResumeLayout(false);
            this.panelPreparation.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.RadioButton radioButtonOrders;
        private System.Windows.Forms.RadioButton radioButtonPreparations;
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_Sales;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Label labelId_preparation;
        private System.Windows.Forms.RadioButton radioButtonDelete_preparation;
        private System.Windows.Forms.RadioButton radioButtonUpdate_preparation;
        private System.Windows.Forms.RadioButton radioButtonInsert_preparation;
        private System.Windows.Forms.Panel panelPreparation;
        private System.Windows.Forms.TextBox textBoxPrice_preparation;
        private System.Windows.Forms.Label labelPrice_preparation;
        private System.Windows.Forms.TextBox textBoxName_preparation;
        private System.Windows.Forms.Label labelName_preparation;
        private System.Windows.Forms.TextBox textBoxId_preparation;
        private System.Windows.Forms.TextBox textBoxLotNumber_preparation;
        private System.Windows.Forms.Label labelLotNumber_preparation;
        private System.Windows.Forms.TextBox textBoxAmount_preparation;
        private System.Windows.Forms.Label labelAmount_preparation;
        private System.Windows.Forms.TextBox textBoxExpirationDate_preparation;
        private System.Windows.Forms.Label labelExpirationDate_preparation;
        private System.Windows.Forms.TextBox textBoxManufactureDate_preparation;
        private System.Windows.Forms.Label labelManufactureDate_preparation;
        private System.Windows.Forms.Button buttonSelectPreparations;
        private System.Windows.Forms.TextBox textBoxDescription_preparation;
        private System.Windows.Forms.Label labelDescription_preparation;
        private System.Windows.Forms.DataGridView dataGridViewPreparations;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxId_employee;
        private System.Windows.Forms.Label labelId_employee;
    }
}