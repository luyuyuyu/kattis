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
		for (int i = 0; i < input.Length; ++i) {//�����aa bb ss dd�����ÿո�����Ŀ���ʹ��string.join;�����ò�����Console.Write�����
			if (isVowel(input[i])) i += 2;
			Console.Write(input[i]);
		}
		Console.WriteLine();
	}
}

				
		
