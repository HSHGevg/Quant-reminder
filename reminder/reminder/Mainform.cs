using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            customizeDising();
        }
        private void customizeDising()
        {
           panelSlideNotif.Visible= false;
           panelSlideAdmin.Visible= false;
        }
        private void hideSubMenu()
        {//поправить потом этот кринж, затрата памяти в пустутую, но работает
            if (panelSlideNotif.Visible==true)
                panelSlideNotif.Visible=true;

            if (panelSlideAdmin.Visible==true)
                panelSlideAdmin.Visible =true;
        }
       private void showSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible==false)
            {
                hideSubMenu();
                SubMenu.Visible=true;
            }
            else
                SubMenu.Visible=false;
        }

        private void BtnNotif_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSlideNotif);
        }

        private void CreateNotif_Click(object sender, EventArgs e)
        {
            //создание напоминания
            openChildForm(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSlideAdmin);
        }
        //отображение разных форм именно на заданной панели
        private Form activeForm=null;
       private void openChildForm(Form childForm)
        {
            if(activeForm!=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://kvantprv.dm-centre.ru/") { UseShellExecute = true });
        }
    }
}
