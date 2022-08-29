using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class BrigadesForm : Form
    {
        private Database Database { get; }
        public BrigadesForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewBrigades, "sp_GetBrigades");
        }

        private void buttonOpenMembershipBrigadesForm_Click(object sender, EventArgs e)
        {
            MembershipBrigadesForm membershipBrigadesForm = new MembershipBrigadesForm(Database);
            membershipBrigadesForm.ShowDialog();
        }

        /// <summary>
        /// Установка подсказок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrigadesForm_Load(object sender, EventArgs e)
        {
            toolTipBrigadesForm.SetToolTip(textBoxBrigadeName, "Обязательное поле");
            toolTipBrigadesForm.SetToolTip(textBoxBrigadierID, "Обязательное поле");
            toolTipBrigadesForm.SetToolTip(textBoxComment, "Необязательное поле");
        }

        private void textBoxBrigadierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }
         /// <summary>
         /// Добавление бригады в БД.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxBrigadeName) || InputHandler.TextBoxIsNull(textBoxBrigadierID))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                string brigadeName = textBoxBrigadeName.Text;
                int brigadierId = Convert.ToInt32(textBoxBrigadierID.Text);
                string comment = textBoxComment.Text;

                brigadierId = Database.GetID("sp_GetBrigadierID", brigadierId);
                if (brigadierId == 0)
                {
                    InputHandler.PrintBrigadierFindErrorMessagge();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO Brigade (Name, Brigadier, Comment) VALUES ('{brigadeName}', {brigadierId}, '{comment}')";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewBrigades, "sp_GetBrigades");

                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод очистки текстовых полей на форме.
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxBrigadeName.Clear();
            textBoxBrigadierID.Clear();
            textBoxComment.Clear();
        }

        /// <summary>
        /// Удаление бригады из БД.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewBrigades.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE Brigade WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewBrigades, "sp_GetBrigades");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Редактирование бригады.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxBrigadeName) || InputHandler.TextBoxIsNull(textBoxBrigadierID))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewBrigades.CurrentRow.Cells[0].Value;
                string brigadeName = textBoxBrigadeName.Text;
                int brigadierId = Convert.ToInt32(textBoxBrigadierID.Text);
                string comment = textBoxComment.Text;

                brigadierId = Database.GetID("sp_GetBrigadierID", brigadierId);
                if (brigadierId == 0)
                {
                    InputHandler.PrintBrigadierFindErrorMessagge();
                    return;
                }

                string sqlQuery = $"UPDATE Brigade SET Name = '{brigadeName}', Brigadier = {brigadierId}, Comment = '{comment}' WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewBrigades, "sp_GetBrigades");

                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Событие, возникающее при смене выделенной строки DataGridView на другую строку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBrigades_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBrigades.CurrentRow != null)
                {
                    textBoxBrigadeName.Text = dataGridViewBrigades.CurrentRow.Cells[1].Value.ToString();
                    textBoxBrigadierID.Text = dataGridViewBrigades.CurrentRow.Cells[2].Value.ToString();
                    textBoxComment.Text = dataGridViewBrigades.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
