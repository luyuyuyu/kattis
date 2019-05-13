using System;
using System.Linq;

class aboveaverage {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; ++i) {
			var input = Array.ConvertAll(Console.ReadLine().Split(),
						double.Parse);
			var average = (input.Aggregate((a1, a2) => a1 + a2)
						- input[0])/ input[0];
			double count = 0.0;
			for (int j = 1; j < input[0] + 1; ++j) {
				if (input[j] > average) ++count;
			}
			Console.WriteLine("{0:0.000}%", 
			Math.Round(count * 100 / input[0], 3));
		}
	}
}
					
