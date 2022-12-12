using OOP_Principels.Entities;
using OOP_Principels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Principels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product p = new Product();

            MessageBox.Show(p.UnitPrice.ToString());
            Category c = new Category("Sweets");
            c.CategoryName = "cas";
        }
    }
}
