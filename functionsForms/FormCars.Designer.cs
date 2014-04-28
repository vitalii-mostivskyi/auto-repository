namespace car_shop_administrative__program.UI.functionsForms
{
    partial class FormCars
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddCar = new System.Windows.Forms.TabPage();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxCreationDate = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAllCars = new System.Windows.Forms.TabPage();
            this.dataGridViewAllCars = new System.Windows.Forms.DataGridView();
            this.ColumnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBoxCategories = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItemAllCars = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAddCar.SuspendLayout();
            this.tabPageAllCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddCar);
            this.tabControl1.Controls.Add(this.tabPageAllCars);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAddCar
            // 
            this.tabPageAddCar.Controls.Add(this.buttonCancelEdit);
            this.tabPageAddCar.Controls.Add(this.buttonAddCar);
            this.tabPageAddCar.Controls.Add(this.richTextBoxDescription);
            this.tabPageAddCar.Controls.Add(this.comboBoxCategory);
            this.tabPageAddCar.Controls.Add(this.textBoxCreationDate);
            this.tabPageAddCar.Controls.Add(this.textBoxCount);
            this.tabPageAddCar.Controls.Add(this.textBoxPrice);
            this.tabPageAddCar.Controls.Add(this.textBoxMarka);
            this.tabPageAddCar.Controls.Add(this.textBoxModel);
            this.tabPageAddCar.Controls.Add(this.label7);
            this.tabPageAddCar.Controls.Add(this.label6);
            this.tabPageAddCar.Controls.Add(this.label5);
            this.tabPageAddCar.Controls.Add(this.label4);
            this.tabPageAddCar.Controls.Add(this.label3);
            this.tabPageAddCar.Controls.Add(this.label2);
            this.tabPageAddCar.Controls.Add(this.label1);
            this.tabPageAddCar.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddCar.Name = "tabPageAddCar";
            this.tabPageAddCar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddCar.Size = new System.Drawing.Size(1003, 499);
            this.tabPageAddCar.TabIndex = 0;
            this.tabPageAddCar.Text = "Add car";
            this.tabPageAddCar.UseVisualStyleBackColor = true;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCar.Location = new System.Drawing.Point(244, 391);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(226, 58);
            this.buttonAddCar.TabIndex = 15;
            this.buttonAddCar.Text = "Додати";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxDescription.Location = new System.Drawing.Point(379, 248);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(360, 114);
            this.richTextBoxDescription.TabIndex = 14;
            this.richTextBoxDescription.Text = "";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategory.DisplayMember = "Text";
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(379, 110);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(360, 24);
            this.comboBoxCategory.TabIndex = 13;
            this.comboBoxCategory.ValueMember = "Value";
            // 
            // textBoxCreationDate
            // 
            this.textBoxCreationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCreationDate.Location = new System.Drawing.Point(379, 212);
            this.textBoxCreationDate.Name = "textBoxCreationDate";
            this.textBoxCreationDate.Size = new System.Drawing.Size(360, 22);
            this.textBoxCreationDate.TabIndex = 12;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCount.Location = new System.Drawing.Point(379, 179);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(360, 22);
            this.textBoxCount.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.Location = new System.Drawing.Point(379, 147);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(360, 22);
            this.textBoxPrice.TabIndex = 10;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMarka.Location = new System.Drawing.Point(379, 77);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(360, 22);
            this.textBoxMarka.TabIndex = 8;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxModel.Location = new System.Drawing.Point(379, 43);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(360, 22);
            this.textBoxModel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата виготовлення";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кількість";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Опис";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категорія";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Марка";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель";
            // 
            // tabPageAllCars
            // 
            this.tabPageAllCars.Controls.Add(this.dataGridViewAllCars);
            this.tabPageAllCars.Controls.Add(this.menuStrip1);
            this.tabPageAllCars.Location = new System.Drawing.Point(4, 25);
            this.tabPageAllCars.Name = "tabPageAllCars";
            this.tabPageAllCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllCars.Size = new System.Drawing.Size(1003, 499);
            this.tabPageAllCars.TabIndex = 1;
            this.tabPageAllCars.Text = "All cars";
            this.tabPageAllCars.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAllCars
            // 
            this.dataGridViewAllCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModel,
            this.ColumnMarka,
            this.ColumnCategory,
            this.ColumnDescription,
            this.ColumnQuantity,
            this.ColumnPrice,
            this.ColumnCreationDate,
            this.ColumnId,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridViewAllCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllCars.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewAllCars.MultiSelect = false;
            this.dataGridViewAllCars.Name = "dataGridViewAllCars";
            this.dataGridViewAllCars.ReadOnly = true;
            this.dataGridViewAllCars.RowTemplate.Height = 24;
            this.dataGridViewAllCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllCars.Size = new System.Drawing.Size(997, 461);
            this.dataGridViewAllCars.TabIndex = 0;
            this.dataGridViewAllCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllCars_CellContentClick);
            this.dataGridViewAllCars.Click += new System.EventHandler(this.dataGridViewAllCars_Click);
            // 
            // ColumnModel
            // 
            this.ColumnModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModel.HeaderText = "Model";
            this.ColumnModel.Name = "ColumnModel";
            this.ColumnModel.ReadOnly = true;
            this.ColumnModel.Width = 71;
            // 
            // ColumnMarka
            // 
            this.ColumnMarka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnMarka.HeaderText = "Marka";
            this.ColumnMarka.Name = "ColumnMarka";
            this.ColumnMarka.ReadOnly = true;
            this.ColumnMarka.Width = 72;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCategory.HeaderText = "Category";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.Width = 90;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 86;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 65;
            // 
            // ColumnCreationDate
            // 
            this.ColumnCreationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCreationDate.HeaderText = "Creation date";
            this.ColumnCreationDate.Name = "ColumnCreationDate";
            this.ColumnCreationDate.ReadOnly = true;
            this.ColumnCreationDate.Width = 118;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEdit.HeaderText = "Edit";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEdit.Width = 57;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Width = 55;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxCategories,
            this.toolStripMenuItemAllCars});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBoxCategories
            // 
            this.toolStripComboBoxCategories.Name = "toolStripComboBoxCategories";
            this.toolStripComboBoxCategories.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxCategories_SelectedIndexChanged);
            // 
            // toolStripMenuItemAllCars
            // 
            this.toolStripMenuItemAllCars.Name = "toolStripMenuItemAllCars";
            this.toolStripMenuItemAllCars.Size = new System.Drawing.Size(41, 28);
            this.toolStripMenuItemAllCars.Text = "Всі";
            this.toolStripMenuItemAllCars.Click += new System.EventHandler(this.toolStripMenuItemAllCars_Click);
            // 
            // comboBoxItemBindingSource
            // 
            this.comboBoxItemBindingSource.DataSource = typeof(car_shop_administrative__program.Model.ComboBoxItem);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(534, 391);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(204, 58);
            this.buttonCancelEdit.TabIndex = 16;
            this.buttonCancelEdit.Text = "Відмінити";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Visible = false;
            this.buttonCancelEdit.Click += new System.EventHandler(this.buttonCancelEdit_Click);
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 528);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCars_FormClosed);
            this.Load += new System.EventHandler(this.FormCars_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddCar.ResumeLayout(false);
            this.tabPageAddCar.PerformLayout();
            this.tabPageAllCars.ResumeLayout(false);
            this.tabPageAllCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAllCars;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxCreationDate;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAllCars;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCategories;
        private System.Windows.Forms.BindingSource comboBoxItemBindingSource;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAllCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
        private System.Windows.Forms.Button buttonCancelEdit;
    }
}