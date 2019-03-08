using System;

class numberfun {
	public static bool plus(int x, int y, int z) {
		if (x + y == z) return true;
		return false;
	}
	
	public static bool minus(int x, int y, int z) {
		if (x - y == z || y - x == z) return true;
		return false;
	}
	
	public static bool multiply(int x, int y, int z) {
		if (x * y == z) return true;
		return false;
	}
	
	public static bool divide(int x, int y, int z) {
		if (x * z == y || y * z == x) return true;
		return false;
	}
	
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; ++i) {
			var input = Console.ReadLine().Split();
			var a = int.Parse(input[0]);
			var b = int.Parse(input[1]);
			var c = int.Parse(input[2]);
			if (plus(a, b, c) || minus(a, b, c) 
			|| multiply(a, b, c) || divide(a, b, c)){
				Console.WriteLine("Possible");
			} else Console.WriteLine("Impossible");
		}
	}
}
				
