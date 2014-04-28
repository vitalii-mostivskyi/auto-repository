namespace car_shop_administrative__program.UI.functionsForms
{
    partial class FormPerformOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonPerformBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(119, 44);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(186, 22);
            this.textBoxPhone.TabIndex = 1;
            // 
            // buttonPerformBuy
            // 
            this.buttonPerformBuy.Location = new System.Drawing.Point(78, 90);
            this.buttonPerformBuy.Name = "buttonPerformBuy";
            this.buttonPerformBuy.Size = new System.Drawing.Size(185, 43);
            this.buttonPerformBuy.TabIndex = 2;
            this.buttonPerformBuy.Text = "Зв\'язатися з покупцем";
            this.buttonPerformBuy.UseVisualStyleBackColor = true;
            this.buttonPerformBuy.Click += new System.EventHandler(this.buttonPerformBuy_Click);
            // 
            // FormPerformOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 175);
            this.Controls.Add(this.buttonPerformBuy);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Name = "FormPerformOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perform Order Form";
            this.Load += new System.EventHandler(this.FormPerformOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonPerformBuy;
    }
}