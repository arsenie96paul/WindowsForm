using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CardHandler : IInfoCardFactory
    {

        private string[] categories = new string[2]
         {
            "Credit Card",
            "Student Card"
         };
        private string[] descriptions = new string[2]
        {
            "Store details of Credit Card",
            "Store details of Student Card"
        };


        public IInfoCard CreateNewInfoCard(string category)
        {
            if (category == categories[0])
                return new CreditCard();
            if (category == categories[1])
                return new StudentCard();
            throw new Exception("Unhandled Infocard Type");
        }

        public IInfoCard CreateInfoCard(string initialData)
        {
            if (initialData.StartsWith(categories[0]))
                return new CreditCard(initialData.Substring(12));
            if (initialData.StartsWith(categories[1]))
                return new StudentCard(initialData.Substring(13));
            throw new Exception("Unhandled Infocard Type");
        }

        public string[] CategoriesSupported
        {
            get
            {
                return categories;
            }
        }

        public string GetDescription(string category)
        {
            if (category == categories[0])
                return descriptions[0];
            if (category == categories[1])
                return descriptions[1];
            return "Unrecognised category";
        }
    }
}

