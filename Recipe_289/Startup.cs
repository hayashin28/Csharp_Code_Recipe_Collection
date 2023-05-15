using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

// SQLiteの例です。
namespace Recipe_289
{

	// ASP.NET CoreのStartup.csに似せたクラス
	// ConfigureServicesメソッドで利用するサービスを登録する（DIを利用できる)
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// コンソールアプリケーションでは、ServiceLifetime.Singletonの指定が必要
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ExampleDbContext>(options =>
				options.UseSqlite(Configuration.GetConnectionString("ExampleDbContext")), ServiceLifetime.Singleton);
			services.AddSingleton<IConsoleWorker, MyWorker>();
			services.AddHostedService<ConsoleService>();
		}
	}
}


