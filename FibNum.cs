using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm15
{
	public class FibNum
	{
		public FibNum(uint n)
		{
			uint[] mass = new uint[2] { 0, 1 };
			uint i = 0;
			uint a = 0;
			while (i <= n)
			{
				Console.WriteLine(mass[0]);
				a = mass[0] + mass[1];
				mass[0] = mass[1];
				mass[1] = a;
				i++;
				
			}
		
			
		}
	}
}
