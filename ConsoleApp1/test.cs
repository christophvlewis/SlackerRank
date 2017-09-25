using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ConsoleApp1
{
	public class test
	{
		[Fact]
		public void testhello()
		{
			bool success = false;
			string hello = "Hello World!!!adfasefaef";
			Program.PrintOut(ref hello, out success);
			Assert.True(success);

		}

	}
}
