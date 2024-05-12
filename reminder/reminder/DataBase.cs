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
       public string StringCon()
        {
            return @"Data Source=PABLOVIRT\SQLEXPRESS;Initial Catalog=DB;Integrated Security=True";
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
        
    }



}

