using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindTry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (NorthwindEntities c = new NorthwindEntities())
            {
                cbCategories.DataSource = c.Categories.ToList();
                cbCategories.ValueMember = "CategoryID";
                cbCategories.DisplayMember = "CategoryName";
            }
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (NorthwindEntities p = new NorthwindEntities())
            {
                Category cat = (Category)cbCategories.SelectedItem;
                List<Product> list = p.Products.Where(x => x.CategoryID == cat.CategoryID).ToList();
                gvProducts.DataSource = list;

            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd frm = new frmAdd();
            frm.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = gvProducts.CurrentCell.RowIndex;
            int columnindex = gvProducts.CurrentCell.ColumnIndex;
            int id = (int)gvProducts.Rows[rowindex].Cells[columnindex].Value;
           
            using (NorthwindEntities p = new NorthwindEntities())
            {
                Product prod = new Product();
                prod = p.Products.Find(id);
                p.Products.Remove(prod);
                p.SaveChanges();
                gvProducts.DataSource = null;
                gvProducts.DataSource = p.Products;
            }
            
        }
    }
}
