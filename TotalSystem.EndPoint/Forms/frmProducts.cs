using ApplicationTotalSystem.Services.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalSystem.EndPoint.Forms
{
	public partial class frmProducts : Form
	{
		private readonly IProductService _productService;

		public frmProducts(IProductService productService)
		{
			InitializeComponent();
			_productService = productService;
		}

		private void frmProducts_Load(object sender, EventArgs e)
		{
			var product = _productService.GetProductsAsync();
			//var product = _repository.GetAlls();
			dataGridView1.DataSource = product;
			dataGridView1.Columns[0].HeaderText = "کد محصول";
			dataGridView1.Columns[1].HeaderText = "نام محصول";
			dataGridView1.Columns[2].HeaderText = "نوع";
			dataGridView1.Columns[3].HeaderText = "واحد";
			dataGridView1.Columns[4].HeaderText = "وزن (کیلوگرم)";
		}
	}
}
