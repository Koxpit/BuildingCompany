namespace BuildingCompany
{
    partial class BrigadesForm
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
            this.buttonOpenMembershipBrigadesForm = new System.Windows.Forms.Button();
            this.dataGridViewBrigades = new System.Windows.Forms.DataGridView();
            this.textBoxBrigadeName = new System.Windows.Forms.TextBox();
            this.textBoxBrigadierID = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelBrigadeID = new System.Windows.Forms.Label();
            this.labelBrigadeName = new System.Windows.Forms.Label();
            this.toolTipBrigadesForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrigades)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenMembershipBrigadesForm
            // 
            this.buttonOpenMembershipBrigadesForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenMembershipBrigadesForm.Location = new System.Drawing.Point(675, 363);
            this.buttonOpenMembershipBrigadesForm.Name = "buttonOpenMembershipBrigadesForm";
            this.buttonOpenMembershipBrigadesForm.Size = new System.Drawing.Size(105, 30);
            this.buttonOpenMembershipBrigadesForm.TabIndex = 0;
            this.buttonOpenMembershipBrigadesForm.Text = "Состав бригад";
            this.buttonOpenMembershipBrigadesForm.UseVisualStyleBackColor = false;
            this.buttonOpenMembershipBrigadesForm.Click += new System.EventHandler(this.buttonOpenMembershipBrigadesForm_Click);
            // 
            // dataGridViewBrigades
            // 
            this.dataGridViewBrigades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBrigades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrigades.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewBrigades.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBrigades.MultiSelect = false;
            this.dataGridViewBrigades.Name = "dataGridViewBrigades";
            this.dataGridViewBrigades.ReadOnly = true;
            this.dataGridViewBrigades.Size = new System.Drawing.Size(800, 337);
            this.dataGridViewBrigades.TabIndex = 1;
            this.dataGridViewBrigades.SelectionChanged += new System.EventHandler(this.dataGridViewBrigades_SelectionChanged);
            // 
            // textBoxBrigadeName
            // 
            this.textBoxBrigadeName.Location = new System.Drawing.Point(15, 382);
            this.textBoxBrigadeName.MaxLength = 100;
            this.textBoxBrigadeName.Name = "textBoxBrigadeName";
            this.textBoxBrigadeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrigadeName.TabIndex = 2;
            // 
            // textBoxBrigadierID
            // 
            this.textBoxBrigadierID.Location = new System.Drawing.Point(165, 382);
            this.textBoxBrigadierID.Name = "textBoxBrigadierID";
            this.textBoxBrigadierID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrigadierID.TabIndex = 3;
            this.textBoxBrigadierID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBrigadierID_KeyPress);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(293, 382);
            this.textBoxComment.MaxLength = 300;
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(267, 56);
            this.textBoxComment.TabIndex = 4;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(578, 408);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(578, 379);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(578, 350);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(290, 363);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(77, 13);
            this.labelComment.TabIndex = 8;
            this.labelComment.Text = "Комментарий";
            // 
            // labelBrigadeID
            // 
            this.labelBrigadeID.AutoSize = true;
            this.labelBrigadeID.Location = new System.Drawing.Point(162, 363);
            this.labelBrigadeID.Name = "labelBrigadeID";
            this.labelBrigadeID.Size = new System.Drawing.Size(74, 13);
            this.labelBrigadeID.TabIndex = 9;
            this.labelBrigadeID.Text = "ID бригадира";
            // 
            // labelBrigadeName
            // 
            this.labelBrigadeName.AutoSize = true;
            this.labelBrigadeName.Location = new System.Drawing.Point(15, 363);
            this.labelBrigadeName.Name = "labelBrigadeName";
            this.labelBrigadeName.Size = new System.Drawing.Size(29, 13);
            this.labelBrigadeName.TabIndex = 10;
            this.labelBrigadeName.Text = "Имя";
            // 
            // BrigadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBrigadeName);
            this.Controls.Add(this.labelBrigadeID);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxBrigadierID);
            this.Controls.Add(this.textBoxBrigadeName);
            this.Controls.Add(this.dataGridViewBrigades);
            this.Controls.Add(this.buttonOpenMembershipBrigadesForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BrigadesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бригады";
            this.Load += new System.EventHandler(this.BrigadesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrigades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenMembershipBrigadesForm;
        private System.Windows.Forms.DataGridView dataGridViewBrigades;
        private System.Windows.Forms.TextBox textBoxBrigadeName;
        private System.Windows.Forms.TextBox textBoxBrigadierID;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelBrigadeID;
        private System.Windows.Forms.Label labelBrigadeName;
        private System.Windows.Forms.ToolTip toolTipBrigadesForm;
    }
}