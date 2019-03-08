using System;
using System.Collections;

class cups {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		var color = new string[n];
		var radium = new int[n];
		for (int i = 0; i < n; ++i) {
			var input = Console.ReadLine().Split();
			int intinput;
			if (int.TryParse(input[0], out intinput)) {
				radium[i] = intinput / 2;
				color[i] = input[1];
			}
			else { 
				color[i] = input[0];
				radium[i] = int.Parse(input[1]);
			}
		}
		Array.Sort(radium, color); 
		for (int i = 0; i < radium.Length; ++i) {
			Console.WriteLine(color[i]);
		}
	}
}
