namespace ParkingCars.Forms
{
    partial class FormListRates
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
            this.dataGridView_list_rates = new System.Windows.Forms.DataGridView();
            this.button_add_colors = new System.Windows.Forms.Button();
            this.textBoxNameRate = new System.Windows.Forms.TextBox();
            this.textBoxPriceRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdPlace = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_rates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list_rates
            // 
            this.dataGridView_list_rates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_rates.Location = new System.Drawing.Point(12, 25);
            this.dataGridView_list_rates.Name = "dataGridView_list_rates";
            this.dataGridView_list_rates.Size = new System.Drawing.Size(364, 150);
            this.dataGridView_list_rates.TabIndex = 0;
            this.dataGridView_list_rates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_rates_CellClick);
            // 
            // button_add_colors
            // 
            this.button_add_colors.Location = new System.Drawing.Point(326, 187);
            this.button_add_colors.Name = "button_add_colors";
            this.button_add_colors.Size = new System.Drawing.Size(131, 23);
            this.button_add_colors.TabIndex = 2;
            this.button_add_colors.Text = "Новая запись";
            this.button_add_colors.UseVisualStyleBackColor = true;
            this.button_add_colors.Click += new System.EventHandler(this.button_add_colors_Click);
            // 
            // textBoxNameRate
            // 
            this.textBoxNameRate.Location = new System.Drawing.Point(115, 213);
            this.textBoxNameRate.Name = "textBoxNameRate";
            this.textBoxNameRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameRate.TabIndex = 3;
            // 
            // textBoxPriceRate
            // 
            this.textBoxPriceRate.Location = new System.Drawing.Point(115, 239);
            this.textBoxPriceRate.Name = "textBoxPriceRate";
            this.textBoxPriceRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceRate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название тарифа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxIdPlace
            // 
            this.textBoxIdPlace.Location = new System.Drawing.Point(115, 187);
            this.textBoxIdPlace.Name = "textBoxIdPlace";
            this.textBoxIdPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdPlace.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 197);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(15, 13);
            this.ID.TabIndex = 8;
            this.ID.Text = "id";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 20);
            this.button3.TabIndex = 11;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormListRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 279);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBoxIdPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPriceRate);
            this.Controls.Add(this.textBoxNameRate);
            this.Controls.Add(this.button_add_colors);
            this.Controls.Add(this.dataGridView_list_rates);
            this.Name = "FormListRates";
            this.Text = "FormRates";
            this.Load += new System.EventHandler(this.FormListRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_rates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_list_rates;
        private System.Windows.Forms.Button button_add_colors;
        private System.Windows.Forms.TextBox textBoxNameRate;
        private System.Windows.Forms.TextBox textBoxPriceRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdPlace;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}