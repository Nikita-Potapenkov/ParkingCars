namespace ParkingCars
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_all_lists = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_all_lists
            // 
            this.button_all_lists.Location = new System.Drawing.Point(46, 147);
            this.button_all_lists.Name = "button_all_lists";
            this.button_all_lists.Size = new System.Drawing.Size(219, 46);
            this.button_all_lists.TabIndex = 0;
            this.button_all_lists.Text = "Списки";
            this.button_all_lists.UseVisualStyleBackColor = true;
            this.button_all_lists.Click += new System.EventHandler(this.button_all_lists_Click);
            // 
            // button_reports
            // 
            this.button_reports.Location = new System.Drawing.Point(493, 147);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(219, 46);
            this.button_reports.TabIndex = 1;
            this.button_reports.Text = "Отчеты";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_all_lists);
            this.Name = "FormMainMenu";
            this.Text = "Основное Меню";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_all_lists;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

