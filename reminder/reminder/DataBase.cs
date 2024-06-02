using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public class DataBase
    {
        private SqlConnection connection;

        public DataBase()
        {
            
           connection = new SqlConnection(StringCon());
        }
        public string StringCon()
        {
            return @"Data Source=PABLOVIRT\SQLEXPRESS;Initial Catalog=BDforPO;Integrated Security=True";

        }
      
       public SqlDataAdapter queryExecute(string query)
       
        {
            try

            {
                SqlConnection myCon = new SqlConnection(StringCon());
                myCon.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(query, myCon);
                //SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Подключение к базе данных успешно выполненно!", "Успех");
                return SDA;
                
                
            }
            catch 
            {
                MessageBox.Show("Возникла ошибка при выполении запроса.", "Ошибка");
               return null;
            }

        }
        public bool QueryExecute(string query)
        {
            try
            {
                using (SqlConnection myCon = new SqlConnection(StringCon()))
                {
                    myCon.Open();
                        using  (SqlCommand command = new SqlCommand(query, myCon)) 
                        {
                          command.ExecuteNonQuery();

                        }
                }
                MessageBox.Show("Запрос успешно выполнен", "Успех");
                return true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Ошибка выполнения запроса:{ex.Message}", "Ошибка");
                return false;
            }
        }

        public List<string> GetColumnNames(string tableName)
        {
            List<string> columnNames = new List<string>();
            try
            {
                using (SqlConnection myCon = new SqlConnection(StringCon()))
                {
                    myCon.Open();
                    string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";
                    using (SqlCommand command = new SqlCommand(query, myCon))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnNames.Add(reader["COLUMN_NAME"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения столбцов: {ex.Message}", "Ошибка");
            }
            return columnNames;
        }
        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

    }
   
}





