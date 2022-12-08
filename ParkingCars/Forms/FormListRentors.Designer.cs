namespace ParkingCars.Forms
{
    partial class FormListRentors
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
            System.Windows.Forms.Label Валидность;
            this.dataGridView_List__rentors = new System.Windows.Forms.DataGridView();
            this.textBoxRentor_id = new System.Windows.Forms.TextBox();
            this.textBoxRentorSurname = new System.Windows.Forms.TextBox();
            this.textBoxRentorName = new System.Windows.Forms.TextBox();
            this.textBoxRentorMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxRentorNumber = new System.Windows.Forms.TextBox();
            this.textBoxRentorCar_id = new System.Windows.Forms.TextBox();
            this.textBoxRentorContractId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            Валидность = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List__rentors)).BeginInit();
            this.SuspendLayout();
            // 
            // Валидность
            // 
            Валидность.AutoSize = true;
            Валидность.Location = new System.Drawing.Point(14, 407);
            Валидность.Name = "Валидность";
            Валидность.Size = new System.Drawing.Size(67, 13);
            Валидность.TabIndex = 16;
            Валидность.Text = "Валидность";
            // 
            // dataGridView_List__rentors
            // 
            this.dataGridView_List__rentors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List__rentors.Location = new System.Drawing.Point(2, 1);
            this.dataGridView_List__rentors.Name = "dataGridView_List__rentors";
            this.dataGridView_List__rentors.Size = new System.Drawing.Size(656, 203);
            this.dataGridView_List__rentors.TabIndex = 0;
            this.dataGridView_List__rentors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List__rentors_CellClick);
            this.dataGridView_List__rentors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List__rentors_CellContentClick);
            // 
            // textBoxRentor_id
            // 
            this.textBoxRentor_id.Location = new System.Drawing.Point(100, 219);
            this.textBoxRentor_id.Name = "textBoxRentor_id";
            this.textBoxRentor_id.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentor_id.TabIndex = 1;
            // 
            // textBoxRentorSurname
            // 
            this.textBoxRentorSurname.Location = new System.Drawing.Point(100, 245);
            this.textBoxRentorSurname.Name = "textBoxRentorSurname";
            this.textBoxRentorSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentorSurname.TabIndex = 2;
            // 
            // textBoxRentorName
            // 
            this.textBoxRentorName.Location = new System.Drawing.Point(100, 297);
            this.textBoxRentorName.Name = "textBoxRentorName";
            this.textBoxRentorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentorName.TabIndex = 3;
            // 
            // textBoxRentorMiddleName
            // 
            this.textBoxRentorMiddleName.Location = new System.Drawing.Point(100, 271);
            this.textBoxRentorMiddleName.Name = "textBoxRentorMiddleName";
            this.textBoxRentorMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentorMiddleName.TabIndex = 4;
            // 
            // textBoxRentorNumber
            // 
            this.textBoxRentorNumber.Location = new System.Drawing.Point(100, 323);
            this.textBoxRentorNumber.Name = "textBoxRentorNumber";
            this.textBoxRentorNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentorNumber.TabIndex = 5;
            // 
            // textBoxRentorCar_id
            // 
            this.textBoxRentorCar_id.Location = new System.Drawing.Point(100, 349);
            this.textBoxRentorCar_id.Name = "textBoxRentorCar_id";
            this.textBoxRentorCar_id.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentorCar_id.TabIndex = 6;
            // 
            // textBoxRentorContractId
            // 
            this.textBoxRentorContractId.Location = new System.Drawing.Point(100, 375);
            this.textBoxRentorContractId.Name = "textBoxRentorContractId";
            this.textBoxRentorContractId.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentorContractId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID автомобиля";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Договора";
            // 
            // textBoxValid
            // 
            this.textBoxValid.Location = new System.Drawing.Point(100, 401);
            this.textBoxValid.Name = "textBoxValid";
            this.textBoxValid.Size = new System.Drawing.Size(100, 20);
            this.textBoxValid.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 39);
            this.button2.TabIndex = 21;
            this.button2.Text = "Выгрузить в Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FormListRentors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(Валидность);
            this.Controls.Add(this.textBoxValid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRentorContractId);
            this.Controls.Add(this.textBoxRentorCar_id);
            this.Controls.Add(this.textBoxRentorNumber);
            this.Controls.Add(this.textBoxRentorMiddleName);
            this.Controls.Add(this.textBoxRentorName);
            this.Controls.Add(this.textBoxRentorSurname);
            this.Controls.Add(this.textBoxRentor_id);
            this.Controls.Add(this.dataGridView_List__rentors);
            this.Name = "FormListRentors";
            this.Text = "СПИСОК КЛИЕНТОВ";
            this.Load += new System.EventHandler(this.FormListRentors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List__rentors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_List__rentors;
        private System.Windows.Forms.TextBox textBoxRentor_id;
        private System.Windows.Forms.TextBox textBoxRentorSurname;
        private System.Windows.Forms.TextBox textBoxRentorName;
        private System.Windows.Forms.TextBox textBoxRentorMiddleName;
        private System.Windows.Forms.TextBox textBoxRentorNumber;
        private System.Windows.Forms.TextBox textBoxRentorCar_id;
        private System.Windows.Forms.TextBox textBoxRentorContractId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}