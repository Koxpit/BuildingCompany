namespace BuildingCompany
{
    partial class SchedulesForm
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
            this.dataGridViewSchedules = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxIdBrigade = new System.Windows.Forms.TextBox();
            this.textBoxIdFacility = new System.Windows.Forms.TextBox();
            this.textBoxEndingDate = new System.Windows.Forms.TextBox();
            this.textBoxWorkDescription = new System.Windows.Forms.TextBox();
            this.labelIDFacility = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelEndingDate = new System.Windows.Forms.Label();
            this.labelIdBrigade = new System.Windows.Forms.Label();
            this.labelWorkDescription = new System.Windows.Forms.Label();
            this.toolTipSchedules = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxBeginDate = new System.Windows.Forms.TextBox();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.labelBeginDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedules
            // 
            this.dataGridViewSchedules.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSchedules.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSchedules.MultiSelect = false;
            this.dataGridViewSchedules.Name = "dataGridViewSchedules";
            this.dataGridViewSchedules.ReadOnly = true;
            this.dataGridViewSchedules.Size = new System.Drawing.Size(800, 328);
            this.dataGridViewSchedules.TabIndex = 0;
            this.dataGridViewSchedules.SelectionChanged += new System.EventHandler(this.dataGridViewSchedules_SelectionChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(683, 363);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(683, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(683, 438);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(415, 362);
            this.textBoxComment.MaxLength = 300;
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(231, 107);
            this.textBoxComment.TabIndex = 40;
            // 
            // textBoxIdBrigade
            // 
            this.textBoxIdBrigade.Location = new System.Drawing.Point(9, 404);
            this.textBoxIdBrigade.Name = "textBoxIdBrigade";
            this.textBoxIdBrigade.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdBrigade.TabIndex = 41;
            this.textBoxIdBrigade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBoxIdFacility
            // 
            this.textBoxIdFacility.Location = new System.Drawing.Point(9, 362);
            this.textBoxIdFacility.Name = "textBoxIdFacility";
            this.textBoxIdFacility.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdFacility.TabIndex = 42;
            this.textBoxIdFacility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBoxEndingDate
            // 
            this.textBoxEndingDate.Location = new System.Drawing.Point(9, 449);
            this.textBoxEndingDate.MaxLength = 12;
            this.textBoxEndingDate.Name = "textBoxEndingDate";
            this.textBoxEndingDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndingDate.TabIndex = 43;
            // 
            // textBoxWorkDescription
            // 
            this.textBoxWorkDescription.Location = new System.Drawing.Point(134, 362);
            this.textBoxWorkDescription.MaxLength = 500;
            this.textBoxWorkDescription.Multiline = true;
            this.textBoxWorkDescription.Name = "textBoxWorkDescription";
            this.textBoxWorkDescription.Size = new System.Drawing.Size(260, 107);
            this.textBoxWorkDescription.TabIndex = 44;
            // 
            // labelIDFacility
            // 
            this.labelIDFacility.AutoSize = true;
            this.labelIDFacility.Location = new System.Drawing.Point(6, 346);
            this.labelIDFacility.Name = "labelIDFacility";
            this.labelIDFacility.Size = new System.Drawing.Size(63, 13);
            this.labelIDFacility.TabIndex = 45;
            this.labelIDFacility.Text = "ID объекта";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(412, 346);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(77, 13);
            this.labelComment.TabIndex = 46;
            this.labelComment.Text = "Комментарии";
            // 
            // labelEndingDate
            // 
            this.labelEndingDate.AutoSize = true;
            this.labelEndingDate.Location = new System.Drawing.Point(6, 433);
            this.labelEndingDate.Name = "labelEndingDate";
            this.labelEndingDate.Size = new System.Drawing.Size(77, 13);
            this.labelEndingDate.TabIndex = 47;
            this.labelEndingDate.Text = "Крайний срок";
            // 
            // labelIdBrigade
            // 
            this.labelIdBrigade.AutoSize = true;
            this.labelIdBrigade.Location = new System.Drawing.Point(6, 388);
            this.labelIdBrigade.Name = "labelIdBrigade";
            this.labelIdBrigade.Size = new System.Drawing.Size(64, 13);
            this.labelIdBrigade.TabIndex = 48;
            this.labelIdBrigade.Text = "ID бригады";
            // 
            // labelWorkDescription
            // 
            this.labelWorkDescription.AutoSize = true;
            this.labelWorkDescription.Location = new System.Drawing.Point(131, 346);
            this.labelWorkDescription.Name = "labelWorkDescription";
            this.labelWorkDescription.Size = new System.Drawing.Size(97, 13);
            this.labelWorkDescription.TabIndex = 49;
            this.labelWorkDescription.Text = "Описание работы";
            // 
            // textBoxBeginDate
            // 
            this.textBoxBeginDate.Location = new System.Drawing.Point(389, 507);
            this.textBoxBeginDate.MaxLength = 12;
            this.textBoxBeginDate.Name = "textBoxBeginDate";
            this.textBoxBeginDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeginDate.TabIndex = 50;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(546, 507);
            this.textBoxEndDate.MaxLength = 12;
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndDate.TabIndex = 51;
            // 
            // labelBeginDate
            // 
            this.labelBeginDate.AutoSize = true;
            this.labelBeginDate.Location = new System.Drawing.Point(386, 491);
            this.labelBeginDate.Name = "labelBeginDate";
            this.labelBeginDate.Size = new System.Drawing.Size(71, 13);
            this.labelBeginDate.TabIndex = 52;
            this.labelBeginDate.Text = "Дата начала";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(543, 491);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(66, 13);
            this.labelEndDate.TabIndex = 53;
            this.labelEndDate.Text = "Дата конца";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(683, 504);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 54;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // SchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelBeginDate);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.textBoxBeginDate);
            this.Controls.Add(this.labelWorkDescription);
            this.Controls.Add(this.labelIdBrigade);
            this.Controls.Add(this.labelEndingDate);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelIDFacility);
            this.Controls.Add(this.textBoxWorkDescription);
            this.Controls.Add(this.textBoxEndingDate);
            this.Controls.Add(this.textBoxIdFacility);
            this.Controls.Add(this.textBoxIdBrigade);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewSchedules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SchedulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписания работ";
            this.Load += new System.EventHandler(this.SchedulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedules;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxIdBrigade;
        private System.Windows.Forms.TextBox textBoxIdFacility;
        private System.Windows.Forms.TextBox textBoxEndingDate;
        private System.Windows.Forms.TextBox textBoxWorkDescription;
        private System.Windows.Forms.Label labelIDFacility;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelEndingDate;
        private System.Windows.Forms.Label labelIdBrigade;
        private System.Windows.Forms.Label labelWorkDescription;
        private System.Windows.Forms.ToolTip toolTipSchedules;
        private System.Windows.Forms.TextBox textBoxBeginDate;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.Label labelBeginDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonSearch;
    }
}