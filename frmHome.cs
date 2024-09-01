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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnTeleLink_Click(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://t.me/MoHaMeD_SaBeR_TaMeR");
        }

        private void btnInLink_Click(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mohamed-saber-285a382ab?utm_" +
                "source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app");
        }

        private void btnXlink_Click(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MMohamedSaber");

        }

        private void HomeUserPage_Load(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
