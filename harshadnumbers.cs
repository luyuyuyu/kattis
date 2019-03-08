using System;

class harshadnumbers {
	public static int sumDigit(int n) {
		var sum = 0;
		while (n > 0) {
			sum += n % 10;
			n /= 10;
		}
		return sum;
	}
	
	public static void Main() {
		var input = int.Parse(Console.ReadLine());
		while (input % sumDigit(input) != 0) {
			++input;
		}
		Console.WriteLine(input);
	}
}

