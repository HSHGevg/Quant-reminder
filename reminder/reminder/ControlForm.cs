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
    public partial class ControlForm : Form

    {

        private DataBase db=new DataBase();
        
        public ControlForm()

        {
            
            InitializeComponent();
            LoadTablesIntoComboBox();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = SelectTable.SelectedItem.ToString();
            string queryTable="SELECT * FROM " + selectedTable;
            try
            {
                SqlDataAdapter adapter = db.queryExecute(queryTable);
                if (adapter != null)
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                }
                int columnIndex = dataGridView1.Columns["is_deleted"].Index;
                if (columnIndex != -1)
                {
                    dataGridView1.Columns[columnIndex].Visible = false;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Получить значение в столбце is_delete для текущей строки
                    object value = row.Cells["is_deleted"].Value;

                    // Проверить, равно ли значение 1
                    if (value != null && value.ToString() == "1")
                    {
                        // Скрыть строку
                        row.Visible = false;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных из таблицы:"+ex.Message);
            }
        }
        private void LoadTablesIntoComboBox()
        {

            var queryComboBox = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE';";
            try
            {
                SqlDataAdapter adapter = db.queryExecute(queryComboBox);
                if(adapter != null)
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        foreach(DataRow row in table.Rows)
                        {
                            SelectTable.Items.Add(row["TABLE_NAME"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Ошибка загрузки таблиц:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddUser(this).Show();
        }

        private void Delete_userBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> tableIdColumnNames = new Dictionary<string, string>
             {
            {"hall_reminder", "reminder_id"},
            {"hall_admins", "hall_id"},
            {"methodists_reminder", "reminder_id"},
            {"methodists", "methodist_id"},
            {"bosses_reminder", "reminder_id"},
            {"bosses", "boss_id"},
            {"project_department", "project_id"},
            {"project_reminder", "reminder_id"},
            {"sys_admins", "sys_id"},
            {"admins_reminder", "reminder_id"}

            };

            try

            {



                if (SelectTable.SelectedItem == null)
                {


                    MessageBox.Show("Пожалуйса укажите таблицу в поле", "Ошибка");
                    return;

                }
                string selectedTable = SelectTable.SelectedItem.ToString();
                List<string> columnNames = db.GetColumnNames(selectedTable);
                if (columnNames.Count == 0)
                {
                    MessageBox.Show("Не удалось получить столбцы для выбранной таблицы.", "Ошибка");
                    return;
                }
                //получение имени столбца идентификатора для выбранной таблицы
                if (!tableIdColumnNames.TryGetValue(selectedTable, out string idColumnName))
                {
                    MessageBox.Show("не удалось найти идентификатор выбранной таблицы", "Ошибка");
                    return;
                }

                // Получение ID выбранной записи из DataGridView
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Ошибка");
                    return;
                }
                
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int id = (int)dataGridView1.Rows[selectedRowIndex].Cells[idColumnName].Value;
               

                var queryUpdate = $"UPDATE {selectedTable} SET is_deleted = 1 WHERE {idColumnName} = @id";


                db.QueryExecuteWithParams(queryUpdate, new Dictionary<string, object>
                {
                    {"@id", id}
                });
                // Удаление записи из datagridview
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
               
                MessageBox.Show("Запись успешно удалена.", "Информация");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при удалении записи: " + ex.Message, "Ошибка");
            }
        }
    }
}
