using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace gymsystemProject
{
    public partial class frmUpdateAndDelete : Form
    {

        frmListTrainenees frm1 = new frmListTrainenees();
        frmAddNewTrainee frm2 = new frmAddNewTrainee();
        public frmUpdateAndDelete()
        {
            InitializeComponent();
        
        
        }

        public struct stTrneeData
        {
            public int ID;
            public string FName;
            public string LName;
            public string MName;
            public string Phone;
            public float age;
            public char Gender;
            public string Plan;
            public string Time;
            public DateTime StartDate;
            public DateTime EndDate;
            public bool MarkedForDeleted;
        }

        stTrneeData ThisTranee = new stTrneeData();
        bool GetTraneeInfo(string Rec)
        {
            string[] Data = Rec.Split(',');

            if (!(Data.Any(x => x.Length > 2)))
                return false;


            ThisTranee.ID = Convert.ToInt32(Data[0]);
            ThisTranee.FName = Data[1];
            ThisTranee.MName = Data[2];
            ThisTranee.LName = Data[3];
            ThisTranee.Phone = Data[4];
            ThisTranee.age = Convert.ToSingle(Data[5]);
            ThisTranee.Gender = Convert.ToChar(Data[6]);
            ThisTranee.Plan = Data[7];
            ThisTranee.Time = Data[8];
            ThisTranee.StartDate = Convert.ToDateTime(Data[9]);
            ThisTranee.EndDate = Convert.ToDateTime(Data[10]);


            return true;
        }
        bool CheckID(int Id)
        {
            return (Id == ThisTranee.ID) ? true : false;

        }
        bool Find(int Id)
        {
            string[] Records = frm1.GetAlltrainees();

            foreach (string Rec in Records)
            {
                if (GetTraneeInfo(Rec) && CheckID(Id))
                {
                    return true;
                }
            }

            return false;


        }
        void LoadCard()
        {
            Card CrdForm = new Card(ThisTranee);
            CrdForm = CrdForm.setCard();

            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.Clear();
            }

            CrdForm.Dock = DockStyle.Fill;
            CrdForm.TopLevel = false;

            this.panel1.Controls.Add(CrdForm);
            CrdForm.Show();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (Find(Convert.ToInt32(textBox1.Text)))
            {
                panel1.Visible = true;
                pictureBox1.Visible = false;
                lblFoundError.Enabled = false;
                LoadCard();
            }
            else
            {
                lblFoundError.Visible= true;
                panel1.Visible = false;
                lblFoundError.Text = "Enter valied ID ,Please check list .";

            }


        }

        

        private void frmUpdateAndDelete_Load(object sender, EventArgs e)
        {
                lblFoundError.Visible= false;
                pictureBox1.Visible= false;
 
        }

        

       
        
        stTrneeData ConvertTostr(string Rec)
        {
            string[] Data = Rec.Split(',');

            stTrneeData stData = new stTrneeData();


            stData.ID = Convert.ToInt32(Data[0]);
            stData.FName = Data[1];
            stData.MName = Data[2];
            stData.LName = Data[3];
            stData.Phone = Data[4];
            stData.age = Convert.ToSingle(Data[5]);
            stData.Gender = Convert.ToChar(Data[6]);
            stData.Plan = Data[7];
            stData.Time = Data[8];
            stData.StartDate = Convert.ToDateTime(Data[9]);
            stData.EndDate = Convert.ToDateTime(Data[10]);

            return stData;



        }
        void CleanFile()
        {
            try
            {
                File.WriteAllText(frm2.filePath, string.Empty);

            }
            catch (Exception Ex)
            {
                throw new ApplicationException(Ex.Message);

            }
        }
        public static string Collector(stTrneeData data)
        {
            string result = "";

            result += data.ID.ToString() + ",";
            result += data.FName.ToString() + ",";
            result += data.MName.ToString() + ",";
            result += data.LName.ToString() + ",";
            result += data.Phone.ToString() + ",";
            result += data.age.ToString() + ",";
            result += data.Gender + ",";
            result += data.Plan.ToString() + ",";
            result += data.Time.ToString() + ",";
            result += data.StartDate.ToString() + ",";
            result += data.EndDate.ToString() + ",";

            return result;
        }
        void PushInFile(stTrneeData Data)
        {
            string Record = Collector(Data);

            try
            {
                using (StreamWriter file = new StreamWriter(frm2.filePath ,true))
                {
                    file.WriteLine(Record);
                }

            }

            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        private void SaveClients()
        {
            string[] Records = frm1.GetAlltrainees();
            CleanFile();
            int CountID = 1;
            stTrneeData CrntTr = new stTrneeData();

            foreach (string Rec in Records)
            {
                CrntTr = ConvertTostr(Rec);
                if (CrntTr.ID != ThisTranee.ID)
                {
                    CrntTr.ID = CountID;
                    CountID++;
                    PushInFile(CrntTr);
                }

            }


        }
        void SetUi()
        {
            pictureBox1.Location = new Point(250, 230); // Set the desired coordinates
            pictureBox1.Parent = this;
            pictureBox1.Visible = true;
            panel1.Visible = false;
            textBox1.Clear();
        }
        void ShowDeleteSucessMessage()
        {
            notifyIcon1.Icon = SystemIcons.Application;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "trainee Deleted successfully";
            notifyIcon1.BalloonTipTitle = "Done";

            notifyIcon1.ShowBalloonTip(1000);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure ? ", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ThisTranee.MarkedForDeleted = true;
                SaveClients();
                SetUi();
                ShowDeleteSucessMessage();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello, this is confirming the addition.");
        }
    }
}
