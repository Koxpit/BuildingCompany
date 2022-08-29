using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class ProfessionsForm : Form
    {
        private Database Database { get; }
        public ProfessionsForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewProfessions, "sp_GetProfessions");
        }

        private void ProfessionsForm_Load(object sender, EventArgs e)
        {
            toolTipProfessionsForm.SetToolTip(textBoxProfessionName, "Обязательное поле");
        }

        private void textBoxProfessionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.SymbolWithSpace(e);
        }

        private void dataGridViewProfessions_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProfessions.CurrentRow != null)
                    textBoxProfessionName.Text = dataGridViewProfessions.CurrentRow.Cells[1].Value.ToString();
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
                if (InputHandler.TextBoxIsNull(textBoxProfessionName))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                string professionName = textBoxProfessionName.Text;
                int id = Database.GetProfessionIdByName(professionName);
                if (id != 0)
                {
                    InputHandler.PrintWarningExistProfession();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO Profession (Name) VALUES ('{professionName}')";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewProfessions, "sp_GetProfessions");

                textBoxProfessionName.Clear();
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
                int id = (int)dataGridViewProfessions.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE Profession WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewProfessions, "sp_GetProfessions");
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
                if (InputHandler.TextBoxIsNull(textBoxProfessionName))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewProfessions.CurrentRow.Cells[0].Value;
                string professionName = textBoxProfessionName.Text;
                int idByName = Database.GetProfessionIdByName(professionName);
                if (idByName != 0)
                {
                    InputHandler.PrintWarningExistProfession();
                    return;
                }

                string sqlQuery = $"UPDATE Profession SET Name = '{professionName}' WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewProfessions, "sp_GetProfessions");

                textBoxProfessionName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
