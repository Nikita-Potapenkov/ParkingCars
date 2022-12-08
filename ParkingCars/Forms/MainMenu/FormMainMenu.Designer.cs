namespace ParkingCars.Forms.MainMenu
{
    partial class FormMainMenu
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
            this.button3 = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_all_lists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Меню работника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_reports
            // 
            this.button_reports.Location = new System.Drawing.Point(580, 202);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(219, 46);
            this.button_reports.TabIndex = 6;
            this.button_reports.Text = "Отчеты";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_all_lists
            // 
            this.button_all_lists.Location = new System.Drawing.Point(1, 202);
            this.button_all_lists.Name = "button_all_lists";
            this.button_all_lists.Size = new System.Drawing.Size(219, 46);
            this.button_all_lists.TabIndex = 5;
            this.button_all_lists.Text = "Списки";
            this.button_all_lists.UseVisualStyleBackColor = true;
            this.button_all_lists.Click += new System.EventHandler(this.button_all_lists_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_all_lists);
            this.Name = "FormMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_all_lists;
    }
}