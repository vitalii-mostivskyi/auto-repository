namespace car_shop_administrative__program.UI
{
    partial class FormSecretary
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
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonAllSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCars
            // 
            this.buttonCars.Location = new System.Drawing.Point(12, 12);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(405, 57);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Автомобілі";
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // buttonAllSales
            // 
            this.buttonAllSales.Location = new System.Drawing.Point(12, 75);
            this.buttonAllSales.Name = "buttonAllSales";
            this.buttonAllSales.Size = new System.Drawing.Size(405, 58);
            this.buttonAllSales.TabIndex = 2;
            this.buttonAllSales.Text = "Всі продажі";
            this.buttonAllSales.UseVisualStyleBackColor = true;
            this.buttonAllSales.Click += new System.EventHandler(this.buttonAllSales_Click);
            // 
            // FormSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 146);
            this.Controls.Add(this.buttonAllSales);
            this.Controls.Add(this.buttonCars);
            this.Name = "FormSecretary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretary Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSecretary_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonAllSales;
    }
}