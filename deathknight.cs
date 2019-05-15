using System;

class deathknight {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		var lose = 0;
		for (int i = 0; i < n; ++i) {
			var input = Console.ReadLine();
			if (input.Length == 1) continue;
			for (int j = 1; j < input.Length; ++j) {
				if (input[j] == 'D' && input[j - 1] == 'C') {
					++lose;
					break;
				}
			}
		}
		Console.WriteLine(n - lose);
	}
}
