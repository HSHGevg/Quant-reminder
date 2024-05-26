using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public partial class AddUser : Form

    {
        ControlForm controlForm;
        private DataBase db;
        public AddUser(ControlForm owner)
        {
            controlForm = owner;
            db=new DataBase();
            InitializeComponent();
           

        }


        Dictionary<string, string> tableIdColumnNames = new Dictionary<string, string>
        {
            {"admins_department", "admin_id"         },
            {"methodists_department", "methodist_id" },
            {"bosses_department", "boss_id"          },
            {"project_department", "project_id"      },
            {"all_reminds","id"                      }
        };
        private void AddMainUs_Click(object sender, EventArgs e)
        {
            
            try

            {
                
                

                if (controlForm.SelectTable.SelectedItem==null)
                {


                    MessageBox.Show("Пожалуйса укажите таблицу в поле", "Ошибка");
                    return;
                   
                }
                string selectedTable = controlForm.SelectTable.SelectedItem.ToString();
                List<string> columnNames=db.GetColumnNames(selectedTable);
                if (columnNames.Count == 0)
                {
                    MessageBox.Show("Не удалось получить столбцы для выбранной таблицы.", "Ошибка");
                    return;
                }
                //получение имени столбца идентификатора для выбранной таблицы
                if(!tableIdColumnNames.TryGetValue(selectedTable, out string idColumnName)) 
                {
                    MessageBox.Show("не удалось найти идентификатор выбранной таблицы", "Ошибка");
                    return;
                }
                // Динамическое создание SQL-запроса
                string columns = string.Join(", ", columnNames);
                string values = string.Join(", ", columnNames.Select(name =>
                {
                    switch (name)
                    {
                        case var n when n==idColumnName:
                            return string.IsNullOrEmpty(textBoxID.Text)? "NULL":$"'{textBoxID.Text}'";
                        
                        case "FIO":
                            return string.IsNullOrEmpty(textBoxSecondName.Text) ? "NULL" : $"'{textBoxSecondName.Text}'";
                        case "date_born":
                            return dateTimePickerBirth.Value==null ? "NULL":$"'{dateTimePickerBirth.Value.ToString("yyyy-MM-dd")}'";
                        default:
                            return "Null"; // Значение по умолчанию для неизвестных столбцов
                    }
                }));
                var queryInsert = $"INSERT INTO {selectedTable} ({columns}) values ({values})";
               
               if(db.QueryExecute(queryInsert))
                {
                    MessageBox.Show("Данные успешно добавлены.", "Успех");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные.", "Ошибка");
                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                
            }
           


        }

        
    }
}
