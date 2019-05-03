using System;
using System.Linq;

class plantingtrees {
	public static void Main() {
		var num = int.Parse(Console.ReadLine());
		var tree = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		Array.Sort(tree);
		Array.Reverse(tree);
		for (int i = 0; i < num; ++i) tree[i] += i + 2;
		Console.WriteLine(tree.Aggregate((a1, a2) => Math.Max(a1, a2)));
	}
}
