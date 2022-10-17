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
            this.dataGridView_List__rentors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List__rentors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_List__rentors
            // 
            this.dataGridView_List__rentors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List__rentors.Location = new System.Drawing.Point(2, 1);
            this.dataGridView_List__rentors.Name = "dataGridView_List__rentors";
            this.dataGridView_List__rentors.Size = new System.Drawing.Size(711, 345);
            this.dataGridView_List__rentors.TabIndex = 0;
            this.dataGridView_List__rentors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List__rentors_CellContentClick);
            // 
            // FormListRentors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_List__rentors);
            this.Name = "FormListRentors";
            this.Text = "СПИСОК КЛИЕНТОВ";
            this.Load += new System.EventHandler(this.FormListRentors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List__rentors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_List__rentors;
    }
}