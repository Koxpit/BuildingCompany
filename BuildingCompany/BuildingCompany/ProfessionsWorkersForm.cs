using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class ProfessionsWorkersForm : Form
    {
        private Database Database { get; }
        public ProfessionsWorkersForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewProfessionsWorkers, "sp_GetProfessionWorker");
        }

        private void ProfessionsWorkersForm_Load(object sender, EventArgs e)
        {
            toolTipProfessionsWorkersForm.SetToolTip(textBoxWorkerID, "Обязательное поле");
            toolTipProfessionsWorkersForm.SetToolTip(textBoxProfessionId, "Обязательное поле");
        }

        private void textBoxWorkerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void textBoxProfessionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void dataGridViewProfessionsWorkers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProfessionsWorkers.CurrentRow != null)
                {
                    textBoxWorkerID.Text = dataGridViewProfessionsWorkers.CurrentRow.Cells[1].Value.ToString();
                    textBoxProfessionId.Text = dataGridViewProfessionsWorkers.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxWorkerID) || InputHandler.TextBoxIsNull(textBoxProfessionId))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int workerId = Convert.ToInt32(textBoxWorkerID.Text);
                int professionId = Convert.ToInt32(textBoxProfessionId.Text);

                workerId = Database.GetID("sp_GetWorkerID", workerId);
                professionId = Database.GetID("sp_GetProfessionID", professionId);
                if (workerId == 0)
                {
                    InputHandler.PrintErrorFindWorker();
                    return;
                }
                if (professionId == 0)
                {
                    InputHandler.PrintErrorFindProfession();
                    return;
                }

                int membershipBrigadeId = Database.GetProfessionWorkerID(workerId, professionId);
                if (membershipBrigadeId != 0)
                {
                    InputHandler.PrintWarningExistProfessionInWorker();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO ProfessionWorker (WorkerID, ProfessionID) VALUES ({workerId}, {professionId})";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewProfessionsWorkers, "sp_GetProfessionWorker");

                textBoxWorkerID.Clear();
                textBoxProfessionId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewProfessionsWorkers.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE ProfessionWorker WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewProfessionsWorkers, "sp_GetProfessionWorker");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxWorkerID) || InputHandler.TextBoxIsNull(textBoxProfessionId))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewProfessionsWorkers.CurrentRow.Cells[0].Value;
                int workerId = Convert.ToInt32(textBoxWorkerID.Text);
                int professionId = Convert.ToInt32(textBoxProfessionId.Text);

                workerId = Database.GetID("sp_GetWorkerID", workerId);
                professionId = Database.GetID("sp_GetProfessionID", professionId);
                if (workerId == 0)
                {
                    InputHandler.PrintErrorFindWorker();
                    return;
                }
                if (professionId == 0)
                {
                    InputHandler.PrintErrorFindProfession();
                    return;
                }

                int membershipBrigadeId = Database.GetProfessionWorkerID(workerId, professionId);
                if (membershipBrigadeId != 0)
                {
                    InputHandler.PrintWarningExistProfessionInWorker();
                    return;
                }

                string sqlQuery = $"UPDATE ProfessionWorker SET WorkerID = {workerId}, ProfessionID = {professionId} WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewProfessionsWorkers, "sp_GetProfessionWorker");

                textBoxWorkerID.Clear();
                textBoxProfessionId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
