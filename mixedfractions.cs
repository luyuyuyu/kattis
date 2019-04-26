using System;

class mixedfractions {
	public static void Main() {
		while (true) {
			var input = Console.ReadLine().Split();
			var numerator = int.Parse(input[0]);
			var denominator = int.Parse(input[1]);
			if (numerator == 0 && denominator == 0) break;
			var integer = numerator / denominator;
			var fraction = numerator - denominator * integer; 
			Console.WriteLine("{0} {1} / {2}",
			                  integer, fraction, denominator);
		}
	}
}
