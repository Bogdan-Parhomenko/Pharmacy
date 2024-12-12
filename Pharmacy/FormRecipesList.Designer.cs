namespace Pharmacy
{
    partial class FormRecipesList
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
            System.Windows.Forms.Label iD_рецептаLabel;
            System.Windows.Forms.Label iD_покупателяLabel;
            System.Windows.Forms.Label название_препаратаLabel;
            System.Windows.Forms.Label дата_оформленияLabel;
            System.Windows.Forms.Label фИО_врачаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecipesList));
            System.Windows.Forms.Label покупательLabel;
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.рецептыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рецептыTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.РецептыTableAdapter();
            this.tableAdapterManager = new Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.рецептыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.рецептыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_рецептаTextBox = new System.Windows.Forms.TextBox();
            this.iD_покупателяTextBox = new System.Windows.Forms.TextBox();
            this.название_препаратаTextBox = new System.Windows.Forms.TextBox();
            this.дата_оформленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фИО_врачаTextBox = new System.Windows.Forms.TextBox();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.покупательLabel1 = new System.Windows.Forms.Label();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.ПокупателиTableAdapter();
            iD_рецептаLabel = new System.Windows.Forms.Label();
            iD_покупателяLabel = new System.Windows.Forms.Label();
            название_препаратаLabel = new System.Windows.Forms.Label();
            дата_оформленияLabel = new System.Windows.Forms.Label();
            фИО_врачаLabel = new System.Windows.Forms.Label();
            покупательLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingNavigator)).BeginInit();
            this.рецептыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_рецептаLabel
            // 
            iD_рецептаLabel.AutoSize = true;
            iD_рецептаLabel.Location = new System.Drawing.Point(12, 39);
            iD_рецептаLabel.Name = "iD_рецептаLabel";
            iD_рецептаLabel.Size = new System.Drawing.Size(65, 13);
            iD_рецептаLabel.TabIndex = 1;
            iD_рецептаLabel.Text = "ID рецепта:";
            // 
            // iD_покупателяLabel
            // 
            iD_покупателяLabel.AutoSize = true;
            iD_покупателяLabel.Location = new System.Drawing.Point(12, 65);
            iD_покупателяLabel.Name = "iD_покупателяLabel";
            iD_покупателяLabel.Size = new System.Drawing.Size(82, 13);
            iD_покупателяLabel.TabIndex = 3;
            iD_покупателяLabel.Text = "ID покупателя:";
            // 
            // название_препаратаLabel
            // 
            название_препаратаLabel.AutoSize = true;
            название_препаратаLabel.Location = new System.Drawing.Point(12, 91);
            название_препаратаLabel.Name = "название_препаратаLabel";
            название_препаратаLabel.Size = new System.Drawing.Size(116, 13);
            название_препаратаLabel.TabIndex = 5;
            название_препаратаLabel.Text = "Название препарата:";
            // 
            // дата_оформленияLabel
            // 
            дата_оформленияLabel.AutoSize = true;
            дата_оформленияLabel.Location = new System.Drawing.Point(12, 118);
            дата_оформленияLabel.Name = "дата_оформленияLabel";
            дата_оформленияLabel.Size = new System.Drawing.Size(103, 13);
            дата_оформленияLabel.TabIndex = 7;
            дата_оформленияLabel.Text = "Дата оформления:";
            // 
            // фИО_врачаLabel
            // 
            фИО_врачаLabel.AutoSize = true;
            фИО_врачаLabel.Location = new System.Drawing.Point(12, 143);
            фИО_врачаLabel.Name = "фИО_врачаLabel";
            фИО_врачаLabel.Size = new System.Drawing.Size(69, 13);
            фИО_врачаLabel.TabIndex = 9;
            фИО_врачаLabel.Text = "ФИО врача:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рецептыBindingSource
            // 
            this.рецептыBindingSource.DataMember = "Рецепты";
            this.рецептыBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // рецептыTableAdapter
            // 
            this.рецептыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Pharmacy.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детали_заказовTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПрепаратыTableAdapter = null;
            this.tableAdapterManager.РецептыTableAdapter = this.рецептыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // рецептыBindingNavigator
            // 
            this.рецептыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.рецептыBindingNavigator.BindingSource = this.рецептыBindingSource;
            this.рецептыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.рецептыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.рецептыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.рецептыBindingNavigatorSaveItem});
            this.рецептыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.рецептыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.рецептыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.рецептыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.рецептыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.рецептыBindingNavigator.Name = "рецептыBindingNavigator";
            this.рецептыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.рецептыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.рецептыBindingNavigator.TabIndex = 0;
            this.рецептыBindingNavigator.Text = "bindingNavigator1";
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
            // рецептыBindingNavigatorSaveItem
            // 
            this.рецептыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.рецептыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("рецептыBindingNavigatorSaveItem.Image")));
            this.рецептыBindingNavigatorSaveItem.Name = "рецептыBindingNavigatorSaveItem";
            this.рецептыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.рецептыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.рецептыBindingNavigatorSaveItem.Click += new System.EventHandler(this.рецептыBindingNavigatorSaveItem_Click);
            // 
            // iD_рецептаTextBox
            // 
            this.iD_рецептаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рецептыBindingSource, "ID_рецепта", true));
            this.iD_рецептаTextBox.Location = new System.Drawing.Point(134, 36);
            this.iD_рецептаTextBox.Name = "iD_рецептаTextBox";
            this.iD_рецептаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_рецептаTextBox.TabIndex = 2;
            // 
            // iD_покупателяTextBox
            // 
            this.iD_покупателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рецептыBindingSource, "ID_покупателя", true));
            this.iD_покупателяTextBox.Location = new System.Drawing.Point(134, 62);
            this.iD_покупателяTextBox.Name = "iD_покупателяTextBox";
            this.iD_покупателяTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_покупателяTextBox.TabIndex = 4;
            // 
            // название_препаратаTextBox
            // 
            this.название_препаратаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рецептыBindingSource, "Название_препарата", true));
            this.название_препаратаTextBox.Location = new System.Drawing.Point(134, 88);
            this.название_препаратаTextBox.Name = "название_препаратаTextBox";
            this.название_препаратаTextBox.Size = new System.Drawing.Size(200, 20);
            this.название_препаратаTextBox.TabIndex = 6;
            // 
            // дата_оформленияDateTimePicker
            // 
            this.дата_оформленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.рецептыBindingSource, "Дата_оформления", true));
            this.дата_оформленияDateTimePicker.Location = new System.Drawing.Point(134, 114);
            this.дата_оформленияDateTimePicker.Name = "дата_оформленияDateTimePicker";
            this.дата_оформленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_оформленияDateTimePicker.TabIndex = 8;
            // 
            // фИО_врачаTextBox
            // 
            this.фИО_врачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рецептыBindingSource, "ФИО_врача", true));
            this.фИО_врачаTextBox.Location = new System.Drawing.Point(134, 140);
            this.фИО_врачаTextBox.Name = "фИО_врачаTextBox";
            this.фИО_врачаTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИО_врачаTextBox.TabIndex = 10;
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(340, 60);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(109, 23);
            this.buttonCustomer.TabIndex = 11;
            this.buttonCustomer.Text = "Покупатель";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // покупательLabel
            // 
            покупательLabel.AutoSize = true;
            покупательLabel.Location = new System.Drawing.Point(340, 39);
            покупательLabel.Name = "покупательLabel";
            покупательLabel.Size = new System.Drawing.Size(70, 13);
            покупательLabel.TabIndex = 12;
            покупательLabel.Text = "Покупатель:";
            // 
            // покупательLabel1
            // 
            this.покупательLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.покупательLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рецептыBindingSource, "Покупатель", true));
            this.покупательLabel1.Location = new System.Drawing.Point(416, 39);
            this.покупательLabel1.Name = "покупательLabel1";
            this.покупательLabel1.Size = new System.Drawing.Size(372, 17);
            this.покупательLabel1.TabIndex = 13;
            this.покупательLabel1.Text = "label1";
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // FormRecipesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(покупательLabel);
            this.Controls.Add(this.покупательLabel1);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(iD_рецептаLabel);
            this.Controls.Add(this.iD_рецептаTextBox);
            this.Controls.Add(iD_покупателяLabel);
            this.Controls.Add(this.iD_покупателяTextBox);
            this.Controls.Add(название_препаратаLabel);
            this.Controls.Add(this.название_препаратаTextBox);
            this.Controls.Add(дата_оформленияLabel);
            this.Controls.Add(this.дата_оформленияDateTimePicker);
            this.Controls.Add(фИО_врачаLabel);
            this.Controls.Add(this.фИО_врачаTextBox);
            this.Controls.Add(this.рецептыBindingNavigator);
            this.Name = "FormRecipesList";
            this.Text = "Рецепты";
            this.Load += new System.EventHandler(this.FormRecipesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептыBindingNavigator)).EndInit();
            this.рецептыBindingNavigator.ResumeLayout(false);
            this.рецептыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource рецептыBindingSource;
        private PharmacyDataSetTableAdapters.РецептыTableAdapter рецептыTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator рецептыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton рецептыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_рецептаTextBox;
        private System.Windows.Forms.TextBox iD_покупателяTextBox;
        private System.Windows.Forms.TextBox название_препаратаTextBox;
        private System.Windows.Forms.DateTimePicker дата_оформленияDateTimePicker;
        private System.Windows.Forms.TextBox фИО_врачаTextBox;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Label покупательLabel1;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private PharmacyDataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
    }
}