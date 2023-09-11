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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

        }

        private void btnAddProducttoDB_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities t = new NorthwindEntities())
            {
                
                if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtProductDiscontinued.Text))
                {
                    lblError.Text = "missing details";
                    return;
                }
                Product p = new Product();
                p.ProductName = txtProductName.Text;
                p.CategoryID = (int?)cbocatNewProduct.SelectedValue;
                p.Discontinued = false;
                t.Products.Add(p);
                t.SaveChanges();
            }
        }
    }
}
