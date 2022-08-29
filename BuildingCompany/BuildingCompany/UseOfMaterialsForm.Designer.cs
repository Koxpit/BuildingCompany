namespace BuildingCompany
{
    partial class UseOfMaterialsForm
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
            this.dataGridViewUseOfMaterials = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxIdMaterial = new System.Windows.Forms.TextBox();
            this.textBoxIdBrigade = new System.Windows.Forms.TextBox();
            this.textBoxIdFacility = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelIdBrigade = new System.Windows.Forms.Label();
            this.labeldMaterial = new System.Windows.Forms.Label();
            this.labelIdFacility = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.toolTipUseOfMaterialsForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUseOfMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUseOfMaterials
            // 
            this.dataGridViewUseOfMaterials.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUseOfMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUseOfMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewUseOfMaterials.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUseOfMaterials.MultiSelect = false;
            this.dataGridViewUseOfMaterials.Name = "dataGridViewUseOfMaterials";
            this.dataGridViewUseOfMaterials.ReadOnly = true;
            this.dataGridViewUseOfMaterials.Size = new System.Drawing.Size(800, 336);
            this.dataGridViewUseOfMaterials.TabIndex = 0;
            this.dataGridViewUseOfMaterials.SelectionChanged += new System.EventHandler(this.dataGridViewUseOfMaterials_SelectionChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(228, 415);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(370, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(514, 415);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 31;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxIdMaterial
            // 
            this.textBoxIdMaterial.Location = new System.Drawing.Point(278, 369);
            this.textBoxIdMaterial.Name = "textBoxIdMaterial";
            this.textBoxIdMaterial.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdMaterial.TabIndex = 34;
            this.textBoxIdMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdMaterial_KeyPress);
            // 
            // textBoxIdBrigade
            // 
            this.textBoxIdBrigade.Location = new System.Drawing.Point(414, 369);
            this.textBoxIdBrigade.Name = "textBoxIdBrigade";
            this.textBoxIdBrigade.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdBrigade.TabIndex = 35;
            this.textBoxIdBrigade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdBrigade_KeyPress);
            // 
            // textBoxIdFacility
            // 
            this.textBoxIdFacility.Location = new System.Drawing.Point(145, 369);
            this.textBoxIdFacility.Name = "textBoxIdFacility";
            this.textBoxIdFacility.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdFacility.TabIndex = 36;
            this.textBoxIdFacility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdFacility_KeyPress);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(551, 369);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 37;
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            // 
            // labelIdBrigade
            // 
            this.labelIdBrigade.AutoSize = true;
            this.labelIdBrigade.Location = new System.Drawing.Point(411, 353);
            this.labelIdBrigade.Name = "labelIdBrigade";
            this.labelIdBrigade.Size = new System.Drawing.Size(64, 13);
            this.labelIdBrigade.TabIndex = 38;
            this.labelIdBrigade.Text = "ID бригады";
            // 
            // labeldMaterial
            // 
            this.labeldMaterial.AutoSize = true;
            this.labeldMaterial.Location = new System.Drawing.Point(275, 353);
            this.labeldMaterial.Name = "labeldMaterial";
            this.labeldMaterial.Size = new System.Drawing.Size(76, 13);
            this.labeldMaterial.TabIndex = 39;
            this.labeldMaterial.Text = "ID материала";
            // 
            // labelIdFacility
            // 
            this.labelIdFacility.AutoSize = true;
            this.labelIdFacility.Location = new System.Drawing.Point(142, 353);
            this.labelIdFacility.Name = "labelIdFacility";
            this.labelIdFacility.Size = new System.Drawing.Size(63, 13);
            this.labelIdFacility.TabIndex = 40;
            this.labelIdFacility.Text = "ID объекта";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(548, 354);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(41, 13);
            this.labelAmount.TabIndex = 41;
            this.labelAmount.Text = "Кол-во";
            // 
            // UseOfMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelIdFacility);
            this.Controls.Add(this.labeldMaterial);
            this.Controls.Add(this.labelIdBrigade);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxIdFacility);
            this.Controls.Add(this.textBoxIdBrigade);
            this.Controls.Add(this.textBoxIdMaterial);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewUseOfMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UseOfMaterialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Используемые материалы";
            this.Load += new System.EventHandler(this.UseOfMaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUseOfMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUseOfMaterials;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxIdMaterial;
        private System.Windows.Forms.TextBox textBoxIdBrigade;
        private System.Windows.Forms.TextBox textBoxIdFacility;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelIdBrigade;
        private System.Windows.Forms.Label labeldMaterial;
        private System.Windows.Forms.Label labelIdFacility;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.ToolTip toolTipUseOfMaterialsForm;
    }
}