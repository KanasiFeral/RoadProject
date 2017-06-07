using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RoadProject
{
    public class MSSQLConnector
    {
        //Строка подключения
        public SqlConnection conn;

        public bool CheckException;

        public DataTable dataTable;
        public SqlDataAdapter adap;
        public DataSet ds;
        public SqlCommandBuilder commBuild;

        //Бинсорсы для таблиц
        public BindingSource binSourceTypeRoad = new BindingSource();
        public BindingSource binSourceRoadDirection = new BindingSource();
        public BindingSource binSourceRoadComposition = new BindingSource();
        public BindingSource binSourceRoad = new BindingSource();
        public BindingSource binSourceEquipmentType = new BindingSource();
        public BindingSource binSourceManufacturer = new BindingSource();
        public BindingSource binSourceLocation = new BindingSource();
        public BindingSource binSourceDepartments = new BindingSource();
        public BindingSource binSourceEquipment = new BindingSource();
        public BindingSource binSourceRoadStatus = new BindingSource();
        public BindingSource binSourceTypeImportantPlaces = new BindingSource();
        public BindingSource binSourceImportantPlaces = new BindingSource();
        public BindingSource binSourceRoadBrigade = new BindingSource();
        public BindingSource binSourceWorkStaff = new BindingSource();
        public BindingSource binSourceRoadOrder = new BindingSource();

        /*Процедуры*/
        //Процедура коннекта к базе
        public bool bConnection(string sConnection)
        {
            try
            {
                conn = new SqlConnection(sConnection);
                conn.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Процедура закрытия коннекта
        public bool bCloseConnection()
        {
            conn.Close();
            return true;
        }

        //Вернет true, если есть записи
        public bool bQueryToBool(string sQueryString)
        {
            dataTable = new DataTable();
            SqlCommand com;
            SqlDataReader dataReader;
            com = new SqlCommand(sQueryString, conn);
            try
            {
                dataReader = com.ExecuteReader();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                CheckException = true;
                return false;
            }
            if (dataReader.HasRows)
            {
                dataTable.Load(dataReader);

                dataReader.Close();
                com.Dispose();
                return true;
            }
            dataReader.Close();
            com.Dispose();
            CheckException = false;
            return false;
        }

        //Процедура загрузки таблицы
        public void vLoadTable(string sNameTable, string sQueryString, BindingSource binSource, DataGridView dataGrid, BindingNavigator Navigator)
        {
            try
            {
                adap = new SqlDataAdapter(sQueryString, conn);
                ds = new DataSet();
                adap.Fill(ds, sNameTable);
                binSource.DataSource = ds.Tables[0];
                Navigator.BindingSource = binSource;
                dataGrid.DataSource = binSource;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Процедура для агрегатных запросов
        public string sAgregateQueryToDataGrid(string sQueryString)
        {
            int iResultQuery = 0;
            string resultQuery = "";
            SqlCommand com;
            SqlDataReader dataReader;
            com = new SqlCommand(sQueryString, conn);
            try
            {
                dataReader = com.ExecuteReader();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return resultQuery;
            }

            dataReader.Read();

            //Пытаемся читать значение которое пришло, обычно это стринг, если нет, то ловим исключение
            try
            {
                resultQuery = dataReader.GetString(0);
            }
            //Поймали исключение и читаем не текст, а число
            catch (Exception)
            {
                iResultQuery = dataReader.GetInt32(0);
                resultQuery = Convert.ToString(iResultQuery);
            }

            dataReader.Close();
            com.Dispose();
            return resultQuery;
        }

        //Процедура вывода в комбо бокса столбца таблицы
        public bool bQueryToComboBox(string sQueryString, ComboBox comboBox, string sNameColumn)
        {
            dataTable = new DataTable();
            SqlCommand com;
            SqlDataReader dataReader;
            com = new SqlCommand(sQueryString, conn);
            try
            {
                dataReader = com.ExecuteReader();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
            if (dataReader.HasRows)
            {
                dataTable.Load(dataReader);
                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = sNameColumn;

                dataReader.Close();
                com.Dispose();
                return true;
            }
            dataReader.Close();
            com.Dispose();
            return false;
        }
    }
}