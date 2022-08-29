using BuildingCompany.Data;
using BuildingCompany.Errors;
using System;
using System.Windows.Forms;

namespace BuildingCompany
{
    public partial class UseOfMaterialsForm : Form
    {
        private Database Database { get; }
        public UseOfMaterialsForm(Database database)
        {
            InitializeComponent();
            Database = database;

            Database.GetData(dataGridViewUseOfMaterials, "sp_GetUseOfMaterials");
        }

        private void UseOfMaterialsForm_Load(object sender, EventArgs e)
        {
            toolTipUseOfMaterialsForm.SetToolTip(textBoxAmount, "Обзательное поле");
            toolTipUseOfMaterialsForm.SetToolTip(textBoxIdFacility, "Обзательное поле");
            toolTipUseOfMaterialsForm.SetToolTip(textBoxIdBrigade, "Обзательное поле");
            toolTipUseOfMaterialsForm.SetToolTip(textBoxIdMaterial, "Обзательное поле");
        }

        private void dataGridViewUseOfMaterials_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUseOfMaterials.CurrentRow != null)
                {
                    textBoxIdFacility.Text = dataGridViewUseOfMaterials.CurrentRow.Cells[1].Value.ToString();
                    textBoxIdBrigade.Text = dataGridViewUseOfMaterials.CurrentRow.Cells[4].Value.ToString();
                    textBoxIdMaterial.Text = dataGridViewUseOfMaterials.CurrentRow.Cells[8].Value.ToString();
                    textBoxAmount.Text = dataGridViewUseOfMaterials.CurrentRow.Cells[10].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxIdFacility_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void textBoxIdMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void textBoxIdBrigade_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DigitOnly(e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputHandler.TextBoxIsNull(textBoxAmount) || InputHandler.TextBoxIsNull(textBoxIdBrigade)
                    || InputHandler.TextBoxIsNull(textBoxIdMaterial) || InputHandler.TextBoxIsNull(textBoxIdFacility))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int amount = Convert.ToInt32(textBoxAmount.Text);
                int materiaId = Convert.ToInt32(textBoxIdMaterial.Text);
                int brigadeId = Convert.ToInt32(textBoxIdBrigade.Text);
                int facilityId = Convert.ToInt32(textBoxIdFacility.Text);

                materiaId = Database.GetID("sp_GetMaterialID", materiaId);
                brigadeId = Database.GetID("sp_GetBrigadeID", brigadeId);
                facilityId = Database.GetID("sp_GetFacilityID", facilityId);
                if (materiaId == 0)
                {
                    InputHandler.PrintErrorFindMaterial();
                    return;
                }
                if (brigadeId == 0)
                {
                    InputHandler.PrintErrorFindBrigade();
                    return;
                }
                if (facilityId == 0)
                {
                    InputHandler.PrintErrorFindFacility();
                    return;
                }

                string sqlQueryAdd = $"INSERT INTO UseOfMaterial (FacilityID, BrigadeID, MaterialID, Amount) VALUES ({facilityId}, {brigadeId}, {materiaId}, {amount})";

                Database.ExecuteQuery(sqlQueryAdd);
                Database.GetData(dataGridViewUseOfMaterials, "sp_GetUseOfMaterials");

                textBoxAmount.Clear();
                textBoxIdFacility.Clear();
                textBoxIdBrigade.Clear();
                textBoxIdMaterial.Clear();
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
                int id = (int)dataGridViewUseOfMaterials.CurrentRow.Cells[0].Value;
                string sqlQuery = $"DELETE UseOfMaterial WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewUseOfMaterials, "sp_GetUseOfMaterials");
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
                if (InputHandler.TextBoxIsNull(textBoxAmount) || InputHandler.TextBoxIsNull(textBoxIdBrigade)
                    || InputHandler.TextBoxIsNull(textBoxIdMaterial) || InputHandler.TextBoxIsNull(textBoxIdFacility))
                {
                    InputHandler.PrintNullWarningMessagge();
                    return;
                }

                int id = (int)dataGridViewUseOfMaterials.CurrentRow.Cells[0].Value;
                int amount = Convert.ToInt32(textBoxAmount.Text);
                int materiaId = Convert.ToInt32(textBoxIdMaterial.Text);
                int brigadeId = Convert.ToInt32(textBoxIdBrigade.Text);
                int facilityId = Convert.ToInt32(textBoxIdFacility.Text);

                materiaId = Database.GetID("sp_GetMaterialID", materiaId);
                brigadeId = Database.GetID("sp_GetBrigadeID", brigadeId);
                facilityId = Database.GetID("sp_GetFacilityID", facilityId);
                if (materiaId == 0)
                {
                    InputHandler.PrintErrorFindMaterial();
                    return;
                }
                if (brigadeId == 0)
                {
                    InputHandler.PrintErrorFindBrigade();
                    return;
                }
                if (facilityId == 0)
                {
                    InputHandler.PrintErrorFindFacility();
                    return;
                }

                string sqlQuery = $"UPDATE Material SET FacilityID = {facilityId}, BrigadeID = {brigadeId}, MaterialID = {materiaId}, Amount = {amount} WHERE ID = {id}";

                Database.ExecuteQuery(sqlQuery);
                Database.GetData(dataGridViewUseOfMaterials, "sp_GetUseOfMaterials");

                textBoxAmount.Clear();
                textBoxIdFacility.Clear();
                textBoxIdBrigade.Clear();
                textBoxIdMaterial.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
