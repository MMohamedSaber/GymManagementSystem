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
    public partial class Card : Form
    {

        public frmUpdateAndDelete.stTrneeData Data;
        public Card(frmUpdateAndDelete.stTrneeData stData)
        {
            InitializeComponent();
            Data=stData;
        }

        private void Card_Load(object sender, EventArgs e)
        {

        }


        public Card setCard()
        {



            lblFullName.Text = Data.FName + " " + Data.MName + " " + Data.LName;
            lblID.Text = Data.ID.ToString();
            lblPlan.Text = Data.Plan.ToString();
            lblStartFrom.Text = Data.StartDate.ToString();
            lblEndAt.Text = Data.EndDate.ToString();



            pictureBox1.Image = (Data.Gender == 'M') ?
                Properties.Resources.boy : Properties.Resources.girl;

            return this;

        }

    }
}
