using System.Windows.Forms;

namespace Pharmacy
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReferenceBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPreparations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRecipes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemContextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextReferenceBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextPreparations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextRecipes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEmployees = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPreparations = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRecipes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItemQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemReferenceBooks,
            this.toolStripMenuItemDocuments});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemQuery});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExit.Image")));
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemExit.Text = "Выход";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAbout.Image")));
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemAbout.Text = "О программе...";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemReferenceBooks
            // 
            this.toolStripMenuItemReferenceBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCustomers,
            this.toolStripMenuItemEmployees,
            this.toolStripMenuItemPreparations});
            this.toolStripMenuItemReferenceBooks.Name = "toolStripMenuItemReferenceBooks";
            this.toolStripMenuItemReferenceBooks.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItemReferenceBooks.Text = "Справочники";
            // 
            // toolStripMenuItemCustomers
            // 
            this.toolStripMenuItemCustomers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCustomers.Image")));
            this.toolStripMenuItemCustomers.Name = "toolStripMenuItemCustomers";
            this.toolStripMenuItemCustomers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.toolStripMenuItemCustomers.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemCustomers.Text = "Покупатели";
            this.toolStripMenuItemCustomers.Click += new System.EventHandler(this.toolStripMenuItemCustomers_Click);
            // 
            // toolStripMenuItemEmployees
            // 
            this.toolStripMenuItemEmployees.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEmployees.Image")));
            this.toolStripMenuItemEmployees.Name = "toolStripMenuItemEmployees";
            this.toolStripMenuItemEmployees.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.toolStripMenuItemEmployees.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemEmployees.Text = "Сотрудники";
            this.toolStripMenuItemEmployees.Click += new System.EventHandler(this.toolStripMenuItemEmployees_Click);
            // 
            // toolStripMenuItemPreparations
            // 
            this.toolStripMenuItemPreparations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPreparations.Image")));
            this.toolStripMenuItemPreparations.Name = "toolStripMenuItemPreparations";
            this.toolStripMenuItemPreparations.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItemPreparations.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemPreparations.Text = "Препараты";
            this.toolStripMenuItemPreparations.Click += new System.EventHandler(this.toolStripMenuItemPreparations_Click);
            // 
            // toolStripMenuItemDocuments
            // 
            this.toolStripMenuItemDocuments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRecipes,
            this.toolStripMenuItemOrders});
            this.toolStripMenuItemDocuments.Name = "toolStripMenuItemDocuments";
            this.toolStripMenuItemDocuments.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItemDocuments.Text = "Документы";
            // 
            // toolStripMenuItemRecipes
            // 
            this.toolStripMenuItemRecipes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemRecipes.Image")));
            this.toolStripMenuItemRecipes.Name = "toolStripMenuItemRecipes";
            this.toolStripMenuItemRecipes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItemRecipes.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRecipes.Text = "Рецепты";
            this.toolStripMenuItemRecipes.Click += new System.EventHandler(this.toolStripMenuItemRecipes_Click);
            // 
            // toolStripMenuItemOrders
            // 
            this.toolStripMenuItemOrders.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemOrders.Image")));
            this.toolStripMenuItemOrders.Name = "toolStripMenuItemOrders";
            this.toolStripMenuItemOrders.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItemOrders.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOrders.Text = "Заказы";
            this.toolStripMenuItemOrders.Click += new System.EventHandler(this.toolStripMenuItemOrders_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemContextFile,
            this.toolStripMenuItemContextReferenceBooks,
            this.toolStripMenuItemContextDocuments});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(150, 70);
            // 
            // toolStripMenuItemContextFile
            // 
            this.toolStripMenuItemContextFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemContextExit,
            this.toolStripMenuItemContextAbout});
            this.toolStripMenuItemContextFile.Name = "toolStripMenuItemContextFile";
            this.toolStripMenuItemContextFile.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemContextFile.Text = "Файл";
            // 
            // toolStripMenuItemContextExit
            // 
            this.toolStripMenuItemContextExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemContextExit.Image")));
            this.toolStripMenuItemContextExit.Name = "toolStripMenuItemContextExit";
            this.toolStripMenuItemContextExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItemContextExit.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemContextExit.Text = "Выход";
            this.toolStripMenuItemContextExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemContextAbout
            // 
            this.toolStripMenuItemContextAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemContextAbout.Image")));
            this.toolStripMenuItemContextAbout.Name = "toolStripMenuItemContextAbout";
            this.toolStripMenuItemContextAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItemContextAbout.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemContextAbout.Text = "О программе...";
            this.toolStripMenuItemContextAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemContextReferenceBooks
            // 
            this.toolStripMenuItemContextReferenceBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemContextCustomers,
            this.toolStripMenuItemContextEmployees,
            this.toolStripMenuItemContextPreparations});
            this.toolStripMenuItemContextReferenceBooks.Name = "toolStripMenuItemContextReferenceBooks";
            this.toolStripMenuItemContextReferenceBooks.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemContextReferenceBooks.Text = "Справочники";
            // 
            // toolStripMenuItemContextCustomers
            // 
            this.toolStripMenuItemContextCustomers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemContextCustomers.Image")));
            this.toolStripMenuItemContextCustomers.Name = "toolStripMenuItemContextCustomers";
            this.toolStripMenuItemContextCustomers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.toolStripMenuItemContextCustomers.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemContextCustomers.Text = "Покупатели";
            this.toolStripMenuItemContextCustomers.Click += new System.EventHandler(this.toolStripMenuItemCustomers_Click);
            // 
            // toolStripMenuItemContextEmployees
            // 
            this.toolStripMenuItemContextEmployees.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemContextEmployees.Image")));
            this.toolStripMenuItemContextEmployees.Name = "toolStripMenuItemContextEmployees";
            this.toolStripMenuItemContextEmployees.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.toolStripMenuItemContextEmployees.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemContextEmployees.Text = "Сотрудники";
            this.toolStripMenuItemContextEmployees.Click += new System.EventHandler(this.toolStripMenuItemEmployees_Click);
            // 
            // toolStripMenuItemContextPreparations
            // 
            this.toolStripMenuItemContextPreparations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemContextPreparations.Image")));
            this.toolStripMenuItemContextPreparations.Name = "toolStripMenuItemContextPreparations";
            this.toolStripMenuItemContextPreparations.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItemContextPreparations.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemContextPreparations.Text = "Препараты";
            this.toolStripMenuItemContextPreparations.Click += new System.EventHandler(this.toolStripMenuItemPreparations_Click);
            // 
            // toolStripMenuItemContextDocuments
            // 
            this.toolStripMenuItemContextDocuments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemContextRecipes,
            this.toolStripMenuItemContextOrders});
            this.toolStripMenuItemContextDocuments.Name = "toolStripMenuItemContextDocuments";
            this.toolStripMenuItemContextDocuments.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemContextDocuments.Text = "Документы";
            // 
            // toolStripMenuItemContextRecipes
            // 
            this.toolStripMenuItemContextRecipes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemContextRecipes.Image")));
            this.toolStripMenuItemContextRecipes.Name = "toolStripMenuItemContextRecipes";
            this.toolStripMenuItemContextRecipes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItemContextRecipes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItemContextRecipes.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemContextRecipes.Text = "Рецепты";
            this.toolStripMenuItemContextRecipes.Click += new System.EventHandler(this.toolStripMenuItemRecipes_Click);
            // 
            // toolStripMenuItemContextOrders
            // 
            this.toolStripMenuItemContextOrders.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemContextOrders.Image")));
            this.toolStripMenuItemContextOrders.Name = "toolStripMenuItemContextOrders";
            this.toolStripMenuItemContextOrders.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItemContextOrders.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItemContextOrders.Text = "Заказы";
            this.toolStripMenuItemContextOrders.Click += new System.EventHandler(this.toolStripMenuItemOrders_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExit,
            this.toolStripButtonAbout,
            this.toolStripButtonCustomers,
            this.toolStripButtonEmployees,
            this.toolStripButtonPreparations,
            this.toolStripButtonRecipes,
            this.toolStripButtonOrder});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Text = "toolStripButton1";
            this.toolStripButtonExit.ToolTipText = "Выход";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAbout.Text = "О программе...";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripButtonCustomers
            // 
            this.toolStripButtonCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCustomers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCustomers.Image")));
            this.toolStripButtonCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomers.Name = "toolStripButtonCustomers";
            this.toolStripButtonCustomers.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCustomers.Text = "Покупатели";
            this.toolStripButtonCustomers.Click += new System.EventHandler(this.toolStripMenuItemCustomers_Click);
            // 
            // toolStripButtonEmployees
            // 
            this.toolStripButtonEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEmployees.Image")));
            this.toolStripButtonEmployees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEmployees.Name = "toolStripButtonEmployees";
            this.toolStripButtonEmployees.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEmployees.Text = "Сотрудники";
            this.toolStripButtonEmployees.Click += new System.EventHandler(this.toolStripMenuItemEmployees_Click);
            // 
            // toolStripButtonPreparations
            // 
            this.toolStripButtonPreparations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPreparations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPreparations.Image")));
            this.toolStripButtonPreparations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPreparations.Name = "toolStripButtonPreparations";
            this.toolStripButtonPreparations.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPreparations.Text = "Препараты";
            this.toolStripButtonPreparations.Click += new System.EventHandler(this.toolStripMenuItemPreparations_Click);
            // 
            // toolStripButtonRecipes
            // 
            this.toolStripButtonRecipes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRecipes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRecipes.Image")));
            this.toolStripButtonRecipes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRecipes.Name = "toolStripButtonRecipes";
            this.toolStripButtonRecipes.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRecipes.Text = "Рецепты";
            this.toolStripButtonRecipes.Click += new System.EventHandler(this.toolStripMenuItemRecipes_Click);
            // 
            // toolStripButtonOrder
            // 
            this.toolStripButtonOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOrder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOrder.Image")));
            this.toolStripButtonOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOrder.Name = "toolStripButtonOrder";
            this.toolStripButtonOrder.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOrder.Text = "Заказы";
            this.toolStripButtonOrder.Click += new System.EventHandler(this.toolStripMenuItemOrders_Click);
            // 
            // toolStripMenuItemQuery
            // 
            this.toolStripMenuItemQuery.Name = "toolStripMenuItemQuery";
            this.toolStripMenuItemQuery.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItemQuery.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemQuery.Text = "Запросы";
            this.toolStripMenuItemQuery.Click += new System.EventHandler(this.toolStripMenuItemQuery_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Pharmacy.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::Pharmacy.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Программа для аптеки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReferenceBooks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEmployees;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextReferenceBooks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextCustomers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextEmployees;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonCustomers;
        private System.Windows.Forms.ToolStripButton toolStripButtonEmployees;
        private ToolStripMenuItem toolStripMenuItemDocuments;
        private ToolStripMenuItem toolStripMenuItemRecipes;
        private ToolStripMenuItem toolStripMenuItemOrders;
        private ToolStripMenuItem toolStripMenuItemContextDocuments;
        private ToolStripMenuItem toolStripMenuItemContextRecipes;
        private ToolStripButton toolStripButtonRecipes;
        private ToolStripMenuItem toolStripMenuItemPreparations;
        private ToolStripMenuItem toolStripMenuItemContextPreparations;
        private ToolStripButton toolStripButtonPreparations;
        private ToolStripMenuItem toolStripMenuItemContextOrders;
        private ToolStripButton toolStripButtonOrder;
        private ToolStripMenuItem toolStripMenuItemQuery;
    }
}

