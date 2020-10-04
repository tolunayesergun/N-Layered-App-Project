using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramewrok;
using Northwind.Entities.Concrete;
using NorthWind.Business.Abstract;
using NorthWind.Business.Concrete;
using NorthWind.Business.DependencyResolvers.Ninject;
using Nortwind.DataAccess.Concrete.EntityFramework;
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
    public partial class AppInterface : Form
    {
        public AppInterface()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        IProductService _productService;
        ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        #region Loads
        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryID";

            cmbUCategoryId.DataSource = _categoryService.GetAll();
            cmbUCategoryId.DisplayMember = "CategoryName";
            cmbUCategoryId.ValueMember = "CategoryID";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void LoadProductsWithFilter(string filter)
        {
            dgwProduct.DataSource = _productService.GetProductsByProductName(filter);
        }
        #endregion


        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{ dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue)); }
            catch (Exception) { }
          
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtProduct.Text))LoadProducts();      
            else LoadProductsWithFilter(txtProduct.Text);      
        }

        private void btProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = txtProductName.Text,
                    QuantityPerUnit = txtQuantity.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtStock.Text)
                });
                LoadProducts();
                MessageBox.Show("Ürün Eklendi");
            }

            catch (Exception exc) { MessageBox.Show(exc.Message); }

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = txtUProductName.Text,
                    UnitPrice = Convert.ToDecimal(txtUPrice.Text),
                    CategoryId = Convert.ToInt32(cmbUCategoryId.SelectedValue),
                    QuantityPerUnit = txtUQuantity.Text,
                    UnitsInStock = Convert.ToInt16(txtUStock.Text)
                });

                LoadProducts();
                MessageBox.Show("Ürün Güncellendi");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try 
            {
            _productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
            LoadProducts();
            MessageBox.Show("Ürün Silindi");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow.Cells;
            txtUProductName.Text = row[1].Value.ToString();
            cmbUCategoryId.SelectedValue = row[2].Value;
            txtUPrice.Text = row[3].Value.ToString();
            txtUQuantity.Text = row[4].Value.ToString();
            txtUStock.Text = row[5].Value.ToString();
        }
    }
}
