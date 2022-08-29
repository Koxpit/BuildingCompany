using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BuildingCompany.Data
{
    /// <summary>
    /// Класс для выполнения операций над базой данных.
    /// </summary>
    public class Database
    {
        private string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        /// <summary>
        /// Метод загрузки данных из БД в таблицу DataGridView.
        /// </summary>
        /// <param name="dataGridView">Ссылка на экземпляр класса DataGridView, в который будет загружена информация.</param>
        /// <param name="sqlProcedure">Название роцедуры, созданной в SQL Managment Studio.</param>
        public void GetData(DataGridView dataGridView, string sqlProcedure)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();

                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод для выполнения SQL-запроса, созданного в Visual Studio.
        /// </summary>
        /// <param name="sqlQuery">SQL-запрос, представляющаий собой строку.</param>
        public void ExecuteQuery(string sqlQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("Операция успешно выполнена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод для проверки существования записи в БД. Если возвращается 0, то записи не существует, в ином случае возвращается ее ID.
        /// </summary>
        /// <param name="sqlProcedure">Название процедуры, созданной в SQL MS.</param>
        /// <param name="inputId">Входной ID, полученный от пользователяя из поля TextBox.</param>
        /// <returns></returns>
        public int GetID(string sqlProcedure, int inputId)
        {
            int id = 0;
            object ID;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", inputId);

                    ID = command.ExecuteScalar();

                    connection.Close();
                }

                if (ID == null)
                    return id;

                id = (int)ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        /// <summary>
        /// Получение ID записи из таблицы БД MembershipBrigades по ID бригады и ID рабочего.
        /// </summary>
        /// <param name="brigadeId">Параметр ID, полученный от пользователя.</param>
        /// <param name="workerId">Параметр ID, полученный от пользователя.</param>
        /// <returns></returns>
        public int GetMembershipBrigadeId(int brigadeId, int workerId)
        {
            int id = 0;
            object ID;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_GetMembershipBrigadeId", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BrigadeID", brigadeId);
                    command.Parameters.AddWithValue("@WorkerID", workerId);

                    ID = command.ExecuteScalar();

                    connection.Close();
                }

                if (ID == null)
                    return id;

                id = (int)ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        /// <summary>
        /// Получение ID записи из таблицы Worker по номеру телефона рабочего.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона рабочего.</param>
        /// <returns></returns>
        public int GetWorkerIdByPhoneNumber(string phoneNumber)
        {
            int id = 0;
            object ID;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_GetWorkerIdByPhoneNumber", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    ID = command.ExecuteScalar();

                    connection.Close();
                }

                if (ID == null)
                    return id;

                id = (int)ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        /// <summary>
        /// Получить ID записи из таблицы ProfessionWorker по ID рабочего и ID профессии
        /// </summary>
        /// <param name="workerId">ID рабочего</param>
        /// <param name="professionId">ID профессии</param>
        /// <returns></returns>
        public int GetProfessionWorkerID(int workerId, int professionId)
        {
            int id = 0;
            object ID;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_GetProfessionWorkerID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@WorkerID", workerId);
                    command.Parameters.AddWithValue("@ProfessionID", professionId);

                    ID = command.ExecuteScalar();

                    connection.Close();
                }

                if (ID == null)
                    return id;

                id = (int)ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        /// <summary>
        /// Получить ID профессии из таблицы Profession по ее имени.
        /// </summary>
        /// <param name="professionName">Название профессии.</param>
        /// <returns></returns>
        public int GetProfessionIdByName(string professionName)
        {
            int id = 0;
            object ID;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_GetProfessionIdByName", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", professionName);

                    ID = command.ExecuteScalar();

                    connection.Close();
                }

                if (ID == null)
                    return id;

                id = (int)ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        /// <summary>
        /// Получить ID материала из таблицы Material по его имени.
        /// </summary>
        /// <param name="materialName">Название материала</param>
        /// <returns></returns>
        public int GetMaterialIdByName(string materialName)
        {
            int id = 0;
            object ID;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_GetMaterialIdByName", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", materialName);

                    ID = command.ExecuteScalar();

                    connection.Close();
                }

                if (ID == null)
                    return id;

                id = (int)ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        /// <summary>
        /// Метод для получения графика работ за переданный период с последующим выводом работ в таблицу DataGridView.
        /// </summary>
        /// <param name="dataGridView">Ссылка на таблицу DataGridView.</param>
        /// <param name="beginDate">Начальная дата просмотра.</param>
        /// <param name="endDate">Конечная дата просмотра.</param>
        public void GetSchedulesInPeriod(DataGridView dataGridView, string beginDate, string endDate)
        {
            DateTime thisBeginDate = Convert.ToDateTime(beginDate);
            DateTime thisEndDate = Convert.ToDateTime(endDate);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_GetSchedulesInPeriod", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BeginDate", thisBeginDate);
                    command.Parameters.AddWithValue("@EndDate", thisEndDate);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();

                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
