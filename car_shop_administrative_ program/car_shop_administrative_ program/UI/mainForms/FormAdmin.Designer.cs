namespace car_shop_administrative__program.UI
{
    partial class FormAdmin
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
            this.buttonAllsales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCars
            // 
            this.buttonCars.Location = new System.Drawing.Point(12, 12);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(405, 57);
            this.buttonCars.TabIndex = 0;
            this.buttonCars.Text = "Автомобілі";
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // buttonAllsales
            // 
            this.buttonAllsales.Location = new System.Drawing.Point(12, 84);
            this.buttonAllsales.Name = "buttonAllsales";
            this.buttonAllsales.Size = new System.Drawing.Size(405, 60);
            this.buttonAllsales.TabIndex = 1;
            this.buttonAllsales.Text = "Продані товари та товар для покупки";
            this.buttonAllsales.UseVisualStyleBackColor = true;
            this.buttonAllsales.Click += new System.EventHandler(this.buttonAllsales_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 165);
            this.Controls.Add(this.buttonAllsales);
            this.Controls.Add(this.buttonCars);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonAllsales;
    }
}