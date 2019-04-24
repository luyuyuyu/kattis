using System;

class mnist2class {
	public static void Main() {
		var count = 0;
		while (count < 150) {
			var count51 = 0;
			while (count51 < 51) {
				Console.Write("-1 ");
				++count51;
			}
			Console.WriteLine();
			++count;
		}
	}
}

