using BuildingCompany.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class FormBuildingCompany : Form
    {
        private Database Database { get; } = new Database();

        public FormBuildingCompany()
        {
            InitializeComponent();
        }

        private void FormBuildingCompany_Load(object sender, EventArgs e)
        {
            Database.GetData(dataGridViewCurrentWorks, "sp_GetCurrentWorks");
        }

        private void бригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrigadesForm brigadesForm = new BrigadesForm(Database);
            brigadesForm.Show();
        }

        private void рабочиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersForm workersForm = new WorkersForm(Database);
            workersForm.Show();
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialsForm materialsForm = new MaterialsForm(Database);
            materialsForm.Show();
        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilitiesForm facilitiesForm = new FacilitiesForm(Database);
            facilitiesForm.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulesForm schedulesForm = new SchedulesForm(Database);
            schedulesForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBuildingCompanyForm aboutBuildingCompanyForm = new AboutBuildingCompanyForm();
            aboutBuildingCompanyForm.ShowDialog();
        }
    }
}
