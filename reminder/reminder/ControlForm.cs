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
            string selectedTable=SelectTable.SelectedItem.ToString();
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
    }
}
