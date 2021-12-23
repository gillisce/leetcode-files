// A good meal is a meal that contains exactly two different food items with a sum of deliciousness equal to a power of two.
// You can pick any two different foods to make a good meal.
// Given an array of integers deliciousness where deliciousness[i] is the deliciousness of the i​​​​​​th​​​​​​​​ item of food, return the number of different good meals you can make from this list modulo 109 + 7.
// Note that items with different indices are considered different even if they have the same deliciousness value.
namespace leetcode.array_problems
{
    public class GoodMealProblem
    {
        // public int CountPairs(int[] deliciousness)
        // {
        //     int numberOfGoodMeals;
        //     if (deliciousness == null || deliciousness.Length < 2)
        //     {
        //         return 0;
        //     }

        //     var occurences = new Dictionary<int, int>();
        //     foreach (var item in deliciousness)
        //     {
        //         if (!occurences.ContainsKey(item))
        //         {
        //             occurences.Add(item);
        //         }
        //         occurences[item]++;
        //     }

        //     // Create a container for tuples so we can keep track of which numbers we have already compared, we should avoid the use of Lists becuase hash look ups are faster for .Contains()
        //     HashSet<(int, int)> AlreadyCheckedPairs = new HashSet<(int, int)>();

        //     foreach (var option in Occurences.Keys)
        //     {
        //         // since the maximum power of two we can find in this example iterate to the maximum
        //         for (int i = 0; i < 21; i++)
        //         {
        //             // create a variable that is the integer representation of 1 ^ i
        //             int power = 1 << i;

        //             // Get the difference between the power and the delicousness
        //             int difference = power - option;

        //             if (difference < 0)
        //             {
        //                 continue;
        //             }


        //             // It it is once we don't count it. We only count it if it appears more than once.
        //             if ((difference == 0 || difference == option) && AlreadyCheckedPairs.Contains((option, option)) == false)
        //             {
        //                 if (Occurences[option] > 0)
        //                 {
        //                     long single = Occurences[option];
        //                     long combos = single * (single - 1);
        //                     long result = (combos >> 1) % 1000000007;
        //                     numberOfGoodMeals += (int)result;
        //                 }

        //                 // make sure we mark down that we have compared the values, or else we may count the values multiple times
        //                 AlreadyCheckedPairs.Add((option, option));
        //                 continue;
        //             }

        //             if (Occurences.ContainsKey(difference) && AlreadyCheckedPairs.Contains((option, difference)) == false)
        //             {
        //                 numberOfGoodMeals += Occurences[delicousness] * Occurences[difference];
        //                 AlreadyCheckedPairs.Add((difference, delicousness));
        //             }
        //         }
        //     }

        //     return numberOfGoodMeals;

       // }
    }
}

