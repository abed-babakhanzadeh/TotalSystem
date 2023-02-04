namespace TotalSystem.EndPoint
{
	using System.Reflection;

	using ApplicationTotalSystem.DataBase;

	using DomainTotoalSystem.Entities;

	using Microsoft.Extensions.DependencyInjection;
	using PersistenceTotalSystem.Context;
	using PersistenceTotalSystem.Repository.GenericRepositories;
	using TotalSystem.EndPoint.Forms;

	internal static class Program
	{

		//public static IServiceProvider ServiceProvider { get; private set; }

		/// <summary>
		/// سرویسها
		/// </summary>
		//static void ConfigureServices()
		//{
		//	var services = new ServiceCollection();

		//	services.AddScoped<IDataBaseContext, DatabaseContext>();
		//	services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
		//	//services.AddAllGenericTypes(typeof(IGenericRepository<>), new[] {typeof(DatabaseContext).GetTypeInfo().Assembly});

		//	services.AddDbContext<DatabaseContext>();

		//	ServiceProvider = services.BuildServiceProvider();
		//}



		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			//ConfigureServices();
			ApplicationConfiguration.Initialize();

			//IGenericRepository<Product>? product = (IGenericRepository<Product>)ServiceProvider.GetService(typeof(GenericRepository<>));
			//Application.Run(new frmMain(product));

			var services = new ServiceCollection();
			ConfigureServices(services);

			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				var generic = serviceProvider.GetRequiredService<IGenericRepository<Product>>();
				//var generic = (IDataBaseContext)serviceProvider.GetService(typeof(IDataBaseContext));
				Application.Run(new frmMain(generic));
			}


		}

		private static void ConfigureServices(ServiceCollection services)
		{

			services.AddScoped<IDataBaseContext, DatabaseContext>();
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			//services.AddAllGenericTypes(typeof(IGenericRepository<>), new[] {typeof(DatabaseContext).GetTypeInfo().Assembly});

			services.AddDbContext<DatabaseContext>();
		}
	}
}