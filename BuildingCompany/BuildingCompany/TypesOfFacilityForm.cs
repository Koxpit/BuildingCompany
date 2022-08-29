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
    public partial class TypesOfFacilityForm : Form
    {
        private Database Database { get; }
        public TypesOfFacilityForm(Database database)
        {
            InitializeComponent();
            Database = database;
        }

        private void TypesOfFacilityForm_Load(object sender, EventArgs e)
        {
            Database.GetData(dataGridViewTypesOfFacilities, "sp_GetTypesOfFacilities");
        }
    }
}
