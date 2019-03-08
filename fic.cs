using System;
class fib;

	public int fib (int x) {
		if (x < 2) {
			return x;
		}
		else {
			return fib(x - 1) + fib (x - 2);
		}
			
	public static void Main () {
		Console.WriteLine(fib(4));
	}
}
