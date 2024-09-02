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
    public partial class frmListTrainenees : Form
    {
        public frmListTrainenees()
        {
            InitializeComponent();
            FilePath = frm.filePath;
        }
        public int GetNumberOfTrainee()
        {
            return GetAlltrainees().Length;
        }
        public struct stTraineesData
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
                //static public bool MarkedForDeleted = false;
            


        }


        frmAddNewTrainee frm =new frmAddNewTrainee();
        stTraineesData stData=new stTraineesData();
        

        string FilePath;


        private void frmListTrainenees_Load(object sender, EventArgs e)
        {
            ShowinDGV();
        }

        private void ShowinDGV()
        {
            string[] Records = GetAlltrainees();

            foreach (string Rec in Records)
            {
                if (GetTraneeInfo(Rec))
                {
                    dataGridView1.Rows.Add(stData.ID, stData.FName, stData.LName, stData.Phone, stData.Plan, stData.Time, stData.StartDate.ToString("dd/MM/yyyy"), stData.EndDate.ToString("dd/MM/yyyy"));
                }
            }
        }

        public string[] GetAlltrainees()
        {
            string[] Records = null;
            try
            {
                Records = File.ReadAllLines(FilePath);
                return Records;


            }

            catch (Exception Ex)
            {

                throw new ApplicationException("Error", Ex);
                return Records;
            }
        }

        bool GetTraneeInfo(string Rec)
        {
            string[] Data = Rec.Split(',');

            if (!(Data.Any(x => x.Length > 2)))
                return false;


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


            return true;
        }

    }

   
}
