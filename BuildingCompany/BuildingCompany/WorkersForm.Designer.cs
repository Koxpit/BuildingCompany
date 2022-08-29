namespace BuildingCompany
{
    partial class WorkersForm
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
            this.buttonOpenProfessionsForm = new System.Windows.Forms.Button();
            this.buttonOpenProfessionsWorkersForm = new System.Windows.Forms.Button();
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.toolTipWorkersForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenProfessionsForm
            // 
            this.buttonOpenProfessionsForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenProfessionsForm.Location = new System.Drawing.Point(677, 406);
            this.buttonOpenProfessionsForm.Name = "buttonOpenProfessionsForm";
            this.buttonOpenProfessionsForm.Size = new System.Drawing.Size(111, 32);
            this.buttonOpenProfessionsForm.TabIndex = 0;
            this.buttonOpenProfessionsForm.Text = "Все профессии";
            this.buttonOpenProfessionsForm.UseVisualStyleBackColor = false;
            this.buttonOpenProfessionsForm.Click += new System.EventHandler(this.buttonOpenProfessionsForm_Click);
            // 
            // buttonOpenProfessionsWorkersForm
            // 
            this.buttonOpenProfessionsWorkersForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenProfessionsWorkersForm.Location = new System.Drawing.Point(677, 351);
            this.buttonOpenProfessionsWorkersForm.Name = "buttonOpenProfessionsWorkersForm";
            this.buttonOpenProfessionsWorkersForm.Size = new System.Drawing.Size(111, 39);
            this.buttonOpenProfessionsWorkersForm.TabIndex = 1;
            this.buttonOpenProfessionsWorkersForm.Text = "Профессии рабочих";
            this.buttonOpenProfessionsWorkersForm.UseVisualStyleBackColor = false;
            this.buttonOpenProfessionsWorkersForm.Click += new System.EventHandler(this.buttonOpenProfessionsWorkersForm_Click);
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWorkers.MultiSelect = false;
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.ReadOnly = true;
            this.dataGridViewWorkers.Size = new System.Drawing.Size(800, 324);
            this.dataGridViewWorkers.TabIndex = 2;
            this.dataGridViewWorkers.SelectionChanged += new System.EventHandler(this.dataGridViewWorkers_SelectionChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(559, 377);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(559, 412);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(478, 392);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(217, 361);
            this.textBoxComment.MaxLength = 300;
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(237, 77);
            this.textBoxComment.TabIndex = 21;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(12, 413);
            this.textBoxPhoneNumber.MaxLength = 11;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(132, 20);
            this.textBoxPhoneNumber.TabIndex = 22;
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(12, 361);
            this.textBoxFIO.MaxLength = 100;
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(182, 20);
            this.textBoxFIO.TabIndex = 23;
            this.textBoxFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFIO_KeyPress);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(214, 345);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(77, 13);
            this.labelComment.TabIndex = 24;
            this.labelComment.Text = "Комментарий";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(12, 397);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 25;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(9, 345);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 26;
            this.labelFIO.Text = "ФИО";
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewWorkers);
            this.Controls.Add(this.buttonOpenProfessionsWorkersForm);
            this.Controls.Add(this.buttonOpenProfessionsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочие";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenProfessionsForm;
        private System.Windows.Forms.Button buttonOpenProfessionsWorkersForm;
        private System.Windows.Forms.DataGridView dataGridViewWorkers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.ToolTip toolTipWorkersForm;
    }
}