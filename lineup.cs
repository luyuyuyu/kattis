using System;

class lineup {
	public static bool increasing(string[] a) {
		for (int i = 1; i < a.Length; ++i) {
			if (a[i].CompareTo(a[i - 1]) < 0) return false;
		}
		return true;
	}
	
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		var name = new string[n];
		for (int i = 0; i < n; ++i) {
			name[i] = Console.ReadLine();
		}
		if (increasing(name)) Console.WriteLine("INCREASING");
		else {
			Array.Reverse(name);
			if (increasing(name)) Console.WriteLine("DECREASING");
			else Console.WriteLine("NEITHER");
		}
	}
}
