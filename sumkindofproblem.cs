using System;

class sumkindofproblem {
	public static void Main() {
		var num = int.Parse(Console.ReadLine());
		for (int j = 0; j < num; ++j) {
			var input = Console.ReadLine().Split();
			var sequence = int.Parse(input[0]);
			var end = int.Parse(input[1]);
			int positive = 0;
			int odd = 0;
			int even = 0;
			var count = 0;
			var evenCount = 0;
			for (int i = 0; i <= end; ++i) positive += i;
			for (int i = 1; ; i += 2) {
				odd += i;
				++count;
				if (count == end) break;
			}
			for (int i = 2; ; i += 2) {
				even += i;
				++evenCount;
				if (evenCount == end) break;
			}
			Console.WriteLine("{0} {1} {2} {3}", sequence, positive, odd, even);
		}
	}
}
