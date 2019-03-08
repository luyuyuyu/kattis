using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var toIndex = new Dictionary<int, int>();
        for (int i = 0; i < list.Count; ++i) {
            toIndex[list[i]] = i;
        }
        for (int i = 0; i < list.Count; ++i) {
            if (toIndex.TryGetValue(sum - list[i], out int index)) {
                if (i != index) return new Tuple<int, int>(i, index);
            }
        }
        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if(indices != null) 
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}
