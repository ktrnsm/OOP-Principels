using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principels.Entities
{
    internal class Category
    {
        void NameControl(string name)
        {
            if(name.Length<5)
            {
                throw new Exception("Category name connot be longer than 5 character");

            }
                
        }

        public Category(string categoryname)
        {
            NameControl(categoryname);
            CategoryName = categoryname;
        }
    }
}
