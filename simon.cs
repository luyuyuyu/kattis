using System;

class simonsays {
    public static void Main() {
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; ++i) {
            var input = Console.ReadLine().Split();
            if (input.Length < 2) Console.WriteLine();
            else {
                if (input[0] == "simon" && input[1] == "says") {
                    for (int j = 2; j < input.Length; ++j) {
                        Console.Write("{0} ", input[j]);
                    }
                Console.WriteLine();
                }
                else Console.WriteLine();
            }
        }
    }
}
