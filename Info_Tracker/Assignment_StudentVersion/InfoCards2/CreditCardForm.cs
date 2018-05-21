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
    public partial class CreditCardForm : Form
    {
        private CreditCard newcredit;
        public CreditCardForm()
        {
            InitializeComponent();
        }

        public CreditCard NewCard
        {
            set
            {
                newcredit = value;
            }
        }
        private void CreditCardForm_Load(object sender, EventArgs e)
        {
            if (this.newcredit == null)
                return;
            labelName.Text = newcredit.Name;
            labelNumber.Text = newcredit.CardNumber;
            labelStartM.Text = newcredit.StartDateM;
            labelStartY.Text = newcredit.StartDateY;
            labelExpireM.Text = newcredit.ExpireDateM;
            labelExpireY.Text = newcredit.ExpireDateY;
            labelNameOnCard.Text = newcredit.NameOnCard;
            labelCVC.Text = newcredit.CVC;
        }
    }
}
