using System;

class blackfriday {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		var inpu = Array.ConvertAll(Console.ReadLine().Split(),
					int.Parse);
		var input = new int[n];
		for (int i = 0; i < n; ++i) input[i] = inpu[i];
		Array.Sort(input);
		//11134566
		var result = 0;
		if (n == 1) Console.WriteLine(input[0]);
		else {
			if (input[n - 1] != input[n - 2]) result = input[n - 1];
			else {
				for (int i = n - 2; i > 0; --i) {
					if (input[i] != input[i + 1] && input[i] != input[i - 1]) {
						result = input[i];
						break;
					}
				}
			}
			if (result == 0 && input[0] != input[1]) result = input[0];
			if (result == 0) Console.WriteLine("none");
			else Console.WriteLine(Array.IndexOf(inpu, result) + 1);
		}
	}
}
		
