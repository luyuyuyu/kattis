using System;

class stararrangements {
	public static bool Right(int input, int a, int b) {
		var mod = input % (a + b);
		return mod == 0 || mod == a;
	}
	
	public static void Main() {
		var input = int.Parse(Console.ReadLine());
		Console.WriteLine("{0}:", input);
		for (int i = 2; i <= (input + 1) / 2; ++i) {
			if (Right(input, i, i - 1)) {
				Console.WriteLine("{0},{1}", i, i - 1);
			}
			if (Right(input, i, i)) {
				Console.WriteLine("{0},{0}", i);
			}
		}
	}
}
