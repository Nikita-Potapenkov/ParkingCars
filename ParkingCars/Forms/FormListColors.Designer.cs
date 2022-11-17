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
            this.button_add_colors = new System.Windows.Forms.Button();
            this.textBox_new_color = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDColors = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_colors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list_colors
            // 
            this.dataGridView_list_colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_colors.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_list_colors.Name = "dataGridView_list_colors";
            this.dataGridView_list_colors.Size = new System.Drawing.Size(238, 302);
            this.dataGridView_list_colors.TabIndex = 0;
            this.dataGridView_list_colors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_colors_CellClick);
            // 
            // button_add_colors
            // 
            this.button_add_colors.Location = new System.Drawing.Point(266, 140);
            this.button_add_colors.Name = "button_add_colors";
            this.button_add_colors.Size = new System.Drawing.Size(136, 23);
            this.button_add_colors.TabIndex = 2;
            this.button_add_colors.Text = "Добавить";
            this.button_add_colors.UseVisualStyleBackColor = true;
            this.button_add_colors.Click += new System.EventHandler(this.button_add_colors_Click);
            // 
            // textBox_new_color
            // 
            this.textBox_new_color.Location = new System.Drawing.Point(302, 101);
            this.textBox_new_color.Name = "textBox_new_color";
            this.textBox_new_color.Size = new System.Drawing.Size(100, 20);
            this.textBox_new_color.TabIndex = 3;
            this.textBox_new_color.TextChanged += new System.EventHandler(this.textBox_new_color_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ЦВЕТ";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(247, 12);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(136, 23);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Цвета";
            // 
            // textBoxIDColors
            // 
            this.textBoxIDColors.Location = new System.Drawing.Point(302, 66);
            this.textBoxIDColors.Name = "textBoxIDColors";
            this.textBoxIDColors.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDColors.TabIndex = 7;
            this.textBoxIDColors.TextChanged += new System.EventHandler(this.textBoxIDColors_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormListColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 308);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIDColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_new_color);
            this.Controls.Add(this.button_add_colors);
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
        private System.Windows.Forms.Button button_add_colors;
        private System.Windows.Forms.TextBox textBox_new_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDColors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}