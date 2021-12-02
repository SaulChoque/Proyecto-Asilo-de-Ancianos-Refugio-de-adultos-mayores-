using System;

	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			PTecnico p1 = new PTecnico();
			p1.leerPT();
			p1.mostrarPT();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}