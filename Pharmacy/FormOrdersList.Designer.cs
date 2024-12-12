namespace Pharmacy
{
    partial class FormOrdersList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdersList));
            System.Windows.Forms.Label iD_заказаLabel;
            System.Windows.Forms.Label iD_покупателяLabel;
            System.Windows.Forms.Label iD_сотрудникаLabel;
            System.Windows.Forms.Label дата_заказаLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.заказыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.заказыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_заказаTextBox = new System.Windows.Forms.TextBox();
            this.iD_покупателяTextBox = new System.Windows.Forms.TextBox();
            this.iD_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.детали_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.детали_заказовDataGridView = new System.Windows.Forms.DataGridView();
            this.детали_заказовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.детали_заказовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.заказыTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.детали_заказовTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.Детали_заказовTableAdapter();
            this.препаратыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.препаратыTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ПрепаратыTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.О_препарате = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена_препарата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_заказаLabel = new System.Windows.Forms.Label();
            iD_покупателяLabel = new System.Windows.Forms.Label();
            iD_сотрудникаLabel = new System.Windows.Forms.Label();
            дата_заказаLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).BeginInit();
            this.заказыBindingNavigator.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.детали_заказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детали_заказовDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детали_заказовBindingNavigator)).BeginInit();
            this.детали_заказовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.препаратыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // заказыBindingNavigator
            // 
            this.заказыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказыBindingNavigator.BindingSource = this.заказыBindingSource;
            this.заказыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заказыBindingNavigatorSaveItem});
            this.заказыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказыBindingNavigator.Name = "заказыBindingNavigator";
            this.заказыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.заказыBindingNavigator.TabIndex = 0;
            this.заказыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // заказыBindingNavigatorSaveItem
            // 
            this.заказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыBindingNavigatorSaveItem.Image")));
            this.заказыBindingNavigatorSaveItem.Name = "заказыBindingNavigatorSaveItem";
            this.заказыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказыBindingNavigatorSaveItem_Click);
            // 
            // iD_заказаLabel
            // 
            iD_заказаLabel.AutoSize = true;
            iD_заказаLabel.Location = new System.Drawing.Point(12, 31);
            iD_заказаLabel.Name = "iD_заказаLabel";
            iD_заказаLabel.Size = new System.Drawing.Size(60, 13);
            iD_заказаLabel.TabIndex = 1;
            iD_заказаLabel.Text = "ID заказа:";
            // 
            // iD_заказаTextBox
            // 
            this.iD_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "ID_заказа", true));
            this.iD_заказаTextBox.Location = new System.Drawing.Point(100, 28);
            this.iD_заказаTextBox.Name = "iD_заказаTextBox";
            this.iD_заказаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_заказаTextBox.TabIndex = 2;
            // 
            // iD_покупателяLabel
            // 
            iD_покупателяLabel.AutoSize = true;
            iD_покупателяLabel.Location = new System.Drawing.Point(12, 57);
            iD_покупателяLabel.Name = "iD_покупателяLabel";
            iD_покупателяLabel.Size = new System.Drawing.Size(82, 13);
            iD_покупателяLabel.TabIndex = 3;
            iD_покупателяLabel.Text = "ID покупателя:";
            // 
            // iD_покупателяTextBox
            // 
            this.iD_покупателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "ID_покупателя", true));
            this.iD_покупателяTextBox.Location = new System.Drawing.Point(100, 54);
            this.iD_покупателяTextBox.Name = "iD_покупателяTextBox";
            this.iD_покупателяTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_покупателяTextBox.TabIndex = 4;
            // 
            // iD_сотрудникаLabel
            // 
            iD_сотрудникаLabel.AutoSize = true;
            iD_сотрудникаLabel.Location = new System.Drawing.Point(12, 83);
            iD_сотрудникаLabel.Name = "iD_сотрудникаLabel";
            iD_сотрудникаLabel.Size = new System.Drawing.Size(82, 13);
            iD_сотрудникаLabel.TabIndex = 5;
            iD_сотрудникаLabel.Text = "ID сотрудника:";
            // 
            // iD_сотрудникаTextBox
            // 
            this.iD_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаTextBox.Location = new System.Drawing.Point(100, 80);
            this.iD_сотрудникаTextBox.Name = "iD_сотрудникаTextBox";
            this.iD_сотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_сотрудникаTextBox.TabIndex = 6;
            // 
            // дата_заказаLabel
            // 
            дата_заказаLabel.AutoSize = true;
            дата_заказаLabel.Location = new System.Drawing.Point(12, 110);
            дата_заказаLabel.Name = "дата_заказаLabel";
            дата_заказаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заказаLabel.TabIndex = 7;
            дата_заказаLabel.Text = "Дата заказа:";
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата_заказа", true));
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(100, 106);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заказаDateTimePicker.TabIndex = 8;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 135);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 9;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Стоимость", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.стоимостьTextBox.Location = new System.Drawing.Point(100, 132);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 20);
            this.стоимостьTextBox.TabIndex = 10;
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOrderDetails.Controls.Add(this.детали_заказовBindingNavigator);
            this.groupBoxOrderDetails.Controls.Add(this.детали_заказовDataGridView);
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(12, 158);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(766, 349);
            this.groupBoxOrderDetails.TabIndex = 11;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Детали заказов";
            // 
            // детали_заказовBindingSource
            // 
            this.детали_заказовBindingSource.DataMember = "FK_Детали_заказов_Заказы";
            this.детали_заказовBindingSource.DataSource = this.заказыBindingSource;
            // 
            // детали_заказовDataGridView
            // 
            this.детали_заказовDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.детали_заказовDataGridView.AutoGenerateColumns = false;
            this.детали_заказовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.детали_заказовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.О_препарате,
            this.dataGridViewTextBoxColumn3,
            this.Цена_препарата});
            this.детали_заказовDataGridView.DataSource = this.детали_заказовBindingSource;
            this.детали_заказовDataGridView.Location = new System.Drawing.Point(3, 44);
            this.детали_заказовDataGridView.Name = "детали_заказовDataGridView";
            this.детали_заказовDataGridView.Size = new System.Drawing.Size(760, 302);
            this.детали_заказовDataGridView.TabIndex = 0;
            this.детали_заказовDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.детали_заказовDataGridView_CellClick);
            // 
            // детали_заказовBindingNavigator
            // 
            this.детали_заказовBindingNavigator.AddNewItem = this.toolStripButton1;
            this.детали_заказовBindingNavigator.BindingSource = this.детали_заказовBindingSource;
            this.детали_заказовBindingNavigator.CountItem = this.toolStripLabel1;
            this.детали_заказовBindingNavigator.DeleteItem = this.toolStripButton2;
            this.детали_заказовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.детали_заказовBindingNavigatorSaveItem});
            this.детали_заказовBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.детали_заказовBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.детали_заказовBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.детали_заказовBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.детали_заказовBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.детали_заказовBindingNavigator.Name = "детали_заказовBindingNavigator";
            this.детали_заказовBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.детали_заказовBindingNavigator.Size = new System.Drawing.Size(760, 25);
            this.детали_заказовBindingNavigator.TabIndex = 1;
            this.детали_заказовBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // детали_заказовBindingNavigatorSaveItem
            // 
            this.детали_заказовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.детали_заказовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("детали_заказовBindingNavigatorSaveItem.Image")));
            this.детали_заказовBindingNavigatorSaveItem.Name = "детали_заказовBindingNavigatorSaveItem";
            this.детали_заказовBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.детали_заказовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.детали_заказовBindingNavigatorSaveItem.Click += new System.EventHandler(this.детали_заказовBindingNavigatorSaveItem_Click);
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детали_заказовTableAdapter = this.детали_заказовTableAdapter;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПрепаратыTableAdapter = null;
            this.tableAdapterManager.РецептыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // детали_заказовTableAdapter
            // 
            this.детали_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // препаратыBindingSource
            // 
            this.препаратыBindingSource.DataMember = "Препараты";
            this.препаратыBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // препаратыTableAdapter
            // 
            this.препаратыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_заказа";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_препарата";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_препарата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // О_препарате
            // 
            this.О_препарате.DataPropertyName = "О_препарате";
            this.О_препарате.HeaderText = "О_препарате";
            this.О_препарате.Name = "О_препарате";
            this.О_препарате.ReadOnly = true;
            this.О_препарате.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.О_препарате.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Цена_препарата
            // 
            this.Цена_препарата.DataPropertyName = "Цена_препарата";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Цена_препарата.DefaultCellStyle = dataGridViewCellStyle1;
            this.Цена_препарата.HeaderText = "Цена_препарата";
            this.Цена_препарата.Name = "Цена_препарата";
            this.Цена_препарата.ReadOnly = true;
            // 
            // FormOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.groupBoxOrderDetails);
            this.Controls.Add(iD_заказаLabel);
            this.Controls.Add(this.iD_заказаTextBox);
            this.Controls.Add(iD_покупателяLabel);
            this.Controls.Add(this.iD_покупателяTextBox);
            this.Controls.Add(iD_сотрудникаLabel);
            this.Controls.Add(this.iD_сотрудникаTextBox);
            this.Controls.Add(дата_заказаLabel);
            this.Controls.Add(this.дата_заказаDateTimePicker);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.заказыBindingNavigator);
            this.Name = "FormOrdersList";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrdersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).EndInit();
            this.заказыBindingNavigator.ResumeLayout(false);
            this.заказыBindingNavigator.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.детали_заказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детали_заказовDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детали_заказовBindingNavigator)).EndInit();
            this.детали_заказовBindingNavigator.ResumeLayout(false);
            this.детали_заказовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.препаратыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private PharmacyDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заказыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_заказаTextBox;
        private System.Windows.Forms.TextBox iD_покупателяTextBox;
        private System.Windows.Forms.TextBox iD_сотрудникаTextBox;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
        private PharmacyDataSetTableAdapters.Детали_заказовTableAdapter детали_заказовTableAdapter;
        private System.Windows.Forms.BindingSource детали_заказовBindingSource;
        private System.Windows.Forms.BindingNavigator детали_заказовBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton детали_заказовBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView детали_заказовDataGridView;
        private System.Windows.Forms.BindingSource препаратыBindingSource;
        private PharmacyDataSetTableAdapters.ПрепаратыTableAdapter препаратыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn О_препарате;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена_препарата;
    }
}