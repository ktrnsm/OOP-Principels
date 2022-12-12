using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principels.Models
{
    public class Product
    {

        decimal _unitprice;

        public decimal UnitPrice
        {
            get
            {
                if(_unitprice<5)
                {
                    System.Windows.Forms.MessageBox.Show($"Please be aware ! the unit price{_unitprice} cannot be lower than 5, the value will be revised to minimum value of 5 automatically");

                }
                return _unitprice = 5;
            }
            set
            {
                if(value<5)
                {
                    throw new Exception("Price canot be lower than 5!");
                }
                _unitprice = value;
            }
        }
    }
}
