namespace TotalSystem.EndPoint.Forms
{
	using ApplicationTotalSystem.DataBase;

	using DomainTotoalSystem.Entities;

	using PersistenceTotalSystem.Repository.GenericRepositories;

	public partial class frmMain : Form
	{
		//private readonly IDataBaseContext _context;

		private readonly IGenericRepository<Product> _repository;

		public frmMain(IGenericRepository<Product> repository)
		{
			InitializeComponent();
			_repository = repository;
		}


		private void frmMain_Load(object sender, EventArgs e)
		{
			var product = _repository.GetAlls();
			dataGridView1.DataSource = product;
			dataGridView1.Columns[0].HeaderText = "کد محصول";
			dataGridView1.Columns[1].HeaderText = "نام محصول";
			dataGridView1.Columns[2].HeaderText = "نوع";
			dataGridView1.Columns[3].HeaderText = "واحد";
			dataGridView1.Columns[4].HeaderText = "وزن (کیلوگرم)";
			dataGridView1.Columns[5].Visible = false;
			dataGridView1.Columns[6].HeaderText = "تاریخ ایجاد";
			dataGridView1.Columns[7].HeaderText = "تاریخ ویرایش";
			dataGridView1.Columns[8].HeaderText = "کاربر";
		}
	}
}
