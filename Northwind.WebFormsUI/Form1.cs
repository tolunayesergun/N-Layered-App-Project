using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramewrok;
using Northwind.Entities.Concrete;
using NorthWind.Business.Abstract;
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
            _productService = new ProductManager(new ProductEFDAL());
        }

        IProductService _productService;

        private void Form1_Load(object sender, EventArgs e)
        {
       

            dgwProduct.DataSource = _productService.GetAll();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
        }
    }
}
