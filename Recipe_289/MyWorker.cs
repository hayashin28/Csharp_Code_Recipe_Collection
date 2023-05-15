using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Recipe_289
{

	public class MyWorker : IConsoleWorker
	{
		private readonly ExampleDbContext _context;
		public MyWorker(ExampleDbContext context)
		{
			_context = context;
		}

		public async Task Run()
		{
			// ここで、_context を通じてDBにアクセスするコードを書く。
		}
	}
}