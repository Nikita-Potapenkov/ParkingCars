namespace ParkingCars.Forms
{
    partial class FormListCars
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
            this.dataGridView_list_cars = new System.Windows.Forms.DataGridView();
            this.button_on_all_cars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_cars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list_cars
            // 
            this.dataGridView_list_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_cars.Location = new System.Drawing.Point(1, 3);
            this.dataGridView_list_cars.Name = "dataGridView_list_cars";
            this.dataGridView_list_cars.Size = new System.Drawing.Size(692, 333);
            this.dataGridView_list_cars.TabIndex = 0;
            this.dataGridView_list_cars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_cars_CellContentClick);
            // 
            // button_on_all_cars
            // 
            this.button_on_all_cars.Location = new System.Drawing.Point(699, 69);
            this.button_on_all_cars.Name = "button_on_all_cars";
            this.button_on_all_cars.Size = new System.Drawing.Size(89, 37);
            this.button_on_all_cars.TabIndex = 1;
            this.button_on_all_cars.Text = "Вывести все автомобили";
            this.button_on_all_cars.UseVisualStyleBackColor = true;
            this.button_on_all_cars.Click += new System.EventHandler(this.button_on_all_cars_Click);
            // 
            // FormListCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_on_all_cars);
            this.Controls.Add(this.dataGridView_list_cars);
            this.Name = "FormListCars";
            this.Text = "СПИСОК АВТОМОБИЛЕЙ";
            this.Load += new System.EventHandler(this.FormListCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_cars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_list_cars;
        private System.Windows.Forms.Button button_on_all_cars;
    }
}