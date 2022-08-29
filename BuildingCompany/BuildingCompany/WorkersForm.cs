using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class WorkersForm : Form
    {
        private Database Database { get; }
        public WorkersForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewWorkers, "sp_GetWorkers");
        }

        private void buttonOpenProfessionsForm_Click(object sender, EventArgs e)
        {
            ProfessionsForm professionsForm = new ProfessionsForm(Database);
            professionsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessionsWorkersForm professionsWorkers = new ProfessionsWorkersForm(Database);
            professionsWorkers.ShowDialog();
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.SymbolWithSpace(e);
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxFIO) || InputHandler.TextBoxIsNull(textBoxPhoneNumber))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                string fio = textBoxFIO.Text;
                string phoneNumber = textBoxPhoneNumber.Text;
                string comment = textBoxComment.Text;

                int id = Database.GetWorkerIdByPhoneNumber(phoneNumber);
                if (id != 0)
                {
                    InputHandler.PrintWarningExistPhoneNumberOnWorker();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO Worker (FIO, PhoneNumber, Comment) VALUES ('{fio}', '{phoneNumber}', '{comment}')";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewWorkers, "sp_GetWorkers");

                textBoxFIO.Clear();
                textBoxPhoneNumber.Clear();
                textBoxComment.Clear();
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
                int id = (int)dataGridViewWorkers.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE Worker WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewWorkers, "sp_GetWorkers");
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
                if (InputHandler.TextBoxIsNull(textBoxFIO) || InputHandler.TextBoxIsNull(textBoxPhoneNumber))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewWorkers.CurrentRow.Cells[0].Value;
                string fio = textBoxFIO.Text;
                string phoneNumber = textBoxPhoneNumber.Text;
                string comment = textBoxComment.Text;

                int idByPhone = Database.GetWorkerIdByPhoneNumber(phoneNumber);
                if (idByPhone != 0 && idByPhone != id)
                {
                    InputHandler.PrintWarningExistPhoneNumberOnWorker();
                    return;
                }

                string sqlQuery = $"UPDATE Worker SET FIO = '{fio}', PhoneNumber = '{phoneNumber}', Comment = '{comment}' WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewWorkers, "sp_GetWorkers");

                textBoxFIO.Clear();
                textBoxPhoneNumber.Clear();
                textBoxComment.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewWorkers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewWorkers.CurrentRow != null)
                {
                    textBoxFIO.Text = dataGridViewWorkers.CurrentRow.Cells[1].Value.ToString();
                    textBoxPhoneNumber.Text = dataGridViewWorkers.CurrentRow.Cells[2].Value.ToString();
                    textBoxComment.Text = dataGridViewWorkers.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            toolTipWorkersForm.SetToolTip(textBoxFIO, "Обязательное поле");
            toolTipWorkersForm.SetToolTip(textBoxPhoneNumber, "Обязательное поле");
            toolTipWorkersForm.SetToolTip(textBoxComment, "Необязательное поле");
        }

        private void buttonOpenProfessionsWorkersForm_Click(object sender, EventArgs e)
        {
            ProfessionsWorkersForm professionsWorkers = new ProfessionsWorkersForm(Database);
            professionsWorkers.ShowDialog();
        }
    }
}
