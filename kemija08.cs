using System;

class kemija08 {
	public static bool isVowel(char x) {
		switch(x) {
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u': 
				return true;
			default: 
				return false;
		}
	}
	
	public static void Main() {
		var input = Console.ReadLine();
		for (int i = 0; i < input.Length; ++i) {//输出是aa bb ss dd这种用空格隔开的可以使用string.join;本题用不到，Console.Write解决了
			if (isVowel(input[i])) i += 2;
			Console.Write(input[i]);
		}
		Console.WriteLine();
	}
}

				
		
