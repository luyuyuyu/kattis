using System;
class aaah {
	public static int anumber(string s) {
		for(int i = 0; i < s.Length; ++i) {
			if (s[i] == 'h') return i;
		}
		return s.Length;
	}
	
	public static void Main() {
		var able = Console.ReadLine();
		var wanted = Console.ReadLine();
		Console.WriteLine(anumber(able) < anumber(wanted) ? "no" : "go");
	}
}
