using System;

class server {
	public static void Main() {
		var input1 = Console.ReadLine().Split();
		var num = int.Parse(input1[0]);
		var time = int.Parse(input1[1]);
		var input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		var accumulate = 0;
		var answer = 0;
		for (int i = 0; i < num; ++i) {
			accumulate += input2[i];
			if (accumulate > time || answer == num) break;
			answer++;
		}
		Console.WriteLine(answer);
	}
}	
			
