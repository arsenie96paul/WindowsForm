using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class StudentCardForm : Form
    {
        private StudentCard newstudent;
        public StudentCardForm()
        {
            InitializeComponent();
        }
        public StudentCard NewCard
        {
            set
            {
                newstudent = value;
            }
        }
        private void StudentCardForm_Load(object sender, EventArgs e)
        {
            if (newstudent == null)
                return;
            labelName.Text = newstudent.Name;
            labelStudentNumber.Text = newstudent.StudentNumber;
            labelIssueDateD.Text = newstudent.IssueDateD;
            labelIssueDateM.Text = newstudent.IssueDateM;
            labelIssueDateY.Text = newstudent.IssueDateY;
            labelExpireDate.Text = newstudent.ExpireDate;
            labelPNumber.Text = newstudent.PNumber;
        }


    }
}
