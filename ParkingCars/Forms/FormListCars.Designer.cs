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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_list_cars = new System.Windows.Forms.DataGridView();
            this.button_add_car = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumberCar = new System.Windows.Forms.TextBox();
            this.textBoxMarkCar = new System.Windows.Forms.TextBox();
            this.textBoxModelCar = new System.Windows.Forms.TextBox();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.parkingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.colorsTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxIdCar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxColorCar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list_cars
            // 
            this.dataGridView_list_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_cars.Location = new System.Drawing.Point(1, 3);
            this.dataGridView_list_cars.Name = "dataGridView_list_cars";
            this.dataGridView_list_cars.Size = new System.Drawing.Size(614, 196);
            this.dataGridView_list_cars.TabIndex = 0;
            this.dataGridView_list_cars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_cars_CellClick);
            this.dataGridView_list_cars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_cars_CellContentClick);
            // 
            // button_add_car
            // 
            this.button_add_car.Location = new System.Drawing.Point(311, 248);
            this.button_add_car.Name = "button_add_car";
            this.button_add_car.Size = new System.Drawing.Size(115, 35);
            this.button_add_car.TabIndex = 2;
            this.button_add_car.Text = "Добавить";
            this.button_add_car.UseVisualStyleBackColor = true;
            this.button_add_car.Click += new System.EventHandler(this.button_add_car_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "НОМЕР АВТО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "МАРКА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "МОДЕЛЬ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ЦВЕТ";
            // 
            // textBoxNumberCar
            // 
            this.textBoxNumberCar.Location = new System.Drawing.Point(118, 256);
            this.textBoxNumberCar.Name = "textBoxNumberCar";
            this.textBoxNumberCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberCar.TabIndex = 7;
            // 
            // textBoxMarkCar
            // 
            this.textBoxMarkCar.Location = new System.Drawing.Point(118, 282);
            this.textBoxMarkCar.Name = "textBoxMarkCar";
            this.textBoxMarkCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarkCar.TabIndex = 8;
            // 
            // textBoxModelCar
            // 
            this.textBoxModelCar.Location = new System.Drawing.Point(118, 308);
            this.textBoxModelCar.Name = "textBoxModelCar";
            this.textBoxModelCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelCar.TabIndex = 9;
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "colors";
            this.colorsBindingSource.DataSource = this.parkingDataSet;
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingDataSetBindingSource
            // 
            this.parkingDataSetBindingSource.DataSource = this.parkingDataSet;
            this.parkingDataSetBindingSource.Position = 0;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 334);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxIdCar
            // 
            this.textBoxIdCar.Location = new System.Drawing.Point(118, 230);
            this.textBoxIdCar.Name = "textBoxIdCar";
            this.textBoxIdCar.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID авто";
            // 
            // textBoxValid
            // 
            this.textBoxValid.Location = new System.Drawing.Point(118, 360);
            this.textBoxValid.Name = "textBoxValid";
            this.textBoxValid.Size = new System.Drawing.Size(100, 20);
            this.textBoxValid.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Валидность";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Выгрузить в Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxColorCar
            // 
            this.comboBoxColorCar.FormattingEnabled = true;
            this.comboBoxColorCar.Location = new System.Drawing.Point(97, 406);
            this.comboBoxColorCar.Name = "comboBoxColorCar";
            this.comboBoxColorCar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColorCar.TabIndex = 17;
            // 
            // FormListCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.comboBoxColorCar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxValid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIdCar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxModelCar);
            this.Controls.Add(this.textBoxMarkCar);
            this.Controls.Add(this.textBoxNumberCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add_car);
            this.Controls.Add(this.dataGridView_list_cars);
            this.Name = "FormListCars";
            this.Text = "СПИСОК АВТОМОБИЛЕЙ";
            this.Load += new System.EventHandler(this.FormListCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_list_cars;
        private System.Windows.Forms.Button button_add_car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumberCar;
        private System.Windows.Forms.TextBox textBoxMarkCar;
        private System.Windows.Forms.TextBox textBoxModelCar;
        private System.Windows.Forms.BindingSource parkingDataSetBindingSource;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private ParkingDataSetTableAdapters.colorsTableAdapter colorsTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxIdCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxColorCar;
    }
}