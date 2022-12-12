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

        string _categoryname;
        public string CategoryName
        {
            get
            {
                if(_categoryname.Length<5)
                {
                    throw new Exception("Category Name should be more than 5 letter");
                }
                return _categoryname;
            }
            set
            {
                if(_categoryname.Length<5)
                {
                    throw new Exception("Please recheck the letter length");
                }
                _categoryname = value;
            }
        }
        public void SetCategoryName(string categoryName)
        {
            NameControl(categoryName);
            AssignName(ref _categoryname, categoryName);
            
                
        }
        void AssignName(ref string name, string value)
        {
            name = value;
        }

        public string GetName()
        {
            NameControl(_categoryname);
            return _categoryname;
        }
    }
}
