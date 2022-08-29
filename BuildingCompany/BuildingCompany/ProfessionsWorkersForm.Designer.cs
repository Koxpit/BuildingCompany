namespace BuildingCompany
{
    partial class ProfessionsWorkersForm
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
            this.dataGridViewProfessionsWorkers = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelWorkerID = new System.Windows.Forms.Label();
            this.labelProfessionId = new System.Windows.Forms.Label();
            this.textBoxProfessionId = new System.Windows.Forms.TextBox();
            this.textBoxWorkerID = new System.Windows.Forms.TextBox();
            this.toolTipProfessionsWorkersForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessionsWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfessionsWorkers
            // 
            this.dataGridViewProfessionsWorkers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProfessionsWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessionsWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProfessionsWorkers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProfessionsWorkers.MultiSelect = false;
            this.dataGridViewProfessionsWorkers.Name = "dataGridViewProfessionsWorkers";
            this.dataGridViewProfessionsWorkers.ReadOnly = true;
            this.dataGridViewProfessionsWorkers.Size = new System.Drawing.Size(800, 369);
            this.dataGridViewProfessionsWorkers.TabIndex = 0;
            this.dataGridViewProfessionsWorkers.SelectionChanged += new System.EventHandler(this.dataGridViewProfessionsWorkers_SelectionChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(324, 405);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(430, 405);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(531, 405);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelWorkerID
            // 
            this.labelWorkerID.AutoSize = true;
            this.labelWorkerID.Location = new System.Drawing.Point(12, 389);
            this.labelWorkerID.Name = "labelWorkerID";
            this.labelWorkerID.Size = new System.Drawing.Size(67, 13);
            this.labelWorkerID.TabIndex = 21;
            this.labelWorkerID.Text = "ID рабочего";
            // 
            // labelProfessionId
            // 
            this.labelProfessionId.AutoSize = true;
            this.labelProfessionId.Location = new System.Drawing.Point(159, 389);
            this.labelProfessionId.Name = "labelProfessionId";
            this.labelProfessionId.Size = new System.Drawing.Size(98, 13);
            this.labelProfessionId.TabIndex = 20;
            this.labelProfessionId.Text = "ID специальности";
            // 
            // textBoxProfessionId
            // 
            this.textBoxProfessionId.Location = new System.Drawing.Point(162, 408);
            this.textBoxProfessionId.Name = "textBoxProfessionId";
            this.textBoxProfessionId.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfessionId.TabIndex = 19;
            this.textBoxProfessionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProfessionId_KeyPress);
            // 
            // textBoxWorkerID
            // 
            this.textBoxWorkerID.Location = new System.Drawing.Point(12, 408);
            this.textBoxWorkerID.MaxLength = 100;
            this.textBoxWorkerID.Name = "textBoxWorkerID";
            this.textBoxWorkerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxWorkerID.TabIndex = 18;
            this.textBoxWorkerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWorkerID_KeyPress);
            // 
            // ProfessionsWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelWorkerID);
            this.Controls.Add(this.labelProfessionId);
            this.Controls.Add(this.textBoxProfessionId);
            this.Controls.Add(this.textBoxWorkerID);
            this.Controls.Add(this.dataGridViewProfessionsWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProfessionsWorkersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профессии рабочих";
            this.Load += new System.EventHandler(this.ProfessionsWorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessionsWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfessionsWorkers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelWorkerID;
        private System.Windows.Forms.Label labelProfessionId;
        private System.Windows.Forms.TextBox textBoxProfessionId;
        private System.Windows.Forms.TextBox textBoxWorkerID;
        private System.Windows.Forms.ToolTip toolTipProfessionsWorkersForm;
    }
}