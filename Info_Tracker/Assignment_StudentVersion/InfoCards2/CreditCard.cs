using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class CreditCard : IInfoCard
    {
        private string cName;
        private string cCardNumber;
        private string cStartDateM;
        private string cStartDateY;
        private string cExpireDateM;
        private string cExpireDateY;
        private string cNameOnCard;
        private string cCVC;
        private CreditCardForm ShowForm;

        public string Name
        {
            get
            {
                return cName;
            }
            set
            {
                cName = value;
            }
        }

        public string CardNumber
        {
            get
            {
                return cCardNumber;
            }
            set
            {
                cCardNumber = value;
            }
        }
        public string StartDateM
        {
            get
            {
                return cStartDateM;
            }
            set
            {
                cStartDateM = value;
            }
        }
        public string StartDateY
        {
            get
            {
                return cStartDateY;
            }
            set
            {
                cStartDateY = value;
            }
        }
        public string ExpireDateM
        {
            get
            {
                return cExpireDateM;
            }
            set
            {
                cExpireDateM = value;
            }
        }
        public string ExpireDateY
        {
            get
            {
                return cExpireDateY;
            }
            set
            {
                cExpireDateY = value;
            }
        }
        public string NameOnCard
        {
            get
            {
                return cNameOnCard;
            }
            set
            {
                cNameOnCard = value;
            }
        }
        public string CVC
        {
            get
            {
                return cCVC;
            }
            set
            {
                cCVC = value;
            }
        }

        public string Category
        {
            get
            {
                return "Credit Card";
            }
        }

        public CreditCard()
        {
            cName = string.Empty;
            cCardNumber = string.Empty;
            cStartDateM = string.Empty;
            cExpireDateM = string.Empty;
            cStartDateY = string.Empty;
            cExpireDateY = string.Empty;
            cNameOnCard = string.Empty;
            cCVC = string.Empty;
        }
        public CreditCard(string initialData)
        {
            string[] strArray = initialData.Split('|');
            if (strArray.Length != 8)
                throw new Exception("Invalid data for CreditCard");
            cName = strArray[0];
            cCardNumber = strArray[1];
            cStartDateM = strArray[2];
            cExpireDateM = strArray[3];
            cExpireDateY = strArray[4];
            cStartDateY = strArray[5];
            cNameOnCard = strArray[6];
            cCVC = strArray[7];
        }
        public virtual string GetDataAsString()
        {
            return "Credit Card|" + cName + "|" + cCardNumber + "|" + cStartDateM + "|" + cStartDateY + "|" + cExpireDateM + "|"
                + cExpireDateY + "|" + cNameOnCard + "|" + cCVC;
        }
        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();
            ShowForm = new CreditCardForm();
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
            EditCreditCard editCreditCard = new EditCreditCard();
            editCreditCard.NewCard = this;
            if (editCreditCard.ShowDialog() == DialogResult.OK)
            {
                cName = editCreditCard.NewCard.Name;
                cCardNumber = editCreditCard.NewCard.CardNumber;
                cStartDateM = editCreditCard.NewCard.StartDateM;
                cStartDateY = editCreditCard.NewCard.StartDateY;
                cExpireDateM = editCreditCard.NewCard.ExpireDateM;
                cExpireDateY = editCreditCard.NewCard.ExpireDateY;
                cNameOnCard = editCreditCard.NewCard.NameOnCard;
                cCVC = editCreditCard.NewCard.CVC;

                point = true;
            }
            return point;
        }
    }
}
