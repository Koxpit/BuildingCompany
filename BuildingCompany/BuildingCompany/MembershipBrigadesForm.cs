using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class MembershipBrigadesForm : Form
    {
        private Database Database { get; }
        public MembershipBrigadesForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewMembershipBrigades, "sp_GetMembershipBrigades");
        }

        private void MembershipBrigadesForm_Load(object sender, EventArgs e)
        {
            toolTipMembershipBrigadesForm.SetToolTip(textBoxBrigadeID, "Обязательное поле");
            toolTipMembershipBrigadesForm.SetToolTip(textBoxWorkerID, "Обязательное поле");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxWorkerID) || InputHandler.TextBoxIsNull(textBoxBrigadeID))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int workerId = Convert.ToInt32(textBoxWorkerID.Text);
                int brigadeId = Convert.ToInt32(textBoxBrigadeID.Text);

                workerId = Database.GetID("sp_GetWorkerID", workerId);
                brigadeId = Database.GetID("sp_GetBrigadeID", brigadeId);
                if (workerId == 0)
                {
                    InputHandler.PrintErrorFindWorker();
                    return;
                }
                if (brigadeId == 0)
                {
                    InputHandler.PrintErrorFindBrigade();
                    return;
                }

                int membershipBrigadeId = Database.GetMembershipBrigadeId(brigadeId, workerId);
                if (membershipBrigadeId != 0)
                {
                    InputHandler.PrintWarningExistWorker();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO MembershipBrigade (BrigadeID, WorkerID) VALUES ({brigadeId}, {workerId})";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewMembershipBrigades, "sp_GetMembershipBrigades");

                textBoxWorkerID.Clear();
                textBoxBrigadeID.Clear();
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
                int id = (int)dataGridViewMembershipBrigades.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE MembershipBrigade WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewMembershipBrigades, "sp_GetMembershipBrigades");
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
                if (InputHandler.TextBoxIsNull(textBoxWorkerID) || InputHandler.TextBoxIsNull(textBoxBrigadeID))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewMembershipBrigades.CurrentRow.Cells[0].Value;
                int workerId = Convert.ToInt32(textBoxWorkerID.Text);
                int brigadeId = Convert.ToInt32(textBoxBrigadeID.Text);

                workerId = Database.GetID("sp_GetWorkerID", workerId);
                brigadeId = Database.GetID("sp_GetBrigadeID", brigadeId);
                if (workerId == 0)
                {
                    InputHandler.PrintErrorFindWorker();
                    return;
                }
                if (brigadeId == 0)
                {
                    InputHandler.PrintErrorFindBrigade();
                    return;
                }

                int membershipBrigadeId = Database.GetMembershipBrigadeId(brigadeId, workerId);
                if (membershipBrigadeId != 0)
                {
                    InputHandler.PrintWarningExistWorker();
                    return;
                }

                string sqlQuery = $"UPDATE MembershipBrigade SET BrigadeID = {brigadeId}, WorkerID = {workerId} WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewMembershipBrigades, "sp_GetMembershipBrigades");

                textBoxWorkerID.Clear();
                textBoxBrigadeID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxBrigadeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void textBoxWorkerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void dataGridViewMembershipBrigades_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMembershipBrigades.CurrentRow != null)
                {
                    textBoxWorkerID.Text = dataGridViewMembershipBrigades.CurrentRow.Cells[4].Value.ToString();
                    textBoxBrigadeID.Text = dataGridViewMembershipBrigades.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
