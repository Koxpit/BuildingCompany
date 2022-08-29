namespace BuildingCompany
{
    partial class FacilitiesForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonOpenTypesOfFacilityForm = new System.Windows.Forms.Button();
            this.dataGridViewFacilities = new System.Windows.Forms.DataGridView();
            this.textBoxIdTypeOfFacility = new System.Windows.Forms.TextBox();
            this.textBoxAddressFacility = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIdTypeOfFacility = new System.Windows.Forms.Label();
            this.labelFacilityAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.toolTipFacilitiesForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacilities)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenTypesOfFacilityForm
            // 
            this.buttonOpenTypesOfFacilityForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenTypesOfFacilityForm.Location = new System.Drawing.Point(450, 413);
            this.buttonOpenTypesOfFacilityForm.Name = "buttonOpenTypesOfFacilityForm";
            this.buttonOpenTypesOfFacilityForm.Size = new System.Drawing.Size(100, 29);
            this.buttonOpenTypesOfFacilityForm.TabIndex = 0;
            this.buttonOpenTypesOfFacilityForm.Text = "Типы объектов";
            this.buttonOpenTypesOfFacilityForm.UseVisualStyleBackColor = false;
            this.buttonOpenTypesOfFacilityForm.Click += new System.EventHandler(this.buttonOpenTypesOfFacilityForm_Click);
            // 
            // dataGridViewFacilities
            // 
            this.dataGridViewFacilities.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFacilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacilities.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFacilities.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFacilities.MultiSelect = false;
            this.dataGridViewFacilities.Name = "dataGridViewFacilities";
            this.dataGridViewFacilities.ReadOnly = true;
            this.dataGridViewFacilities.Size = new System.Drawing.Size(563, 376);
            this.dataGridViewFacilities.TabIndex = 1;
            this.dataGridViewFacilities.SelectionChanged += new System.EventHandler(this.dataGridViewFacilities_SelectionChanged);
            // 
            // textBoxIdTypeOfFacility
            // 
            this.textBoxIdTypeOfFacility.Location = new System.Drawing.Point(347, 418);
            this.textBoxIdTypeOfFacility.Name = "textBoxIdTypeOfFacility";
            this.textBoxIdTypeOfFacility.Size = new System.Drawing.Size(86, 20);
            this.textBoxIdTypeOfFacility.TabIndex = 2;
            this.textBoxIdTypeOfFacility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdTypeOfFacility_KeyPress);
            // 
            // textBoxAddressFacility
            // 
            this.textBoxAddressFacility.Location = new System.Drawing.Point(137, 418);
            this.textBoxAddressFacility.MaxLength = 100;
            this.textBoxAddressFacility.Name = "textBoxAddressFacility";
            this.textBoxAddressFacility.Size = new System.Drawing.Size(192, 20);
            this.textBoxAddressFacility.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 418);
            this.textBoxName.MaxLength = 150;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // labelIdTypeOfFacility
            // 
            this.labelIdTypeOfFacility.AutoSize = true;
            this.labelIdTypeOfFacility.Location = new System.Drawing.Point(344, 402);
            this.labelIdTypeOfFacility.Name = "labelIdTypeOfFacility";
            this.labelIdTypeOfFacility.Size = new System.Drawing.Size(44, 13);
            this.labelIdTypeOfFacility.TabIndex = 5;
            this.labelIdTypeOfFacility.Text = "ID типа";
            // 
            // labelFacilityAddress
            // 
            this.labelFacilityAddress.AutoSize = true;
            this.labelFacilityAddress.Location = new System.Drawing.Point(134, 402);
            this.labelFacilityAddress.Name = "labelFacilityAddress";
            this.labelFacilityAddress.Size = new System.Drawing.Size(83, 13);
            this.labelFacilityAddress.TabIndex = 6;
            this.labelFacilityAddress.Text = "Адрес объекта";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 402);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Наименование";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(87, 451);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(229, 451);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(373, 451);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 34;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FacilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 486);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFacilityAddress);
            this.Controls.Add(this.labelIdTypeOfFacility);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAddressFacility);
            this.Controls.Add(this.textBoxIdTypeOfFacility);
            this.Controls.Add(this.dataGridViewFacilities);
            this.Controls.Add(this.buttonOpenTypesOfFacilityForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FacilitiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты";
            this.Load += new System.EventHandler(this.FacilitiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacilities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenTypesOfFacilityForm;
        private System.Windows.Forms.DataGridView dataGridViewFacilities;
        private System.Windows.Forms.TextBox textBoxIdTypeOfFacility;
        private System.Windows.Forms.TextBox textBoxAddressFacility;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelIdTypeOfFacility;
        private System.Windows.Forms.Label labelFacilityAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolTip toolTipFacilitiesForm;
    }
}