namespace TotalSystem.EndPoint.Forms
{
	using ApplicationTotalSystem.Services.Product;
	
	using DomainTotoalSystem.Entities;

	using PersistenceTotalSystem.Repository.GenericRepositories;

	public partial class frmMain : Form
	{
		private readonly IProductService _productService;

		//private readonly IDataBaseContext _context;

		//private readonly IGenericRepository<Product> _repository;

		//public frmMain(IGenericRepository<Product> repository)
		//{
		//	InitializeComponent();
		//	_repository = repository;
		//}
		public frmMain(IProductService productService)
		{
			InitializeComponent();
			//_repository = repository;
			_productService = productService;
		}


		private void frmMain_Load(object sender, EventArgs e)
		{
			var product = _productService.GetProductsAsync();
			//var product = _repository.GetAlls();
			dataGridView1.DataSource = product;
			dataGridView1.Columns[0].HeaderText = "کد محصول";
			dataGridView1.Columns[1].HeaderText = "نام محصول";
			dataGridView1.Columns[2].HeaderText = "نوع";
			dataGridView1.Columns[3].HeaderText = "واحد";
			dataGridView1.Columns[4].HeaderText = "وزن (کیلوگرم)";
			//dataGridView1.Columns[5].Visible = false;
			//dataGridView1.Columns[6].HeaderText = "تاریخ ایجاد";
			//dataGridView1.Columns[7].HeaderText = "تاریخ ویرایش";
			//dataGridView1.Columns[8].HeaderText = "کاربر";
		}

		private void تستToolStripMenuItem_Click(object sender, EventArgs e)
		{

			var addService = (IProductService)Program.ServiceProvider.GetService(typeof(IProductService))!;
			
			new frmProducts(addService).ShowDialog();
		}
	}
}
