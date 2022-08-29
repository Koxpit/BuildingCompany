namespace BuildingCompany
{
    partial class MaterialsForm
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
            this.buttonOpenUseOfMaterialsForm = new System.Windows.Forms.Button();
            this.dataGridViewMeterials = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxUnitOfMeasure = new System.Windows.Forms.TextBox();
            this.labelUnitOfMeasure = new System.Windows.Forms.Label();
            this.toolTipMaterialsForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeterials)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenUseOfMaterialsForm
            // 
            this.buttonOpenUseOfMaterialsForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenUseOfMaterialsForm.Location = new System.Drawing.Point(655, 390);
            this.buttonOpenUseOfMaterialsForm.Name = "buttonOpenUseOfMaterialsForm";
            this.buttonOpenUseOfMaterialsForm.Size = new System.Drawing.Size(123, 38);
            this.buttonOpenUseOfMaterialsForm.TabIndex = 0;
            this.buttonOpenUseOfMaterialsForm.Text = "Используемые материалы";
            this.buttonOpenUseOfMaterialsForm.UseVisualStyleBackColor = false;
            this.buttonOpenUseOfMaterialsForm.Click += new System.EventHandler(this.buttonOpenUseOfMaterialsForm_Click);
            // 
            // dataGridViewMeterials
            // 
            this.dataGridViewMeterials.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMeterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMeterials.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMeterials.MultiSelect = false;
            this.dataGridViewMeterials.Name = "dataGridViewMeterials";
            this.dataGridViewMeterials.ReadOnly = true;
            this.dataGridViewMeterials.Size = new System.Drawing.Size(800, 357);
            this.dataGridViewMeterials.TabIndex = 1;
            this.dataGridViewMeterials.SelectionChanged += new System.EventHandler(this.dataGridViewMeterials_SelectionChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(22, 400);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 384);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Наименование";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(269, 400);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(361, 400);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(452, 400);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxUnitOfMeasure
            // 
            this.textBoxUnitOfMeasure.Location = new System.Drawing.Point(143, 400);
            this.textBoxUnitOfMeasure.Name = "textBoxUnitOfMeasure";
            this.textBoxUnitOfMeasure.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitOfMeasure.TabIndex = 31;
            // 
            // labelUnitOfMeasure
            // 
            this.labelUnitOfMeasure.AutoSize = true;
            this.labelUnitOfMeasure.Location = new System.Drawing.Point(143, 384);
            this.labelUnitOfMeasure.Name = "labelUnitOfMeasure";
            this.labelUnitOfMeasure.Size = new System.Drawing.Size(111, 13);
            this.labelUnitOfMeasure.TabIndex = 32;
            this.labelUnitOfMeasure.Text = "Единицы измерения";
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUnitOfMeasure);
            this.Controls.Add(this.textBoxUnitOfMeasure);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewMeterials);
            this.Controls.Add(this.buttonOpenUseOfMaterialsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaterialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenUseOfMaterialsForm;
        private System.Windows.Forms.DataGridView dataGridViewMeterials;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxUnitOfMeasure;
        private System.Windows.Forms.Label labelUnitOfMeasure;
        private System.Windows.Forms.ToolTip toolTipMaterialsForm;
    }
}