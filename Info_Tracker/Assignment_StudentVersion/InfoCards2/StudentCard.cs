using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class StudentCard : IInfoCard
    {
        private string sName;
        private string sStudentNumber;
        private string sIssueDateD;
        private string sIssueDateM;
        private string sIssueDateY;
        private string sExpireDate;
        private string sPNumber;
        private StudentCardForm ShowForm;
        public string Name
        {
            get
            {
                return sName;
            }
            set
            {
                sName = value;
            }
        }
        public string StudentNumber
        {
            get
            {
                return sStudentNumber;
            }
            set
            {
                sStudentNumber = value;
            }
        }
        public string IssueDateD
        {
            get
            {
                return sIssueDateD;
            }
            set
            {
                sIssueDateD = value;
            }
        }
        public string IssueDateM
        {
            get
            {
                return sIssueDateM;
            }
            set
            {
                sIssueDateM = value;
            }
        }
        public string IssueDateY
        {
            get
            {
                return sIssueDateY;
            }
            set
            {
                sIssueDateY = value;
            }
        }
        public string ExpireDate
        {
            get
            {
                return sExpireDate;
            }
            set
            {
                sExpireDate = value;
            }
        }
        public string PNumber
        {
            get
            {
                return sPNumber;
            }
            set
            {
                sPNumber = value;
            }
        }
        public string Category
        {
            get
            {
                return "Student Card";
            }
        }
        public StudentCard()
        {
            sName = string.Empty;
            sStudentNumber = string.Empty;
            sIssueDateD = string.Empty;
            sIssueDateM = string.Empty;
            sIssueDateY = string.Empty;
            sExpireDate = string.Empty;
            sPNumber = string.Empty;
        }
        public StudentCard(string initialData)
        {
            string[] strArray = initialData.Split('|');
            if (strArray.Length != 7)
                throw new Exception("Invalid data for CreditCard");
            sName = strArray[0];
            sStudentNumber = strArray[1];
            sIssueDateD = strArray[2];
            sIssueDateM = strArray[3];
            sIssueDateY = strArray[4];
            sExpireDate = strArray[5];
            sPNumber = strArray[6];
        }
        public virtual string GetDataAsString()
        {
            return "Student Card|" + sName + "|" + sStudentNumber + "|" + sIssueDateD + "|" + sIssueDateM + "|" + sIssueDateY + "|"
                + sExpireDate + "|" + sPNumber;
        }
        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();
            ShowForm = new StudentCardForm();
            ShowForm.TopLevel = false;
            ShowForm.Parent = displayPanel;
            ShowForm.NewCard = this;
            ShowForm.Height = displayPanel.Height;
            ShowForm.Width = displayPanel.Width;
            ShowForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ShowForm.Show();
        }
        public void CloseDisplay()
        {
            if (ShowForm == null)
                return;
            ShowForm.Close();
            ShowForm.Dispose();
            ShowForm = null;
        }
        public bool EditData()
        {
            bool point = false;
            editStudentCard editStudentCard = new editStudentCard();
            editStudentCard.NewCard = this;
            if (editStudentCard.ShowDialog() == DialogResult.OK)
            {
                sName = editStudentCard.NewCard.Name;
                sStudentNumber = editStudentCard.NewCard.StudentNumber;
                sIssueDateD = editStudentCard.NewCard.IssueDateD;
                sIssueDateM = editStudentCard.NewCard.IssueDateM;
                sIssueDateY = editStudentCard.NewCard.IssueDateY;
                sExpireDate = editStudentCard.NewCard.ExpireDate;
                sPNumber = editStudentCard.NewCard.PNumber;
                point = true;
            }
            return point;
        }
    }
}
