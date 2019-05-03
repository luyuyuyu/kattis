using System;

class pizza2 {
	public static void Main() {
		var input = Console.ReadLine().Split();
		var c = double.Parse(input[1]);
		var r = double.Parse(input[0]);
		var cheese = r - c;
		var area1 = cheese * cheese;
		var area2 = r * r;
		Console.WriteLine(area1 * 100.0 / area2);
	}
}
