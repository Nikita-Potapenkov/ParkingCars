namespace ParkingCars.Forms
{
    partial class FormListPlaces
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
            this.dataGridView_list_place = new System.Windows.Forms.DataGridView();
            this.button_on_all_places = new System.Windows.Forms.Button();
            this.button_add_place = new System.Windows.Forms.Button();
            this.textBoxParkingPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_place)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list_place
            // 
            this.dataGridView_list_place.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_place.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_list_place.Name = "dataGridView_list_place";
            this.dataGridView_list_place.Size = new System.Drawing.Size(216, 410);
            this.dataGridView_list_place.TabIndex = 0;
            this.dataGridView_list_place.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_place_CellClick);
            this.dataGridView_list_place.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_place_CellContentClick);
            // 
            // button_on_all_places
            // 
            this.button_on_all_places.Location = new System.Drawing.Point(405, 88);
            this.button_on_all_places.Name = "button_on_all_places";
            this.button_on_all_places.Size = new System.Drawing.Size(75, 23);
            this.button_on_all_places.TabIndex = 1;
            this.button_on_all_places.Text = "Вывести все места";
            this.button_on_all_places.UseVisualStyleBackColor = true;
            this.button_on_all_places.Click += new System.EventHandler(this.button_on_all_places_Click);
            // 
            // button_add_place
            // 
            this.button_add_place.Location = new System.Drawing.Point(657, 361);
            this.button_add_place.Name = "button_add_place";
            this.button_add_place.Size = new System.Drawing.Size(75, 23);
            this.button_add_place.TabIndex = 2;
            this.button_add_place.Text = "Добавить";
            this.button_add_place.UseVisualStyleBackColor = true;
            this.button_add_place.Click += new System.EventHandler(this.button_add_place_Click);
            // 
            // textBoxParkingPlace
            // 
            this.textBoxParkingPlace.Location = new System.Drawing.Point(334, 296);
            this.textBoxParkingPlace.Name = "textBoxParkingPlace";
            this.textBoxParkingPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxParkingPlace.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Место";
            // 
            // textBoxIdPlace
            // 
            this.textBoxIdPlace.Location = new System.Drawing.Point(334, 270);
            this.textBoxIdPlace.Name = "textBoxIdPlace";
            this.textBoxIdPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdPlace.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID места";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Валидность";
            // 
            // FormListPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParkingPlace);
            this.Controls.Add(this.button_add_place);
            this.Controls.Add(this.button_on_all_places);
            this.Controls.Add(this.dataGridView_list_place);
            this.Name = "FormListPlaces";
            this.Text = "FormListPlaces";
            this.Load += new System.EventHandler(this.FormListPlaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_place)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_list_place;
        private System.Windows.Forms.Button button_on_all_places;
        private System.Windows.Forms.Button button_add_place;
        private System.Windows.Forms.TextBox textBoxParkingPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}