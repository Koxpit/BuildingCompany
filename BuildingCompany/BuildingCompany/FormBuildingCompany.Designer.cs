namespace BuildingCompany
{
    partial class FormBuildingCompany
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuildingCompany));
            this.menuStripBuildingCompany = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рабочиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewCurrentWorks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripBuildingCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripBuildingCompany
            // 
            this.menuStripBuildingCompany.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStripBuildingCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.данныеToolStripMenuItem});
            this.menuStripBuildingCompany.Location = new System.Drawing.Point(0, 0);
            this.menuStripBuildingCompany.Name = "menuStripBuildingCompany";
            this.menuStripBuildingCompany.Size = new System.Drawing.Size(800, 24);
            this.menuStripBuildingCompany.TabIndex = 0;
            this.menuStripBuildingCompany.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бригадыToolStripMenuItem,
            this.рабочиеToolStripMenuItem,
            this.материалыToolStripMenuItem,
            this.объектыToolStripMenuItem,
            this.расписаниеToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // бригадыToolStripMenuItem
            // 
            this.бригадыToolStripMenuItem.Name = "бригадыToolStripMenuItem";
            this.бригадыToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.бригадыToolStripMenuItem.Text = "Бригады";
            this.бригадыToolStripMenuItem.Click += new System.EventHandler(this.бригадыToolStripMenuItem_Click);
            // 
            // рабочиеToolStripMenuItem
            // 
            this.рабочиеToolStripMenuItem.Name = "рабочиеToolStripMenuItem";
            this.рабочиеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.рабочиеToolStripMenuItem.Text = "Рабочие";
            this.рабочиеToolStripMenuItem.Click += new System.EventHandler(this.рабочиеToolStripMenuItem_Click);
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.материалыToolStripMenuItem.Text = "Материалы";
            this.материалыToolStripMenuItem.Click += new System.EventHandler(this.материалыToolStripMenuItem_Click);
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.объектыToolStripMenuItem.Text = "Объекты";
            this.объектыToolStripMenuItem.Click += new System.EventHandler(this.объектыToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // dataGridViewCurrentWorks
            // 
            this.dataGridViewCurrentWorks.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewCurrentWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentWorks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCurrentWorks.Location = new System.Drawing.Point(0, 86);
            this.dataGridViewCurrentWorks.Name = "dataGridViewCurrentWorks";
            this.dataGridViewCurrentWorks.ReadOnly = true;
            this.dataGridViewCurrentWorks.Size = new System.Drawing.Size(800, 364);
            this.dataGridViewCurrentWorks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущие работы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormBuildingCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCurrentWorks);
            this.Controls.Add(this.menuStripBuildingCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripBuildingCompany;
            this.Name = "FormBuildingCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Строительная компания";
            this.Load += new System.EventHandler(this.FormBuildingCompany_Load);
            this.menuStripBuildingCompany.ResumeLayout(false);
            this.menuStripBuildingCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripBuildingCompany;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бригадыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рабочиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewCurrentWorks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

