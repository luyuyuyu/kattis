using System;

class toilet {
	public static void Main() {
		var input = Console.ReadLine();
		var result1 = 0;
		var result2 = 0;
		var result3 = 0;
		if (input[0] != input[1]) {
			++result1;
			++result2;
			++result3;
		}
		if (input[1] == 'U') ++result2;
		if (input[1] == 'D') ++result1;
		if (input.Length > 2) {
			for (int i = 2; i < input.Length; ++i) {
				if (input[i] == 'D') result1 += 2;
				if (input[i] == 'U') result2 += 2;
				if (input[i] != input[i - 1]) ++result3;
			}
		}
		Console.WriteLine(result1);
		Console.WriteLine(result2);
		Console.WriteLine(result3);
	}
} 
