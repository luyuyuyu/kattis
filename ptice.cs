using System;

class ptice {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		var answer = Console.ReadLine();
		var a = new int[n];
		var b = new int[n];
		var g = new int[n];
		int ac = 0; int bc = 0; int gc = 0;
		for (int i = 0; i < n; ++i) {
			if (i % 3 == 0) a[i] = 'A';
			if (i % 3 == 1) a[i] = 'B';
			if (i % 3 == 2) a[i] = 'C';
		}
		for (int i = 0; i < n; ++i) {
			if (i % 4 == 0 || i % 4 == 2) b[i] = 'B';
			if (i % 4 == 1) b[i] = 'A';
			if (i % 4 == 3) b[i] = 'C';
		}
		for (int i = 0; i < n; ++i) {
			if (i % 6 == 0 || i % 6 == 1) g[i] = 'C';
			if (i % 6 == 2 || i % 6 == 3) g[i] = 'A';
			if (i % 6 == 4 || i % 6 == 5) g[i] = 'B';
		}
		for (int i = 0; i < n; ++i) {
			if (answer[i] == a[i]) ++ac;
			if (answer[i] == b[i]) ++bc;
			if (answer[i] == g[i]) ++gc;
		}
		var max = Math.Max(Math.Max(ac, bc), Math.Max(bc, gc));
		Console.WriteLine(max);
		if (ac == max) Console.WriteLine("Adrian");
		if (bc == max) Console.WriteLine("Bruno");
		if (gc == max) Console.WriteLine("Goran");
	}
}
