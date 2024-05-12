using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public partial class Form1 : Form
    {

        private DataBase db;
        private DateTime reminderDateTime;
        private Timer reminderTimer;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            // обработка событий в comboBox1
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            
            //проверка времени каждую секунду
            reminderTimer = new Timer();
            reminderTimer.Tick += reminderTimer_Tick;
            reminderTimer.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("dddd, dd MMMM yyyy", CultureInfo.CurrentUICulture);
            string time = dateTimePicker2.Value.ToString("hh:mm:ss tt", CultureInfo.CurrentUICulture);
            string message = textBox3.Text;
            string logEntry = $"Дата: {date}  Время:{time}\r\n Напоминание: {message}\r\n";


            reminderDateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day,
                dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);

            reminderTimer.Start();


        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= reminderDateTime)
            {
                reminderTimer.Stop();
                MessageBox.Show(textBox3.Text);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            reminderTimer.Stop();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        
    }
}
