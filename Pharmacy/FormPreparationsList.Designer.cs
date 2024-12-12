namespace Pharmacy
{
    partial class FormPreparationsList
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
            System.Windows.Forms.Label iD_препаратаLabel;
            System.Windows.Forms.Label iD_сотрудникаLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label номер_партииLabel;
            System.Windows.Forms.Label количество_на_складеLabel;
            System.Windows.Forms.Label срок_годностиLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label дата_производстваLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreparationsList));
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.препаратыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.препаратыTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ПрепаратыTableAdapter();
            this.tableAdapterManager = new Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.препаратыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.препаратыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_препаратаTextBox = new System.Windows.Forms.TextBox();
            this.iD_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.номер_партииTextBox = new System.Windows.Forms.TextBox();
            this.количество_на_складеTextBox = new System.Windows.Forms.TextBox();
            this.срок_годностиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.дата_производстваDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            iD_препаратаLabel = new System.Windows.Forms.Label();
            iD_сотрудникаLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            номер_партииLabel = new System.Windows.Forms.Label();
            количество_на_складеLabel = new System.Windows.Forms.Label();
            срок_годностиLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            дата_производстваLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.препаратыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.препаратыBindingNavigator)).BeginInit();
            this.препаратыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_препаратаLabel
            // 
            iD_препаратаLabel.AutoSize = true;
            iD_препаратаLabel.Location = new System.Drawing.Point(12, 31);
            iD_препаратаLabel.Name = "iD_препаратаLabel";
            iD_препаратаLabel.Size = new System.Drawing.Size(77, 13);
            iD_препаратаLabel.TabIndex = 1;
            iD_препаратаLabel.Text = "ID препарата:";
            // 
            // iD_сотрудникаLabel
            // 
            iD_сотрудникаLabel.AutoSize = true;
            iD_сотрудникаLabel.Location = new System.Drawing.Point(12, 57);
            iD_сотрудникаLabel.Name = "iD_сотрудникаLabel";
            iD_сотрудникаLabel.Size = new System.Drawing.Size(82, 13);
            iD_сотрудникаLabel.TabIndex = 3;
            iD_сотрудникаLabel.Text = "ID сотрудника:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(12, 83);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 5;
            названиеLabel.Text = "Название:";
            // 
            // номер_партииLabel
            // 
            номер_партииLabel.AutoSize = true;
            номер_партииLabel.Location = new System.Drawing.Point(12, 109);
            номер_партииLabel.Name = "номер_партииLabel";
            номер_партииLabel.Size = new System.Drawing.Size(82, 13);
            номер_партииLabel.TabIndex = 7;
            номер_партииLabel.Text = "Номер партии:";
            // 
            // количество_на_складеLabel
            // 
            количество_на_складеLabel.AutoSize = true;
            количество_на_складеLabel.Location = new System.Drawing.Point(12, 135);
            количество_на_складеLabel.Name = "количество_на_складеLabel";
            количество_на_складеLabel.Size = new System.Drawing.Size(123, 13);
            количество_на_складеLabel.TabIndex = 9;
            количество_на_складеLabel.Text = "Количество на складе:";
            // 
            // срок_годностиLabel
            // 
            срок_годностиLabel.AutoSize = true;
            срок_годностиLabel.Location = new System.Drawing.Point(12, 162);
            срок_годностиLabel.Name = "срок_годностиLabel";
            срок_годностиLabel.Size = new System.Drawing.Size(84, 13);
            срок_годностиLabel.TabIndex = 11;
            срок_годностиLabel.Text = "Срок годности:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(12, 187);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 13;
            ценаLabel.Text = "Цена:";
            // 
            // дата_производстваLabel
            // 
            дата_производстваLabel.AutoSize = true;
            дата_производстваLabel.Location = new System.Drawing.Point(12, 214);
            дата_производстваLabel.Name = "дата_производстваLabel";
            дата_производстваLabel.Size = new System.Drawing.Size(110, 13);
            дата_производстваLabel.TabIndex = 15;
            дата_производстваLabel.Text = "Дата производства:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(12, 239);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(60, 13);
            описаниеLabel.TabIndex = 17;
            описаниеLabel.Text = "Описание:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детали_заказовTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПрепаратыTableAdapter = this.препаратыTableAdapter;
            this.tableAdapterManager.РецептыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // препаратыBindingNavigator
            // 
            this.препаратыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.препаратыBindingNavigator.BindingSource = this.препаратыBindingSource;
            this.препаратыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.препаратыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.препаратыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.препаратыBindingNavigatorSaveItem});
            this.препаратыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.препаратыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.препаратыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.препаратыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.препаратыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.препаратыBindingNavigator.Name = "препаратыBindingNavigator";
            this.препаратыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.препаратыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.препаратыBindingNavigator.TabIndex = 0;
            this.препаратыBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // препаратыBindingNavigatorSaveItem
            // 
            this.препаратыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.препаратыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("препаратыBindingNavigatorSaveItem.Image")));
            this.препаратыBindingNavigatorSaveItem.Name = "препаратыBindingNavigatorSaveItem";
            this.препаратыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.препаратыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.препаратыBindingNavigatorSaveItem.Click += new System.EventHandler(this.препаратыBindingNavigatorSaveItem_Click);
            // 
            // iD_препаратаTextBox
            // 
            this.iD_препаратаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.препаратыBindingSource, "ID_препарата", true));
            this.iD_препаратаTextBox.Location = new System.Drawing.Point(141, 28);
            this.iD_препаратаTextBox.Name = "iD_препаратаTextBox";
            this.iD_препаратаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_препаратаTextBox.TabIndex = 2;
            // 
            // iD_сотрудникаTextBox
            // 
            this.iD_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.препаратыBindingSource, "ID_сотрудника", true));
            this.iD_сотрудникаTextBox.Location = new System.Drawing.Point(141, 54);
            this.iD_сотрудникаTextBox.Name = "iD_сотрудникаTextBox";
            this.iD_сотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_сотрудникаTextBox.TabIndex = 4;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.препаратыBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(141, 80);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(200, 20);
            this.названиеTextBox.TabIndex = 6;
            // 
            // номер_партииTextBox
            // 
            this.номер_партииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.препаратыBindingSource, "Номер_партии", true));
            this.номер_партииTextBox.Location = new System.Drawing.Point(141, 106);
            this.номер_партииTextBox.Name = "номер_партииTextBox";
            this.номер_партииTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_партииTextBox.TabIndex = 8;
            // 
            // количество_на_складеTextBox
            // 
            this.количество_на_складеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.препаратыBindingSource, "Количество_на_складе", true));
            this.количество_на_складеTextBox.Location = new System.Drawing.Point(141, 132);
            this.количество_на_складеTextBox.Name = "количество_на_складеTextBox";
            this.количество_на_складеTextBox.Size = new System.Drawing.Size(200, 20);
            this.количество_на_складеTextBox.TabIndex = 10;
            // 
            // срок_годностиDateTimePicker
            // 
            this.срок_годностиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.препаратыBindingSource, "Срок_годности", true));
            this.срок_годностиDateTimePicker.Location = new System.Drawing.Point(141, 158);
            this.срок_годностиDateTimePicker.Name = "срок_годностиDateTimePicker";
            this.срок_годностиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.срок_годностиDateTimePicker.TabIndex = 12;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.препаратыBindingSource, "Цена", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.ценаTextBox.Location = new System.Drawing.Point(141, 184);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(200, 20);
            this.ценаTextBox.TabIndex = 14;
            // 
            // дата_производстваDateTimePicker
            // 
            this.дата_производстваDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.препаратыBindingSource, "Дата_производства", true));
            this.дата_производстваDateTimePicker.Location = new System.Drawing.Point(141, 210);
            this.дата_производстваDateTimePicker.Name = "дата_производстваDateTimePicker";
            this.дата_производстваDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_производстваDateTimePicker.TabIndex = 16;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.препаратыBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(141, 236);
            this.описаниеTextBox.Multiline = true;
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 92);
            this.описаниеTextBox.TabIndex = 18;
            // 
            // FormPreparationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_препаратаLabel);
            this.Controls.Add(this.iD_препаратаTextBox);
            this.Controls.Add(iD_сотрудникаLabel);
            this.Controls.Add(this.iD_сотрудникаTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(номер_партииLabel);
            this.Controls.Add(this.номер_партииTextBox);
            this.Controls.Add(количество_на_складеLabel);
            this.Controls.Add(this.количество_на_складеTextBox);
            this.Controls.Add(срок_годностиLabel);
            this.Controls.Add(this.срок_годностиDateTimePicker);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(дата_производстваLabel);
            this.Controls.Add(this.дата_производстваDateTimePicker);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.препаратыBindingNavigator);
            this.Name = "FormPreparationsList";
            this.Text = "Препараты";
            this.Load += new System.EventHandler(this.FormPreperationsList_Load);
            this.Shown += new System.EventHandler(this.FormPreparationsList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.препаратыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.препаратыBindingNavigator)).EndInit();
            this.препаратыBindingNavigator.ResumeLayout(false);
            this.препаратыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource препаратыBindingSource;
        private PharmacyDataSetTableAdapters.ПрепаратыTableAdapter препаратыTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator препаратыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton препаратыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_препаратаTextBox;
        private System.Windows.Forms.TextBox iD_сотрудникаTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox номер_партииTextBox;
        private System.Windows.Forms.TextBox количество_на_складеTextBox;
        private System.Windows.Forms.DateTimePicker срок_годностиDateTimePicker;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.DateTimePicker дата_производстваDateTimePicker;
        private System.Windows.Forms.TextBox описаниеTextBox;
    }
}