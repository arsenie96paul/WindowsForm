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
    public partial class editStudentCard : Form
    {
        private StudentCard sNewCard;
        public StudentCard NewCard
        {
            get
            {
                return sNewCard;
            }
            set
            {
                sNewCard = value;
            }
        }
        private void editStudentCard_Load(object sender, EventArgs e)
        {
            if (sNewCard == null)
                return;
            textBoxName.Text = sNewCard.Name;
            textBoxStudentNumber.Text = sNewCard.StudentNumber;
            textBoxIssueD.Text = sNewCard.IssueDateD;
            textBoxIssueM.Text = sNewCard.IssueDateM;
            textBoxIssueY.Text = sNewCard.IssueDateY;
            textBoxExpireDate.Text = sNewCard.ExpireDate;
            textBoxPNumber.Text = sNewCard.PNumber;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sNewCard == null)
                return;
            sNewCard.Name = textBoxName.Text;
            sNewCard.StudentNumber = textBoxStudentNumber.Text;
            sNewCard.IssueDateD = textBoxIssueD.Text;
            sNewCard.IssueDateM = textBoxIssueM.Text;
            sNewCard.IssueDateY = textBoxIssueY.Text;
            sNewCard.ExpireDate = textBoxExpireDate.Text;
            sNewCard.PNumber = textBoxPNumber.Text;
            DialogResult = DialogResult.OK;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void SaveButtonRun()
        {
            if (textBoxName.Text.Length == 0 || textBoxStudentNumber.Text.Length == 0 || textBoxIssueD.Text.Length == 0 || textBoxIssueM.Text.Length == 0
                || textBoxIssueY.Text.Length == 0 || textBoxExpireDate.Text.Length == 0 || textBoxPNumber.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }

        private void textBoxStudentNumber_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }

        private void textBoxIssueD_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }

        private void textBoxIssueM_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxIssueY_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxExpireDate_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxPNumber_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        public editStudentCard()
        {
            InitializeComponent();
        }
    }
}
