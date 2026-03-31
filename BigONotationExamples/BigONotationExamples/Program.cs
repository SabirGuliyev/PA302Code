
#region HomeWork Solution
//int[] eded = { 81, -34, 101, -56, 89, 91 };
//int max = eded[0];
//for (int i = 1; i < eded.Length; i++)
//{
//    if (eded[i] > max)
//    {
//        max = eded[i];
//    }
//}
//Console.WriteLine(max);


//Task 1
//int[] num = { 81, -34, 101, -56, 89, 91 };
//int min = num[0];
//for (int i = 1; i < num.Length; i++)
//{
//    if (num[i] < min)
//    {
//        min = num[i];
//    }
//}
//Console.WriteLine(min);



//Task 2

//string[] names = { "Ali", "Omer", "Mehemmed", "va va" };

//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i].Length > 4)
//    {
//        Console.WriteLine(names[i]);
//    }
//}


//Task 3
//1,2,3,5   11  -> 4
//1,2,3,4,5  15
//int[] nums = { 5, 4, 2, 9, 6, 8, 1, 10, 3 };

//int arrSum = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    arrSum+= nums[i];
//}

//int sum = 0;
//for(int i = 1; i <= 10; i++)
//{
//    sum += i;
//}

//Console.WriteLine(sum-arrSum); 
#endregion


//int num = 6;
//bool result = false;
//int step = 0;

//for (int i = 2; i*i<=num;i++)
//{
//    step++;
//    if (num % i == 0)
//    {
//        result = true;
//        break;
//    }
//}

//if (result)
//{
//    Console.WriteLine(num+" murekkebdir");
//}
//else
//{
//    Console.WriteLine(num + " sadedir");
//}

//Console.WriteLine("Addimlar:"+step);

//Linear searching algorithms Big O(n)
//searching 


//int[] nums = { 1, 6, 3, 2, 88, 12, 54 };

//int search = 54;
//bool result = false;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == search)
//    {
//        result = true;
//        break;
//    }
//}

//Console.WriteLine(result);



//             L              M                     H
//             0  1   2   3   4   5   6   7    8    9
//int[] nums = { 1, 9, 15, 25, 60, 80, 99, 123, 400, 678 };

//int low = 0;
//int high = nums.Length - 1;
//int mid = (low + high) / 2;

//int step = 0;

//int search = 9;

//while (nums[mid] != search)
//{
//    step++;
//    if (nums[mid] > search)
//    {
//        high=mid-1;
//    }
//    else
//    {
//        low = mid+1;
//    }
//    mid = (low + high) / 2;

//}

//Console.WriteLine(mid);

//Console.WriteLine("Addimlar:"+step);




int[] nums = { 11, 2, 8, 7,7, 23, 1, 0, 15,-1,-1 };
//              2, 8, 7,11, 1,  0,  15,23

int step = 0;

for (int i = 0; i < nums.Length; i++)
{
	for (int j = 0; j < nums.Length-1-i; j++)
	{
		if (nums[j] > nums[j + 1])
		{
			///a=10  b=5  a+=b  b=a-b  a=a-b
			nums[j] += nums[j + 1];
			nums[j+1]= nums[j]-nums[j+1];
			nums[j] -= nums[j + 1];

			//int temp = nums[j];
			//nums[j]= nums[j + 1];
			//nums[j+1]= temp;
		}
	}
}

for (int i = 0;i < nums.Length; i++)
{
	Console.WriteLine(nums[i]);
}


Console.WriteLine("Addimlar:"+step);