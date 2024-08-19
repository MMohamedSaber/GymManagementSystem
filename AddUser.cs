using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace gymsystemProject
{
    public partial class AddUser : UserControl 
    {

        private DataGridView datagridView1;


        public AddUser(DataGridView userList)
        {
            InitializeComponent();
            datagridView1 = userList;
        }
    

        

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (datagridView1 != null)
            {
                // Create a row of data
                int ID = datagridView1.Rows.Count + 1;  // Incremental ID based on row count

                object[] rowData = { ID.ToString(), tbFirstName.Text, tbMidName.Text, tbLastName.Text, tbPhoneNumber.Text, cbPlan.Text, cbTime.Text, tbStartFrom.Text, tbEndAt.Text };

                // Ensure the DataGridView has the correct number of columns
                if (datagridView1.ColumnCount == rowData.Length)
                {
                    datagridView1.Rows.Add(rowData); // Add the row to the DataGridView
                    MessageBox.Show("The Trainer Added successfuly.");
                }
                else
                {
                    MessageBox.Show("The number of columns in the DataGridView does not match the data.");
                }
            }
            else
            {
                MessageBox.Show("The DataGridView control is not initialized.");
            }
        }


    }

       
    
}
