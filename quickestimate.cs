using System;

class quickestimate {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; ++i) {
			var input = Console.ReadLine();
			Console.WriteLine(input.Length);
		}
	}
}

