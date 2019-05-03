using System;
using System.Linq;

class dicegame {
	static int sum(int a1, int a2) => a1 + a2;
	
	public static void Main() {
		var gunnar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		var emma = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		var gsum = gunnar.Aggregate(sum);
		var esum = emma.Aggregate(sum);
		if (gsum < esum) Console.WriteLine("Emma"); 
		if (gsum > esum) Console.WriteLine("gunnar");
		if (gsum == esum) Console.WriteLine("Tie");
	}
}
