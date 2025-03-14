namespace Motors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Statisztika stat = new Statisztika();
			stat.ReadFromFile("motors.txt");
			Console.WriteLine("A motorok árának összege: " + stat.SumPrices());

			Console.WriteLine("Kérem adjon meg egy motormárkát: ");
			string brand = Console.ReadLine();
			if (stat.Contains(brand))
			{
				Console.WriteLine("Van ilyen motormárka az állományban.");
			}
			else
			{
				Console.WriteLine("Nincs ilyen motormárka az állományban.");
			}
			Motor oldestMotor = stat.Oldest();
			Console.WriteLine("Legrégebbi motor: " + oldestMotor.Brand + " " + oldestMotor.Name + " (" + oldestMotor.ReleseYear + ")");
			Console.WriteLine("Összes ár a 'Yamaha' márkájú motorok esetén: " + stat.SumBasedOnBrand("Yamaha", "motors.txt") + " EUR");


			stat.Sort();
			Console.WriteLine("Motorok teljesítmény alapján sorbarendezve:");
			stat.PrintMotors();

		}
	}
}
