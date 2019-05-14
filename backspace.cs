using System;
using System.Collections.Generic;

class backspace {
	public static void Main() {
		var input = Console.ReadLine();
		var output = new List<char>();
		for (int i = 0; i < input.Length; ++i) {
			if (input[i] != '<') output.Add(input[i]);
			else output.RemoveAt(output.Count - 1);
		}
		foreach (char i in output) Console.Write(i);
	}
}
