using System.Globalization;

int[] nums = { 54, 7, 41, 23, 4, 12, 80, 33, 5, 2 };
int temp = nums[0];
int[] new_list = new int[nums.Length];
int temp_num = 0;
int[] func_res = new int[3];



Console.WriteLine("Before sort :");
for (int i = 0; i < nums.Length - 1; i++)
{
    Console.Write($"{nums[i]}, ");
}



int[] Find_less(int[] nums, int temp,int temp_num)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            if (temp >= nums[i])
            {
                temp = nums[i];
                temp_num = i;
 //               Console.WriteLine(temp);
            }
        }
    }
 //   Console.WriteLine($"temp_num: {temp_num}");
    int[] result = { temp, temp_num };
    return result;
    //temp is liest number
}



//Find_less(nums, temp, temp_num);
//nums[4] = 12;
/*
int[] func_res = Find_less(nums, temp, temp_num);
Console.WriteLine("func_ress:");
Console.WriteLine(func_res[0]);
Console.WriteLine(func_res[1]);
new_list[0] = func_res[0];
nums[func_res[1]] = 0;
func_res = Find_less(nums, temp, temp_num);
Console.WriteLine("func_ress:");
Console.WriteLine(func_res[0]);
Console.WriteLine(func_res[1]);
*/





for (int j = 0; j < new_list.Length; j++)
{
    func_res = Find_less(nums, temp, temp_num);
    new_list[j] = func_res[0];
    nums[func_res[1]] = 0;
}
Console.WriteLine(" ");
Console.WriteLine("After sort :");
for (int i = 0; i < nums.Length - 1; i++)
{
    Console.Write($"{nums[i]}, ");
}
Console.WriteLine(" ");
Console.WriteLine("Sorted list :");
for (int i = 0; i < nums.Length - 1; i++)
{
    Console.Write($"{new_list[i]}, ");
}
