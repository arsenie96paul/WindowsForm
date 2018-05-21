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
    public partial class EditCreditCard : Form
    {
        private CreditCard cNewCard;
        public CreditCard NewCard
        {
            get
            {
                return cNewCard;
            }
            set
            {
                cNewCard = value;
            }
        }        
        private void EditCreditCard_Load(object sender, EventArgs e)
        {
            if (cNewCard == null)
                return;
            textBoxName.Text = cNewCard.Name;
            textBoxCardNumber.Text = cNewCard.CardNumber;
            textBoxStartM.Text = cNewCard.StartDateM;
            textBoxStartY.Text = cNewCard.StartDateY;
            textBoxExpireM.Text = cNewCard.ExpireDateM;
            textBoxExpireY.Text = cNewCard.ExpireDateY;
            textBoxNameOnCard.Text = cNewCard.NameOnCard;
            textBoxCVC.Text = cNewCard.CVC;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cNewCard == null)
                return;
            cNewCard.Name = textBoxName.Text;
            cNewCard.CardNumber = textBoxCardNumber.Text;
            cNewCard.StartDateM = textBoxStartM.Text;
            cNewCard.StartDateY = textBoxStartY.Text;
            cNewCard.ExpireDateM = textBoxExpireM.Text;
            cNewCard.ExpireDateY = textBoxExpireY.Text;
            cNewCard.NameOnCard = textBoxNameOnCard.Text;
            cNewCard.CVC = textBoxCVC.Text;
            DialogResult = DialogResult.OK;            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void SaveButtonRun()
        {
            if (textBoxName.Text.Length == 0 || textBoxCardNumber.Text.Length == 0 || textBoxStartM.Text.Length == 0 || textBoxStartY.Text.Length == 0
                || textBoxExpireM.Text.Length == 0 || textBoxExpireY.Text.Length == 0 || textBoxNameOnCard.Text.Length == 0 || textBoxCVC.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxCardNumber_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxStartM_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxStartY_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxExpireM_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxExpireY_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxNameOnCard_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        private void textBoxCVC_TextChanged(object sender, EventArgs e)
        {
            SaveButtonRun();
        }
        public EditCreditCard()
        {
            InitializeComponent();
        }
    }
}
