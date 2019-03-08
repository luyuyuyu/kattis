using System;

class encodedmessage {
	public static void Main() {
		var n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; ++i) {
			var encode = Console.ReadLine();
			var row = (int)Math.Sqrt(encode.Length);
			for (int j = row - 1; j >= 0; --j){
				for (int k = j; k < encode.Length; k += row) {
					Console.Write(encode[k]); 
				}
			}
			Console.WriteLine();
		}
	}
}
