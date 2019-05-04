//5 1:2 2:4 3:4
//1 1:1
//2 2
//3 3
//4 3
//5 4
//6 4 f(n) = f(n + 1 / 2) + 1
//7 4
//8 4
//9 5
//10 5
using System;

class dprinter {
	public static void Main() {
		var status = int.Parse(Console.ReadLine());
		var answer = 1;
		while (status > 1) {
			status = (status + 1 ) / 2;
			++answer;
		}
		Console.WriteLine(answer);
	}
}
