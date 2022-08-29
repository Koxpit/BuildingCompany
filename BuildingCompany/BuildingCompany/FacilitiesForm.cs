using BuildingCompany.Data;
using BuildingCompany.Errors;
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
    public partial class FacilitiesForm : Form
    {
        private Database Database { get; }
        public FacilitiesForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewFacilities, "sp_GetFacilities"); // Загрузка данных из БД в DataGridView при создании экземпляра данного класса.
        }

        private void buttonOpenTypesOfFacilityForm_Click(object sender, EventArgs e)
        {
            TypesOfFacilityForm typesOfFacilityForm = new TypesOfFacilityForm(Database);
            typesOfFacilityForm.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxAddressFacility) || InputHandler.TextBoxIsNull(textBoxIdTypeOfFacility)
                    || InputHandler.TextBoxIsNull(textBoxName))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int typeOfFacilityId = Convert.ToInt32(textBoxIdTypeOfFacility.Text);
                string address = textBoxAddressFacility.Text;
                string name = textBoxName.Text;

                typeOfFacilityId = Database.GetID("sp_GetTypeOfFacilityID", typeOfFacilityId);
                if (typeOfFacilityId == 0)
                {
                    InputHandler.PrintErrorFindTypeOfFacility();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO Facility (Name, Address, TypeOfFacilityID) VALUES ('{name}', '{address}', {typeOfFacilityId})";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewFacilities, "sp_GetFacilities");

                textBoxIdTypeOfFacility.Clear();
                textBoxAddressFacility.Clear();
                textBoxName.Clear();
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
                int id = (int)dataGridViewFacilities.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE Facility WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewFacilities, "sp_GetFacilities");
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
                if (InputHandler.TextBoxIsNull(textBoxAddressFacility) || InputHandler.TextBoxIsNull(textBoxIdTypeOfFacility)
                    || InputHandler.TextBoxIsNull(textBoxName))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewFacilities.CurrentRow.Cells[0].Value;
                int typeOfFacilityId = Convert.ToInt32(textBoxIdTypeOfFacility.Text);
                string address = textBoxAddressFacility.Text;
                string name = textBoxName.Text;

                typeOfFacilityId = Database.GetID("sp_GetTypeOfFacilityID", typeOfFacilityId);
                if (typeOfFacilityId == 0)
                {
                    InputHandler.PrintErrorFindTypeOfFacility();
                    return;
                }

                string sqlQuery = $"UPDATE Facility SET Name = '{name}', Address = '{address}', TypeOfFacilityID = {typeOfFacilityId} WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewFacilities, "sp_GetFacilities");

                textBoxIdTypeOfFacility.Clear();
                textBoxAddressFacility.Clear();
                textBoxName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxIdTypeOfFacility_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        /// <summary>
        /// Возникает при смене выеделнной строки на другую.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewFacilities_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFacilities.CurrentRow != null)
                {
                    textBoxName.Text = dataGridViewFacilities.CurrentRow.Cells[1].Value.ToString();
                    textBoxAddressFacility.Text = dataGridViewFacilities.CurrentRow.Cells[2].Value.ToString();
                    textBoxIdTypeOfFacility.Text = dataGridViewFacilities.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Установка подсказок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FacilitiesForm_Load(object sender, EventArgs e)
        {
            toolTipFacilitiesForm.SetToolTip(textBoxName, "Обязательное поле");
            toolTipFacilitiesForm.SetToolTip(textBoxAddressFacility, "Обязательное поле");
            toolTipFacilitiesForm.SetToolTip(textBoxIdTypeOfFacility, "Обязательное поле");
        }
    }
}
