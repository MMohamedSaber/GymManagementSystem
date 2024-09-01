using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsystemProject
{
    public partial class Form1 : Form
    {

        public UserList userList;
           



        public Form1()
        {
            InitializeComponent();

            frmHome frm = new frmHome();
            LoadFormIntoPanel(frm);


        }
        private void LoadFormIntoPanel(Form frm)
        {
            frm.TopLevel = false;          // Prevent the form from being top-level
            frm.FormBorderStyle = FormBorderStyle.None; // Remove the border (optional)
            frm.AutoScaleMode = AutoScaleMode.Dpi;
            frm.Dock = DockStyle.Fill;     // Dock the form inside the panel
            PanelContainer.Controls.Clear();       // Clear any existing controls in the panel
            PanelContainer.Controls.Add(frm);      // Add the form to the panel
            frm.Show();                    // Display the form
        }
        private void addUserControl(UserControl uc)
        {
            PanelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            PanelContainer.Controls.Add(uc);

        }

      

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // HomeUserPage Home = new HomeUserPage();
           // addUserControl(Home);

            frmHome frm = new frmHome();
            LoadFormIntoPanel(frm);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddUser AddTraining = new AddUser(userList.dataGridView1);
            addUserControl(AddTraining);
        }

        private void btnList_Click_1(object sender, EventArgs e)
        {
          
            addUserControl(userList);
        }

        
    }
}
