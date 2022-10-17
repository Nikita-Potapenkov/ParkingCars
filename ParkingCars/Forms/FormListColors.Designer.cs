namespace ParkingCars.Forms
{
    partial class FormListColors
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
            this.dataGridView_list_colors = new System.Windows.Forms.DataGridView();
            this.button_on_all_colors = new System.Windows.Forms.Button();
            this.button_add_colors = new System.Windows.Forms.Button();
            this.textBox_new_color = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_colors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list_colors
            // 
            this.dataGridView_list_colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_colors.Location = new System.Drawing.Point(12, 45);
            this.dataGridView_list_colors.Name = "dataGridView_list_colors";
            this.dataGridView_list_colors.Size = new System.Drawing.Size(541, 209);
            this.dataGridView_list_colors.TabIndex = 0;
            // 
            // button_on_all_colors
            // 
            this.button_on_all_colors.Location = new System.Drawing.Point(638, 112);
            this.button_on_all_colors.Name = "button_on_all_colors";
            this.button_on_all_colors.Size = new System.Drawing.Size(136, 23);
            this.button_on_all_colors.TabIndex = 1;
            this.button_on_all_colors.Text = "Вывести все цвета";
            this.button_on_all_colors.UseVisualStyleBackColor = true;
            this.button_on_all_colors.Click += new System.EventHandler(this.button_on_all_colors_Click);
            // 
            // button_add_colors
            // 
            this.button_add_colors.Location = new System.Drawing.Point(671, 352);
            this.button_add_colors.Name = "button_add_colors";
            this.button_add_colors.Size = new System.Drawing.Size(75, 23);
            this.button_add_colors.TabIndex = 2;
            this.button_add_colors.Text = "ДОБАВИТЬ ";
            this.button_add_colors.UseVisualStyleBackColor = true;
            this.button_add_colors.Click += new System.EventHandler(this.button_add_colors_Click);
            // 
            // textBox_new_color
            // 
            this.textBox_new_color.Location = new System.Drawing.Point(395, 354);
            this.textBox_new_color.Name = "textBox_new_color";
            this.textBox_new_color.Size = new System.Drawing.Size(100, 20);
            this.textBox_new_color.TabIndex = 3;
            this.textBox_new_color.TextChanged += new System.EventHandler(this.textBox_new_color_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ЦВЕТ";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(638, 163);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 301);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FormListColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_new_color);
            this.Controls.Add(this.button_add_colors);
            this.Controls.Add(this.button_on_all_colors);
            this.Controls.Add(this.dataGridView_list_colors);
            this.Name = "FormListColors";
            this.Text = "FormListColors";
            this.Load += new System.EventHandler(this.FormListColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_colors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_list_colors;
        private System.Windows.Forms.Button button_on_all_colors;
        private System.Windows.Forms.Button button_add_colors;
        private System.Windows.Forms.TextBox textBox_new_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}