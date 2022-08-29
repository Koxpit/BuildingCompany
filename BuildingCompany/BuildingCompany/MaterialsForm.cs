using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class MaterialsForm : Form
    {
        private Database Database { get; }

        /// <summary>
        /// Класс формы для работы с материалами.
        /// </summary>
        /// <param name="database">Ссылка на подключение к БД.</param>
        public MaterialsForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewMeterials, "sp_GetMaterials");
        }

        private void buttonOpenUseOfMaterialsForm_Click(object sender, EventArgs e)
        {
            UseOfMaterialsForm useOfMaterialsForm = new UseOfMaterialsForm(Database);
            useOfMaterialsForm.ShowDialog();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.SymbolWithSpace(e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxName))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                string materialName = textBoxName.Text;
                string unitOfMeasure = textBoxUnitOfMeasure.Text;
                int id = Database.GetMaterialIdByName(materialName);
                if (id != 0)
                {
                    InputHandler.PrintErrorFindMaterial();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO Material (Name, UnitOfMeasure) VALUES ('{materialName}', '{unitOfMeasure}')";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewMeterials, "sp_GetMaterials");

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
                int id = (int)dataGridViewMeterials.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE Material WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewMeterials, "sp_GetMaterials");
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
                if (InputHandler.TextBoxIsNull(textBoxName) || InputHandler.TextBoxIsNull(textBoxUnitOfMeasure))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewMeterials.CurrentRow.Cells[0].Value;
                string materialName = textBoxName.Text;
                string unitOfMeasure = textBoxUnitOfMeasure.Text;
                int idByName = Database.GetMaterialIdByName(materialName);
                if (idByName != 0 && idByName != id)
                {
                    InputHandler.PrintWarningExistMaterial();
                    return;
                }

                string sqlQuery = $"UPDATE Material SET Name = '{materialName}', UnitOfMeasure = '{unitOfMeasure}' WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewMeterials, "sp_GetMaterials");

                textBoxName.Clear();
                textBoxUnitOfMeasure.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            toolTipMaterialsForm.SetToolTip(textBoxName, "Обязательное поле");
            toolTipMaterialsForm.SetToolTip(textBoxUnitOfMeasure, "Обязательное поле");
        }

        private void dataGridViewMeterials_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMeterials.CurrentRow != null)
                {
                    textBoxName.Text = dataGridViewMeterials.CurrentRow.Cells[1].Value.ToString();
                    textBoxUnitOfMeasure.Text = dataGridViewMeterials.CurrentRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
