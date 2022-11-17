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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_list_colors = new System.Windows.Forms.Button();
            this.button_list_contract = new System.Windows.Forms.Button();
            this.button_list_places = new System.Windows.Forms.Button();
            this.button_list_rates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_list_rentors
            // 
            this.button_list_rentors.Location = new System.Drawing.Point(12, 12);
            this.button_list_rentors.Name = "button_list_rentors";
            this.button_list_rentors.Size = new System.Drawing.Size(261, 46);
            this.button_list_rentors.TabIndex = 0;
            this.button_list_rentors.Text = "СПИСОК КЛИЕНТОВ";
            this.button_list_rentors.UseVisualStyleBackColor = true;
            this.button_list_rentors.Click += new System.EventHandler(this.button_list_rentors_Click);
            // 
            // button_list_cars
            // 
            this.button_list_cars.Location = new System.Drawing.Point(12, 64);
            this.button_list_cars.Name = "button_list_cars";
            this.button_list_cars.Size = new System.Drawing.Size(261, 46);
            this.button_list_cars.TabIndex = 1;
            this.button_list_cars.Text = "СПИСОК АВТОМОБИЛЕЙ";
            this.button_list_cars.UseVisualStyleBackColor = true;
            this.button_list_cars.Click += new System.EventHandler(this.button_list_cars_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "JOIN запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_list_colors
            // 
            this.button_list_colors.Location = new System.Drawing.Point(12, 116);
            this.button_list_colors.Name = "button_list_colors";
            this.button_list_colors.Size = new System.Drawing.Size(261, 46);
            this.button_list_colors.TabIndex = 4;
            this.button_list_colors.Text = "СПИСОК ЦВЕТОВ";
            this.button_list_colors.UseVisualStyleBackColor = true;
            this.button_list_colors.Click += new System.EventHandler(this.button_list_colors_Click);
            // 
            // button_list_contract
            // 
            this.button_list_contract.Location = new System.Drawing.Point(279, 12);
            this.button_list_contract.Name = "button_list_contract";
            this.button_list_contract.Size = new System.Drawing.Size(261, 46);
            this.button_list_contract.TabIndex = 5;
            this.button_list_contract.Text = "СПИСОК КОНТРАКТОВ";
            this.button_list_contract.UseVisualStyleBackColor = true;
            this.button_list_contract.Click += new System.EventHandler(this.button_list_contract_Click);
            // 
            // button_list_places
            // 
            this.button_list_places.Location = new System.Drawing.Point(280, 64);
            this.button_list_places.Name = "button_list_places";
            this.button_list_places.Size = new System.Drawing.Size(260, 46);
            this.button_list_places.TabIndex = 6;
            this.button_list_places.Text = "СПИСОК ПАРКОВОЧНЫХ МЕСТ";
            this.button_list_places.UseVisualStyleBackColor = true;
            this.button_list_places.Click += new System.EventHandler(this.button_list_places_Click);
            // 
            // button_list_rates
            // 
            this.button_list_rates.Location = new System.Drawing.Point(280, 116);
            this.button_list_rates.Name = "button_list_rates";
            this.button_list_rates.Size = new System.Drawing.Size(260, 46);
            this.button_list_rates.TabIndex = 7;
            this.button_list_rates.Text = "СПИСОК ТАРИФОВ";
            this.button_list_rates.UseVisualStyleBackColor = true;
            this.button_list_rates.Click += new System.EventHandler(this.button_list_rates_Click);
            // 
            // FormAllLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_list_rates);
            this.Controls.Add(this.button_list_places);
            this.Controls.Add(this.button_list_contract);
            this.Controls.Add(this.button_list_colors);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_list_cars);
            this.Controls.Add(this.button_list_rentors);
            this.Name = "FormAllLists";
            this.Text = "ВСЕ СПИСКИ";
            this.Load += new System.EventHandler(this.FormAllLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_list_rentors;
        private System.Windows.Forms.Button button_list_cars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_list_colors;
        private System.Windows.Forms.Button button_list_contract;
        private System.Windows.Forms.Button button_list_places;
        private System.Windows.Forms.Button button_list_rates;
    }
}