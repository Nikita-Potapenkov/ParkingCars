﻿namespace ParkingCars.Forms
{
    partial class FormListContracts
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
            this.dataGridView_list_contracts = new System.Windows.Forms.DataGridView();
            this.button_add_contracts = new System.Windows.Forms.Button();
            this.textBoxNumCont = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdCont = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBoxValid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_contracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list_contracts
            // 
            this.dataGridView_list_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list_contracts.Location = new System.Drawing.Point(0, -1);
            this.dataGridView_list_contracts.Name = "dataGridView_list_contracts";
            this.dataGridView_list_contracts.Size = new System.Drawing.Size(788, 174);
            this.dataGridView_list_contracts.TabIndex = 0;
            this.dataGridView_list_contracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_contracts_CellClick);
            // 
            // button_add_contracts
            // 
            this.button_add_contracts.Location = new System.Drawing.Point(490, 223);
            this.button_add_contracts.Name = "button_add_contracts";
            this.button_add_contracts.Size = new System.Drawing.Size(127, 42);
            this.button_add_contracts.TabIndex = 2;
            this.button_add_contracts.Text = "Добавить ";
            this.button_add_contracts.UseVisualStyleBackColor = true;
            this.button_add_contracts.Click += new System.EventHandler(this.button_add_contracts_Click);
            // 
            // textBoxNumCont
            // 
            this.textBoxNumCont.Location = new System.Drawing.Point(169, 235);
            this.textBoxNumCont.Name = "textBoxNumCont";
            this.textBoxNumCont.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumCont.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 287);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "НОМЕР ДОГОВОРА";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(169, 339);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlace.TabIndex = 8;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(169, 365);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "МЕСТО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ТАРИФ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "id";
            // 
            // textBoxIdCont
            // 
            this.textBoxIdCont.Location = new System.Drawing.Point(169, 209);
            this.textBoxIdCont.Name = "textBoxIdCont";
            this.textBoxIdCont.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCont.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата заключения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата начала";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата след оплаты";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(169, 313);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 17;
            // 
            // textBoxValid
            // 
            this.textBoxValid.Location = new System.Drawing.Point(169, 392);
            this.textBoxValid.Name = "textBoxValid";
            this.textBoxValid.Size = new System.Drawing.Size(100, 20);
            this.textBoxValid.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Валидноть";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Выгрузить в Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxValid);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIdCont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxNumCont);
            this.Controls.Add(this.button_add_contracts);
            this.Controls.Add(this.dataGridView_list_contracts);
            this.Name = "FormListContracts";
            this.Text = "FormListContracts";
            this.Load += new System.EventHandler(this.FormListContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list_contracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_list_contracts;
        private System.Windows.Forms.Button button_add_contracts;
        private System.Windows.Forms.TextBox textBoxNumCont;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdCont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBoxValid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}