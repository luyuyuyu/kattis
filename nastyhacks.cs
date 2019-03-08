using System;

class nastyhacks {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; ++i) {
			var input = Console.ReadLine().Split();
			var noAd = int.Parse(input[0]);
			var withAd = int.Parse(input[1]);
			var Ad = int.Parse(input[2]);
			switch (withAd - Ad) {
				case > noAd: Console.WriteLine("advertise");
				case = noAd: Console.WriteLine("does not matter");
				case < noAd: Console.WriteLine("do not advertise");
			}
		}
	}
}
