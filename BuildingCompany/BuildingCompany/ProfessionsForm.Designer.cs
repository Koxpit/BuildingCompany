namespace BuildingCompany
{
    partial class ProfessionsForm
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
            this.dataGridViewProfessions = new System.Windows.Forms.DataGridView();
            this.textBoxProfessionName = new System.Windows.Forms.TextBox();
            this.labelProfessionName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.toolTipProfessionsForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfessions
            // 
            this.dataGridViewProfessions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProfessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProfessions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProfessions.MultiSelect = false;
            this.dataGridViewProfessions.Name = "dataGridViewProfessions";
            this.dataGridViewProfessions.ReadOnly = true;
            this.dataGridViewProfessions.Size = new System.Drawing.Size(269, 331);
            this.dataGridViewProfessions.TabIndex = 0;
            this.dataGridViewProfessions.SelectionChanged += new System.EventHandler(this.dataGridViewProfessions_SelectionChanged);
            // 
            // textBoxProfessionName
            // 
            this.textBoxProfessionName.Location = new System.Drawing.Point(28, 389);
            this.textBoxProfessionName.MaxLength = 100;
            this.textBoxProfessionName.Name = "textBoxProfessionName";
            this.textBoxProfessionName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfessionName.TabIndex = 1;
            this.textBoxProfessionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProfessionName_KeyPress);
            // 
            // labelProfessionName
            // 
            this.labelProfessionName.AutoSize = true;
            this.labelProfessionName.Location = new System.Drawing.Point(25, 373);
            this.labelProfessionName.Name = "labelProfessionName";
            this.labelProfessionName.Size = new System.Drawing.Size(83, 13);
            this.labelProfessionName.TabIndex = 2;
            this.labelProfessionName.Text = "Наименование";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(163, 348);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(163, 386);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(163, 428);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ProfessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 463);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelProfessionName);
            this.Controls.Add(this.textBoxProfessionName);
            this.Controls.Add(this.dataGridViewProfessions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProfessionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessionsForm";
            this.Load += new System.EventHandler(this.ProfessionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfessions;
        private System.Windows.Forms.TextBox textBoxProfessionName;
        private System.Windows.Forms.Label labelProfessionName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolTip toolTipProfessionsForm;
    }
}