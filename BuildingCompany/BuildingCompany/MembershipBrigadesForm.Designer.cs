namespace BuildingCompany
{
    partial class MembershipBrigadesForm
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
            this.dataGridViewMembershipBrigades = new System.Windows.Forms.DataGridView();
            this.labelWorkerID = new System.Windows.Forms.Label();
            this.labelBrigadeID = new System.Windows.Forms.Label();
            this.textBoxBrigadeID = new System.Windows.Forms.TextBox();
            this.textBoxWorkerID = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.toolTipMembershipBrigadesForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipBrigades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMembershipBrigades
            // 
            this.dataGridViewMembershipBrigades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMembershipBrigades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembershipBrigades.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMembershipBrigades.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMembershipBrigades.MultiSelect = false;
            this.dataGridViewMembershipBrigades.Name = "dataGridViewMembershipBrigades";
            this.dataGridViewMembershipBrigades.ReadOnly = true;
            this.dataGridViewMembershipBrigades.Size = new System.Drawing.Size(800, 358);
            this.dataGridViewMembershipBrigades.TabIndex = 0;
            this.dataGridViewMembershipBrigades.SelectionChanged += new System.EventHandler(this.dataGridViewMembershipBrigades_SelectionChanged);
            // 
            // labelWorkerID
            // 
            this.labelWorkerID.AutoSize = true;
            this.labelWorkerID.Location = new System.Drawing.Point(23, 386);
            this.labelWorkerID.Name = "labelWorkerID";
            this.labelWorkerID.Size = new System.Drawing.Size(67, 13);
            this.labelWorkerID.TabIndex = 14;
            this.labelWorkerID.Text = "ID рабочего";
            // 
            // labelBrigadeID
            // 
            this.labelBrigadeID.AutoSize = true;
            this.labelBrigadeID.Location = new System.Drawing.Point(170, 386);
            this.labelBrigadeID.Name = "labelBrigadeID";
            this.labelBrigadeID.Size = new System.Drawing.Size(64, 13);
            this.labelBrigadeID.TabIndex = 13;
            this.labelBrigadeID.Text = "ID бригады";
            // 
            // textBoxBrigadeID
            // 
            this.textBoxBrigadeID.Location = new System.Drawing.Point(173, 405);
            this.textBoxBrigadeID.Name = "textBoxBrigadeID";
            this.textBoxBrigadeID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrigadeID.TabIndex = 12;
            this.textBoxBrigadeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBrigadeID_KeyPress);
            // 
            // textBoxWorkerID
            // 
            this.textBoxWorkerID.Location = new System.Drawing.Point(23, 405);
            this.textBoxWorkerID.MaxLength = 100;
            this.textBoxWorkerID.Name = "textBoxWorkerID";
            this.textBoxWorkerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxWorkerID.TabIndex = 11;
            this.textBoxWorkerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWorkerID_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(331, 402);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(437, 402);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(538, 402);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // MembershipBrigadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelWorkerID);
            this.Controls.Add(this.labelBrigadeID);
            this.Controls.Add(this.textBoxBrigadeID);
            this.Controls.Add(this.textBoxWorkerID);
            this.Controls.Add(this.dataGridViewMembershipBrigades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MembershipBrigadesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состав бригад";
            this.Load += new System.EventHandler(this.MembershipBrigadesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipBrigades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMembershipBrigades;
        private System.Windows.Forms.Label labelWorkerID;
        private System.Windows.Forms.Label labelBrigadeID;
        private System.Windows.Forms.TextBox textBoxBrigadeID;
        private System.Windows.Forms.TextBox textBoxWorkerID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolTip toolTipMembershipBrigadesForm;
    }
}