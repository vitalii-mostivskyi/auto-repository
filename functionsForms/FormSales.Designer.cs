namespace car_shop_administrative__program.UI.functionsForms
{
    partial class FormSales
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
            this.dataGridViewAllSales = new System.Windows.Forms.DataGridView();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModelMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSuccess = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnPerformOrder = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllSales
            // 
            this.dataGridViewAllSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUserName,
            this.ColumnModelMark,
            this.ColumnOrderDate,
            this.ColumnCount,
            this.ColumnPrice,
            this.ColumSum,
            this.ColumnSuccess,
            this.ColumnPerformOrder,
            this.Id});
            this.dataGridViewAllSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllSales.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllSales.Name = "dataGridViewAllSales";
            this.dataGridViewAllSales.ReadOnly = true;
            this.dataGridViewAllSales.RowTemplate.Height = 24;
            this.dataGridViewAllSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllSales.Size = new System.Drawing.Size(1071, 479);
            this.dataGridViewAllSales.TabIndex = 0;
            this.dataGridViewAllSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllSales_CellContentClick);
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnUserName.HeaderText = "Ім\'я та прізвище покупця";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            this.ColumnUserName.Width = 179;
            // 
            // ColumnModelMark
            // 
            this.ColumnModelMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModelMark.HeaderText = "Модель та марка авто";
            this.ColumnModelMark.Name = "ColumnModelMark";
            this.ColumnModelMark.ReadOnly = true;
            // 
            // ColumnOrderDate
            // 
            this.ColumnOrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnOrderDate.HeaderText = "Дата покупки";
            this.ColumnOrderDate.Name = "ColumnOrderDate";
            this.ColumnOrderDate.ReadOnly = true;
            this.ColumnOrderDate.Width = 114;
            // 
            // ColumnCount
            // 
            this.ColumnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCount.HeaderText = "Кількість";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Width = 91;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPrice.HeaderText = "Ціна";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 63;
            // 
            // ColumSum
            // 
            this.ColumSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumSum.HeaderText = "Сума";
            this.ColumSum.Name = "ColumSum";
            this.ColumSum.ReadOnly = true;
            this.ColumSum.Width = 66;
            // 
            // ColumnSuccess
            // 
            this.ColumnSuccess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSuccess.HeaderText = "Оформлена";
            this.ColumnSuccess.Name = "ColumnSuccess";
            this.ColumnSuccess.ReadOnly = true;
            this.ColumnSuccess.Width = 93;
            // 
            // ColumnPerformOrder
            // 
            this.ColumnPerformOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPerformOrder.HeaderText = "Оформити покупку";
            this.ColumnPerformOrder.Name = "ColumnPerformOrder";
            this.ColumnPerformOrder.ReadOnly = true;
            this.ColumnPerformOrder.Width = 126;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 479);
            this.Controls.Add(this.dataGridViewAllSales);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSales_FormClosed);
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModelMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumSum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSuccess;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnPerformOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}