using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Client
{
	public class TestKlasa
	{
		public int Br { get; set; }
		public string Txt { get; set; }
		public bool Brisanje { get; set; }

		public TestKlasa(int x, string t)
		{
			Br = x;
			Txt = t;
		}
	}
}
