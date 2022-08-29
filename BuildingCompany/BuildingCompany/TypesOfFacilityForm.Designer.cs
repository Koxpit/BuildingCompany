namespace BuildingCompany
{
    partial class TypesOfFacilityForm
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
            this.dataGridViewTypesOfFacilities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesOfFacilities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTypesOfFacilities
            // 
            this.dataGridViewTypesOfFacilities.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTypesOfFacilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypesOfFacilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTypesOfFacilities.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTypesOfFacilities.MultiSelect = false;
            this.dataGridViewTypesOfFacilities.Name = "dataGridViewTypesOfFacilities";
            this.dataGridViewTypesOfFacilities.ReadOnly = true;
            this.dataGridViewTypesOfFacilities.Size = new System.Drawing.Size(322, 333);
            this.dataGridViewTypesOfFacilities.TabIndex = 0;
            // 
            // TypesOfFacilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 333);
            this.Controls.Add(this.dataGridViewTypesOfFacilities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TypesOfFacilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы объектов";
            this.Load += new System.EventHandler(this.TypesOfFacilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesOfFacilities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTypesOfFacilities;
    }
}