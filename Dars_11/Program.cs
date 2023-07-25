// See https://aka.ms/new-console-template for more information

using Dars_11;

// string content =
//     @"Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";

// string content = @"Lorem. ipsum dolor. sit amet con";
// EssayAnalyzerService service = new EssayAnalyzerService();
// var s = service.CountOfNotCapitalisedWords(content);
// Console.WriteLine(s)
int[] array = new int[] { 1, 2, 3, 5, 6, 7, 8 };
int target = 4;
Solution solution = new Solution();
var s = solution.SearchInsert(array, target);
Console.WriteLine(s);
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        if (Array.IndexOf(nums, target) == -1)
        {
            nums = nums.Concat(new int[] { target }).ToArray();
            Array.Sort(nums);
            return Array.IndexOf(nums, target);
        }

        return Array.IndexOf(nums, target);;
    }
}
