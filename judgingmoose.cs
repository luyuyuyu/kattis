using System;

class judgingmoose {
	public static void Main() {
		var input = Console.ReadLine().Split();
		var left = int.Parse(input[0]);
		var right = int.Parse(input[1]);
		if (left == right) {
			if (left == 0)Console.WriteLine("Not a moose");
			else Console.WriteLine("Even {0}", left * 2);
		}
		else Console.WriteLine("Odd {0}", Math.Max(left, right) * 2);
	}
}
