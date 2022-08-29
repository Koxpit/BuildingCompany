using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class SchedulesForm : Form
    {
        private Database Database { get; }
        public SchedulesForm(Database database)
        {
            InitializeComponent();
            Database = database;
        }

        private void SchedulesForm_Load(object sender, EventArgs e)
        {
            toolTipSchedules.SetToolTip(textBoxIdBrigade, "Обязательное поле");
            toolTipSchedules.SetToolTip(textBoxIdFacility, "Обязательное поле");
            toolTipSchedules.SetToolTip(textBoxEndingDate, "Обязательное поле");
            toolTipSchedules.SetToolTip(textBoxComment, "Необязательное поле");
            toolTipSchedules.SetToolTip(textBoxWorkDescription, "Необязательное поле");
            toolTipSchedules.SetToolTip(textBoxBeginDate, "Формат ГГГГ-ММ-ДД");
            toolTipSchedules.SetToolTip(textBoxEndDate, "Формат ГГГГ-ММ-ДД");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxIdBrigade) || InputHandler.TextBoxIsNull(textBoxEndingDate)
                    || InputHandler.TextBoxIsNull(textBoxIdFacility))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int brigadeId = Convert.ToInt32(textBoxIdBrigade.Text);
                int facilityId = Convert.ToInt32(textBoxIdFacility.Text);
                DateTime endingDate = Convert.ToDateTime(textBoxEndingDate.Text);
                string comment = textBoxComment.Text;
                string workDescription = textBoxWorkDescription.Text;

                facilityId = Database.GetID("sp_GetFacilityID", facilityId);
                brigadeId = Database.GetID("sp_GetBrigadeID", brigadeId);
                if (facilityId == 0)
                {
                    InputHandler.PrintErrorFindFacility();
                    return;
                }
                if (brigadeId == 0)
                {
                    InputHandler.PrintErrorFindBrigade();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO Schedule (FacilityID, WorkDescription, BrigadeID, Comment, EndingDate) VALUES ({facilityId}, '{workDescription}', {brigadeId}, '{comment}', '{endingDate}')";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewSchedules, "sp_GetSchedules");

                textBoxIdBrigade.Clear();
                textBoxIdFacility.Clear();
                textBoxEndingDate.Clear();
                textBoxComment.Clear();
                textBoxWorkDescription.Clear();
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
                int id = (int)dataGridViewSchedules.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE Schedule WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewSchedules, "sp_GetSchedules");
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
                if (InputHandler.TextBoxIsNull(textBoxIdBrigade) || InputHandler.TextBoxIsNull(textBoxEndingDate)
                     || InputHandler.TextBoxIsNull(textBoxIdFacility))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewSchedules.CurrentRow.Cells[0].Value;
                int brigadeId = Convert.ToInt32(textBoxIdBrigade.Text);
                int facilityId = Convert.ToInt32(textBoxIdFacility.Text);
                DateTime endingDate = Convert.ToDateTime(textBoxEndingDate.Text);
                string comment = textBoxComment.Text;
                string workDescription = textBoxWorkDescription.Text;

                facilityId = Database.GetID("sp_GetFacilityID", facilityId);
                brigadeId = Database.GetID("sp_GetBrigadeID", brigadeId);
                if (facilityId == 0)
                {
                    InputHandler.PrintErrorFindFacility();
                    return;
                }
                if (brigadeId == 0)
                {
                    InputHandler.PrintErrorFindBrigade();
                    return;
                }

                string sqlQuery = $"UPDATE Schedule SET FacilityID = {facilityId}, WorkDescription = '{workDescription}', BrigadeID = {brigadeId}, Comment = '{comment}', EndingDate = '{endingDate}' WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewSchedules, "sp_GetSchedules");

                textBoxIdBrigade.Clear();
                textBoxIdFacility.Clear();
                textBoxEndingDate.Clear();
                textBoxComment.Clear();
                textBoxWorkDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void dataGridViewSchedules_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSchedules.CurrentRow != null)
                {
                    textBoxIdFacility.Text = dataGridViewSchedules.CurrentRow.Cells[1].Value.ToString();
                    textBoxIdBrigade.Text = dataGridViewSchedules.CurrentRow.Cells[6].Value.ToString();
                    textBoxWorkDescription.Text = dataGridViewSchedules.CurrentRow.Cells[5].Value.ToString();
                    textBoxComment.Text = dataGridViewSchedules.CurrentRow.Cells[10].Value.ToString();
                    textBoxEndingDate.Text = Convert.ToDateTime(dataGridViewSchedules.CurrentRow.Cells[11].Value).ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string beginDate = Convert.ToDateTime(textBoxBeginDate.Text).ToShortDateString();
                string endDate = Convert.ToDateTime(textBoxEndDate.Text).ToShortDateString();

                Database.GetSchedulesInPeriod(dataGridViewSchedules, beginDate, endDate);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
