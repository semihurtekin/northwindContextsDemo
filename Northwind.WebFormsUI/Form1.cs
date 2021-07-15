using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        IProductService _productService;
        ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            ProductList();
            CategoryList();
        }

        private void CategoryList()
        {
            cbxCategoryName.DataSource = _categoryService.GetAll();
            cbxCategoryName.DisplayMember = "CategoryName";
            cbxCategoryName.ValueMember = "CategoryId";

            cbxCategoryID.DataSource = _categoryService.GetAll();
            cbxCategoryID.DisplayMember = "CategoryName";
            cbxCategoryID.ValueMember = "CategoryId";

            cbxUpdateCategoryID.DataSource = _categoryService.GetAll();
            cbxUpdateCategoryID.DisplayMember = "CategoryName";
            cbxUpdateCategoryID.ValueMember = "CategoryId";
        }

        private void ProductList()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategoryName.SelectedValue));
            }
            catch
            {


            }


        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productService.GetProductsByName(tbxProductName.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantityPerUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryID.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxStockAmount.Text),
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)

                }
                );
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpdateProductName.Text,
                CategoryId = Convert.ToInt32(cbxCategoryID.SelectedValue),
                QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text)


            });
            MessageBox.Show("ÜRÜN GÜNCELLENDİ");
            ProductList();
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCategoryID.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
            tbxUpdateUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateUnitsInStock.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgwProduct.CurrentRow.Cells[0] != null)
            {
                try
                {
                    _productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
                    MessageBox.Show("ÜRÜN SİLİNDİ");
                    ProductList();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
            }
        }
    }
}
