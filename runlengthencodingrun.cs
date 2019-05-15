using System;

class runlengthencodingrun {
	public static void Main() {
		var input = Console.ReadLine().Split();
		if (input[0] == "D") {
			for (int i = 0; i < input[1].Length; ++i) {
				if (Char.IsNumber(input[1][i])) {
					var num = (int)(input[1][i] - '0');
					while (num > 1) {
						Console.Write(input[1][i - 1]); 
						--num;
					}
				}
				else Console.Write(input[1][i]);
			}
		}
		else {
			Console.Write(input[1][0]);
			var count = 1;
			if (input[1].Length == 1) Console.Write(count);
			for (int i = 1; i < input[1].Length; ++i) {
				if (input[1][i] == input[1][i - 1]) {
					++count;
				}
				else {
					Console.Write(count);
					count = 1;
					Console.Write(input[1][i]);
				}
				if (i == input[1].Length - 1) Console.Write(count);
			}
		}
	}
}
