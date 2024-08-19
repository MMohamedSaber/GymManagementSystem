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
            userList = new UserList();
            HomeUserPage Home = new HomeUserPage();
            addUserControl(Home);


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
            HomeUserPage Home = new HomeUserPage();
            addUserControl(Home);
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
