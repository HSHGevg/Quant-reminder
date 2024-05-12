namespace reminder
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSlideNotif = new System.Windows.Forms.Panel();
            this.Calen = new System.Windows.Forms.Button();
            this.AllNotif = new System.Windows.Forms.Button();
            this.CreateNotif = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSlideAdmin = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ControlAdminDB = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.BtnNotif = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSlideNotif.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelSlideAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelSlideNotif
            // 
            this.panelSlideNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(22)))), ((int)(((byte)(51)))));
            this.panelSlideNotif.Controls.Add(this.Calen);
            this.panelSlideNotif.Controls.Add(this.AllNotif);
            this.panelSlideNotif.Controls.Add(this.CreateNotif);
            this.panelSlideNotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSlideNotif.Location = new System.Drawing.Point(0, 142);
            this.panelSlideNotif.Name = "panelSlideNotif";
            this.panelSlideNotif.Size = new System.Drawing.Size(328, 130);
            this.panelSlideNotif.TabIndex = 1;
            // 
            // Calen
            // 
            this.Calen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Calen.FlatAppearance.BorderSize = 0;
            this.Calen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calen.ForeColor = System.Drawing.Color.Gainsboro;
            this.Calen.Location = new System.Drawing.Point(0, 84);
            this.Calen.Name = "Calen";
            this.Calen.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Calen.Size = new System.Drawing.Size(328, 42);
            this.Calen.TabIndex = 3;
            this.Calen.Text = "Календарь";
            this.Calen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calen.UseVisualStyleBackColor = true;
            // 
            // AllNotif
            // 
            this.AllNotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllNotif.FlatAppearance.BorderSize = 0;
            this.AllNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllNotif.ForeColor = System.Drawing.Color.Gainsboro;
            this.AllNotif.Location = new System.Drawing.Point(0, 42);
            this.AllNotif.Name = "AllNotif";
            this.AllNotif.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AllNotif.Size = new System.Drawing.Size(328, 42);
            this.AllNotif.TabIndex = 2;
            this.AllNotif.Text = "Все напоминания";
            this.AllNotif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllNotif.UseVisualStyleBackColor = true;
            // 
            // CreateNotif
            // 
            this.CreateNotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateNotif.FlatAppearance.BorderSize = 0;
            this.CreateNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNotif.ForeColor = System.Drawing.Color.Gainsboro;
            this.CreateNotif.Location = new System.Drawing.Point(0, 0);
            this.CreateNotif.Name = "CreateNotif";
            this.CreateNotif.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.CreateNotif.Size = new System.Drawing.Size(328, 42);
            this.CreateNotif.TabIndex = 1;
            this.CreateNotif.Text = "Создать";
            this.CreateNotif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateNotif.UseVisualStyleBackColor = true;
            this.CreateNotif.Click += new System.EventHandler(this.CreateNotif_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.panelMain.Controls.Add(this.panelSlideAdmin);
            this.panelMain.Controls.Add(this.btnControl);
            this.panelMain.Controls.Add(this.panelSlideNotif);
            this.panelMain.Controls.Add(this.BtnNotif);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(328, 577);
            this.panelMain.TabIndex = 0;
            // 
            // panelSlideAdmin
            // 
            this.panelSlideAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(22)))), ((int)(((byte)(51)))));
            this.panelSlideAdmin.Controls.Add(this.button5);
            this.panelSlideAdmin.Controls.Add(this.button4);
            this.panelSlideAdmin.Controls.Add(this.ControlAdminDB);
            this.panelSlideAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSlideAdmin.Location = new System.Drawing.Point(0, 314);
            this.panelSlideAdmin.Name = "panelSlideAdmin";
            this.panelSlideAdmin.Size = new System.Drawing.Size(328, 121);
            this.panelSlideAdmin.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(0, 84);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(328, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Логи";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(0, 42);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(328, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "Доступ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ControlAdminDB
            // 
            this.ControlAdminDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlAdminDB.FlatAppearance.BorderSize = 0;
            this.ControlAdminDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlAdminDB.ForeColor = System.Drawing.Color.Gainsboro;
            this.ControlAdminDB.Location = new System.Drawing.Point(0, 0);
            this.ControlAdminDB.Name = "ControlAdminDB";
            this.ControlAdminDB.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ControlAdminDB.Size = new System.Drawing.Size(328, 42);
            this.ControlAdminDB.TabIndex = 1;
            this.ControlAdminDB.Text = "Отделы";
            this.ControlAdminDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ControlAdminDB.UseVisualStyleBackColor = true;
            this.ControlAdminDB.Click += new System.EventHandler(this.ControlAdminDB_Click);
            // 
            // btnControl
            // 
            this.btnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControl.FlatAppearance.BorderSize = 0;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnControl.Location = new System.Drawing.Point(0, 272);
            this.btnControl.Name = "btnControl";
            this.btnControl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnControl.Size = new System.Drawing.Size(328, 42);
            this.btnControl.TabIndex = 2;
            this.btnControl.Text = "Управление";
            this.btnControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNotif
            // 
            this.BtnNotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNotif.FlatAppearance.BorderSize = 0;
            this.BtnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotif.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnNotif.Location = new System.Drawing.Point(0, 100);
            this.BtnNotif.Name = "BtnNotif";
            this.BtnNotif.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnNotif.Size = new System.Drawing.Size(328, 42);
            this.BtnNotif.TabIndex = 1;
            this.BtnNotif.Text = "Напоминания";
            this.BtnNotif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotif.UseVisualStyleBackColor = true;
            this.BtnNotif.Click += new System.EventHandler(this.BtnNotif_Click);
            // 
            // P
            // 
            this.P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(7)))), ((int)(((byte)(35)))));
            this.P.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P.Location = new System.Drawing.Point(328, 477);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(560, 100);
            this.P.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(328, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(560, 477);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 577);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.P);
            this.Controls.Add(this.panelMain);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSlideNotif.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelSlideAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSlideNotif;
        private System.Windows.Forms.Button AllNotif;
        private System.Windows.Forms.Button CreateNotif;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button Calen;
        private System.Windows.Forms.Panel panelSlideAdmin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ControlAdminDB;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button BtnNotif;
        private System.Windows.Forms.Panel P;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}