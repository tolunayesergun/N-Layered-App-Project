using Northwind.Business.Concrete;
using Northwind.Entities.Concrete;
using Northwind.DataAccess.Concrete.EntityFramewrok;
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
        }

        ProductManager productManger = new ProductManager(new ProductEFDAL());

        private void Form1_Load(object sender, EventArgs e)
        {
       

            dgwProduct.DataSource = productManger.GetAll();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productManger.Delete(new Product { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
        }
    }
}
