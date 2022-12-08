namespace ParkingCars.Forms
{
    partial class FormAllLists
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
            this.button_list_rentors = new System.Windows.Forms.Button();
            this.button_list_cars = new System.Windows.Forms.Button();
            this.button_list_colors = new System.Windows.Forms.Button();
            this.button_list_contract = new System.Windows.Forms.Button();
            this.button_list_places = new System.Windows.Forms.Button();
            this.button_list_rates = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_list_rentors
            // 
            this.button_list_rentors.Location = new System.Drawing.Point(1, 39);
            this.button_list_rentors.Name = "button_list_rentors";
            this.button_list_rentors.Size = new System.Drawing.Size(374, 61);
            this.button_list_rentors.TabIndex = 0;
            this.button_list_rentors.Text = "СПИСОК КЛИЕНТОВ";
            this.button_list_rentors.UseVisualStyleBackColor = true;
            this.button_list_rentors.Click += new System.EventHandler(this.button_list_rentors_Click);
            // 
            // button_list_cars
            // 
            this.button_list_cars.Location = new System.Drawing.Point(1, 121);
            this.button_list_cars.Name = "button_list_cars";
            this.button_list_cars.Size = new System.Drawing.Size(374, 67);
            this.button_list_cars.TabIndex = 1;
            this.button_list_cars.Text = "СПИСОК АВТОМОБИЛЕЙ";
            this.button_list_cars.UseVisualStyleBackColor = true;
            this.button_list_cars.Click += new System.EventHandler(this.button_list_cars_Click);
            // 
            // button_list_colors
            // 
            this.button_list_colors.Location = new System.Drawing.Point(1, 219);
            this.button_list_colors.Name = "button_list_colors";
            this.button_list_colors.Size = new System.Drawing.Size(374, 63);
            this.button_list_colors.TabIndex = 4;
            this.button_list_colors.Text = "СПИСОК ЦВЕТОВ";
            this.button_list_colors.UseVisualStyleBackColor = true;
            this.button_list_colors.Click += new System.EventHandler(this.button_list_colors_Click);
            // 
            // button_list_contract
            // 
            this.button_list_contract.Location = new System.Drawing.Point(398, 39);
            this.button_list_contract.Name = "button_list_contract";
            this.button_list_contract.Size = new System.Drawing.Size(400, 61);
            this.button_list_contract.TabIndex = 5;
            this.button_list_contract.Text = "СПИСОК КОНТРАКТОВ";
            this.button_list_contract.UseVisualStyleBackColor = true;
            this.button_list_contract.Click += new System.EventHandler(this.button_list_contract_Click);
            // 
            // button_list_places
            // 
            this.button_list_places.Location = new System.Drawing.Point(398, 121);
            this.button_list_places.Name = "button_list_places";
            this.button_list_places.Size = new System.Drawing.Size(400, 67);
            this.button_list_places.TabIndex = 6;
            this.button_list_places.Text = "СПИСОК ПАРКОВОЧНЫХ МЕСТ";
            this.button_list_places.UseVisualStyleBackColor = true;
            this.button_list_places.Click += new System.EventHandler(this.button_list_places_Click);
            // 
            // button_list_rates
            // 
            this.button_list_rates.Location = new System.Drawing.Point(398, 219);
            this.button_list_rates.Name = "button_list_rates";
            this.button_list_rates.Size = new System.Drawing.Size(400, 63);
            this.button_list_rates.TabIndex = 7;
            this.button_list_rates.Text = "СПИСОК ТАРИФОВ";
            this.button_list_rates.UseVisualStyleBackColor = true;
            this.button_list_rates.Click += new System.EventHandler(this.button_list_rates_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "НОВЫЙ ПОЛЬЗОВАТЕЛЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAllLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_list_rates);
            this.Controls.Add(this.button_list_places);
            this.Controls.Add(this.button_list_contract);
            this.Controls.Add(this.button_list_colors);
            this.Controls.Add(this.button_list_cars);
            this.Controls.Add(this.button_list_rentors);
            this.Name = "FormAllLists";
            this.Text = "ВСЕ СПИСКИ";
            this.Load += new System.EventHandler(this.FormAllLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_list_rentors;
        private System.Windows.Forms.Button button_list_cars;
        private System.Windows.Forms.Button button_list_colors;
        private System.Windows.Forms.Button button_list_contract;
        private System.Windows.Forms.Button button_list_places;
        private System.Windows.Forms.Button button_list_rates;
        private System.Windows.Forms.Button button1;
    }
}