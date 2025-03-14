using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
	internal class Motor
	{
		string brand;
		string name;
		int releseYear;
		double performance;
		double priceInEur;

		public Motor(string brand, string name, int releseYear, double performance, double priceInEur)
		{
			this.brand = brand;
			this.name = name;
			this.releseYear = releseYear;
			this.performance = performance;
			this.priceInEur = priceInEur;
		}

		public string Brand { get => brand;}
		public string Name { get => name;}
		public int ReleseYear { get => releseYear;}
		public double Performance { get => performance;}
		public double PriceInEur { get => priceInEur;}

		public override string ToString()
		{
			return $"{brand} {name} {releseYear} {performance} {priceInEur}";
		}
	}
}
